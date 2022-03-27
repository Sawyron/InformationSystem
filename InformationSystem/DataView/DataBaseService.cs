using InformationSystem.Services;
using System.Data;
using System.Data.Odbc;

namespace InformationSystem.DataView
{
    internal class DataBaseService : IDataBaseService
    {
        private IDbConnection? _connection;
        public IDbConnection? DbConnection { get => _connection; set => _connection = value; }

        public string? DataBase => _connection?.Database;

        private OdbcDataAdapter GetDataAdapter(string query)
        {
            if (_connection == null)
                throw new ConnectionIsNotSetException();
            OdbcConnection? odbcConnection = _connection as OdbcConnection;
            if (odbcConnection == null)
                throw new ArgumentException("ODBC connection is required");
            OdbcDataAdapter adapter = new OdbcDataAdapter(query, odbcConnection);
            return adapter;
        }
        public IEnumerable<string> GetDataBases()
        {
            string query = "SELECT datname From pg_database WHERE  datistemplate=false;";
            OdbcDataAdapter adapter = GetDataAdapter(query);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "pg_database");
            List<string> dataBases = new List<string>();
            DataTable? dataTable = dataSet.Tables["pg_database"];
            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    string? db = row["datname"].ToString();
                    if (db != null)
                        dataBases.Add(db);
                }
            }
            return dataBases;
        }

        public IEnumerable<string> GetTables()
        {
            string query = "SELECT table_name  FROM information_schema.tables WHERE table_schema = 'public';";
            OdbcDataAdapter adapter = GetDataAdapter(query);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "tables");
            List<string> tables = new List<string>();
            DataTable dataTable = dataSet.Tables[0];
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                string? table = row["table_name"].ToString();
                if (table != null)
                    tables.Add(table);
            }
            return tables;
        }
    }
}

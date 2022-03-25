using InformationSystem.Services;
using System.Data;
using System.Data.Odbc;

namespace InformationSystem.DataView
{
    public class TableService : ITableService
    {
        private IDbConnection? _connection;
        private DataSet _dataSet = new DataSet();
        private string _table = "";
        private OdbcDataAdapter? _adapter;
        public IDbConnection? DbConnection { get => _connection; set => _connection = value; }
        public void SetTable(string name)
        {
            if (_connection == null)
                throw new ConnectionIsNotSetException();
            OdbcConnection? odbcConnection = _connection as OdbcConnection;
            if (odbcConnection == null)
                throw new ArgumentException("ODBC connection is required");
            string query = $"SELECT * FROM {name}";
            _adapter = new OdbcDataAdapter(query, odbcConnection);
            _dataSet = new DataSet();
            _table = name;
            OdbcCommandBuilder builder = new OdbcCommandBuilder(_adapter);
            _adapter.UpdateCommand = builder.GetUpdateCommand();
            _adapter.DeleteCommand = builder.GetDeleteCommand();
            _adapter.InsertCommand = builder.GetInsertCommand();
        }
        public DataTable GetTable()
        {
            if (_adapter == null)
                throw new Exception("table is not set");
            _adapter.Fill(_dataSet, _table);
            DataTable? dataTable = _dataSet.Tables[_table];
            if (dataTable == null)
                throw new ArgumentException("Wrong table name");
            return dataTable;
        }

        public void UpdateRow(int row, int column, object value)
        {
            DataTable? dataTable = _dataSet.Tables[_table];
            if (dataTable != null)
            {
                if (row >= 0 && row < dataTable.Rows.Count)
                    dataTable.Rows[row][column] = value;
            }
        }

        public int UpdateTable()
        {
            if (_adapter == null)
                throw new Exception("table is not set");
            return _adapter.Update(_dataSet, _table);
        }

        public void CreateRow()
        {
            DataTable? table = _dataSet.Tables[_table];
            if (table != null)
            {
                table.Rows.Add();
            }
        }

        public void DeleteRows(IEnumerable<int> rows)
        {
            DataTable? table = _dataSet.Tables[_table];
            if (table != null) {
                List<DataRow> dataRows = new List<DataRow>();
                foreach (int row in rows)
                {
                    if(row >= 0 && row < table.Rows.Count)
                        dataRows.Add(table.Rows[row]);
                }
                foreach (DataRow row in dataRows)
                {
                    row.Delete();
                }
            }
        }

        public void DeleteRow(int row)
        {
            _dataSet.Tables[_table]?.Rows[row].Delete();
        }
    }
}

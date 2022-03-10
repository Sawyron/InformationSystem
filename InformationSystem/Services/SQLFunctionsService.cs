using InformationSystem.Models;
using System.Data;
using System.Data.Common;

namespace InformationSystem.Services
{
    public class SQLFunctionsService : ISQLFunctionsService
    {
        private IDbConnection? _dbConnection;

        public IDbConnection? DbConnection { get => _dbConnection; set => _dbConnection = value; }

        public IEnumerable<ISQLFunction> GetAll()
        {
            List<ISQLFunction> functions = new List<ISQLFunction>();
            if (_dbConnection != null)
            {
                string query = @"SELECT
                                    routine_name AS name, pg_get_functiondef((
            SELECT
                oid FROM pg_proc
            WHERE
                proname = routine_name)) AS code
                               FROM 
                                    information_schema.routines
                               INNER JOIN pg_proc
                                ON information_schema.routines.routine_name = proname
                               WHERE 
                                    routine_type = 'FUNCTION'
                               AND
                                    routine_schema = 'public';";
                try
                {
                    IDbCommand command = _dbConnection.CreateCommand();
                    command.CommandText = query;
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            functions.Add(new SQLFunction(
                                (string)reader["name"],
                                (string)reader["code"])
                                );
                        }
                    }
                }
                catch (DbException)
                {

                }
            }
            return functions;
        }
    }
}

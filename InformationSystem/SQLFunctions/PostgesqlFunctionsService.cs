using InformationSystem.SQLFunctions;
using System.Data;
using System.Data.Common;

namespace InformationSystem.Services
{
    public class PostgesqlFunctionsService : ISQLFunctionsService
    {
        private readonly string _query = @"
        SELECT 
            p.proname AS specific_name,
            p.prosrc AS definition,
            pg_get_function_arguments(p.oid) as arguments,
            t.typname AS return_type
        FROM pg_proc p
            LEFT JOIN pg_namespace n on p.pronamespace = n.oid
            LEFT JOIN pg_language l on p.prolang = l.oid
            LEFT JOIN pg_type t on t.oid = p.prorettype 
        WHERE n.nspname not in ('pg_catalog', 'information_schema')
        ORDER BY n.nspname, specific_name;";

        private IDbConnection? _dbConnection;

        public IDbConnection? DbConnection { get => _dbConnection; set => _dbConnection = value; }

        public IEnumerable<ISQLFunction> GetAll()
        {
            List<ISQLFunction> functions = new List<ISQLFunction>();
            if (_dbConnection != null)
            {
                try
                {
                    IDbCommand command = _dbConnection.CreateCommand();
                    command.CommandText = _query;
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string stringArguments = reader["arguments"].ToString() ?? string.Empty;
                            Dictionary<string, string> argumentsDict = new Dictionary<string, string>();
                            foreach (string argumentPair in stringArguments.Split(","))
                            {
                                string[] pair = argumentPair.Split(" ");
                                if (pair.Length == 2)
                                {
                                    argumentsDict.Add(pair[0], pair[1]);
                                }
                            }
                            string name = (string)reader["specific_name"];
                            string code = (string)reader["definition"];
                            string type = (string)reader["return_type"];
                            functions.Add(new SQLFunction(name, code, argumentsDict, type));
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

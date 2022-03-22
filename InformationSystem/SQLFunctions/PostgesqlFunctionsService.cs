using InformationSystem.SQLFunctions;
using System.Data;
using System.Data.Common;

namespace InformationSystem.Services
{
    public class PostgesqlFunctionsService : ISQLFunctionsService
    {
        private readonly string _functionInfoQuery = @"
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
            if (_dbConnection == null)
                throw new ConnectionIsNotSetExepton();
            try
            {
                IDbCommand command = _dbConnection.CreateCommand();
                command.CommandText = _functionInfoQuery;
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

            return functions;
        }

        public void Update(ISQLFunction function)
        {
            if (_dbConnection == null)
                throw new ConnectionIsNotSetExepton();

            string selectDefinitionQuery = $@"
            SELECT
	            CASE WHEN l.lanname = 'internal' THEN p.prosrc
                        ELSE pg_get_functiondef(p.oid)
                        END AS definition
            FROM pg_proc AS P
            LEFT JOIN pg_language AS l ON p.prolang = l.oid
            LEFT JOIN pg_namespace AS n ON p.pronamespace = n.oid
            WHERE n.nspname NOT IN ('pg_catalog', 'information_schema')
	            AND p.proname = '{function.Name}';";

            IDbCommand command = _dbConnection.CreateCommand();
            command.CommandText = selectDefinitionQuery;
            string createFunctionQuery = "";
            using (IDataReader reader = command.ExecuteReader())
            {
                reader.Read();
                createFunctionQuery = (string)reader["definition"];
            }
            createFunctionQuery = UpdateFunctionDefinition(createFunctionQuery, function.Code);
            command = _dbConnection.CreateCommand();
            command.CommandText = createFunctionQuery;
            command.ExecuteNonQuery();
        }
        private string GetUpdatedDefinition(ISQLFunction function)
        {
            return "";
        }

        private static string UpdateFunctionDefinition(string definition, string body)
        {
            string marker = "$function$";
            int start = definition.IndexOf(marker);
            int end = definition.LastIndexOf(marker);
            string functionBody = definition.Substring(start + marker.Length, end - start - marker.Length);
            return definition.Replace(functionBody, body);
        }

    }
}

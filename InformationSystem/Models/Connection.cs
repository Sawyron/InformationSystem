using System.Data.Odbc;

namespace InformationSystem.Models
{
    public class Connection : IConnection
    {
        private OdbcConnection? _connection;
        public Connection(string server, int port, string dataBase, string user, string password)
        {
            Server = server;
            Port = port;
            DataBase = dataBase;
            User = user;
            Password = password;
        }
        public Connection(string dataBase, string user, string password) :
            this("localhost", 5432, dataBase, user, password)
        { }
        public string Server { get; set; }
        public int Port { get; set; }
        public string DataBase { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        public bool OpenConnection()
        {
            if (_connection != null) CloseConnectin();
            string connectionString = $"Driver={{PostgreSQL ODBC Driver(UNICODE)}};Server={Server};Port={Port};Database={DataBase};UID={User};PWD={Password}";
            _connection = new OdbcConnection(connectionString);
            _connection.Open();
            return _connection.State == System.Data.ConnectionState.Open;
        }

        public bool CloseConnectin()
        {
            if (_connection == null) return false;
            if (_connection.State != System.Data.ConnectionState.Closed)
            {
                _connection.Close();
            }
            return _connection.State == System.Data.ConnectionState.Closed;
        }
    }
}

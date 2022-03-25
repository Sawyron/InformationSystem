namespace InformationSystem.Connection
{
    public class OdbcConnectionString : IConnectionString
    {
        public OdbcConnectionString(string server, int port, string dataBase, string user, string password)
        {
            Server = server;
            Port = port;
            DataBase = dataBase;
            User = user;
            Password = password;
        }
        public OdbcConnectionString(string dataBase, string user, string password) :
            this("localhost", 5432, dataBase, user, password)
        { }
        public string Server { get; set; }
        public int Port { get; set; }
        public string DataBase { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        public string GetConnectionString()
        {
            return $"Driver={{PostgreSQL Unicode}};Server={Server};Port={Port};Database={DataBase};UID={User};PWD={Password}";
        }
    }
}

namespace InformationSystem.Models
{
    public class Connection : IConnection
    {
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
    }
}

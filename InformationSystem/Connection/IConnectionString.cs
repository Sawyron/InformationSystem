namespace InformationSystem.Connection
{
    public interface IConnectionString
    {
        public string Server { get; set; }
        public int Port { get; set; }
        public string DataBase { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string GetConnectionString();
    }
}

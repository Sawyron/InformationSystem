namespace InformationSystem.Views
{
    public interface IConnectionView
    {
        public void SetOpenedState();
        public void SetClosedState();
        public string Server { get; set; }
        public string Port { get; set; }
        public string DataBase { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string ConnectionState { get; set; }

        event EventHandler? OnSave;
        event EventHandler? OnOpenConnection;
        event EventHandler? OnCloseConnection;
        event EventHandler? OnViewLoad;
    }
}

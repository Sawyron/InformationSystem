namespace InformationSystem.Main
{
    public interface IMainView
    {
        public void AddConnectionPage(EventHandler handler);
        public void AddPage(string name, EventHandler handler);
        public void SetUserControl(UserControl control);
        public void SetOpenedState();
        public void SetClosedState();

        event EventHandler? OnViewClosing;
        event EventHandler? OnConnectionClick;
    }
}

namespace InformationSystem.Views
{
    public partial class MainForm : Form, IConnectionView
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public string Server { get => _serverTextBox.Text; set => _serverTextBox.Text = value; }
        public string Port { get => _portTextBox.Text; set => _portTextBox.Text = value; }
        public string DataBase { get => _databaseTextBox.Text; set => _databaseTextBox.Text = value; }
        public string User { get => _userTextBox.Text; set => _userTextBox.Text = value; }
        public string Password { get => _passwordTextBox.Text; set => _passwordTextBox.Text = value; }

        public event EventHandler? OnSave;
        public event EventHandler? OnOpenConnection;
        public event EventHandler? OnCloseConnection;
        public event EventHandler? OnViewLoad;

        private void OnSaveClick(object sender, EventArgs e)
        {
            OnSave?.Invoke(this, EventArgs.Empty);
        }

        private void OnOpenClick(object sender, EventArgs e)
        {
            OnOpenConnection?.Invoke(this, EventArgs.Empty);
        }

        private void OnCloseClick(object sender, EventArgs e)
        {
            OnCloseConnection?.Invoke(this, EventArgs.Empty);
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            OnViewLoad?.Invoke(this, EventArgs.Empty);
        }
    }
}

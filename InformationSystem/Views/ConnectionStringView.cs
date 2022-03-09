namespace InformationSystem.Views
{
    public partial class ConnectionStringView : UserControl, IConnectionView
    {
        public ConnectionStringView()
        {
            InitializeComponent();
        }

        public string Server { get => _serverTextBox.Text; set => _serverTextBox.Text = value; }
        public string Port { get => _portTextBox.Text; set => _portTextBox.Text = value; }
        public string DataBase { get => _databaseTextBox.Text; set => _databaseTextBox.Text = value; }
        public string User { get => _userTextBox.Text; set => _userTextBox.Text = value; }
        public string Password { get => _passwordTextBox.Text; set => _passwordTextBox.Text = value; }
        public string ConnectionState { get => _stateLabel.Text; set => _stateLabel.Text = value; }

        public event EventHandler? OnSave;
        public event EventHandler? OnOpenConnection;
        public event EventHandler? OnCloseConnection;
        public event EventHandler? OnViewLoad;

        public void SetOpenedState()
        {
            _openButton.Enabled = false;
            _closeButton.Enabled = true;
            _saveButton.Enabled = false;
            SetDataTextBoxesEnabled(false);
        }

        public void SetClosedState()
        {
            _openButton.Enabled = true;
            _closeButton.Enabled = false;
            _saveButton.Enabled = true;
            SetDataTextBoxesEnabled(true);
        }

        private void SetDataTextBoxesEnabled(bool enebled)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Enabled = enebled;
                }
            }
        }

        private void _saveButton_Click(object sender, EventArgs e)
        {
            OnSave?.Invoke(this, EventArgs.Empty);
        }

        private void _openButton_Click(object sender, EventArgs e)
        {
            OnOpenConnection?.Invoke(this, EventArgs.Empty);
        }

        private void _closeButton_Click(object sender, EventArgs e)
        {
            OnCloseConnection?.Invoke(this, EventArgs.Empty);
        }

        private void ConnectionControl_Load(object sender, EventArgs e)
        {
            OnViewLoad?.Invoke(this, EventArgs.Empty);
        }
    }
}

using InformationSystem.Models;

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
        public string ConnectionState { get => _stateLabel.Text; set => _stateLabel.Text = value; }

        public event EventHandler? OnSave;
        public event EventHandler? OnOpenConnection;
        public event EventHandler? OnCloseConnection;
        public event EventHandler? OnViewLoad;
        public event EventHandler? OnSelect;

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

        public void SetOpenedState()
        {
            _openConnectionButton.Enabled = false;
            _closeConnectionButton.Enabled = true;
            _selectButton.Enabled = true;
            _selectButton.Enabled = true;
            SetDataTextBoxesEnabled(false);
        }

        public void SetClosedState()
        {
            _openConnectionButton.Enabled = true;
            _closeConnectionButton.Enabled = false;
            _selectButton.Enabled = false;
            _saveButton.Enabled = false;
            SetDataTextBoxesEnabled(true);
        }

        private void SetDataTextBoxesEnabled(bool enebled)
        {
            foreach (Control control in _dataPanel.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Enabled = enebled;
                }
            }
        }

        public void ShowTitles(IEnumerable<Title> titles)
        {
            _queryTextBox.Text = "";
            foreach (Title title in titles)
            {
                _queryTextBox.Text += title.ToString() + "\n";
            }
        }

        private void _selectButton_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, EventArgs.Empty);
        }

        private void _stateLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

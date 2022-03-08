namespace InformationSystem.Views
{
    public partial class MainForm : Form, IMainView
    {
        private UserControl _connectionControl;
        private UserControl _richTextBoxControl;
        public MainForm(UserControl connectionControl, UserControl richTextBoxControl)
        {
            InitializeComponent();
            _connectionControl = connectionControl;
            _richTextBoxControl = richTextBoxControl;
        }

        public event EventHandler? OnConnectionClick;
        public event EventHandler? OnRichTextBoxClick;
        public event EventHandler? OnViewClosing;

        public void SetConnectionView()
        {
            SetUserControl(_connectionControl);
        }

        public void SetRichTextBoxView()
        {
            SetUserControl(_richTextBoxControl);
        }

        private void SetUserControl(UserControl control)
        {
            _containerPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            _containerPanel.Controls.Add(control);
        }

        private void _connectionButton_Click(object sender, EventArgs e)
        {
            OnConnectionClick?.Invoke(this, EventArgs.Empty);
        }

        private void _richTextBox_Click(object sender, EventArgs e)
        {
            OnRichTextBoxClick?.Invoke(this, EventArgs.Empty);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnViewClosing?.Invoke(this, EventArgs.Empty);
        }
    }
}

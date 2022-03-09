namespace InformationSystem.Views
{
    public partial class MainForm : Form, IMainView
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public event EventHandler? OnConnectionClick;
        public event EventHandler? OnRichTextBoxClick;
        public event EventHandler? OnViewClosing;


        public void SetUserControl(UserControl control)
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

        public void AddPage(string name, Action action)
        {
            Button button = new Button();
            button.Text = name;
            button.Click += (sender, args) => action();
            button.Dock = DockStyle.Top;
            button.TabStop = false;
            _controlPanel.Controls.Add(button);
        }
    }
}

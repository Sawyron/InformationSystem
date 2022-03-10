namespace InformationSystem.Views
{
    public partial class MainForm : Form, IMainView
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public event EventHandler? OnConnectionClick;
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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnViewClosing?.Invoke(this, EventArgs.Empty);
        }

        public void AddPage(string name, EventHandler handler)
        {
            Button button = new Button();
            button.Text = name;
            button.Click += handler;
            button.TabStop = false;
            button.Size = _connectionButton.Size;
            _controlPanel.Controls.Add(button);
        }

        public void AddConnectionPage(EventHandler handler)
        {
            _connectionButton.Click += handler;
        }

        public void SetOpenedState()
        {
            foreach (Control control in _controlPanel.Controls)
            {
                if (control is Button button)
                {
                    button.Enabled = true;
                }
            }
        }

        public void SetClosedState()
        {
            foreach (Control control in _controlPanel.Controls)
            {
                if (control is Button button)
                {
                    button.Enabled = false;
                }
            }
            _connectionButton.Enabled = true;
        }
    }
}

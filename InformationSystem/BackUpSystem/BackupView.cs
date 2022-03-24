namespace InformationSystem.BackupSystem
{
    public partial class BackupView : UserControl, IBackupView
    {
        private string _saveFile = "";
        private string _restoreFile = "";

        public event EventHandler? SaveFileSelected;
        public event EventHandler? RestoreFileSelected;

        public BackupView()
        {
            InitializeComponent();
        }

        public string BinPath => _binPathTextBox.Text;

        public string SaveFile => _saveFile;
        public string RestoreFile => _restoreFile;

        public string Password
        {
            get
            {
                return _passwordTextBox.Text;
            }
        }


        private void _selectPostgesPathButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    _binPathTextBox.Text = fbd.SelectedPath;
                }
            }
        }

        private void _saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Password is not set", "Exclamination", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "dump files (*.dump)|*.dump|All files (*.*.)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(saveFileDialog.FileName) == false)
                {
                    _saveFile = saveFileDialog.FileName;
                    SaveFileSelected?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        private void _restoreButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Password is not set", "Exclamination", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "dump files (*.dump)|*.dump|All files (*.*.)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(openFileDialog.FileName) == false)
                {
                    _restoreFile = openFileDialog.FileName;
                    RestoreFileSelected?.Invoke(this, EventArgs.Empty);
                }
            }
        }
    }
}

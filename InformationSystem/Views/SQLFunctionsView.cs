using InformationSystem.Services;

namespace InformationSystem.Views
{
    public partial class SQLFunctionsView : UserControl, ISQLFunctionsView
    {
        public SQLFunctionsView()
        {
            InitializeComponent();
        }

        public string Code { get => _codeTextBox.Text; set => _codeTextBox.Text = value; }

        public event EventHandler<FunctionEventArgs>? ChangedSelectedFunction;

        public void LoadFunctions(IEnumerable<string> functions, string firstCode)
        {
            _functionsComboBox.Items.Clear();
            _functionsComboBox.Items.AddRange(functions.ToArray());
            if (functions.Count() > 0)
            {
                _functionsComboBox.SelectedIndex = 0;
            }
            _codeTextBox.Text = firstCode;
        }

        private void _functionsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? functionName = _functionsComboBox.SelectedItem.ToString();
            if (string.IsNullOrEmpty(functionName) == false)
            {
                ChangedSelectedFunction?.Invoke(this, new FunctionEventArgs(functionName));
            }
        }
    }
}

using System.Text;

namespace InformationSystem.SQLFunctions
{
    public partial class SQLFunctionsView : UserControl, ISQLFunctionsView
    {
        public SQLFunctionsView()
        {
            InitializeComponent();
        }

        public string Code { get => _codeTextBox.Text; set => _codeTextBox.Text = value; }
        public string ReturnType { get => _returnTypeLabel.Text; set => _returnTypeLabel.Text = value; }

        public event EventHandler<SQLFunctionEventArgs>? ChangedSelectedFunction;

        public void LoadFunctions(IEnumerable<string> functions)
        {
            _functionsComboBox.Items.Clear();
            _functionsComboBox.Items.AddRange(functions.ToArray());
            if (functions.Count() > 0)
            {
                _functionsComboBox.SelectedIndex = 0;
            }
        }

        public void ShowArguments(IReadOnlyDictionary<string, string> arguments)
        {
            _argumentsLabel.Text = "";
            StringBuilder stringBuilder = new StringBuilder();
            foreach(var pair in arguments)
            {
                if (stringBuilder.Length > 0)
                    stringBuilder.Append(", ");
                stringBuilder.Append($"{pair.Key} {pair.Value}");
            }
            _argumentsLabel.Text = stringBuilder.ToString();
        }

        private void _functionsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? functionName = _functionsComboBox.SelectedItem.ToString();
            if (string.IsNullOrEmpty(functionName) == false)
            {
                ChangedSelectedFunction?.Invoke(this, new SQLFunctionEventArgs(functionName));
            }
        }
    }
}

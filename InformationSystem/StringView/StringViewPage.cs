using InformationSystem.Models;
using InformationSystem.StringView;
using System.Text;

namespace InformationSystem.StringView
{
    public partial class StringViewPage : UserControl, IStringView
    {
        public StringViewPage()
        {
            InitializeComponent();
        }

        public event EventHandler? OnSelect;

        public void ShowTitles(IEnumerable<Title> titles)
        {
            _titleTextBox.Text = "";
            StringBuilder stringBuilder = new StringBuilder();
            foreach (Title title in titles)
            {
                stringBuilder.AppendLine(title.ToString());
            }
            _titleTextBox.Text = stringBuilder.ToString();
        }

        private void _selectButton_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, EventArgs.Empty);
        }
    }
}

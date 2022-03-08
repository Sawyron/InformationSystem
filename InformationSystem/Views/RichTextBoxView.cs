using InformationSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationSystem.Views
{
    public partial class RichTextBoxView : UserControl, IRichTextBoxView
    {
        public RichTextBoxView()
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

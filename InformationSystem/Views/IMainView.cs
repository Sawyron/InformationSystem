using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem.Views
{
    public interface IMainView
    {
        public void AddPage(string name, Action action);
        public void SetUserControl(UserControl control);

        event EventHandler? OnViewClosing;
        event EventHandler? OnConnectionClick;
        event EventHandler? OnRichTextBoxClick;
    }
}

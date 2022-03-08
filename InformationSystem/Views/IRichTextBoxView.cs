using InformationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem.Views
{
    public interface IRichTextBoxView
    {
        void ShowTitles(IEnumerable<Title> titles);
        event EventHandler? OnSelect;
    }
}

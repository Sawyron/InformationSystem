using InformationSystem.Services;
using InformationSystem.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem.Controllers
{
    public class RichTextBoxController : IDataController
    {
        private ITitleService _titleService;
        private IRichTextBoxView _richTextBoxView;

        public RichTextBoxController(ITitleService titleService, IRichTextBoxView richTextBoxView)
        {
            _titleService = titleService;
            _richTextBoxView = richTextBoxView;

            _richTextBoxView.OnSelect += richTextBoxView_OnSelect;
        }

        private void richTextBoxView_OnSelect(object? sender, EventArgs e)
        {
            _richTextBoxView.ShowTitles(_titleService.GetAll());
        }

        public IDbConnection DbConnection { set => _titleService.DbConnection = value; }
    }
}

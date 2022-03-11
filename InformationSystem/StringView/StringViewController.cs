using InformationSystem.Controllers;
using InformationSystem.Services;
using System.Data;

namespace InformationSystem.StringView
{
    public class StringViewController : IDataController
    {
        private ITitleService _titleService;
        private IStringView _richTextBoxView;

        public StringViewController(ITitleService titleService, IStringView richTextBoxView)
        {
            _titleService = titleService;
            _richTextBoxView = richTextBoxView;

            _richTextBoxView.OnSelect += richTextBoxView_OnSelect;
        }

        private void richTextBoxView_OnSelect(object? sender, EventArgs e)
        {
            OnLoad();
        }

        public void OnLoad()
        {
            _richTextBoxView.ShowTitles(_titleService.GetAll());
        }

        public IDbConnection DbConnection { set => _titleService.DbConnection = value; }
    }
}

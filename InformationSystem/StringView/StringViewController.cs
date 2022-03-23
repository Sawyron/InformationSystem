using InformationSystem.Controllers;
using InformationSystem.Services;
using System.Data;

namespace InformationSystem.StringView
{
    public class StringViewController : IDataController
    {
        private ITitleService _titleService;
        private IStringView _richTextBoxView;
        private IMessageService _messageService;

        public StringViewController(IStringView richTextBoxView, ITitleService titleService, IMessageService messageService)
        {
            _titleService = titleService;
            _richTextBoxView = richTextBoxView;
            _messageService = messageService;

            _richTextBoxView.OnSelect += richTextBoxView_OnSelect;
        }

        private void richTextBoxView_OnSelect(object? sender, EventArgs e)
        {
            OnLoad();
        }

        public void OnLoad()
        {
            try
            {
                _richTextBoxView.ShowTitles(_titleService.GetAll());
            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }

        public IDbConnection DbConnection { set => _titleService.DbConnection = value; }
    }
}

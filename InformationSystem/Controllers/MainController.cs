using InformationSystem.Services;
using InformationSystem.Views;
using System.Data;

namespace InformationSystem.Controllers
{
    public class MainController
    {
        private IMainView _mainView;
        private IMessageService _messageService;
        private IDbConnection? _dbConnection;
        private IConnectionController _connectionController;
        private IDataController _richTextBoxController;

        public MainController(IMainView mainView,
            IMessageService messageService,
            IConnectionController connectionController,
            IDataController richTextBoxController)
        {
            _mainView = mainView;
            _messageService = messageService;
            _connectionController = connectionController;
            _richTextBoxController = richTextBoxController;

            _mainView.OnViewClosing += mainView_OnViewClosing;
            _mainView.OnConnectionClick += mainView_OnConnectionClick;
            _mainView.OnRichTextBoxClick += mainView_OnRichTextBoxClick;
        }

        private void mainView_OnViewClosing(object? sender, EventArgs e)
        {
            _dbConnection?.Close();
        }

        private void mainView_OnRichTextBoxClick(object? sender, EventArgs e)
        {
            _dbConnection = _connectionController.DbConnection;
            if (_dbConnection != null && _dbConnection.State == ConnectionState.Open)
            {
                _richTextBoxController.DbConnection = _dbConnection;
                _mainView.SetRichTextBoxView();
            }
            else { _messageService.ShowError("Connection is not opened"); }
        }

        private void mainView_OnConnectionClick(object? sender, EventArgs e)
        {
            _mainView.SetConnectionView();
        }
    }
}

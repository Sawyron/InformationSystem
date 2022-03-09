using InformationSystem.Models;
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

        private UserControlPage<IConnectionStringController> _connectionPage;

        public MainController(
            IMainView mainView,
            IMessageService messageService,
            UserControlPage<IConnectionStringController> connectionPage,
            IEnumerable<UserControlPage<IDataController>> controlPages
            )
        {
            _mainView = mainView;
            _messageService = messageService;
            _connectionPage = connectionPage;
            foreach (UserControlPage<IDataController> page in controlPages)
            {
                _mainView.AddPage(page.Name, () =>
                {
                    OnOpeningDataPage(page);
                });
            }
            _mainView.AddPage(_connectionPage.Name, () => OnOpeningConnectionPage());

            _connectionPage.Controller.OnOpeningConnection += mainView_OnConnectionClick;
            _mainView.OnViewClosing += mainView_OnViewClosing;
        }

        private void mainView_OnViewClosing(object? sender, EventArgs e)
        {
            _dbConnection?.Close();
        }

        private void OnOpeningConnectionPage()
        {
            _mainView.SetUserControl(_connectionPage.View);
        }

        private void mainView_OnConnectionClick(object? sender, EventArgs e)
        {
            _dbConnection = _connectionPage.Controller.DbConnection;
        }

        private void OnOpeningDataPage(UserControlPage<IDataController> page)
        {
            if (_dbConnection != null && _dbConnection.State == ConnectionState.Open)
            {
                _mainView.SetUserControl(page.View);
                page.Controller.DbConnection = _dbConnection;
            }
            else
            {
                _messageService.ShowError("Connection is not set");
            }
        }
    }
}

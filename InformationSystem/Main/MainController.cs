using InformationSystem.Connection;
using InformationSystem.Controllers;
using InformationSystem.Models;
using InformationSystem.Services;
using System.Data;

namespace InformationSystem.Main
{
    public class MainController
    {
        private IMainView _mainView;
        private IMessageService _messageService;
        private IDbConnection? _dbConnection;

        private IPage<IConnectionStringController, UserControl> _connectionPage;

        public MainController(
            IMainView mainView,
            IMessageService messageService,
            IPage<IConnectionStringController, UserControl> connectionPage,
            IEnumerable<IPage<IDataController, UserControl>> controlPages
            )
        {
            _mainView = mainView;
            _messageService = messageService;
            _connectionPage = connectionPage;

            _mainView.AddConnectionPage((sender, args) => OnOpeningConnectionPage());
            foreach (IPage<IDataController, UserControl> page in controlPages)
            {
                _mainView.AddPage(page.Name, (sender, args) =>
                {
                    OnOpeningDataPage(page);
                });
            }

            _mainView.SetClosedState();

            _connectionPage.Controller.OnOpeningConnection += mainView_OnConnectionClick;
            _mainView.OnViewClosing += mainView_OnViewClosing;
            _connectionPage.Controller.OnClosingConnection += Controller_OnClosingConnection;
        }

        private void Controller_OnClosingConnection(object? sender, EventArgs e)
        {
            _mainView.SetClosedState();
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
            if (_dbConnection != null)
            {
                _mainView.SetOpenedState();
            }
        }

        private void OnOpeningDataPage(IPage<IDataController, UserControl> page)
        {
            if (_dbConnection != null && _dbConnection.State == ConnectionState.Open)
            {
                _mainView.SetUserControl(page.View);
                page.Controller.DbConnection = _dbConnection;
                page.Controller.OnLoad();
            }
            else
            {
                _messageService.ShowError("Connection is not set");
            }
        }
    }
}

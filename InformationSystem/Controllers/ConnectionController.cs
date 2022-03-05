using InformationSystem.Models;
using InformationSystem.Services;
using InformationSystem.Views;

namespace InformationSystem.Controllers
{
    public class ConnectionController
    {
        private IConnectionView _connectionView;
        private IConnection _connection;
        private IMessageService _messageService;

        public ConnectionController(IConnection connection, IConnectionView connectionView, IMessageService messageService)
        {
            _connection = connection;
            _connectionView = connectionView;
            _messageService = messageService;

            _connectionView.OnSave += connectionView_OnSave;
            _connectionView.OnViewLoad += _connectionView_OnViewLoad;
        }

        private void _connectionView_OnViewLoad(object? sender, EventArgs e)
        {
            _connectionView.Port = _connection.Port.ToString();
            _connectionView.Server = _connection.Server;
            _connectionView.User = _connection.User;
            _connectionView.Password = _connection.Password;
            _connectionView.DataBase = _connection.DataBase;
        }

        private void connectionView_OnSave(object? sender, EventArgs e)
        {
            try
            {
                int port = int.Parse(_connectionView.Port);
                _connection.Port = port;
                _connection.Server = _connectionView.Server;
                _connection.User = _connectionView.User;
                _connection.Password = _connectionView.Password;
                _connection.DataBase = _connectionView.DataBase;
            }
            catch (FormatException ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }
    }
}

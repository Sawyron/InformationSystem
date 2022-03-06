using InformationSystem.Models;
using InformationSystem.Services;
using InformationSystem.Views;
using System.Data.Odbc;

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
            _connectionView.OnOpenConnection += _connectionView_OnOpenConnection;
            _connectionView.OnCloseConnection += _connectionView_OnCloseConnection;
        }

        private void _connectionView_OnOpenConnection(object? sender, EventArgs e)
        {
            bool result = false;
            try
            {
                result = _connection.OpenConnection();
            }
            catch(OdbcException ex)
            {
                _messageService.ShowError(ex.Message);
            }
            if (result)
            {
                _connectionView.CloseButtonEnabled = true;
                _connectionView.OpenButtonEnabled = false;
                _connectionView.ConnectionState = "Connection opened";
            }
            else
            {
                _connectionView.ConnectionState = "Connection opening error";
            }
        }
        private void _connectionView_OnCloseConnection(object? sender, EventArgs e)
        {
            if (_connection.CloseConnectin())
            {
                _connectionView.CloseButtonEnabled = false;
                _connectionView.OpenButtonEnabled = true;
                _connectionView.ConnectionState = "Connection closed";
            }
            else
            {
                _connectionView.ConnectionState = "Connection closing error";
            }
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
                _connectionView.ConnectionState = "Connection data saved";
            }
            catch (FormatException ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }
    }
}

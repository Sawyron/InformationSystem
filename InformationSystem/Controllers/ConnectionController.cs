using InformationSystem.Models;
using InformationSystem.Services;
using InformationSystem.Views;
using System.Data;
using System.Data.Odbc;

namespace InformationSystem.Controllers
{
    public class ConnectionController : IConnectionController
    {
        private IConnectionView _connectionView;
        private IConnectionString _connectionString;
        private IMessageService _messageService;
        private OdbcConnection? _connection;

        public IDbConnection? DbConnection => _connection;

        public IConnectionView ConnectionView => _connectionView;

        public ConnectionController(IConnectionString connection, IConnectionView connectionView, IMessageService messageService)
        {
            _connectionString = connection;
            _connectionView = connectionView;
            _messageService = messageService;

            _connectionView.OnSave += connectionView_OnSave;
            _connectionView.OnViewLoad += _connectionView_OnViewLoad;
            _connectionView.OnOpenConnection += _connectionView_OnOpenConnection;
            _connectionView.OnCloseConnection += _connectionView_OnCloseConnection;
        }

        private void _connectionView_OnOpenConnection(object? sender, EventArgs e)
        {
            _connection = new OdbcConnection(_connectionString.GetConnectionString());
            try
            {
                _connection.Open();
                _connectionView.SetOpenedState();
                _connectionView.ConnectionState = "Connection opened";
            }
            catch (OdbcException ex)
            {
                _connectionView.ConnectionState = "Error appeared while opening the connection";
                _messageService.ShowError(ex.Message);
            }
        }
        private void _connectionView_OnCloseConnection(object? sender, EventArgs e)
        {
            _connection?.Close();
            _connectionView.SetClosedState();
            _connectionView.ConnectionState = "Connection closed";
        }


        private void _connectionView_OnViewLoad(object? sender, EventArgs e)
        {
            _connectionView.Port = _connectionString.Port.ToString();
            _connectionView.Server = _connectionString.Server;
            _connectionView.User = _connectionString.User;
            _connectionView.Password = _connectionString.Password;
            _connectionView.DataBase = _connectionString.DataBase;
        }

        private void connectionView_OnSave(object? sender, EventArgs e)
        {
            try
            {
                int port = int.Parse(_connectionView.Port);
                _connectionString.Port = port;
                _connectionString.Server = _connectionView.Server;
                _connectionString.User = _connectionView.User;
                _connectionString.Password = _connectionView.Password;
                _connectionString.DataBase = _connectionView.DataBase;
                _connectionView.ConnectionState = "Connection data saved";
            }
            catch (FormatException ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }
    }
}

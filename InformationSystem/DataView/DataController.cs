using InformationSystem.Controllers;
using InformationSystem.Services;
using System.Data;

namespace InformationSystem.DataView
{
    public class DataController : IDataController
    {
        private IDataView _dataView;
        private ITableService _tableService;
        private IMessageService _messageService;
        public DataController(IDataView dataView, ITableService tableService, IMessageService messageService)
        {
            _dataView = dataView;
            _tableService = tableService;
            _messageService = messageService;

            _dataView.TableSelected += _dataView_TableSelected;
            _dataView.ValueChanged += _dataView_ValueChanged;
            _dataView.TableUpdated += _dataView_TableUpdated;
        }

        private void _dataView_TableUpdated(object? sender, EventArgs e)
        {
            _tableService.UpdateTable();
        }

        private void _dataView_ValueChanged(object? sender, TableValueArgs e)
        {
            _tableService.UpdateRow(e.Row, e.Column, e.Value);
        }

        private void _dataView_TableSelected(object? sender, EventArgs e)
        {
            try
            {
                _tableService.SetTable(_dataView.TableName);
                _dataView.DataSource = _tableService.GetTable();
            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }

        public IDbConnection DbConnection { set => _tableService.DbConnection = value; }

        public void OnLoad()
        {

        }
    }
}

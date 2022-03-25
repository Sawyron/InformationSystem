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
        private IDataBaseService _dataBaseService;
        public DataController(IDataView dataView, ITableService tableService, IDataBaseService dataBaseService, IMessageService messageService)
        {
            _dataView = dataView;
            _tableService = tableService;
            _messageService = messageService;
            _dataBaseService = dataBaseService;

            _dataView.TableSelected += _dataView_TableSelected;
            _dataView.ValueChanged += _dataView_ValueChanged;
            _dataView.TableUpdated += _dataView_TableUpdated;
            _dataView.RowAdded += _dataView_RowAdded;
            _dataView.DeleteClick += _dataView_DeleteClick;
            _dataView.RowDeleted += _dataView_RowDeleted;
        }

        private void _dataView_RowDeleted(object? sender, RowArgs e)
        {
            _tableService.DeleteRow(e.Row);
        }

        private void _dataView_DeleteClick(object? sender, EventArgs e)
        {
            _tableService.DeleteRows(_dataView.SelectedRows);
        }

        private void _dataView_RowAdded(object? sender, EventArgs e)
        {
            _tableService.CreateRow();
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

        public IDbConnection DbConnection
        {
            set
            {
                _tableService.DbConnection = value;
                _dataBaseService.DbConnection = value;
            }
        }

        public void OnLoad()
        {
            try
            {
                _dataView.LoadDataBases(_dataBaseService.GetDataBases());
                string? table = _dataBaseService.Table;
                if (table != null)
                {
                    _dataView.LoadTables(table, _dataBaseService.GetTables());
                }
            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }
    }
}

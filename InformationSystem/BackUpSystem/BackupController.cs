using InformationSystem.Controllers;
using InformationSystem.Services;
using System.Data;

namespace InformationSystem.BackupSystem
{
    public class BackupController : IDataController
    {
        private IBackupView _backupView;
        private IBackupService _backupService;
        private IMessageService _messageService;

        public BackupController(IBackupView backupView, IBackupService backupService, IMessageService messageService)
        {
            _backupView = backupView;
            _backupService = backupService;
            _messageService = messageService;

            _backupView.SaveFileSelected += _backupView_SaveFileSelected;
            _backupView.RestoreFileSelected += _backupView_RestoreFileSelected;
        }

        private void _backupView_RestoreFileSelected(object? sender, EventArgs e)
        {
            _backupService.BinPath = _backupView.BinPath;
            _backupService.Password = _backupService.Password;
            try
            {
                _backupService.RestoreDataBase(_backupView.RestoreFile);
            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }

        private void _backupView_SaveFileSelected(object? sender, EventArgs e)
        {
            _backupService.BinPath = _backupView.BinPath;
            _backupService.Password = _backupView.Password;
            try
            {
                _backupService.SaveDataBase(_backupView.SaveFile);
            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }

        public IDbConnection DbConnection { set => _backupService.DbConnection = value; }

        public void OnLoad()
        {
        }
    }
}

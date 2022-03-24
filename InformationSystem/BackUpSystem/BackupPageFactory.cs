using InformationSystem.Controllers;
using InformationSystem.Models;
using InformationSystem.Services;
using InformationSystem.Services.Factories;

namespace InformationSystem.BackupSystem
{
    public class BackupPageFactory : IPageFactory<IDataController, UserControl>
    {
        public IPage<IDataController, UserControl> CreatePage()
        {
            BackupService backupService = new BackupService();
            BackupView backupView = new BackupView();
            BackupController backupController = new BackupController(backupView, backupService, MessageService.Instance);
            return new Page<IDataController, UserControl>(backupView, backupController, "Backup");
        }
    }
}

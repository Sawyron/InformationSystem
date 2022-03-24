using InformationSystem.Services;

namespace InformationSystem.BackupSystem
{
    public interface IBackupService : IDataService
    {
        public string BinPath { get; set; }
        public string Password { get; set; }
        public int SaveDataBase(string file);
        public int RestoreDataBase(string file);
    }
}

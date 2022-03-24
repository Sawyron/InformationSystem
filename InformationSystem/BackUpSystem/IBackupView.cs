namespace InformationSystem.BackupSystem
{
    public interface IBackupView
    {
        string BinPath { get; }
        string SaveFile { get; }
        string RestoreFile { get; }
        public string Password { get; }
        event EventHandler? SaveFileSelected;
        event EventHandler? RestoreFileSelected;
    }
}

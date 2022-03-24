using InformationSystem.Services;
using System.Data;
using System.Data.Odbc;
using System.Diagnostics;

namespace InformationSystem.BackupSystem
{
    public class BackupService : IBackupService   
    {
        private IDbConnection? _connection;
        private string _binPath = "";
        public IDbConnection? DbConnection { get => _connection; set => _connection = value; }
        public string BinPath { get => _binPath; set => _binPath = value; }
        public string Password { get; set; } = "";

        private string GetDbName()
        {
            OdbcConnectionStringBuilder builder = new OdbcConnectionStringBuilder(_connection?.ConnectionString);
            return $"--dbname=postgresql://{builder["uid"]}:{Password}@{builder["server"]}:{builder["port"]}/{_connection?.Database}";
        }

        private int ExecuteProcess(string fileName, string args)
        {
            Process dump = new Process();
            dump.StartInfo.FileName = fileName;
            dump.StartInfo.Arguments = args;
            dump.StartInfo.UseShellExecute = false;
            dump.StartInfo.CreateNoWindow = true;
            dump.Start();
            dump.WaitForExit();
            return dump.ExitCode;
        }
        public int SaveDataBase(string file)
        {
            if (_connection == null)
                throw new ConnectionIsNotSetException();
            return ExecuteProcess(_binPath + @"\pg_dump.exe", $"{GetDbName()} -F c -f \"{file}\"");
        }

        public int RestoreDataBase(string file)
        {
            string fileName = _binPath + @"\pg_restore.exe";
            string args = $"{GetDbName()} -c -F c \"{file}\"";
            return ExecuteProcess(fileName, args);
        }
    }
}

using InformationSystem.Services;
using System.Data;
using System.Data.Odbc;
using System.Diagnostics;
using System.Text.Encodings.Web;

namespace InformationSystem.BackupSystem
{
    public class BackupService : IBackupService   
    {
        private IDbConnection? _connection;
        private string _binPath = "";
        public IDbConnection? DbConnection { get => _connection; set => _connection = value; }
        public string BinPath { get => _binPath; set => _binPath = value; }
        public string Password { get; set; } = @"C:\Program Files\PostgreSQL\13\bin";
        private string GetDbName()
        {
            OdbcConnectionStringBuilder builder = new OdbcConnectionStringBuilder(_connection?.ConnectionString);
            string password = Uri.EscapeDataString(Password);
            string dbname = _connection?.Database ?? "";
            dbname = Uri.EscapeDataString(dbname);
            string user = builder["uid"].ToString() ?? "";
            user = Uri.EscapeDataString(user);
            string host = builder["server"].ToString() ?? "";
            host = Uri.EscapeDataString(host);
            string test = Uri.EscapeDataString("%abc@$#^?+=,/<>|");
            return $"--dbname=postgresql://{user}:{password}@{host}:{builder["port"]}/{dbname}";
        }

        private int ExecuteProcess(string fileName, string args)
        {
            Process process = new Process();
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.FileName = fileName;
            process.StartInfo.Arguments = args;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            string error = process.StandardError.ReadToEnd();
            process.WaitForExit();
            if (process.ExitCode != 0)
            {
                throw new Exception(error);
            }
            return process.ExitCode;
        }
        public int SaveDataBase(string file)
        {
            if (_connection == null)
                throw new ConnectionIsNotSetException();
            return  ExecuteProcess(_binPath + @"\pg_dump.exe", $"{GetDbName()} -F c -f \"{file}\"");
        }

        public int RestoreDataBase(string file)
        {
            string fileName = _binPath + @"\pg_restore.exe";
            string args = $"{GetDbName()} -c -F c \"{file}\"";
            return  ExecuteProcess(fileName, args);
        }
    }
}

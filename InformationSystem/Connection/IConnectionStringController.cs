using System.Data;

namespace InformationSystem.Connection
{
    public interface IConnectionStringController
    {
        public IDbConnection? DbConnection { get; }
        public IConnectionView ConnectionView { get; }
        event EventHandler? OnOpeningConnection;
        event EventHandler? OnClosingConnection;
    }
}

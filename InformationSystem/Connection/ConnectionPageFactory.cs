using InformationSystem.Models;
using InformationSystem.Services;
using InformationSystem.Services.Factories;

namespace InformationSystem.Connection
{
    public class ConnectionPageFactory : IPageFactory<IConnectionStringController, UserControl>
    {
        public IPage<IConnectionStringController, UserControl> CreatePage()
        {
            ConnectionStringView connectionView = new ConnectionStringView();
            ConnectionStringController connectionController = new ConnectionStringController(
                new OdbcConnectionString(string.Empty, "postgres", string.Empty),
                connectionView,
                new MessageService());

            Page<IConnectionStringController, UserControl> connectionPage = new Page<IConnectionStringController, UserControl>(connectionView, connectionController, "Connection");
            return connectionPage;
        }
    }
}

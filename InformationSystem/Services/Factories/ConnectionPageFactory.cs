using InformationSystem.Controllers;
using InformationSystem.Models;
using InformationSystem.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem.Services.Factories
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

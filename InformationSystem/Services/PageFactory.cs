using InformationSystem.Controllers;
using InformationSystem.Models;
using InformationSystem.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem.Services
{
    public class PageFactory : IPageFactory
    {
        public UserControlPage<IConnectionStringController> GetConnectionPage()
        {
            ConnectionStringView connectionView = new ConnectionStringView();
            ConnectionStringController connectionController = new ConnectionStringController(
                new OdbcConnectionString(string.Empty, "postgres", string.Empty),
                connectionView,
                new MessageService());

            UserControlPage<IConnectionStringController> connectionPage = new UserControlPage<IConnectionStringController>(connectionView, connectionController, "Connection");
            return connectionPage;

        }

        public UserControlPage<IDataController> GetRichBoxPage()
        {
            RichTextBoxView textBoxView = new RichTextBoxView();
            RichTextBoxController richTextBoxController = new RichTextBoxController(new TitleService(), textBoxView);
            UserControlPage<IDataController> page = new UserControlPage<IDataController>(textBoxView, richTextBoxController, "Rich Text Box");
            return page;
        }
    }
}

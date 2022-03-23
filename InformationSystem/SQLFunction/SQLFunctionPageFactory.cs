using InformationSystem.Controllers;
using InformationSystem.Models;
using InformationSystem.SQLFunctions;

namespace InformationSystem.Services.Factories
{
    public class SQLFunctionPageFactory : IPageFactory<IDataController, UserControl>
    {
        public IPage<IDataController, UserControl> CreatePage()
        {
            PostgesqlFunctionsService functionService = new PostgesqlFunctionsService();
            SQLFunctionsView view = new SQLFunctionsView();
            MessageService messageService = MessageService.Instance;
            SQLFunctionsController controller = new SQLFunctionsController(view, functionService, messageService);
            return new Page<IDataController, UserControl>(view, controller, "Functions");
        }
    }
}

using InformationSystem.Controllers;
using InformationSystem.Models;
using InformationSystem.SQLFunctions;

namespace InformationSystem.Services.Factories
{
    public class SQLFunctionPageFactory : IPageFactory<IDataController, UserControl>
    {
        public IPage<IDataController, UserControl> CreatePage()
        {
            PostgesqlFunctionsService service = new PostgesqlFunctionsService();
            SQLFunctionsView view = new SQLFunctionsView();
            SQLFunctionsController controller = new SQLFunctionsController(service, view);
            return new Page<IDataController, UserControl>(view, controller, "Functions");
        }
    }
}

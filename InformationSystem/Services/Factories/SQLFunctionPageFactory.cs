using InformationSystem.Controllers;
using InformationSystem.Models;
using InformationSystem.Views;

namespace InformationSystem.Services.Factories
{
    public class SQLFunctionPageFactory : IPageFactory<IDataController, UserControl>
    {
        public IPage<IDataController, UserControl> CreatePage()
        {
            SQLFunctionsService service = new SQLFunctionsService();
            SQLFunctionsView view = new SQLFunctionsView();
            SQLFunctionsController controller = new SQLFunctionsController(service, view);
            return new Page<IDataController, UserControl>(view, controller, "Functions");
        }
    }
}

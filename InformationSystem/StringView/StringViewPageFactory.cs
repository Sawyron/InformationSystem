using InformationSystem.Controllers;
using InformationSystem.Models;
using InformationSystem.Services;
using InformationSystem.Services.Factories;

namespace InformationSystem.StringView
{
    public class StringViewPageFactory : IPageFactory<IDataController, UserControl>
    {
        public IPage<IDataController, UserControl> CreatePage()
        {
            StringViewPage textBoxView = new StringViewPage();
            StringViewController richTextBoxController = new StringViewController(textBoxView, new TitleService(), MessageService.Instance);
            Page<IDataController, UserControl> page = new Page<IDataController, UserControl>(textBoxView, richTextBoxController, "Rich Text Box");
            return page;
        }
    }
}

using InformationSystem.Controllers;
using InformationSystem.Models;
using InformationSystem.Views;

namespace InformationSystem.Services.Factories
{
    public class RichTextBoxPageFactory : IPageFactory<IDataController, UserControl>
    {
        public IPage<IDataController, UserControl> CreatePage()
        {
            RichTextBoxView textBoxView = new RichTextBoxView();
            RichTextBoxController richTextBoxController = new RichTextBoxController(new TitleService(), textBoxView);
            Page<IDataController, UserControl> page = new Page<IDataController, UserControl>(textBoxView, richTextBoxController, "Rich Text Box");
            return page;
        }
    }
}

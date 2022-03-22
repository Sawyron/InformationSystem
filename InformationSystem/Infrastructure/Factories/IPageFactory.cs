using InformationSystem.Models;

namespace InformationSystem.Services.Factories
{
    public interface IPageFactory<C, V>
    {
        IPage<C, V> CreatePage();
    }
}

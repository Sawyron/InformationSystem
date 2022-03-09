using InformationSystem.Controllers;
using InformationSystem.Models;

namespace InformationSystem.Services.Factories
{
    public interface IPagesFactory<C, V>
    {
        IEnumerable<IPage<C, V>> GetPages();
    }
}

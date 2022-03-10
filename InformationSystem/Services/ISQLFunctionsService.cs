using InformationSystem.Models;

namespace InformationSystem.Services
{
    public interface ISQLFunctionsService : IDataService
    {
        IEnumerable<ISQLFunction> GetAll();
    }
}
using InformationSystem.SQLFunctions;

namespace InformationSystem.Services
{
    public interface ISQLFunctionsService : IDataService
    {
        IEnumerable<ISQLFunction> GetAll();
        void Update(ISQLFunction function);
    }
}
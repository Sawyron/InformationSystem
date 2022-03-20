using InformationSystem.Models;

namespace InformationSystem.Services
{
    public interface ITableService
    {
        ITable GetTable(string name);
    }
}

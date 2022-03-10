using InformationSystem.Models;
using System.Data;

namespace InformationSystem.Services
{
    public interface ITitleService : IDataService
    {
        IEnumerable<Title> GetAll();
    }
}
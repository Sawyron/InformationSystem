using InformationSystem.Models;
using System.Data;

namespace InformationSystem.Services
{
    public interface ITitleService
    {
        IDbConnection? DbConnection { get; set; }

        IEnumerable<Title> GetAll();
    }
}
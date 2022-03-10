using System.Data;

namespace InformationSystem.Services
{
    public interface IDataService
    {
        IDbConnection? DbConnection { get; set; }
    }
}
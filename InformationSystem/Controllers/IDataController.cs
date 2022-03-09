using System.Data;

namespace InformationSystem.Controllers
{
    public interface IDataController
    {
        public IDbConnection DbConnection { set; }
    }
}

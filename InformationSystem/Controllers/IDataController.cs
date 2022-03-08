using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem.Controllers
{
    public interface IDataController
    {
        public IDbConnection DbConnection { set; }
    }
}

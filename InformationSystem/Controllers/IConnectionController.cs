using InformationSystem.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem.Controllers
{
    public interface IConnectionController
    {
        public IDbConnection? DbConnection { get; }
        public IConnectionView ConnectionView { get; }
    }
}

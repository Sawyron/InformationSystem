using InformationSystem.Controllers;
using InformationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem.Services
{
    public interface IPageFactory
    {
        UserControlPage<IConnectionStringController> GetConnectionPage();
        UserControlPage<IDataController> GetRichBoxPage();
    }
}

using InformationSystem.Controllers;
using InformationSystem.Services;
using System.Data;

namespace InformationSystem.SQLFunctions
{
    public class SQLFunctionsController : IDataController
    {
        private ISQLFunctionsService _service;
        private ISQLFunctionsView _view;

        public SQLFunctionsController(ISQLFunctionsService service, ISQLFunctionsView view)
        {
            _service = service;
            _view = view;
            _view.ChangedSelectedFunction += view_ChangedSelectedFunction;
        }

        private void view_ChangedSelectedFunction(object? sender, SQLFunctionEventArgs e)
        {
            List<ISQLFunction> functions = _service.GetAll().ToList();
            ISQLFunction? f = functions.Find((fn) =>
            {
                return fn.Name.Equals(e.Name);
            });
            if (f != null)
            {
                _view.Code = f.Code;
            }
        }

        public IDbConnection DbConnection { set => _service.DbConnection = value; }

        public void OnLoad()
        {
            List<string> functionNames = new List<string>();
            IEnumerable<ISQLFunction> functions = _service.GetAll();
            foreach (ISQLFunction fn in functions)
            {
                functionNames.Add(fn.Name);
            }
            _view.LoadFunctions(functionNames, functions.First().Code);
        }
    }
}

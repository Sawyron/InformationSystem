using InformationSystem.Controllers;
using InformationSystem.Services;
using System.Data;
using System.Text;

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
        public IDbConnection DbConnection { set => _service.DbConnection = value; }
        private void view_ChangedSelectedFunction(object? sender, SQLFunctionEventArgs e)
        {
            List<ISQLFunction> functions = _service.GetAll().ToList();
            ISQLFunction? f = functions.Find((fn) =>
            {
                return fn.Name.Equals(e.Name);
            });
            if (f != null)
                ShowFunction(f);
            
        }
        private void ShowFunction(ISQLFunction function)
        {
            _view.Code = function.Code;
            _view.ReturnType = function.ReturnType;
            _view.ShowArguments(function.Arguments);
        }
        public void OnLoad()
        {
            List<string> functionNames = new List<string>();
            IEnumerable<ISQLFunction> functions = _service.GetAll();
            foreach (ISQLFunction fn in functions)
            {
                functionNames.Add(fn.Name);
            }
            _view.LoadFunctions(functionNames);
            ISQLFunction? firstFunction = functions.FirstOrDefault();
            if (firstFunction != null)
                ShowFunction(firstFunction);
        }
    }
}

using InformationSystem.Controllers;
using InformationSystem.Services;
using System.Data;
using System.Data.Common;
using System.Text;

namespace InformationSystem.SQLFunctions
{
    public class SQLFunctionsController : IDataController
    {
        private ISQLFunctionsService _service;
        private ISQLFunctionsView _view;
        private IMessageService _messageService;

        public SQLFunctionsController(ISQLFunctionsView view, ISQLFunctionsService service, IMessageService messageService)
        {
            _service = service;
            _view = view;
            _messageService = messageService;

            _view.ChangedSelectedFunction += view_ChangedSelectedFunction;
            _view.UpdatedFunctionDefinition += _view_UpdatedFunctionDefinition;
        }
        public IDbConnection DbConnection { set => _service.DbConnection = value; }

        private void _view_UpdatedFunctionDefinition(object? sender, SQLFunctionEventArgs e)
        {
            ISQLFunction? function = FindFunctionByName(e.Name);
            if (function != null)
            {
                function.Code = e.Code;
                try
                {
                    _service.Update(function);
                    _view.State = "Function succsesfully updated";
                }
                catch (DbException ex)
                {
                    _messageService.ShowError(ex.Message);
                }
            }
        }

        private void view_ChangedSelectedFunction(object? sender, SQLFunctionEventArgs e)
        {
            ISQLFunction? function = FindFunctionByName(e.Name);
            if (function != null)
                ShowFunction(function);
            _view.State = "";
        }

        private ISQLFunction? FindFunctionByName(string name)
        {
            List<ISQLFunction> functions = _service.GetAll().ToList();
            ISQLFunction? function = functions.Find((fn) =>
            {
                return fn.Name.Equals(name);
            });
            return function;
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

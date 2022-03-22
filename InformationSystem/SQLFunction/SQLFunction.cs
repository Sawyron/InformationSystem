
using System.Collections.Immutable;
using System.Collections.ObjectModel;

namespace InformationSystem.SQLFunctions
{
    public class SQLFunction : ISQLFunction
    {
        private readonly string _name;
        private ReadOnlyDictionary<string, string> _arguments;
        private string _code;
        private readonly string _returnType;

        public SQLFunction(string name, string code, IDictionary<string, string> arguments, string returnType)
        {
            _name = name;
            _code = code;
            _arguments = new ReadOnlyDictionary<string, string>(arguments);
            _returnType = returnType;
        }
        public string Name => _name;

        public string Code { get => _code; set => _code = value; }

        public IReadOnlyDictionary<string, string> Arguments => _arguments;

        public string ReturnType => _returnType;
    }
}

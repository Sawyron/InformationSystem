namespace InformationSystem.SQLFunctions
{
    public class SQLFunction : ISQLFunction
    {
        private string _name;
        private string _code;
        private List<string> _parameters = new List<string>();

        public SQLFunction(string name, string code)
        {
            _name = name;
            _code = code;
        }
        public string Name => _name;

        public IEnumerable<string> Parameters
        {
            get => _parameters;
            set
            {
                _parameters.Clear();
                _parameters.AddRange(value);
            }
        }

        public string Code { get => _code; set => _code = value; }

        public override string ToString()
        {
            return $"{_name}({string.Join(',', _parameters)})";
        }
    }
}

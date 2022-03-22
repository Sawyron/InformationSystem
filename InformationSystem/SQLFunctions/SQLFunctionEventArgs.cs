namespace InformationSystem.SQLFunctions
{
    public class SQLFunctionEventArgs : EventArgs
    {
        public SQLFunctionEventArgs(string name, string code)
        {
            Name = name;
            Code = code;
        }
        public string Name { get; private set; }
        public string Code { get; private set; }
    }
}

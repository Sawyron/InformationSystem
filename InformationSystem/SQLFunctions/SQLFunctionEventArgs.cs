namespace InformationSystem.SQLFunctions
{
    public class SQLFunctionEventArgs : EventArgs
    {
        public SQLFunctionEventArgs(string name)
        {
            Name = name;
        }
        public string Name { get; private set; }
    }
}

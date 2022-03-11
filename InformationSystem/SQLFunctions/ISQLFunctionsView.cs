namespace InformationSystem.SQLFunctions
{
    public interface ISQLFunctionsView
    {
        string Code { get; set; }
        void LoadFunctions(IEnumerable<string> functions, string firstCode);
        event EventHandler<SQLFunctionEventArgs>? ChangedSelectedFunction;
    }
}

namespace InformationSystem.SQLFunctions
{
    public interface ISQLFunctionsView
    {
        string Arguments { get; set; }
        string Code { get; set; }
        string ReturnType { get; set; }
        void LoadFunctions(IEnumerable<string> functions);
        event EventHandler<SQLFunctionEventArgs>? ChangedSelectedFunction;
    }
}

namespace InformationSystem.SQLFunctions
{
    public interface ISQLFunctionsView
    {
        void ShowArguments(IReadOnlyDictionary<string, string> arguments);
        string Code { get; set; }
        string ReturnType { get; set; }
        void LoadFunctions(IEnumerable<string> functions);
        event EventHandler<SQLFunctionEventArgs>? ChangedSelectedFunction;
    }
}

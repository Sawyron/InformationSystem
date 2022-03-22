namespace InformationSystem.SQLFunctions
{
    public interface ISQLFunction
    {
        string Name { get; }
        IReadOnlyDictionary<string, string> Arguments { get; }
        string Code { get; set; }
        string ReturnType { get; }
    }
}

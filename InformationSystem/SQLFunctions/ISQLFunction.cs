using System.Collections.Immutable;

namespace InformationSystem.SQLFunctions
{
    public interface ISQLFunction
    {
        string Name { get; }
        IImmutableDictionary<string, string> Arguments { get; }
        string Code { get; set; }
        string ReturnType { get; }
    }
}

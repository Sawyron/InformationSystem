using InformationSystem.Services;

namespace InformationSystem.Views
{
    public interface ISQLFunctionsView
    {
        string Code { get; set; }
        void LoadFunctions(IEnumerable<string> functions, string firstCode);
        event EventHandler<FunctionEventArgs>? ChangedSelectedFunction;
    }
}

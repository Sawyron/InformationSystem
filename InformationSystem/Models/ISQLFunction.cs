namespace InformationSystem.Models
{
    public interface ISQLFunction
    {
        string Name { get; }
        string Code { get; set; }
        IEnumerable<string> Parameters { get; set; }
    }
}

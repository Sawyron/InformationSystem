
namespace InformationSystem.Models
{
    public interface ITable
    {
        string Name { get; }
        ISet<string> ColumnNames { get; }
        IEnumerable<IEnumerable<object>> Rows { get; }
    }
}
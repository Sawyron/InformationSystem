namespace InformationSystem.Services
{
    public interface ITableService
    {
        IEnumerable<string> GetColumnNames();
        IEnumerable<IEnumerable<object>> GetRows();
    }
}

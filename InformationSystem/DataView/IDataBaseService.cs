using InformationSystem.Services;

namespace InformationSystem.DataView
{
    public interface IDataBaseService : IDataService
    {
        public IEnumerable<string> GetDataBases();
        public IEnumerable<string> GetTables();
        public string? Table { get; }
    }
}

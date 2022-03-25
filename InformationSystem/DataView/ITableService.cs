using System.Data;

namespace InformationSystem.Services
{
    public interface ITableService : IDataService
    {
        void SetTable(string name);
        DataTable GetTable();
        void UpdateRow(int row, int column, object value);
        int UpdateTable();
        void CreateRow();
        void DeleteRow(int row);
        void DeleteRows(IEnumerable<int> rows);
    }
}

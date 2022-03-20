namespace InformationSystem.Models
{
    public class Table : ITable
    {
        private HashSet<string> _columnNames = new HashSet<string>();
        private List<List<object>> _rows = new List<List<object>>();
        public Table(string name, ISet<string> columnNames, IEnumerable<IEnumerable<object>> rows)
        {
            Name = name;
            _columnNames.UnionWith(columnNames);
            foreach (IEnumerable<object> row in rows)
            {
                List<object> currentRow = new List<object>();
                currentRow.AddRange(row);
                _rows.Add(currentRow);
            }

        }
        public string Name { get; private set; }
        public ISet<string> ColumnNames { get => _columnNames; }
        public IEnumerable<IEnumerable<object>> Rows { get => _rows; }
    }
}

namespace InformationSystem.DataView
{
    public interface IDataView
    {
        public string TableName { get; }
        public object DataSource { get; set; }
        public void LoadDataBases(IEnumerable<string> dataBases);
        void LoadTables(string dataBase, IEnumerable<string> tables);

        event EventHandler? TableSelected;
        event EventHandler? TableUpdated;
        event EventHandler<TableValueArgs>? ValueChanged;
    }
}

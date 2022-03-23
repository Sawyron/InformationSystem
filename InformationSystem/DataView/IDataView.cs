namespace InformationSystem.DataView
{
    public interface IDataView
    {
        public string TableName { get; }
        public object DataSource { get; set; }
        event EventHandler? TableSelected;
        event EventHandler? TableUpdated;
        event EventHandler<TableValueArgs>? ValueChanged;
    }
}

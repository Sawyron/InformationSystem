namespace InformationSystem.DataView
{
    public class TableValueArgs : EventArgs
    {
        public TableValueArgs(int row, int column, object value)
        {
            Row = row;
            Column = column;
            Value = value;
        }
        public int Row { get; private set; }
        public int Column { get; private set; }
        public object Value { get; private set; }
    }
}

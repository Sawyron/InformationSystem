namespace InformationSystem.DataView
{
    public class RowArgs : EventArgs
    {
        public RowArgs(int row)
        {
            Row = row;
        }
        public int Row { get; private set; }
    }
}

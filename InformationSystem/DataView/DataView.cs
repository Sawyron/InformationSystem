namespace InformationSystem.DataView
{
    public partial class DataView : UserControl, IDataView
    {
        private HashSet<int> _updatedRows = new HashSet<int>();
        public DataView()
        {
            InitializeComponent();
        }

        public string TableName => _tableTextBox.Text;

        public object DataSource { get => _dataGridView.DataSource; set => _dataGridView.DataSource = value; }

        public event EventHandler? TableSelected;
        public event EventHandler<TableValueArgs>? ValueChanged;
        public event EventHandler? TableUpdated;

        private void _selectTableButton_Click(object sender, EventArgs e)
        {
            _dataGridView.Columns.Clear();
            TableSelected?.Invoke(this, EventArgs.Empty);
            //_dataGridView.Columns.Add("State", string.Empty);
            //foreach (DataGridViewRow row in _dataGridView.Rows)
            //{
            //    row.Cells["State"].Value = RowState.Existed;
            //}
            //_dataGridView.Columns["Updated"].Visible = false;
        }

        private void _dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;
            _updatedRows.Add(row);
            ValueChanged?.Invoke(this, new TableValueArgs(row, col, _dataGridView.Rows[row].Cells[col].Value));
        }

        private void _updateButton_Click(object sender, EventArgs e)
        {
            _dataGridView.ClearSelection();
            foreach (int row in _updatedRows)
            {
                _dataGridView.Rows[row].Selected = true;
            }
            _updatedRows.Clear();
            TableUpdated?.Invoke(this, EventArgs.Empty);
        }
    }
}

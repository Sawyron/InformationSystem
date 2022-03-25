namespace InformationSystem.DataView
{
    public partial class DataView : UserControl, IDataView
    {
        private string _table = "";
        private HashSet<int> _updatedRows = new HashSet<int>();
        private Dictionary<string, EventHandler> _tableHandlers = new Dictionary<string, EventHandler>();
        public DataView()
        {
            InitializeComponent();
        }

        public string TableName => _table;

        public object DataSource { get => _dataGridView.DataSource; set => _dataGridView.DataSource = value; }

        public IEnumerable<int> SelectedRows
        {
            get
            {
                List<int> rows = new List<int>();
                foreach (DataGridViewRow row in _dataGridView.SelectedRows)
                {
                    rows.Add(row.Index);
                }
                return rows;
            }
        }

        public event EventHandler? TableSelected;
        public event EventHandler<TableValueArgs>? ValueChanged;
        public event EventHandler? TableUpdated;
        public event EventHandler? RowAdded;
        public event EventHandler? DeleteClick;
        public event EventHandler<RowArgs>? RowDeleted;

        private void _dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            _deleteButton.Enabled = false;
            int row = e.RowIndex;
            int col = e.ColumnIndex;
            _updatedRows.Add(row);
            ValueChanged?.Invoke(this, new TableValueArgs(row, col, _dataGridView.Rows[row].Cells[col].Value));
        }

        private void _updateButton_Click(object sender, EventArgs e)
        {
            _deleteButton.Enabled = true;
            _dataGridView.ClearSelection();
            foreach (int row in _updatedRows)
            {
                _dataGridView.Rows[row].Selected = true;
            }
            _updatedRows.Clear();
            TableUpdated?.Invoke(this, EventArgs.Empty);
            TableSelected?.Invoke(this, EventArgs.Empty);
        }

        public void LoadDataBases(IEnumerable<string> dataBases)
        {
            _databaseTree.BeginUpdate();
            _databaseTree.Nodes.Clear();
            TreeNode root = _databaseTree.Nodes.Add("Data Bases");
            foreach (string db in dataBases)
            {
                root.Nodes.Add(db);
            }
            _databaseTree.EndUpdate();
        }

        public void LoadTables(string dataBase, IEnumerable<string> tables)
        {
            _tableTree.BeginUpdate();
            _tableTree.Nodes.Clear();
            TreeNode treeNode = _tableTree.Nodes.Add(dataBase);
            foreach (string table in tables)
            {
                treeNode.Nodes.Add(table);
            }
            _tableTree.EndUpdate();
        }

        private void _tableTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent != null)
            {
                _dataGridView.Columns.Clear();
                _updatedRows.Clear();
                _deleteButton.Enabled = true;
                _updateButton.Enabled = true;
                _table = e.Node.Text;
                _tableTextBox.Text = _table;
                TableSelected?.Invoke(this, EventArgs.Empty);
            }
        }

        private void _dataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            RowAdded?.Invoke(this, EventArgs.Empty);
            _dataGridView.Rows.RemoveAt(_dataGridView.Rows.Count - 2);
            RowDeleted?.Invoke(this, new RowArgs(_dataGridView.Rows.Count - 2));
        }

        private void _deleteButton_Click(object sender, EventArgs e)
        {
            DeleteClick?.Invoke(this, EventArgs.Empty);
        }
    }
}

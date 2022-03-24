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

        public event EventHandler? TableSelected;
        public event EventHandler<TableValueArgs>? ValueChanged;
        public event EventHandler? TableUpdated;

        private void _selectTableButton_Click(object sender, EventArgs e)
        {
            _dataGridView.Columns.Clear();
            TableSelected?.Invoke(this, EventArgs.Empty);
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
                _table = e.Node.Text;
                _tableTextBox.Text = _table;
                TableSelected?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}

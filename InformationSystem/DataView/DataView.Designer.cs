namespace InformationSystem.DataView
{
    partial class DataView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._dataGridView = new System.Windows.Forms.DataGridView();
            this._controlPanel = new System.Windows.Forms.Panel();
            this._deleteButton = new System.Windows.Forms.Button();
            this._updateButton = new System.Windows.Forms.Button();
            this._tableTextBox = new System.Windows.Forms.TextBox();
            this._tableLabel = new System.Windows.Forms.Label();
            this._databaseTree = new System.Windows.Forms.TreeView();
            this._dataPanel = new System.Windows.Forms.Panel();
            this._treePanel = new System.Windows.Forms.Panel();
            this._tableTree = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).BeginInit();
            this._controlPanel.SuspendLayout();
            this._dataPanel.SuspendLayout();
            this._treePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _dataGridView
            // 
            this._dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataGridView.Location = new System.Drawing.Point(0, 0);
            this._dataGridView.Name = "_dataGridView";
            this._dataGridView.RowTemplate.Height = 25;
            this._dataGridView.Size = new System.Drawing.Size(403, 286);
            this._dataGridView.TabIndex = 0;
            this._dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this._dataGridView_CellValueChanged);
            this._dataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this._dataGridView_UserAddedRow);
            // 
            // _controlPanel
            // 
            this._controlPanel.Controls.Add(this._deleteButton);
            this._controlPanel.Controls.Add(this._updateButton);
            this._controlPanel.Controls.Add(this._tableTextBox);
            this._controlPanel.Controls.Add(this._tableLabel);
            this._controlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._controlPanel.Location = new System.Drawing.Point(0, 286);
            this._controlPanel.Name = "_controlPanel";
            this._controlPanel.Size = new System.Drawing.Size(645, 100);
            this._controlPanel.TabIndex = 1;
            // 
            // _deleteButton
            // 
            this._deleteButton.Enabled = false;
            this._deleteButton.Location = new System.Drawing.Point(134, 58);
            this._deleteButton.Name = "_deleteButton";
            this._deleteButton.Size = new System.Drawing.Size(100, 23);
            this._deleteButton.TabIndex = 4;
            this._deleteButton.Text = "Delete";
            this._deleteButton.UseVisualStyleBackColor = true;
            this._deleteButton.Click += new System.EventHandler(this._deleteButton_Click);
            // 
            // _updateButton
            // 
            this._updateButton.Enabled = false;
            this._updateButton.Location = new System.Drawing.Point(13, 58);
            this._updateButton.Name = "_updateButton";
            this._updateButton.Size = new System.Drawing.Size(100, 23);
            this._updateButton.TabIndex = 3;
            this._updateButton.Text = "Save";
            this._updateButton.UseVisualStyleBackColor = true;
            this._updateButton.Click += new System.EventHandler(this._updateButton_Click);
            // 
            // _tableTextBox
            // 
            this._tableTextBox.Enabled = false;
            this._tableTextBox.Location = new System.Drawing.Point(13, 29);
            this._tableTextBox.Name = "_tableTextBox";
            this._tableTextBox.Size = new System.Drawing.Size(100, 23);
            this._tableTextBox.TabIndex = 1;
            // 
            // _tableLabel
            // 
            this._tableLabel.AutoSize = true;
            this._tableLabel.Location = new System.Drawing.Point(13, 11);
            this._tableLabel.Name = "_tableLabel";
            this._tableLabel.Size = new System.Drawing.Size(34, 15);
            this._tableLabel.TabIndex = 0;
            this._tableLabel.Text = "Table";
            // 
            // _databaseTree
            // 
            this._databaseTree.Dock = System.Windows.Forms.DockStyle.Top;
            this._databaseTree.Location = new System.Drawing.Point(0, 0);
            this._databaseTree.Name = "_databaseTree";
            this._databaseTree.Size = new System.Drawing.Size(242, 121);
            this._databaseTree.TabIndex = 2;
            // 
            // _dataPanel
            // 
            this._dataPanel.Controls.Add(this._dataGridView);
            this._dataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataPanel.Location = new System.Drawing.Point(0, 0);
            this._dataPanel.Name = "_dataPanel";
            this._dataPanel.Size = new System.Drawing.Size(403, 286);
            this._dataPanel.TabIndex = 3;
            // 
            // _treePanel
            // 
            this._treePanel.Controls.Add(this._tableTree);
            this._treePanel.Controls.Add(this._databaseTree);
            this._treePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this._treePanel.Location = new System.Drawing.Point(403, 0);
            this._treePanel.Name = "_treePanel";
            this._treePanel.Size = new System.Drawing.Size(242, 286);
            this._treePanel.TabIndex = 4;
            // 
            // _tableTree
            // 
            this._tableTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableTree.Location = new System.Drawing.Point(0, 121);
            this._tableTree.Name = "_tableTree";
            this._tableTree.Size = new System.Drawing.Size(242, 165);
            this._tableTree.TabIndex = 3;
            this._tableTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this._tableTree_NodeMouseDoubleClick);
            // 
            // DataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._dataPanel);
            this.Controls.Add(this._treePanel);
            this.Controls.Add(this._controlPanel);
            this.Name = "DataView";
            this.Size = new System.Drawing.Size(645, 386);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).EndInit();
            this._controlPanel.ResumeLayout(false);
            this._controlPanel.PerformLayout();
            this._dataPanel.ResumeLayout(false);
            this._treePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView _dataGridView;
        private Panel _controlPanel;
        private TextBox _tableTextBox;
        private Label _tableLabel;
        private Button _updateButton;
        private TreeView _databaseTree;
        private Panel _dataPanel;
        private Panel _treePanel;
        private TreeView _tableTree;
        private Button _deleteButton;
    }
}

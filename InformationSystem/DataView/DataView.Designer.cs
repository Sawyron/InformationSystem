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
            this.panel1 = new System.Windows.Forms.Panel();
            this._selectTableButton = new System.Windows.Forms.Button();
            this._tableTextBox = new System.Windows.Forms.TextBox();
            this._tableLabel = new System.Windows.Forms.Label();
            this._updateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _dataGridView
            // 
            this._dataGridView.AllowUserToAddRows = false;
            this._dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataGridView.Location = new System.Drawing.Point(0, 0);
            this._dataGridView.Name = "_dataGridView";
            this._dataGridView.RowTemplate.Height = 25;
            this._dataGridView.Size = new System.Drawing.Size(633, 225);
            this._dataGridView.TabIndex = 0;
            this._dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this._dataGridView_CellValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._updateButton);
            this.panel1.Controls.Add(this._selectTableButton);
            this.panel1.Controls.Add(this._tableTextBox);
            this.panel1.Controls.Add(this._tableLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 100);
            this.panel1.TabIndex = 1;
            // 
            // _selectTableButton
            // 
            this._selectTableButton.Location = new System.Drawing.Point(13, 58);
            this._selectTableButton.Name = "_selectTableButton";
            this._selectTableButton.Size = new System.Drawing.Size(100, 23);
            this._selectTableButton.TabIndex = 2;
            this._selectTableButton.Text = "Select Table";
            this._selectTableButton.UseVisualStyleBackColor = true;
            this._selectTableButton.Click += new System.EventHandler(this._selectTableButton_Click);
            // 
            // _tableTextBox
            // 
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
            // _updateButton
            // 
            this._updateButton.Location = new System.Drawing.Point(132, 58);
            this._updateButton.Name = "_updateButton";
            this._updateButton.Size = new System.Drawing.Size(100, 23);
            this._updateButton.TabIndex = 3;
            this._updateButton.Text = "Update";
            this._updateButton.UseVisualStyleBackColor = true;
            this._updateButton.Click += new System.EventHandler(this._updateButton_Click);
            // 
            // DataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._dataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "DataView";
            this.Size = new System.Drawing.Size(633, 325);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView _dataGridView;
        private Panel panel1;
        private Button _selectTableButton;
        private TextBox _tableTextBox;
        private Label _tableLabel;
        private Button _updateButton;
    }
}

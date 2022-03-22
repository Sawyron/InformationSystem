namespace InformationSystem.SQLFunctions
{
    partial class SQLFunctionsView
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
            this._functionsComboBox = new System.Windows.Forms.ComboBox();
            this._codeTextBox = new System.Windows.Forms.RichTextBox();
            this._argumentsLabel = new System.Windows.Forms.Label();
            this._returnTypeLabel = new System.Windows.Forms.Label();
            this._updateButton = new System.Windows.Forms.Button();
            this._stateLabel = new System.Windows.Forms.Label();
            this._typeLabel = new System.Windows.Forms.Label();
            this._preArgumentsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _functionsComboBox
            // 
            this._functionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._functionsComboBox.FormattingEnabled = true;
            this._functionsComboBox.Location = new System.Drawing.Point(0, 3);
            this._functionsComboBox.Name = "_functionsComboBox";
            this._functionsComboBox.Size = new System.Drawing.Size(121, 23);
            this._functionsComboBox.TabIndex = 0;
            this._functionsComboBox.TabStop = false;
            this._functionsComboBox.SelectedIndexChanged += new System.EventHandler(this._functionsComboBox_SelectedIndexChanged);
            // 
            // _codeTextBox
            // 
            this._codeTextBox.Location = new System.Drawing.Point(0, 73);
            this._codeTextBox.Name = "_codeTextBox";
            this._codeTextBox.Size = new System.Drawing.Size(227, 226);
            this._codeTextBox.TabIndex = 1;
            this._codeTextBox.Text = "";
            // 
            // _argumentsLabel
            // 
            this._argumentsLabel.AutoEllipsis = true;
            this._argumentsLabel.AutoSize = true;
            this._argumentsLabel.Location = new System.Drawing.Point(80, 45);
            this._argumentsLabel.Name = "_argumentsLabel";
            this._argumentsLabel.Size = new System.Drawing.Size(66, 15);
            this._argumentsLabel.TabIndex = 2;
            this._argumentsLabel.Text = "Arguments";
            // 
            // _returnTypeLabel
            // 
            this._returnTypeLabel.AutoEllipsis = true;
            this._returnTypeLabel.AutoSize = true;
            this._returnTypeLabel.Location = new System.Drawing.Point(80, 312);
            this._returnTypeLabel.Name = "_returnTypeLabel";
            this._returnTypeLabel.Size = new System.Drawing.Size(38, 15);
            this._returnTypeLabel.TabIndex = 3;
            this._returnTypeLabel.Text = "label2";
            // 
            // _updateButton
            // 
            this._updateButton.Location = new System.Drawing.Point(256, 276);
            this._updateButton.Name = "_updateButton";
            this._updateButton.Size = new System.Drawing.Size(75, 23);
            this._updateButton.TabIndex = 4;
            this._updateButton.Text = "Update";
            this._updateButton.UseVisualStyleBackColor = true;
            this._updateButton.Click += new System.EventHandler(this._updateButton_Click);
            // 
            // _stateLabel
            // 
            this._stateLabel.AutoSize = true;
            this._stateLabel.Location = new System.Drawing.Point(189, 312);
            this._stateLabel.Name = "_stateLabel";
            this._stateLabel.Size = new System.Drawing.Size(64, 15);
            this._stateLabel.TabIndex = 5;
            this._stateLabel.Text = "State Label";
            // 
            // _typeLabel
            // 
            this._typeLabel.AutoSize = true;
            this._typeLabel.Location = new System.Drawing.Point(3, 312);
            this._typeLabel.Name = "_typeLabel";
            this._typeLabel.Size = new System.Drawing.Size(71, 15);
            this._typeLabel.TabIndex = 6;
            this._typeLabel.Text = "Return type:";
            // 
            // _preArgumentsLabel
            // 
            this._preArgumentsLabel.AutoSize = true;
            this._preArgumentsLabel.Location = new System.Drawing.Point(3, 45);
            this._preArgumentsLabel.Name = "_preArgumentsLabel";
            this._preArgumentsLabel.Size = new System.Drawing.Size(69, 15);
            this._preArgumentsLabel.TabIndex = 7;
            this._preArgumentsLabel.Text = "Arguments:";
            // 
            // SQLFunctionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._preArgumentsLabel);
            this.Controls.Add(this._typeLabel);
            this.Controls.Add(this._stateLabel);
            this.Controls.Add(this._updateButton);
            this.Controls.Add(this._returnTypeLabel);
            this.Controls.Add(this._argumentsLabel);
            this.Controls.Add(this._codeTextBox);
            this.Controls.Add(this._functionsComboBox);
            this.Name = "SQLFunctionsView";
            this.Size = new System.Drawing.Size(453, 340);
            this.Load += new System.EventHandler(this.SQLFunctionsView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox _functionsComboBox;
        private RichTextBox _codeTextBox;
        private Label _argumentsLabel;
        private Label _returnTypeLabel;
        private Button _updateButton;
        private Label _stateLabel;
        private Label _typeLabel;
        private Label _preArgumentsLabel;
    }
}

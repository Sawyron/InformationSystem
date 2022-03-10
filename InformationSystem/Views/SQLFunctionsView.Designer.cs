namespace InformationSystem.Views
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
            this.SuspendLayout();
            // 
            // _functionsComboBox
            // 
            this._functionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._functionsComboBox.FormattingEnabled = true;
            this._functionsComboBox.Location = new System.Drawing.Point(3, 3);
            this._functionsComboBox.Name = "_functionsComboBox";
            this._functionsComboBox.Size = new System.Drawing.Size(121, 23);
            this._functionsComboBox.TabIndex = 0;
            this._functionsComboBox.TabStop = false;
            this._functionsComboBox.SelectedIndexChanged += new System.EventHandler(this._functionsComboBox_SelectedIndexChanged);
            // 
            // _codeTextBox
            // 
            this._codeTextBox.Location = new System.Drawing.Point(3, 54);
            this._codeTextBox.Name = "_codeTextBox";
            this._codeTextBox.Size = new System.Drawing.Size(227, 226);
            this._codeTextBox.TabIndex = 1;
            this._codeTextBox.Text = "";
            // 
            // SQLFunctionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._codeTextBox);
            this.Controls.Add(this._functionsComboBox);
            this.Name = "SQLFunctionsView";
            this.Size = new System.Drawing.Size(488, 317);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox _functionsComboBox;
        private RichTextBox _codeTextBox;
    }
}

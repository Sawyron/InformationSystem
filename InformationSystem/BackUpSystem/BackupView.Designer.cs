namespace InformationSystem.BackupSystem
{
    partial class BackupView
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
            this._binPathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._selectPostgesPathButton = new System.Windows.Forms.Button();
            this._saveButton = new System.Windows.Forms.Button();
            this._restoreButton = new System.Windows.Forms.Button();
            this._passwordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _binPathTextBox
            // 
            this._binPathTextBox.Location = new System.Drawing.Point(17, 54);
            this._binPathTextBox.Name = "_binPathTextBox";
            this._binPathTextBox.Size = new System.Drawing.Size(185, 23);
            this._binPathTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Postgrees bin path";
            // 
            // _selectPostgesPathButton
            // 
            this._selectPostgesPathButton.Location = new System.Drawing.Point(220, 54);
            this._selectPostgesPathButton.Name = "_selectPostgesPathButton";
            this._selectPostgesPathButton.Size = new System.Drawing.Size(75, 23);
            this._selectPostgesPathButton.TabIndex = 2;
            this._selectPostgesPathButton.Text = "Select";
            this._selectPostgesPathButton.UseVisualStyleBackColor = true;
            this._selectPostgesPathButton.Click += new System.EventHandler(this._selectPostgesPathButton_Click);
            // 
            // _saveButton
            // 
            this._saveButton.Location = new System.Drawing.Point(17, 151);
            this._saveButton.Name = "_saveButton";
            this._saveButton.Size = new System.Drawing.Size(75, 23);
            this._saveButton.TabIndex = 3;
            this._saveButton.Text = "Save";
            this._saveButton.UseVisualStyleBackColor = true;
            this._saveButton.Click += new System.EventHandler(this._saveButton_Click);
            // 
            // _restoreButton
            // 
            this._restoreButton.Location = new System.Drawing.Point(127, 151);
            this._restoreButton.Name = "_restoreButton";
            this._restoreButton.Size = new System.Drawing.Size(75, 23);
            this._restoreButton.TabIndex = 4;
            this._restoreButton.Text = "Restore";
            this._restoreButton.UseVisualStyleBackColor = true;
            this._restoreButton.Click += new System.EventHandler(this._restoreButton_Click);
            // 
            // _passwordTextBox
            // 
            this._passwordTextBox.Location = new System.Drawing.Point(17, 110);
            this._passwordTextBox.Name = "_passwordTextBox";
            this._passwordTextBox.Size = new System.Drawing.Size(75, 23);
            this._passwordTextBox.TabIndex = 5;
            this._passwordTextBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // BackupView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this._passwordTextBox);
            this.Controls.Add(this._restoreButton);
            this.Controls.Add(this._saveButton);
            this.Controls.Add(this._selectPostgesPathButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._binPathTextBox);
            this.Name = "BackupView";
            this.Size = new System.Drawing.Size(310, 218);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox _binPathTextBox;
        private Label label1;
        private Button _selectPostgesPathButton;
        private Button _saveButton;
        private Button _restoreButton;
        private TextBox _passwordTextBox;
        private Label label2;
    }
}

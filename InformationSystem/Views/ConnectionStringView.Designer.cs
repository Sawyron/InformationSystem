namespace InformationSystem.Views
{
    partial class ConnectionStringView
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
            this._serverTextBox = new System.Windows.Forms.TextBox();
            this._portTextBox = new System.Windows.Forms.TextBox();
            this._databaseTextBox = new System.Windows.Forms.TextBox();
            this._userTextBox = new System.Windows.Forms.TextBox();
            this._passwordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._saveButton = new System.Windows.Forms.Button();
            this._openButton = new System.Windows.Forms.Button();
            this._closeButton = new System.Windows.Forms.Button();
            this._stateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _serverTextBox
            // 
            this._serverTextBox.Location = new System.Drawing.Point(121, 14);
            this._serverTextBox.Name = "_serverTextBox";
            this._serverTextBox.Size = new System.Drawing.Size(100, 23);
            this._serverTextBox.TabIndex = 0;
            // 
            // _portTextBox
            // 
            this._portTextBox.Location = new System.Drawing.Point(121, 66);
            this._portTextBox.Name = "_portTextBox";
            this._portTextBox.Size = new System.Drawing.Size(100, 23);
            this._portTextBox.TabIndex = 1;
            // 
            // _databaseTextBox
            // 
            this._databaseTextBox.Location = new System.Drawing.Point(121, 123);
            this._databaseTextBox.Name = "_databaseTextBox";
            this._databaseTextBox.Size = new System.Drawing.Size(100, 23);
            this._databaseTextBox.TabIndex = 2;
            // 
            // _userTextBox
            // 
            this._userTextBox.Location = new System.Drawing.Point(121, 178);
            this._userTextBox.Name = "_userTextBox";
            this._userTextBox.Size = new System.Drawing.Size(100, 23);
            this._userTextBox.TabIndex = 3;
            // 
            // _passwordTextBox
            // 
            this._passwordTextBox.Location = new System.Drawing.Point(121, 231);
            this._passwordTextBox.Name = "_passwordTextBox";
            this._passwordTextBox.PasswordChar = '*';
            this._passwordTextBox.Size = new System.Drawing.Size(100, 23);
            this._passwordTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Server:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data Base:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "User:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password:";
            // 
            // _saveButton
            // 
            this._saveButton.Location = new System.Drawing.Point(121, 280);
            this._saveButton.Name = "_saveButton";
            this._saveButton.Size = new System.Drawing.Size(100, 23);
            this._saveButton.TabIndex = 10;
            this._saveButton.Text = "Save";
            this._saveButton.UseVisualStyleBackColor = true;
            this._saveButton.Click += new System.EventHandler(this._saveButton_Click);
            // 
            // _openButton
            // 
            this._openButton.Location = new System.Drawing.Point(3, 322);
            this._openButton.Name = "_openButton";
            this._openButton.Size = new System.Drawing.Size(60, 23);
            this._openButton.TabIndex = 11;
            this._openButton.Text = "Open";
            this._openButton.UseVisualStyleBackColor = true;
            this._openButton.Click += new System.EventHandler(this._openButton_Click);
            // 
            // _closeButton
            // 
            this._closeButton.Location = new System.Drawing.Point(69, 322);
            this._closeButton.Name = "_closeButton";
            this._closeButton.Size = new System.Drawing.Size(60, 23);
            this._closeButton.TabIndex = 12;
            this._closeButton.Text = "Close";
            this._closeButton.UseVisualStyleBackColor = true;
            this._closeButton.Click += new System.EventHandler(this._closeButton_Click);
            // 
            // _stateLabel
            // 
            this._stateLabel.AutoSize = true;
            this._stateLabel.Location = new System.Drawing.Point(160, 330);
            this._stateLabel.Name = "_stateLabel";
            this._stateLabel.Size = new System.Drawing.Size(64, 15);
            this._stateLabel.TabIndex = 13;
            this._stateLabel.Text = "State Label";
            // 
            // ConnectionStringView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._stateLabel);
            this.Controls.Add(this._closeButton);
            this.Controls.Add(this._openButton);
            this.Controls.Add(this._saveButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._passwordTextBox);
            this.Controls.Add(this._userTextBox);
            this.Controls.Add(this._databaseTextBox);
            this.Controls.Add(this._portTextBox);
            this.Controls.Add(this._serverTextBox);
            this.Name = "ConnectionStringView";
            this.Size = new System.Drawing.Size(288, 377);
            this.Load += new System.EventHandler(this.ConnectionControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox _serverTextBox;
        private TextBox _portTextBox;
        private TextBox _databaseTextBox;
        private TextBox _userTextBox;
        private TextBox _passwordTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button _saveButton;
        private Button _openButton;
        private Button _closeButton;
        private Label _stateLabel;
    }
}

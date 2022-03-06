namespace InformationSystem.Views
{
    partial class MainForm
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

        #region Windows Form Designer generated code

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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._passwordTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this._openConnectionButton = new System.Windows.Forms.Button();
            this._closeConnectionButton = new System.Windows.Forms.Button();
            this._stateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _serverTextBox
            // 
            this._serverTextBox.Location = new System.Drawing.Point(29, 23);
            this._serverTextBox.Name = "_serverTextBox";
            this._serverTextBox.Size = new System.Drawing.Size(100, 23);
            this._serverTextBox.TabIndex = 0;
            this._serverTextBox.TabStop = false;
            // 
            // _portTextBox
            // 
            this._portTextBox.Location = new System.Drawing.Point(29, 76);
            this._portTextBox.Name = "_portTextBox";
            this._portTextBox.Size = new System.Drawing.Size(100, 23);
            this._portTextBox.TabIndex = 1;
            this._portTextBox.TabStop = false;
            // 
            // _databaseTextBox
            // 
            this._databaseTextBox.Location = new System.Drawing.Point(29, 135);
            this._databaseTextBox.Name = "_databaseTextBox";
            this._databaseTextBox.Size = new System.Drawing.Size(100, 23);
            this._databaseTextBox.TabIndex = 2;
            this._databaseTextBox.TabStop = false;
            // 
            // _userTextBox
            // 
            this._userTextBox.Location = new System.Drawing.Point(29, 190);
            this._userTextBox.Name = "_userTextBox";
            this._userTextBox.Size = new System.Drawing.Size(100, 23);
            this._userTextBox.TabIndex = 3;
            this._userTextBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data Base";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "User";
            // 
            // _passwordTextBox
            // 
            this._passwordTextBox.Location = new System.Drawing.Point(29, 246);
            this._passwordTextBox.Name = "_passwordTextBox";
            this._passwordTextBox.PasswordChar = '*';
            this._passwordTextBox.Size = new System.Drawing.Size(100, 23);
            this._passwordTextBox.TabIndex = 8;
            this._passwordTextBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password";
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButton.Location = new System.Drawing.Point(29, 337);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.TabStop = false;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.OnSaveClick);
            // 
            // _openConnectionButton
            // 
            this._openConnectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._openConnectionButton.Location = new System.Drawing.Point(29, 399);
            this._openConnectionButton.Name = "_openConnectionButton";
            this._openConnectionButton.Size = new System.Drawing.Size(100, 23);
            this._openConnectionButton.TabIndex = 11;
            this._openConnectionButton.TabStop = false;
            this._openConnectionButton.Text = "Open";
            this._openConnectionButton.UseVisualStyleBackColor = true;
            this._openConnectionButton.Click += new System.EventHandler(this.OnOpenClick);
            // 
            // _closeConnectionButton
            // 
            this._closeConnectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._closeConnectionButton.Enabled = false;
            this._closeConnectionButton.Location = new System.Drawing.Point(169, 399);
            this._closeConnectionButton.Name = "_closeConnectionButton";
            this._closeConnectionButton.Size = new System.Drawing.Size(100, 23);
            this._closeConnectionButton.TabIndex = 12;
            this._closeConnectionButton.TabStop = false;
            this._closeConnectionButton.Text = "Close";
            this._closeConnectionButton.UseVisualStyleBackColor = true;
            this._closeConnectionButton.Click += new System.EventHandler(this.OnCloseClick);
            // 
            // _stateLabel
            // 
            this._stateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._stateLabel.AutoSize = true;
            this._stateLabel.Location = new System.Drawing.Point(169, 345);
            this._stateLabel.Name = "_stateLabel";
            this._stateLabel.Size = new System.Drawing.Size(119, 15);
            this._stateLabel.TabIndex = 13;
            this._stateLabel.Text = "Connection is not set";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._stateLabel);
            this.Controls.Add(this._closeConnectionButton);
            this.Controls.Add(this._openConnectionButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._passwordTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._userTextBox);
            this.Controls.Add(this._databaseTextBox);
            this.Controls.Add(this._portTextBox);
            this.Controls.Add(this._serverTextBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox _serverTextBox;
        private TextBox _portTextBox;
        private TextBox _databaseTextBox;
        private TextBox _userTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox _passwordTextBox;
        private Label label5;
        private Button saveButton;
        private Button _openConnectionButton;
        private Button _closeConnectionButton;
        private Label _stateLabel;
    }
}
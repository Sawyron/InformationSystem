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
            this._saveButton = new System.Windows.Forms.Button();
            this._openConnectionButton = new System.Windows.Forms.Button();
            this._closeConnectionButton = new System.Windows.Forms.Button();
            this._stateLabel = new System.Windows.Forms.Label();
            this._queryTextBox = new System.Windows.Forms.RichTextBox();
            this._selectButton = new System.Windows.Forms.Button();
            this._dataPanel = new System.Windows.Forms.Panel();
            this._dataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _serverTextBox
            // 
            this._serverTextBox.Location = new System.Drawing.Point(13, 15);
            this._serverTextBox.Name = "_serverTextBox";
            this._serverTextBox.Size = new System.Drawing.Size(100, 23);
            this._serverTextBox.TabIndex = 0;
            this._serverTextBox.TabStop = false;
            // 
            // _portTextBox
            // 
            this._portTextBox.Location = new System.Drawing.Point(13, 68);
            this._portTextBox.Name = "_portTextBox";
            this._portTextBox.Size = new System.Drawing.Size(100, 23);
            this._portTextBox.TabIndex = 1;
            this._portTextBox.TabStop = false;
            // 
            // _databaseTextBox
            // 
            this._databaseTextBox.Location = new System.Drawing.Point(13, 127);
            this._databaseTextBox.Name = "_databaseTextBox";
            this._databaseTextBox.Size = new System.Drawing.Size(100, 23);
            this._databaseTextBox.TabIndex = 2;
            this._databaseTextBox.TabStop = false;
            // 
            // _userTextBox
            // 
            this._userTextBox.Location = new System.Drawing.Point(13, 182);
            this._userTextBox.Name = "_userTextBox";
            this._userTextBox.Size = new System.Drawing.Size(100, 23);
            this._userTextBox.TabIndex = 3;
            this._userTextBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data Base";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "User";
            // 
            // _passwordTextBox
            // 
            this._passwordTextBox.Location = new System.Drawing.Point(13, 238);
            this._passwordTextBox.Name = "_passwordTextBox";
            this._passwordTextBox.PasswordChar = '*';
            this._passwordTextBox.Size = new System.Drawing.Size(100, 23);
            this._passwordTextBox.TabIndex = 8;
            this._passwordTextBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password";
            // 
            // _saveButton
            // 
            this._saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._saveButton.Location = new System.Drawing.Point(13, 366);
            this._saveButton.Name = "_saveButton";
            this._saveButton.Size = new System.Drawing.Size(100, 23);
            this._saveButton.TabIndex = 10;
            this._saveButton.TabStop = false;
            this._saveButton.Text = "Save";
            this._saveButton.UseVisualStyleBackColor = true;
            this._saveButton.Click += new System.EventHandler(this.OnSaveClick);
            // 
            // _openConnectionButton
            // 
            this._openConnectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._openConnectionButton.Location = new System.Drawing.Point(13, 413);
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
            this._closeConnectionButton.Location = new System.Drawing.Point(139, 413);
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
            this._stateLabel.Location = new System.Drawing.Point(68, 312);
            this._stateLabel.Name = "_stateLabel";
            this._stateLabel.Size = new System.Drawing.Size(119, 15);
            this._stateLabel.TabIndex = 13;
            this._stateLabel.Text = "Connection is not set";
            // 
            // _queryTextBox
            // 
            this._queryTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this._queryTextBox.Enabled = false;
            this._queryTextBox.Location = new System.Drawing.Point(430, 0);
            this._queryTextBox.Name = "_queryTextBox";
            this._queryTextBox.Size = new System.Drawing.Size(370, 450);
            this._queryTextBox.TabIndex = 14;
            this._queryTextBox.Text = "";
            // 
            // _selectButton
            // 
            this._selectButton.Enabled = false;
            this._selectButton.Location = new System.Drawing.Point(139, 366);
            this._selectButton.Name = "_selectButton";
            this._selectButton.Size = new System.Drawing.Size(100, 23);
            this._selectButton.TabIndex = 15;
            this._selectButton.Text = "Select";
            this._selectButton.UseVisualStyleBackColor = true;
            this._selectButton.Click += new System.EventHandler(this._selectButton_Click);
            // 
            // _dataPanel
            // 
            this._dataPanel.Controls.Add(this._portTextBox);
            this._dataPanel.Controls.Add(this._selectButton);
            this._dataPanel.Controls.Add(this._serverTextBox);
            this._dataPanel.Controls.Add(this._databaseTextBox);
            this._dataPanel.Controls.Add(this._stateLabel);
            this._dataPanel.Controls.Add(this._userTextBox);
            this._dataPanel.Controls.Add(this._closeConnectionButton);
            this._dataPanel.Controls.Add(this._openConnectionButton);
            this._dataPanel.Controls.Add(this.label1);
            this._dataPanel.Controls.Add(this._saveButton);
            this._dataPanel.Controls.Add(this.label2);
            this._dataPanel.Controls.Add(this.label3);
            this._dataPanel.Controls.Add(this.label5);
            this._dataPanel.Controls.Add(this.label4);
            this._dataPanel.Controls.Add(this._passwordTextBox);
            this._dataPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this._dataPanel.Location = new System.Drawing.Point(0, 0);
            this._dataPanel.Name = "_dataPanel";
            this._dataPanel.Size = new System.Drawing.Size(289, 450);
            this._dataPanel.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._dataPanel);
            this.Controls.Add(this._queryTextBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this._dataPanel.ResumeLayout(false);
            this._dataPanel.PerformLayout();
            this.ResumeLayout(false);

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
        private Button _saveButton;
        private Button _openConnectionButton;
        private Button _closeConnectionButton;
        private Label _stateLabel;
        private RichTextBox _queryTextBox;
        private Button _selectButton;
        private Panel _dataPanel;
    }
}
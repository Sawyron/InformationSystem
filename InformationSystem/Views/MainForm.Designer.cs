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
            this._controlPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this._richTextBox = new System.Windows.Forms.Button();
            this._connectionButton = new System.Windows.Forms.Button();
            this._containerPanel = new System.Windows.Forms.Panel();
            this._controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _controlPanel
            // 
            this._controlPanel.Controls.Add(this.button3);
            this._controlPanel.Controls.Add(this._richTextBox);
            this._controlPanel.Controls.Add(this._connectionButton);
            this._controlPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this._controlPanel.Location = new System.Drawing.Point(0, 0);
            this._controlPanel.Name = "_controlPanel";
            this._controlPanel.Size = new System.Drawing.Size(200, 450);
            this._controlPanel.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(32, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // _richTextBox
            // 
            this._richTextBox.Location = new System.Drawing.Point(32, 104);
            this._richTextBox.Name = "_richTextBox";
            this._richTextBox.Size = new System.Drawing.Size(135, 33);
            this._richTextBox.TabIndex = 1;
            this._richTextBox.Text = "Rich Text Box";
            this._richTextBox.UseVisualStyleBackColor = true;
            this._richTextBox.Click += new System.EventHandler(this._richTextBox_Click);
            // 
            // _connectionButton
            // 
            this._connectionButton.Location = new System.Drawing.Point(32, 31);
            this._connectionButton.Name = "_connectionButton";
            this._connectionButton.Size = new System.Drawing.Size(135, 33);
            this._connectionButton.TabIndex = 0;
            this._connectionButton.Text = "Connection";
            this._connectionButton.UseVisualStyleBackColor = true;
            this._connectionButton.Click += new System.EventHandler(this._connectionButton_Click);
            // 
            // _containerPanel
            // 
            this._containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._containerPanel.Location = new System.Drawing.Point(200, 0);
            this._containerPanel.Name = "_containerPanel";
            this._containerPanel.Size = new System.Drawing.Size(600, 450);
            this._containerPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._containerPanel);
            this.Controls.Add(this._controlPanel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this._controlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel _controlPanel;
        private Button button3;
        private Button _richTextBox;
        private Button _connectionButton;
        private Panel _containerPanel;
    }
}
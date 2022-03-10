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
            this._controlPanel = new System.Windows.Forms.FlowLayoutPanel();
            this._connectionButton = new System.Windows.Forms.Button();
            this._containerPanel = new System.Windows.Forms.Panel();
            this._controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _controlPanel
            // 
            this._controlPanel.AutoScroll = true;
            this._controlPanel.Controls.Add(this._connectionButton);
            this._controlPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this._controlPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this._controlPanel.Location = new System.Drawing.Point(0, 0);
            this._controlPanel.Name = "_controlPanel";
            this._controlPanel.Padding = new System.Windows.Forms.Padding(35);
            this._controlPanel.Size = new System.Drawing.Size(197, 450);
            this._controlPanel.TabIndex = 4;
            // 
            // _connectionButton
            // 
            this._connectionButton.Location = new System.Drawing.Point(38, 38);
            this._connectionButton.Name = "_connectionButton";
            this._connectionButton.Size = new System.Drawing.Size(108, 28);
            this._connectionButton.TabIndex = 0;
            this._connectionButton.TabStop = false;
            this._connectionButton.Text = "Connection";
            this._connectionButton.UseVisualStyleBackColor = true;
            // 
            // _containerPanel
            // 
            this._containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._containerPanel.Location = new System.Drawing.Point(197, 0);
            this._containerPanel.Name = "_containerPanel";
            this._containerPanel.Size = new System.Drawing.Size(603, 450);
            this._containerPanel.TabIndex = 5;
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

        private FlowLayoutPanel _controlPanel;
        private Panel _containerPanel;
        private Button _connectionButton;
    }
}
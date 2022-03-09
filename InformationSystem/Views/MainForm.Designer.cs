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
            this._containerPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // _controlPanel
            // 
            this._controlPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this._controlPanel.Location = new System.Drawing.Point(0, 0);
            this._controlPanel.Name = "_controlPanel";
            this._controlPanel.Size = new System.Drawing.Size(200, 450);
            this._controlPanel.TabIndex = 2;
            // 
            // _containerPanel
            // 
            this._containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._containerPanel.Location = new System.Drawing.Point(200, 0);
            this._containerPanel.Name = "_containerPanel";
            this._containerPanel.Size = new System.Drawing.Size(600, 450);
            this._containerPanel.TabIndex = 3;
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
            this.ResumeLayout(false);

        }

        #endregion

        private Panel _controlPanel;
        private Panel _containerPanel;
    }
}
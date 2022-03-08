namespace InformationSystem.Views
{
    partial class RichTextBoxView
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
            this._titleTextBox = new System.Windows.Forms.RichTextBox();
            this._selectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _titleTextBox
            // 
            this._titleTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this._titleTextBox.Location = new System.Drawing.Point(0, 0);
            this._titleTextBox.Name = "_titleTextBox";
            this._titleTextBox.ReadOnly = true;
            this._titleTextBox.Size = new System.Drawing.Size(382, 128);
            this._titleTextBox.TabIndex = 0;
            this._titleTextBox.Text = "";
            // 
            // _selectButton
            // 
            this._selectButton.Location = new System.Drawing.Point(21, 202);
            this._selectButton.Name = "_selectButton";
            this._selectButton.Size = new System.Drawing.Size(75, 23);
            this._selectButton.TabIndex = 1;
            this._selectButton.Text = "Select";
            this._selectButton.UseVisualStyleBackColor = true;
            this._selectButton.Click += new System.EventHandler(this._selectButton_Click);
            // 
            // RichTextBoxView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._selectButton);
            this.Controls.Add(this._titleTextBox);
            this.Name = "RichTextBoxView";
            this.Size = new System.Drawing.Size(382, 250);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox _titleTextBox;
        private Button _selectButton;
    }
}

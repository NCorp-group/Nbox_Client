namespace NCorp_Mail_Client.UserControls
{
    partial class FolderButton
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
            this.FolderNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FolderNameLabel
            // 
            this.FolderNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.FolderNameLabel.MouseEnter += new System.EventHandler(this.Panel_MouseIn);
            this.FolderNameLabel.MouseLeave += new System.EventHandler(this.Panel_MouseOut);
            this.FolderNameLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseIn);
            this.FolderNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FolderNameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FolderNameLabel.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tds_00dp;
            this.FolderNameLabel.Location = new System.Drawing.Point(60, 0);
            this.FolderNameLabel.Name = "FolderNameLabel";
            this.FolderNameLabel.Size = new System.Drawing.Size(160, 30);
            this.FolderNameLabel.TabIndex = 1;
            this.FolderNameLabel.Text = "Folder";
            this.FolderNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FolderButton
            // 
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.MouseEnter += new System.EventHandler(this.Panel_MouseIn);
            this.MouseLeave += new System.EventHandler(this.Panel_MouseOut);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseIn);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FolderNameLabel);
            this.Name = "FolderButton";
            this.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.Size = new System.Drawing.Size(220, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label FolderNameLabel;
    }
}

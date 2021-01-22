
namespace NCorp_Mail_Client.UserControls
{
    partial class MenuButton
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
            this.IconPanel = new System.Windows.Forms.Panel();
            this.IconLabel = new System.Windows.Forms.Label();
            this.TextPanel = new System.Windows.Forms.Panel();
            this.ButtonLabel = new System.Windows.Forms.Label();
            this.IconPanel.SuspendLayout();
            this.TextPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // IconPanel
            // 
            this.IconPanel.Controls.Add(this.IconLabel);
            this.IconPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.IconPanel.Location = new System.Drawing.Point(0, 18);
            this.IconPanel.Name = "IconPanel";
            this.IconPanel.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.IconPanel.Size = new System.Drawing.Size(60, 24);
            this.IconPanel.TabIndex = 0;
            this.IconPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.IconPanel.MouseEnter += new System.EventHandler(this.Panel_MouseIn);
            this.IconPanel.MouseLeave += new System.EventHandler(this.Panel_MouseOut);
            this.IconPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseIn);
            // 
            // IconLabel
            // 
            this.IconLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IconLabel.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconLabel.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tds_00dp;
            this.IconLabel.Location = new System.Drawing.Point(0, 4);
            this.IconLabel.Name = "IconLabel";
            this.IconLabel.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.IconLabel.Size = new System.Drawing.Size(60, 20);
            this.IconLabel.TabIndex = 1;
            this.IconLabel.Text = "";
            this.IconLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.IconLabel.MouseEnter += new System.EventHandler(this.Panel_MouseIn);
            this.IconLabel.MouseLeave += new System.EventHandler(this.Panel_MouseOut);
            this.IconLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseIn);
            // 
            // TextPanel
            // 
            this.TextPanel.Controls.Add(this.ButtonLabel);
            this.TextPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextPanel.Location = new System.Drawing.Point(60, 18);
            this.TextPanel.Name = "TextPanel";
            this.TextPanel.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.TextPanel.Size = new System.Drawing.Size(200, 24);
            this.TextPanel.TabIndex = 2;
            this.TextPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.TextPanel.MouseEnter += new System.EventHandler(this.Panel_MouseIn);
            this.TextPanel.MouseLeave += new System.EventHandler(this.Panel_MouseOut);
            this.TextPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseIn);
            // 
            // ButtonLabel
            // 
            this.ButtonLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLabel.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tds_00dp;
            this.ButtonLabel.Location = new System.Drawing.Point(13, 0);
            this.ButtonLabel.Name = "ButtonLabel";
            this.ButtonLabel.Size = new System.Drawing.Size(187, 24);
            this.ButtonLabel.TabIndex = 2;
            this.ButtonLabel.Text = "Menu";
            this.ButtonLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.ButtonLabel.MouseEnter += new System.EventHandler(this.Panel_MouseIn);
            this.ButtonLabel.MouseLeave += new System.EventHandler(this.Panel_MouseOut);
            this.ButtonLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseIn);
            // 
            // MenuButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::NCorp_Mail_Client.Properties.Settings.Default.bgd_00dp;
            this.Controls.Add(this.TextPanel);
            this.Controls.Add(this.IconPanel);
            this.Name = "MenuButton";
            this.Padding = new System.Windows.Forms.Padding(0, 18, 0, 18);
            this.Size = new System.Drawing.Size(260, 60);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.MouseEnter += new System.EventHandler(this.Panel_MouseIn);
            this.MouseLeave += new System.EventHandler(this.Panel_MouseOut);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseIn);
            this.IconPanel.ResumeLayout(false);
            this.TextPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel IconPanel;
        public System.Windows.Forms.Panel TextPanel;
        public System.Windows.Forms.Label ButtonLabel;
        public System.Windows.Forms.Label IconLabel;
    }
}

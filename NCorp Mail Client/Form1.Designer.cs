namespace NCorp_Mail_Client
{
    partial class EmailClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailClient));
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.MailPanel = new System.Windows.Forms.Panel();
            this.TitleBarMail = new System.Windows.Forms.Panel();
            this.MinBtn = new System.Windows.Forms.Button();
            this.MaxBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.TitleBarList = new System.Windows.Forms.Panel();
            this.TitleBarSettings = new System.Windows.Forms.Panel();
            this.LogoBtn = new System.Windows.Forms.Button();
            this.BurgerBtn = new System.Windows.Forms.Button();
            this.FolderBtn = new System.Windows.Forms.Button();
            this.ControlPanel.SuspendLayout();
            this.MailPanel.SuspendLayout();
            this.TitleBarMail.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.ControlPanel.Controls.Add(this.FolderBtn);
            this.ControlPanel.Controls.Add(this.BurgerBtn);
            this.ControlPanel.Controls.Add(this.LogoBtn);
            this.ControlPanel.Controls.Add(this.TitleBarSettings);
            this.ControlPanel.Controls.Add(this.SettingsBtn);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ControlPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(60, 720);
            this.ControlPanel.TabIndex = 3;
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.SettingsBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SettingsBtn.FlatAppearance.BorderSize = 0;
            this.SettingsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.SettingsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsBtn.ForeColor = System.Drawing.Color.White;
            this.SettingsBtn.Location = new System.Drawing.Point(0, 660);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(60, 60);
            this.SettingsBtn.TabIndex = 7;
            this.SettingsBtn.Text = "";
            this.SettingsBtn.UseVisualStyleBackColor = false;
            // 
            // MailPanel
            // 
            this.MailPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.MailPanel.Controls.Add(this.TitleBarList);
            this.MailPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MailPanel.Location = new System.Drawing.Point(60, 0);
            this.MailPanel.Name = "MailPanel";
            this.MailPanel.Size = new System.Drawing.Size(400, 720);
            this.MailPanel.TabIndex = 4;
            // 
            // TitleBarMail
            // 
            this.TitleBarMail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TitleBarMail.BackColor = System.Drawing.Color.Transparent;
            this.TitleBarMail.Controls.Add(this.MinBtn);
            this.TitleBarMail.Controls.Add(this.MaxBtn);
            this.TitleBarMail.Controls.Add(this.CloseBtn);
            this.TitleBarMail.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBarMail.Location = new System.Drawing.Point(460, 0);
            this.TitleBarMail.Name = "TitleBarMail";
            this.TitleBarMail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TitleBarMail.Size = new System.Drawing.Size(820, 32);
            this.TitleBarMail.TabIndex = 8;
            // 
            // MinBtn
            // 
            this.MinBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinBtn.FlatAppearance.BorderSize = 0;
            this.MinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinBtn.ForeColor = System.Drawing.Color.White;
            this.MinBtn.Location = new System.Drawing.Point(682, 0);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(46, 32);
            this.MinBtn.TabIndex = 2;
            this.MinBtn.Text = "";
            this.MinBtn.UseVisualStyleBackColor = false;
            // 
            // MaxBtn
            // 
            this.MaxBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.MaxBtn.FlatAppearance.BorderSize = 0;
            this.MaxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxBtn.ForeColor = System.Drawing.Color.White;
            this.MaxBtn.Location = new System.Drawing.Point(728, 0);
            this.MaxBtn.Name = "MaxBtn";
            this.MaxBtn.Size = new System.Drawing.Size(46, 32);
            this.MaxBtn.TabIndex = 1;
            this.MaxBtn.Text = "";
            this.MaxBtn.UseVisualStyleBackColor = false;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.Location = new System.Drawing.Point(774, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(46, 32);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Text = "";
            this.CloseBtn.UseVisualStyleBackColor = false;
            // 
            // TitleBarList
            // 
            this.TitleBarList.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBarList.Location = new System.Drawing.Point(0, 0);
            this.TitleBarList.Name = "TitleBarList";
            this.TitleBarList.Size = new System.Drawing.Size(400, 32);
            this.TitleBarList.TabIndex = 0;
            // 
            // TitleBarSettings
            // 
            this.TitleBarSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBarSettings.Location = new System.Drawing.Point(0, 0);
            this.TitleBarSettings.Name = "TitleBarSettings";
            this.TitleBarSettings.Size = new System.Drawing.Size(60, 32);
            this.TitleBarSettings.TabIndex = 8;
            // 
            // LogoBtn
            // 
            this.LogoBtn.BackColor = System.Drawing.Color.Transparent;
            this.LogoBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoBtn.FlatAppearance.BorderSize = 0;
            this.LogoBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.LogoBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.LogoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoBtn.ForeColor = System.Drawing.Color.White;
            this.LogoBtn.Image = ((System.Drawing.Image)(resources.GetObject("LogoBtn.Image")));
            this.LogoBtn.Location = new System.Drawing.Point(0, 32);
            this.LogoBtn.Name = "LogoBtn";
            this.LogoBtn.Size = new System.Drawing.Size(60, 60);
            this.LogoBtn.TabIndex = 9;
            this.LogoBtn.UseVisualStyleBackColor = false;
            // 
            // BurgerBtn
            // 
            this.BurgerBtn.BackColor = System.Drawing.Color.Transparent;
            this.BurgerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.BurgerBtn.FlatAppearance.BorderSize = 0;
            this.BurgerBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.BurgerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.BurgerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BurgerBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BurgerBtn.ForeColor = System.Drawing.Color.White;
            this.BurgerBtn.Location = new System.Drawing.Point(0, 92);
            this.BurgerBtn.Name = "BurgerBtn";
            this.BurgerBtn.Size = new System.Drawing.Size(60, 60);
            this.BurgerBtn.TabIndex = 10;
            this.BurgerBtn.Text = "";
            this.BurgerBtn.UseVisualStyleBackColor = false;
            // 
            // FolderBtn
            // 
            this.FolderBtn.BackColor = System.Drawing.Color.Transparent;
            this.FolderBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.FolderBtn.FlatAppearance.BorderSize = 0;
            this.FolderBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.FolderBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.FolderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FolderBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FolderBtn.ForeColor = System.Drawing.Color.White;
            this.FolderBtn.Location = new System.Drawing.Point(0, 152);
            this.FolderBtn.Name = "FolderBtn";
            this.FolderBtn.Size = new System.Drawing.Size(60, 60);
            this.FolderBtn.TabIndex = 11;
            this.FolderBtn.Text = "";
            this.FolderBtn.UseVisualStyleBackColor = false;
            // 
            // EmailClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.ControlBox = false;
            this.Controls.Add(this.TitleBarMail);
            this.Controls.Add(this.MailPanel);
            this.Controls.Add(this.ControlPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmailClient";
            this.Text = "     ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ControlPanel.ResumeLayout(false);
            this.MailPanel.ResumeLayout(false);
            this.TitleBarMail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Button SettingsBtn;
        private System.Windows.Forms.Panel MailPanel;
        private System.Windows.Forms.Panel TitleBarList;
        private System.Windows.Forms.Panel TitleBarMail;
        private System.Windows.Forms.Button MinBtn;
        private System.Windows.Forms.Button MaxBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button FolderBtn;
        private System.Windows.Forms.Button BurgerBtn;
        private System.Windows.Forms.Button LogoBtn;
        private System.Windows.Forms.Panel TitleBarSettings;
    }
}


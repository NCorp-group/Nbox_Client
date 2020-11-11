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
            this.TitleBar = new System.Windows.Forms.Panel();
            this.MinBtn = new System.Windows.Forms.Button();
            this.MaxBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.FolderBtn = new System.Windows.Forms.Button();
            this.BurgerBtn = new System.Windows.Forms.Button();
            this.LogoBtn = new System.Windows.Forms.Button();
            this.MailPanel = new System.Windows.Forms.Panel();
            this.MailListPanel = new System.Windows.Forms.Panel();
            this.FilterPanel = new System.Windows.Forms.Panel();
            this.ShowMailPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MailHeader = new System.Windows.Forms.Panel();
            this.MailControlsPanel = new System.Windows.Forms.Panel();
            this.TitleContainer = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TitleBar.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            this.MailPanel.SuspendLayout();
            this.ShowMailPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TitleContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.TitleBar.Controls.Add(this.TitleContainer);
            this.TitleBar.Controls.Add(this.MinBtn);
            this.TitleBar.Controls.Add(this.MaxBtn);
            this.TitleBar.Controls.Add(this.CloseBtn);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TitleBar.Size = new System.Drawing.Size(1280, 26);
            this.TitleBar.TabIndex = 2;
            // 
            // MinBtn
            // 
            this.MinBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinBtn.FlatAppearance.BorderSize = 0;
            this.MinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinBtn.ForeColor = System.Drawing.Color.White;
            this.MinBtn.Location = new System.Drawing.Point(1172, 0);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(36, 26);
            this.MinBtn.TabIndex = 2;
            this.MinBtn.Text = "";
            this.MinBtn.UseVisualStyleBackColor = false;
            // 
            // MaxBtn
            // 
            this.MaxBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.MaxBtn.FlatAppearance.BorderSize = 0;
            this.MaxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxBtn.ForeColor = System.Drawing.Color.White;
            this.MaxBtn.Location = new System.Drawing.Point(1208, 0);
            this.MaxBtn.Name = "MaxBtn";
            this.MaxBtn.Size = new System.Drawing.Size(36, 26);
            this.MaxBtn.TabIndex = 1;
            this.MaxBtn.Text = "";
            this.MaxBtn.UseVisualStyleBackColor = false;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.Location = new System.Drawing.Point(1244, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(36, 26);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Text = "";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.ControlPanel.Controls.Add(this.SettingsBtn);
            this.ControlPanel.Controls.Add(this.FolderBtn);
            this.ControlPanel.Controls.Add(this.BurgerBtn);
            this.ControlPanel.Controls.Add(this.LogoBtn);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ControlPanel.Location = new System.Drawing.Point(0, 26);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(80, 694);
            this.ControlPanel.TabIndex = 3;
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.SettingsBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SettingsBtn.FlatAppearance.BorderSize = 0;
            this.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsBtn.ForeColor = System.Drawing.Color.White;
            this.SettingsBtn.Location = new System.Drawing.Point(0, 614);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(80, 80);
            this.SettingsBtn.TabIndex = 7;
            this.SettingsBtn.Text = "";
            this.SettingsBtn.UseVisualStyleBackColor = false;
            // 
            // FolderBtn
            // 
            this.FolderBtn.BackColor = System.Drawing.Color.Transparent;
            this.FolderBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.FolderBtn.FlatAppearance.BorderSize = 0;
            this.FolderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FolderBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FolderBtn.ForeColor = System.Drawing.Color.White;
            this.FolderBtn.Location = new System.Drawing.Point(0, 160);
            this.FolderBtn.Name = "FolderBtn";
            this.FolderBtn.Size = new System.Drawing.Size(80, 80);
            this.FolderBtn.TabIndex = 6;
            this.FolderBtn.Text = "";
            this.FolderBtn.UseVisualStyleBackColor = false;
            // 
            // BurgerBtn
            // 
            this.BurgerBtn.BackColor = System.Drawing.Color.Transparent;
            this.BurgerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.BurgerBtn.FlatAppearance.BorderSize = 0;
            this.BurgerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BurgerBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BurgerBtn.ForeColor = System.Drawing.Color.White;
            this.BurgerBtn.Location = new System.Drawing.Point(0, 80);
            this.BurgerBtn.Name = "BurgerBtn";
            this.BurgerBtn.Size = new System.Drawing.Size(80, 80);
            this.BurgerBtn.TabIndex = 5;
            this.BurgerBtn.Text = "";
            this.BurgerBtn.UseVisualStyleBackColor = false;
            // 
            // LogoBtn
            // 
            this.LogoBtn.BackColor = System.Drawing.Color.Transparent;
            this.LogoBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoBtn.FlatAppearance.BorderSize = 0;
            this.LogoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoBtn.ForeColor = System.Drawing.Color.White;
            this.LogoBtn.Image = ((System.Drawing.Image)(resources.GetObject("LogoBtn.Image")));
            this.LogoBtn.Location = new System.Drawing.Point(0, 0);
            this.LogoBtn.Name = "LogoBtn";
            this.LogoBtn.Size = new System.Drawing.Size(80, 80);
            this.LogoBtn.TabIndex = 4;
            this.LogoBtn.UseVisualStyleBackColor = false;
            // 
            // MailPanel
            // 
            this.MailPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.MailPanel.Controls.Add(this.MailListPanel);
            this.MailPanel.Controls.Add(this.FilterPanel);
            this.MailPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MailPanel.Location = new System.Drawing.Point(80, 26);
            this.MailPanel.Name = "MailPanel";
            this.MailPanel.Size = new System.Drawing.Size(400, 694);
            this.MailPanel.TabIndex = 4;
            // 
            // MailListPanel
            // 
            this.MailListPanel.BackColor = System.Drawing.Color.Transparent;
            this.MailListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MailListPanel.Location = new System.Drawing.Point(0, 100);
            this.MailListPanel.Name = "MailListPanel";
            this.MailListPanel.Size = new System.Drawing.Size(400, 594);
            this.MailListPanel.TabIndex = 1;
            // 
            // FilterPanel
            // 
            this.FilterPanel.BackColor = System.Drawing.Color.Transparent;
            this.FilterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FilterPanel.Location = new System.Drawing.Point(0, 0);
            this.FilterPanel.Name = "FilterPanel";
            this.FilterPanel.Size = new System.Drawing.Size(400, 100);
            this.FilterPanel.TabIndex = 0;
            // 
            // ShowMailPanel
            // 
            this.ShowMailPanel.BackColor = System.Drawing.Color.Transparent;
            this.ShowMailPanel.Controls.Add(this.panel1);
            this.ShowMailPanel.Controls.Add(this.MailHeader);
            this.ShowMailPanel.Controls.Add(this.MailControlsPanel);
            this.ShowMailPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ShowMailPanel.Location = new System.Drawing.Point(480, 26);
            this.ShowMailPanel.Name = "ShowMailPanel";
            this.ShowMailPanel.Size = new System.Drawing.Size(800, 694);
            this.ShowMailPanel.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 544);
            this.panel1.TabIndex = 2;
            // 
            // MailHeader
            // 
            this.MailHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.MailHeader.Location = new System.Drawing.Point(0, 50);
            this.MailHeader.Name = "MailHeader";
            this.MailHeader.Size = new System.Drawing.Size(800, 100);
            this.MailHeader.TabIndex = 1;
            // 
            // MailControlsPanel
            // 
            this.MailControlsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MailControlsPanel.Location = new System.Drawing.Point(0, 0);
            this.MailControlsPanel.Name = "MailControlsPanel";
            this.MailControlsPanel.Size = new System.Drawing.Size(800, 50);
            this.MailControlsPanel.TabIndex = 0;
            // 
            // TitleContainer
            // 
            this.TitleContainer.BackColor = System.Drawing.Color.Transparent;
            this.TitleContainer.Controls.Add(this.TitleLabel);
            this.TitleContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleContainer.Location = new System.Drawing.Point(0, 0);
            this.TitleContainer.Name = "TitleContainer";
            this.TitleContainer.Size = new System.Drawing.Size(1172, 26);
            this.TitleContainer.TabIndex = 4;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(3, 6);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(85, 13);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Nbox by NCorp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(242, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // EmailClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.ControlBox = false;
            this.Controls.Add(this.ShowMailPanel);
            this.Controls.Add(this.MailPanel);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmailClient";
            this.Text = "     ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TitleBar.ResumeLayout(false);
            this.ControlPanel.ResumeLayout(false);
            this.MailPanel.ResumeLayout(false);
            this.ShowMailPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TitleContainer.ResumeLayout(false);
            this.TitleContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button MinBtn;
        private System.Windows.Forms.Button MaxBtn;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Button SettingsBtn;
        private System.Windows.Forms.Button FolderBtn;
        private System.Windows.Forms.Button BurgerBtn;
        private System.Windows.Forms.Button LogoBtn;
        private System.Windows.Forms.Panel MailPanel;
        private System.Windows.Forms.Panel FilterPanel;
        private System.Windows.Forms.Panel MailListPanel;
        private System.Windows.Forms.Panel ShowMailPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel MailHeader;
        private System.Windows.Forms.Panel MailControlsPanel;
        private System.Windows.Forms.Panel TitleContainer;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label label1;
    }
}


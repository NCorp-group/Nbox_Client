using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

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
            this.FolderBtn = new System.Windows.Forms.Button();
            this.AccountsBtn = new System.Windows.Forms.Button();
            this.BurgerBtn = new System.Windows.Forms.Button();
            this.LogoBtn = new System.Windows.Forms.Button();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.MailPanel = new System.Windows.Forms.Panel();
            this.MailListPanel = new System.Windows.Forms.Panel();
            this.MailThumbnailContainer = new System.Windows.Forms.Panel();
            this.MailThumbnail = new System.Windows.Forms.Panel();
            this.TextWrapper = new System.Windows.Forms.Panel();
            this.ThumbnailBody = new System.Windows.Forms.Panel();
            this.ThumbBodyContainer = new System.Windows.Forms.Panel();
            this.ThumbBody = new System.Windows.Forms.TextBox();
            this.ThumbSubject = new System.Windows.Forms.TextBox();
            this.ThumbSender = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ThumbTime = new System.Windows.Forms.Panel();
            this.ThumbTimeText = new System.Windows.Forms.TextBox();
            this.ThumbControls = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ColourMark = new System.Windows.Forms.Panel();
            this.UnreadMark = new System.Windows.Forms.Panel();
            this.FilterPanel = new System.Windows.Forms.Panel();
            this.FilterBottom = new System.Windows.Forms.Panel();
            this.MarkBtn = new System.Windows.Forms.Button();
            this.FilterDropdownPanel = new System.Windows.Forms.Panel();
            this.FilterDropdownIcon = new System.Windows.Forms.Panel();
            this.FilterIcon = new System.Windows.Forms.Label();
            this.FilterDropdownText = new System.Windows.Forms.Panel();
            this.FilterDesc = new System.Windows.Forms.Label();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.SearchUnderline = new System.Windows.Forms.Panel();
            this.FilterTopPanel = new System.Windows.Forms.Panel();
            this.SearchTextPanel = new System.Windows.Forms.Panel();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.MinBtn = new System.Windows.Forms.Button();
            this.MaxBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.ControlPanel.SuspendLayout();
            this.MailPanel.SuspendLayout();
            this.MailListPanel.SuspendLayout();
            this.MailThumbnailContainer.SuspendLayout();
            this.MailThumbnail.SuspendLayout();
            this.TextWrapper.SuspendLayout();
            this.ThumbnailBody.SuspendLayout();
            this.ThumbBodyContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ThumbTime.SuspendLayout();
            this.ThumbControls.SuspendLayout();
            this.FilterPanel.SuspendLayout();
            this.FilterBottom.SuspendLayout();
            this.FilterDropdownPanel.SuspendLayout();
            this.FilterDropdownIcon.SuspendLayout();
            this.FilterDropdownText.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            this.FilterTopPanel.SuspendLayout();
            this.SearchTextPanel.SuspendLayout();
            this.TitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = global::NCorp_Mail_Client.Properties.Settings.Default.bgd_00dp;
            this.ControlPanel.Controls.Add(this.FolderBtn);
            this.ControlPanel.Controls.Add(this.AccountsBtn);
            this.ControlPanel.Controls.Add(this.BurgerBtn);
            this.ControlPanel.Controls.Add(this.LogoBtn);
            this.ControlPanel.Controls.Add(this.SettingsBtn);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ControlPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(60, 720);
            this.ControlPanel.TabIndex = 3;
            // 
            // FolderBtn
            // 
            this.FolderBtn.BackColor = System.Drawing.Color.Transparent;
            this.FolderBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.FolderBtn.FlatAppearance.BorderSize = 0;
            this.FolderBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.FolderBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.FolderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FolderBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FolderBtn.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tds_00dp;
            this.FolderBtn.Location = new System.Drawing.Point(0, 180);
            this.FolderBtn.Name = "FolderBtn";
            this.FolderBtn.Size = new System.Drawing.Size(60, 60);
            this.FolderBtn.TabIndex = 13;
            this.FolderBtn.Text = "";
            this.FolderBtn.UseVisualStyleBackColor = false;
            // 
            // AccountsBtn
            // 
            this.AccountsBtn.BackColor = System.Drawing.Color.Transparent;
            this.AccountsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AccountsBtn.FlatAppearance.BorderSize = 0;
            this.AccountsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.AccountsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.AccountsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountsBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountsBtn.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tds_00dp;
            this.AccountsBtn.Location = new System.Drawing.Point(0, 120);
            this.AccountsBtn.Name = "AccountsBtn";
            this.AccountsBtn.Size = new System.Drawing.Size(60, 60);
            this.AccountsBtn.TabIndex = 12;
            this.AccountsBtn.Text = "";
            this.AccountsBtn.UseVisualStyleBackColor = false;
            // 
            // BurgerBtn
            // 
            this.BurgerBtn.BackColor = System.Drawing.Color.Transparent;
            this.BurgerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.BurgerBtn.FlatAppearance.BorderSize = 0;
            this.BurgerBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.BurgerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.BurgerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BurgerBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BurgerBtn.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tds_00dp;
            this.BurgerBtn.Location = new System.Drawing.Point(0, 60);
            this.BurgerBtn.Name = "BurgerBtn";
            this.BurgerBtn.Size = new System.Drawing.Size(60, 60);
            this.BurgerBtn.TabIndex = 10;
            this.BurgerBtn.Text = "";
            this.BurgerBtn.UseVisualStyleBackColor = false;
            // 
            // LogoBtn
            // 
            this.LogoBtn.BackColor = System.Drawing.Color.Transparent;
            this.LogoBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoBtn.FlatAppearance.BorderSize = 0;
            this.LogoBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.LogoBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.LogoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoBtn.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tds_00dp;
            this.LogoBtn.Image = ((System.Drawing.Image)(resources.GetObject("LogoBtn.Image")));
            this.LogoBtn.Location = new System.Drawing.Point(0, 0);
            this.LogoBtn.Name = "LogoBtn";
            this.LogoBtn.Size = new System.Drawing.Size(60, 60);
            this.LogoBtn.TabIndex = 9;
            this.LogoBtn.UseVisualStyleBackColor = false;
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.SettingsBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SettingsBtn.FlatAppearance.BorderSize = 0;
            this.SettingsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.SettingsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsBtn.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tds_00dp;
            this.SettingsBtn.Location = new System.Drawing.Point(0, 660);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(60, 60);
            this.SettingsBtn.TabIndex = 7;
            this.SettingsBtn.Text = "";
            this.SettingsBtn.UseVisualStyleBackColor = false;
            // 
            // MailPanel
            // 
            this.MailPanel.BackColor = global::NCorp_Mail_Client.Properties.Settings.Default.bgd_01dp;
            this.MailPanel.Controls.Add(this.MailListPanel);
            this.MailPanel.Controls.Add(this.FilterPanel);
            this.MailPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MailPanel.Location = new System.Drawing.Point(60, 0);
            this.MailPanel.Name = "MailPanel";
            this.MailPanel.Size = new System.Drawing.Size(400, 720);
            this.MailPanel.TabIndex = 4;
            // 
            // MailListPanel
            // 
            this.MailListPanel.BackColor = System.Drawing.Color.Transparent;
            this.MailListPanel.Controls.Add(this.MailThumbnailContainer);
            this.MailListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MailListPanel.Location = new System.Drawing.Point(0, 105);
            this.MailListPanel.Name = "MailListPanel";
            this.MailListPanel.Size = new System.Drawing.Size(400, 615);
            this.MailListPanel.TabIndex = 3;
            // 
            // MailThumbnailContainer
            // 
            this.MailThumbnailContainer.Controls.Add(this.MailThumbnail);
            this.MailThumbnailContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.MailThumbnailContainer.Location = new System.Drawing.Point(0, 0);
            this.MailThumbnailContainer.Name = "MailThumbnailContainer";
            this.MailThumbnailContainer.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.MailThumbnailContainer.Size = new System.Drawing.Size(400, 100);
            this.MailThumbnailContainer.TabIndex = 0;
            // 
            // MailThumbnail
            // 
            this.MailThumbnail.BackColor = global::NCorp_Mail_Client.Properties.Settings.Default.bgd_24dp;
            this.MailThumbnail.Controls.Add(this.TextWrapper);
            this.MailThumbnail.Controls.Add(this.ColourMark);
            this.MailThumbnail.Controls.Add(this.UnreadMark);
            this.MailThumbnail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MailThumbnail.Location = new System.Drawing.Point(0, 5);
            this.MailThumbnail.Name = "MailThumbnail";
            this.MailThumbnail.Size = new System.Drawing.Size(400, 90);
            this.MailThumbnail.TabIndex = 0;
            // 
            // TextWrapper
            // 
            this.TextWrapper.Controls.Add(this.ThumbnailBody);
            this.TextWrapper.Controls.Add(this.panel1);
            this.TextWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextWrapper.Location = new System.Drawing.Point(6, 0);
            this.TextWrapper.Name = "TextWrapper";
            this.TextWrapper.Padding = new System.Windows.Forms.Padding(24, 0, 30, 0);
            this.TextWrapper.Size = new System.Drawing.Size(394, 86);
            this.TextWrapper.TabIndex = 3;
            // 
            // ThumbnailBody
            // 
            this.ThumbnailBody.Controls.Add(this.ThumbBodyContainer);
            this.ThumbnailBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThumbnailBody.Location = new System.Drawing.Point(24, 0);
            this.ThumbnailBody.Name = "ThumbnailBody";
            this.ThumbnailBody.Padding = new System.Windows.Forms.Padding(0, 8, 0, 10);
            this.ThumbnailBody.Size = new System.Drawing.Size(260, 86);
            this.ThumbnailBody.TabIndex = 1;
            // 
            // ThumbBodyContainer
            // 
            this.ThumbBodyContainer.Controls.Add(this.ThumbBody);
            this.ThumbBodyContainer.Controls.Add(this.ThumbSubject);
            this.ThumbBodyContainer.Controls.Add(this.ThumbSender);
            this.ThumbBodyContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThumbBodyContainer.Location = new System.Drawing.Point(0, 8);
            this.ThumbBodyContainer.Name = "ThumbBodyContainer";
            this.ThumbBodyContainer.Size = new System.Drawing.Size(260, 68);
            this.ThumbBodyContainer.TabIndex = 0;
            // 
            // ThumbBody
            // 
            this.ThumbBody.BackColor = global::NCorp_Mail_Client.Properties.Settings.Default.bgd_24dp;
            this.ThumbBody.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ThumbBody.Dock = System.Windows.Forms.DockStyle.Top;
            this.ThumbBody.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThumbBody.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tdm_24dp;
            this.ThumbBody.Location = new System.Drawing.Point(0, 44);
            this.ThumbBody.Name = "ThumbBody";
            this.ThumbBody.Size = new System.Drawing.Size(260, 22);
            this.ThumbBody.TabIndex = 2;
            this.ThumbBody.Text = "Preview of the email\'s body, which";
            // 
            // ThumbSubject
            // 
            this.ThumbSubject.BackColor = global::NCorp_Mail_Client.Properties.Settings.Default.bgd_24dp;
            this.ThumbSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ThumbSubject.Dock = System.Windows.Forms.DockStyle.Top;
            this.ThumbSubject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThumbSubject.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tds_24dp;
            this.ThumbSubject.Location = new System.Drawing.Point(0, 22);
            this.ThumbSubject.Name = "ThumbSubject";
            this.ThumbSubject.Size = new System.Drawing.Size(260, 22);
            this.ThumbSubject.TabIndex = 1;
            this.ThumbSubject.Text = "The subject of the email";
            // 
            // ThumbSender
            // 
            this.ThumbSender.BackColor = global::NCorp_Mail_Client.Properties.Settings.Default.bgd_24dp;
            this.ThumbSender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ThumbSender.Dock = System.Windows.Forms.DockStyle.Top;
            this.ThumbSender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThumbSender.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tds_24dp;
            this.ThumbSender.Location = new System.Drawing.Point(0, 0);
            this.ThumbSender.Name = "ThumbSender";
            this.ThumbSender.Size = new System.Drawing.Size(260, 22);
            this.ThumbSender.TabIndex = 0;
            this.ThumbSender.Text = "sender.mail@example.com";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ThumbTime);
            this.panel1.Controls.Add(this.ThumbControls);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(284, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 8, 0, 10);
            this.panel1.Size = new System.Drawing.Size(80, 86);
            this.panel1.TabIndex = 0;
            // 
            // ThumbTime
            // 
            this.ThumbTime.Controls.Add(this.ThumbTimeText);
            this.ThumbTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThumbTime.Location = new System.Drawing.Point(0, 38);
            this.ThumbTime.Name = "ThumbTime";
            this.ThumbTime.Size = new System.Drawing.Size(80, 38);
            this.ThumbTime.TabIndex = 1;
            // 
            // ThumbTimeText
            // 
            this.ThumbTimeText.BackColor = global::NCorp_Mail_Client.Properties.Settings.Default.bgd_24dp;
            this.ThumbTimeText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ThumbTimeText.Dock = System.Windows.Forms.DockStyle.Top;
            this.ThumbTimeText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThumbTimeText.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tds_24dp;
            this.ThumbTimeText.Location = new System.Drawing.Point(0, 0);
            this.ThumbTimeText.Name = "ThumbTimeText";
            this.ThumbTimeText.Size = new System.Drawing.Size(80, 22);
            this.ThumbTimeText.TabIndex = 0;
            this.ThumbTimeText.Text = "21:39";
            this.ThumbTimeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ThumbControls
            // 
            this.ThumbControls.Controls.Add(this.button1);
            this.ThumbControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.ThumbControls.Location = new System.Drawing.Point(0, 8);
            this.ThumbControls.Name = "ThumbControls";
            this.ThumbControls.Size = new System.Drawing.Size(80, 30);
            this.ThumbControls.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tds_01dp;
            this.button1.Location = new System.Drawing.Point(50, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ColourMark
            // 
            this.ColourMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(94)))), ((int)(((byte)(214)))));
            this.ColourMark.Dock = System.Windows.Forms.DockStyle.Left;
            this.ColourMark.Location = new System.Drawing.Point(0, 0);
            this.ColourMark.Name = "ColourMark";
            this.ColourMark.Size = new System.Drawing.Size(6, 86);
            this.ColourMark.TabIndex = 2;
            // 
            // UnreadMark
            // 
            this.UnreadMark.BackColor = System.Drawing.Color.White;
            this.UnreadMark.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UnreadMark.Location = new System.Drawing.Point(0, 86);
            this.UnreadMark.Name = "UnreadMark";
            this.UnreadMark.Size = new System.Drawing.Size(400, 4);
            this.UnreadMark.TabIndex = 1;
            // 
            // FilterPanel
            // 
            this.FilterPanel.Controls.Add(this.FilterBottom);
            this.FilterPanel.Controls.Add(this.SearchPanel);
            this.FilterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FilterPanel.Location = new System.Drawing.Point(0, 0);
            this.FilterPanel.Name = "FilterPanel";
            this.FilterPanel.Size = new System.Drawing.Size(400, 105);
            this.FilterPanel.TabIndex = 2;
            // 
            // FilterBottom
            // 
            this.FilterBottom.Controls.Add(this.MarkBtn);
            this.FilterBottom.Controls.Add(this.FilterDropdownPanel);
            this.FilterBottom.Controls.Add(this.RefreshBtn);
            this.FilterBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilterBottom.Location = new System.Drawing.Point(0, 55);
            this.FilterBottom.Name = "FilterBottom";
            this.FilterBottom.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.FilterBottom.Size = new System.Drawing.Size(400, 50);
            this.FilterBottom.TabIndex = 3;
            // 
            // MarkBtn
            // 
            this.MarkBtn.BackColor = System.Drawing.Color.Transparent;
            this.MarkBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.MarkBtn.FlatAppearance.BorderSize = 0;
            this.MarkBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.MarkBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.MarkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MarkBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarkBtn.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tds_01dp;
            this.MarkBtn.Location = new System.Drawing.Point(270, 0);
            this.MarkBtn.Name = "MarkBtn";
            this.MarkBtn.Size = new System.Drawing.Size(50, 50);
            this.MarkBtn.TabIndex = 5;
            this.MarkBtn.Text = "";
            this.MarkBtn.UseVisualStyleBackColor = false;
            // 
            // FilterDropdownPanel
            // 
            this.FilterDropdownPanel.AutoSize = true;
            this.FilterDropdownPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FilterDropdownPanel.Controls.Add(this.FilterDropdownIcon);
            this.FilterDropdownPanel.Controls.Add(this.FilterDropdownText);
            this.FilterDropdownPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.FilterDropdownPanel.Location = new System.Drawing.Point(30, 0);
            this.FilterDropdownPanel.Name = "FilterDropdownPanel";
            this.FilterDropdownPanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.FilterDropdownPanel.Size = new System.Drawing.Size(115, 50);
            this.FilterDropdownPanel.TabIndex = 4;
            this.FilterDropdownPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Click);
            this.FilterDropdownPanel.MouseEnter += new System.EventHandler(this.Panel_MouseIn);
            this.FilterDropdownPanel.MouseLeave += new System.EventHandler(this.Panel_MouseOut);
            this.FilterDropdownPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_Reset);
            // 
            // FilterDropdownIcon
            // 
            this.FilterDropdownIcon.AutoSize = true;
            this.FilterDropdownIcon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FilterDropdownIcon.Controls.Add(this.FilterIcon);
            this.FilterDropdownIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.FilterDropdownIcon.Location = new System.Drawing.Point(91, 10);
            this.FilterDropdownIcon.Name = "FilterDropdownIcon";
            this.FilterDropdownIcon.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.FilterDropdownIcon.Size = new System.Drawing.Size(24, 30);
            this.FilterDropdownIcon.TabIndex = 3;
            // 
            // FilterIcon
            // 
            this.FilterIcon.AutoSize = true;
            this.FilterIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.FilterIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterIcon.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tds_01dp;
            this.FilterIcon.Location = new System.Drawing.Point(0, 3);
            this.FilterIcon.Name = "FilterIcon";
            this.FilterIcon.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.FilterIcon.Size = new System.Drawing.Size(24, 21);
            this.FilterIcon.TabIndex = 1;
            this.FilterIcon.Text = "";
            // 
            // FilterDropdownText
            // 
            this.FilterDropdownText.AutoSize = true;
            this.FilterDropdownText.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FilterDropdownText.Controls.Add(this.FilterDesc);
            this.FilterDropdownText.Dock = System.Windows.Forms.DockStyle.Left;
            this.FilterDropdownText.Location = new System.Drawing.Point(0, 10);
            this.FilterDropdownText.Name = "FilterDropdownText";
            this.FilterDropdownText.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.FilterDropdownText.Size = new System.Drawing.Size(91, 30);
            this.FilterDropdownText.TabIndex = 0;
            // 
            // FilterDesc
            // 
            this.FilterDesc.AutoSize = true;
            this.FilterDesc.Dock = System.Windows.Forms.DockStyle.Left;
            this.FilterDesc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterDesc.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tds_01dp;
            this.FilterDesc.Location = new System.Drawing.Point(0, 3);
            this.FilterDesc.Name = "FilterDesc";
            this.FilterDesc.Size = new System.Drawing.Size(91, 21);
            this.FilterDesc.TabIndex = 1;
            this.FilterDesc.Text = "Filter By: All";
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.Transparent;
            this.RefreshBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.RefreshBtn.FlatAppearance.BorderSize = 0;
            this.RefreshBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.RefreshBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tds_01dp;
            this.RefreshBtn.Location = new System.Drawing.Point(320, 0);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(50, 50);
            this.RefreshBtn.TabIndex = 2;
            this.RefreshBtn.Text = "";
            this.RefreshBtn.UseVisualStyleBackColor = false;
            // 
            // SearchPanel
            // 
            this.SearchPanel.Controls.Add(this.SearchUnderline);
            this.SearchPanel.Controls.Add(this.FilterTopPanel);
            this.SearchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchPanel.Location = new System.Drawing.Point(0, 0);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.SearchPanel.Size = new System.Drawing.Size(400, 55);
            this.SearchPanel.TabIndex = 0;
            // 
            // SearchUnderline
            // 
            this.SearchUnderline.BackColor = global::NCorp_Mail_Client.Properties.Settings.Default.bgd_08dp;
            this.SearchUnderline.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SearchUnderline.Location = new System.Drawing.Point(30, 50);
            this.SearchUnderline.Name = "SearchUnderline";
            this.SearchUnderline.Size = new System.Drawing.Size(340, 5);
            this.SearchUnderline.TabIndex = 4;
            // 
            // FilterTopPanel
            // 
            this.FilterTopPanel.BackColor = System.Drawing.Color.Transparent;
            this.FilterTopPanel.Controls.Add(this.SearchTextPanel);
            this.FilterTopPanel.Controls.Add(this.SearchBtn);
            this.FilterTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FilterTopPanel.Location = new System.Drawing.Point(30, 0);
            this.FilterTopPanel.Name = "FilterTopPanel";
            this.FilterTopPanel.Size = new System.Drawing.Size(340, 50);
            this.FilterTopPanel.TabIndex = 0;
            // 
            // SearchTextPanel
            // 
            this.SearchTextPanel.Controls.Add(this.SearchText);
            this.SearchTextPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchTextPanel.Location = new System.Drawing.Point(0, 0);
            this.SearchTextPanel.Name = "SearchTextPanel";
            this.SearchTextPanel.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.SearchTextPanel.Size = new System.Drawing.Size(290, 50);
            this.SearchTextPanel.TabIndex = 3;
            // 
            // SearchText
            // 
            this.SearchText.BackColor = global::NCorp_Mail_Client.Properties.Settings.Default.bgd_01dp;
            this.SearchText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchText.Dock = System.Windows.Forms.DockStyle.Left;
            this.SearchText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchText.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tdw_01dp;
            this.SearchText.Location = new System.Drawing.Point(0, 15);
            this.SearchText.Margin = new System.Windows.Forms.Padding(3, 3, 50, 3);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(270, 22);
            this.SearchText.TabIndex = 1;
            this.SearchText.Text = "Search";
            this.SearchText.GotFocus += new System.EventHandler(this.RemoveSearchPlaceholder);
            this.SearchText.LostFocus += new System.EventHandler(this.AddSearchPlaceholder);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.Transparent;
            this.SearchBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.SearchBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tds_01dp;
            this.SearchBtn.Location = new System.Drawing.Point(290, 0);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(50, 50);
            this.SearchBtn.TabIndex = 1;
            this.SearchBtn.Text = "";
            this.SearchBtn.UseVisualStyleBackColor = false;
            // 
            // TitleBar
            // 
            this.TitleBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TitleBar.BackColor = System.Drawing.Color.Transparent;
            this.TitleBar.Controls.Add(this.MinBtn);
            this.TitleBar.Controls.Add(this.MaxBtn);
            this.TitleBar.Controls.Add(this.CloseBtn);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(460, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TitleBar.Size = new System.Drawing.Size(820, 32);
            this.TitleBar.TabIndex = 8;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            // 
            // MinBtn
            // 
            this.MinBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinBtn.FlatAppearance.BorderSize = 0;
            this.MinBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.MinBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.MinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinBtn.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tds_01dp;
            this.MinBtn.Location = new System.Drawing.Point(682, 0);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(46, 32);
            this.MinBtn.TabIndex = 2;
            this.MinBtn.Text = "";
            this.MinBtn.UseVisualStyleBackColor = false;
            this.MinBtn.Click += new System.EventHandler(this.MaxBtn_Click);
            // 
            // MaxBtn
            // 
            this.MaxBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.MaxBtn.FlatAppearance.BorderSize = 0;
            this.MaxBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.MaxBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.MaxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxBtn.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tds_01dp;
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
            this.CloseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.CloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tds_01dp;
            this.CloseBtn.Location = new System.Drawing.Point(774, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(46, 32);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Text = "";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
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
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.MailPanel);
            this.Controls.Add(this.ControlPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmailClient";
            this.Text = "     ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ControlPanel.ResumeLayout(false);
            this.MailPanel.ResumeLayout(false);
            this.MailListPanel.ResumeLayout(false);
            this.MailThumbnailContainer.ResumeLayout(false);
            this.MailThumbnail.ResumeLayout(false);
            this.TextWrapper.ResumeLayout(false);
            this.ThumbnailBody.ResumeLayout(false);
            this.ThumbBodyContainer.ResumeLayout(false);
            this.ThumbBodyContainer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ThumbTime.ResumeLayout(false);
            this.ThumbTime.PerformLayout();
            this.ThumbControls.ResumeLayout(false);
            this.FilterPanel.ResumeLayout(false);
            this.FilterBottom.ResumeLayout(false);
            this.FilterBottom.PerformLayout();
            this.FilterDropdownPanel.ResumeLayout(false);
            this.FilterDropdownPanel.PerformLayout();
            this.FilterDropdownIcon.ResumeLayout(false);
            this.FilterDropdownIcon.PerformLayout();
            this.FilterDropdownText.ResumeLayout(false);
            this.FilterDropdownText.PerformLayout();
            this.SearchPanel.ResumeLayout(false);
            this.FilterTopPanel.ResumeLayout(false);
            this.SearchTextPanel.ResumeLayout(false);
            this.SearchTextPanel.PerformLayout();
            this.TitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Button SettingsBtn;
        private System.Windows.Forms.Panel MailPanel;
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Button MinBtn;
        private System.Windows.Forms.Button MaxBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button BurgerBtn;
        private System.Windows.Forms.Button LogoBtn;
        private System.Windows.Forms.Panel FilterPanel;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.Panel FilterTopPanel;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Panel SearchUnderline;
        private System.Windows.Forms.Panel FilterBottom;
        private System.Windows.Forms.Panel FilterDropdownPanel;
        private System.Windows.Forms.Panel FilterDropdownIcon;
        private System.Windows.Forms.Label FilterIcon;
        private System.Windows.Forms.Panel FilterDropdownText;
        private System.Windows.Forms.Label FilterDesc;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button MarkBtn;
        private System.Windows.Forms.Button FolderBtn;
        private System.Windows.Forms.Button AccountsBtn;
        private System.Windows.Forms.Panel SearchTextPanel;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Panel MailListPanel;
        private System.Windows.Forms.Panel MailThumbnailContainer;
        private System.Windows.Forms.Panel MailThumbnail;
        private System.Windows.Forms.Panel TextWrapper;
        private System.Windows.Forms.Panel ColourMark;
        private System.Windows.Forms.Panel UnreadMark;
        private System.Windows.Forms.Panel ThumbnailBody;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel ThumbTime;
        private System.Windows.Forms.Panel ThumbControls;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ThumbTimeText;
        private Panel ThumbBodyContainer;
        private TextBox ThumbSender;
        private TextBox ThumbBody;
        private TextBox ThumbSubject;
    }
}


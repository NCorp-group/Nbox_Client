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
            NCorp_Mail_Client.Properties.Settings settings1 = new NCorp_Mail_Client.Properties.Settings();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailClient));
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.FolderBtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.AccountsBtn = new System.Windows.Forms.Button();
            this.BurgerBtn = new System.Windows.Forms.Button();
            this.LogoBtn = new System.Windows.Forms.Button();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.MailPanel = new System.Windows.Forms.Panel();
            this.MailListView = new System.Windows.Forms.Panel();
            this.MailThumbnailContainer = new System.Windows.Forms.Panel();
            this.MailThumbnail = new System.Windows.Forms.Panel();
            this.TextWrapper = new System.Windows.Forms.Panel();
            this.ThumbnailBody = new System.Windows.Forms.Panel();
            this.ThumbBodyContainer = new System.Windows.Forms.Panel();
            this.ThumbBody = new System.Windows.Forms.TextBox();
            this.ThumbSubject = new System.Windows.Forms.TextBox();
            this.ThumbSender = new System.Windows.Forms.TextBox();
            this.ThumbInfoPanel = new System.Windows.Forms.Panel();
            this.ThumbTime = new System.Windows.Forms.Panel();
            this.ThumbTimeText = new System.Windows.Forms.TextBox();
            this.ThumbControls = new System.Windows.Forms.Panel();
            this.InstantReplyBtn = new System.Windows.Forms.Button();
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
            this.CloseBtn = new System.Windows.Forms.Button();
            this.MaxBtn = new System.Windows.Forms.Button();
            this.MinBtn = new System.Windows.Forms.Button();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.LoginScreen = new System.Windows.Forms.Panel();
            this.LoginButton = new System.Windows.Forms.Button();
            this.MailScreen = new System.Windows.Forms.Panel();
            this.MailViewport = new System.Windows.Forms.Panel();
            this.MVPBodyPanel = new System.Windows.Forms.Panel();
            this.MVPBody = new System.Windows.Forms.Label();
            this.MVPHeaderPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MVPTitleControlsPanel = new System.Windows.Forms.Panel();
            this.MVPTitleTextPanel = new System.Windows.Forms.Panel();
            this.MVPTitleLabel = new System.Windows.Forms.Label();
            this.MVPControlsPanel = new System.Windows.Forms.Panel();
            this.ReplyBtn = new System.Windows.Forms.Button();
            this.ForwardBtn = new System.Windows.Forms.Button();
            this.FlagBtn = new System.Windows.Forms.Button();
            this.ControlPanel.SuspendLayout();
            this.MailPanel.SuspendLayout();
            this.MailListView.SuspendLayout();
            this.MailThumbnailContainer.SuspendLayout();
            this.MailThumbnail.SuspendLayout();
            this.TextWrapper.SuspendLayout();
            this.ThumbnailBody.SuspendLayout();
            this.ThumbBodyContainer.SuspendLayout();
            this.ThumbInfoPanel.SuspendLayout();
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
            this.LoginScreen.SuspendLayout();
            this.MailScreen.SuspendLayout();
            this.MailViewport.SuspendLayout();
            this.MVPBodyPanel.SuspendLayout();
            this.MVPHeaderPanel.SuspendLayout();
            this.MVPTitleControlsPanel.SuspendLayout();
            this.MVPTitleTextPanel.SuspendLayout();
            this.MVPControlsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlPanel
            // 
            settings1.SettingsKey = "";
            this.ControlPanel.BackColor = settings1.bgd_00dp;
            this.ControlPanel.Controls.Add(this.FolderBtn);
            this.ControlPanel.Controls.Add(this.button5);
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
            this.FolderBtn.ForeColor = settings1.tds_00dp;
            this.FolderBtn.Location = new System.Drawing.Point(0, 240);
            this.FolderBtn.Name = "FolderBtn";
            this.FolderBtn.Size = new System.Drawing.Size(60, 60);
            this.FolderBtn.TabIndex = 15;
            this.FolderBtn.Text = "";
            this.FolderBtn.UseVisualStyleBackColor = false;
            this.FolderBtn.Click += new System.EventHandler(this.FolderBtn_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = settings1.tds_00dp;
            this.button5.Location = new System.Drawing.Point(0, 180);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 60);
            this.button5.TabIndex = 14;
            this.button5.Text = "";
            this.button5.UseVisualStyleBackColor = false;
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
            this.AccountsBtn.ForeColor = settings1.tds_00dp;
            this.AccountsBtn.Location = new System.Drawing.Point(0, 120);
            this.AccountsBtn.Name = "AccountsBtn";
            this.AccountsBtn.Size = new System.Drawing.Size(60, 60);
            this.AccountsBtn.TabIndex = 12;
            this.AccountsBtn.Text = "";
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
            this.BurgerBtn.ForeColor = settings1.tds_00dp;
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
            this.LogoBtn.ForeColor = settings1.tds_00dp;
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
            this.SettingsBtn.ForeColor = settings1.tds_00dp;
            this.SettingsBtn.Location = new System.Drawing.Point(0, 660);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(60, 60);
            this.SettingsBtn.TabIndex = 7;
            this.SettingsBtn.Text = "";
            this.SettingsBtn.UseVisualStyleBackColor = false;
            // 
            // MailPanel
            // 
            this.MailPanel.BackColor = settings1.bgd_01dp;
            this.MailPanel.Controls.Add(this.MailListView);
            this.MailPanel.Controls.Add(this.FilterPanel);
            this.MailPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MailPanel.Location = new System.Drawing.Point(60, 0);
            this.MailPanel.Name = "MailPanel";
            this.MailPanel.Size = new System.Drawing.Size(400, 720);
            this.MailPanel.TabIndex = 4;
            // 
            // MailListView
            // 
            this.MailListView.AutoScroll = true;
            this.MailListView.BackColor = settings1.bgd_01dp;
            this.MailListView.Controls.Add(this.MailThumbnailContainer);
            this.MailListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MailListView.Location = new System.Drawing.Point(0, 105);
            this.MailListView.Name = "MailListView";
            this.MailListView.Size = new System.Drawing.Size(400, 615);
            this.MailListView.TabIndex = 3;
            // 
            // MailThumbnailContainer
            // 
            this.MailThumbnailContainer.Controls.Add(this.MailThumbnail);
            this.MailThumbnailContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.MailThumbnailContainer.Location = new System.Drawing.Point(0, 0);
            this.MailThumbnailContainer.Name = "MailThumbnailContainer";
            this.MailThumbnailContainer.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.MailThumbnailContainer.Size = new System.Drawing.Size(400, 100);
            this.MailThumbnailContainer.TabIndex = 4;
            // 
            // MailThumbnail
            // 
            this.MailThumbnail.BackColor = settings1.bgd_24dp;
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
            this.TextWrapper.Controls.Add(this.ThumbInfoPanel);
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
            this.ThumbBody.BackColor = settings1.bgd_24dp;
            this.ThumbBody.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ThumbBody.Dock = System.Windows.Forms.DockStyle.Top;
            this.ThumbBody.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThumbBody.ForeColor = settings1.tdm_24dp;
            this.ThumbBody.Location = new System.Drawing.Point(0, 44);
            this.ThumbBody.Name = "ThumbBody";
            this.ThumbBody.Size = new System.Drawing.Size(260, 22);
            this.ThumbBody.TabIndex = 2;
            this.ThumbBody.Text = "Preview of the email\'s body, which";
            // 
            // ThumbSubject
            // 
            this.ThumbSubject.BackColor = settings1.bgd_24dp;
            this.ThumbSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ThumbSubject.Dock = System.Windows.Forms.DockStyle.Top;
            this.ThumbSubject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThumbSubject.ForeColor = settings1.tds_24dp;
            this.ThumbSubject.Location = new System.Drawing.Point(0, 22);
            this.ThumbSubject.Name = "ThumbSubject";
            this.ThumbSubject.Size = new System.Drawing.Size(260, 22);
            this.ThumbSubject.TabIndex = 1;
            this.ThumbSubject.Text = "The subject of the email";
            // 
            // ThumbSender
            // 
            this.ThumbSender.BackColor = settings1.bgd_24dp;
            this.ThumbSender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ThumbSender.Dock = System.Windows.Forms.DockStyle.Top;
            this.ThumbSender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThumbSender.ForeColor = settings1.tds_24dp;
            this.ThumbSender.Location = new System.Drawing.Point(0, 0);
            this.ThumbSender.Name = "ThumbSender";
            this.ThumbSender.ReadOnly = true;
            this.ThumbSender.Size = new System.Drawing.Size(260, 22);
            this.ThumbSender.TabIndex = 0;
            this.ThumbSender.Text = "sender.mail@example.com";
            // 
            // ThumbInfoPanel
            // 
            this.ThumbInfoPanel.Controls.Add(this.ThumbTime);
            this.ThumbInfoPanel.Controls.Add(this.ThumbControls);
            this.ThumbInfoPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ThumbInfoPanel.Location = new System.Drawing.Point(284, 0);
            this.ThumbInfoPanel.Name = "ThumbInfoPanel";
            this.ThumbInfoPanel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 10);
            this.ThumbInfoPanel.Size = new System.Drawing.Size(80, 86);
            this.ThumbInfoPanel.TabIndex = 0;
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
            this.ThumbTimeText.BackColor = settings1.bgd_24dp;
            this.ThumbTimeText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ThumbTimeText.Dock = System.Windows.Forms.DockStyle.Top;
            this.ThumbTimeText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThumbTimeText.ForeColor = settings1.tds_24dp;
            this.ThumbTimeText.Location = new System.Drawing.Point(0, 0);
            this.ThumbTimeText.Name = "ThumbTimeText";
            this.ThumbTimeText.Size = new System.Drawing.Size(80, 22);
            this.ThumbTimeText.TabIndex = 0;
            this.ThumbTimeText.Text = "21:39";
            this.ThumbTimeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ThumbControls
            // 
            this.ThumbControls.Controls.Add(this.InstantReplyBtn);
            this.ThumbControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.ThumbControls.Location = new System.Drawing.Point(0, 8);
            this.ThumbControls.Name = "ThumbControls";
            this.ThumbControls.Size = new System.Drawing.Size(80, 30);
            this.ThumbControls.TabIndex = 0;
            // 
            // InstantReplyBtn
            // 
            this.InstantReplyBtn.BackColor = System.Drawing.Color.Transparent;
            this.InstantReplyBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.InstantReplyBtn.FlatAppearance.BorderSize = 0;
            this.InstantReplyBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.InstantReplyBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.InstantReplyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InstantReplyBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstantReplyBtn.ForeColor = settings1.tds_01dp;
            this.InstantReplyBtn.Location = new System.Drawing.Point(50, 0);
            this.InstantReplyBtn.Name = "InstantReplyBtn";
            this.InstantReplyBtn.Size = new System.Drawing.Size(30, 30);
            this.InstantReplyBtn.TabIndex = 4;
            this.InstantReplyBtn.Text = "";
            this.InstantReplyBtn.UseVisualStyleBackColor = false;
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
            this.MarkBtn.ForeColor = settings1.tds_01dp;
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
            this.FilterIcon.ForeColor = settings1.tds_01dp;
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
            this.FilterDesc.ForeColor = settings1.tds_01dp;
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
            this.RefreshBtn.ForeColor = settings1.tds_01dp;
            this.RefreshBtn.Location = new System.Drawing.Point(320, 0);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(50, 50);
            this.RefreshBtn.TabIndex = 2;
            this.RefreshBtn.Text = "";
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
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
            this.SearchUnderline.BackColor = settings1.bgd_08dp;
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
            this.SearchText.BackColor = settings1.bgd_01dp;
            this.SearchText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchText.Dock = System.Windows.Forms.DockStyle.Left;
            this.SearchText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchText.ForeColor = settings1.tdw_01dp;
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
            this.SearchBtn.ForeColor = settings1.tds_01dp;
            this.SearchBtn.Location = new System.Drawing.Point(290, 0);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(50, 50);
            this.SearchBtn.TabIndex = 1;
            this.SearchBtn.Text = "";
            this.SearchBtn.UseVisualStyleBackColor = false;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.CloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = settings1.tds_01dp;
            this.CloseBtn.Location = new System.Drawing.Point(774, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(46, 32);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Text = "";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // MaxBtn
            // 
            this.MaxBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.MaxBtn.FlatAppearance.BorderSize = 0;
            this.MaxBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.MaxBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.MaxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxBtn.ForeColor = settings1.tds_01dp;
            this.MaxBtn.Location = new System.Drawing.Point(728, 0);
            this.MaxBtn.Name = "MaxBtn";
            this.MaxBtn.Size = new System.Drawing.Size(46, 32);
            this.MaxBtn.TabIndex = 1;
            this.MaxBtn.Text = "";
            this.MaxBtn.UseVisualStyleBackColor = false;
            this.MaxBtn.Click += new System.EventHandler(this.MaxBtn_Click);
            // 
            // MinBtn
            // 
            this.MinBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinBtn.FlatAppearance.BorderSize = 0;
            this.MinBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.MinBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.MinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinBtn.ForeColor = settings1.tds_01dp;
            this.MinBtn.Location = new System.Drawing.Point(682, 0);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(46, 32);
            this.MinBtn.TabIndex = 2;
            this.MinBtn.Text = "";
            this.MinBtn.UseVisualStyleBackColor = false;
            this.MinBtn.Click += new System.EventHandler(this.MinBtn_Click);
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
            // LoginScreen
            // 
            this.LoginScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginScreen.BackgroundImage")));
            this.LoginScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginScreen.Controls.Add(this.LoginButton);
            this.LoginScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginScreen.Location = new System.Drawing.Point(0, 0);
            this.LoginScreen.Name = "LoginScreen";
            this.LoginScreen.Size = new System.Drawing.Size(1280, 720);
            this.LoginScreen.TabIndex = 0;
            // 
            // LoginButton
            // 
            this.LoginButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoginButton.Location = new System.Drawing.Point(0, 697);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(1280, 23);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // MailScreen
            // 
            this.MailScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MailScreen.BackgroundImage")));
            this.MailScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MailScreen.Controls.Add(this.MailViewport);
            this.MailScreen.Controls.Add(this.TitleBar);
            this.MailScreen.Controls.Add(this.MailPanel);
            this.MailScreen.Controls.Add(this.ControlPanel);
            this.MailScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MailScreen.Location = new System.Drawing.Point(0, 0);
            this.MailScreen.Name = "MailScreen";
            this.MailScreen.Size = new System.Drawing.Size(1280, 720);
            this.MailScreen.TabIndex = 0;
            // 
            // MailViewport
            // 
            this.MailViewport.BackColor = System.Drawing.Color.Transparent;
            this.MailViewport.Controls.Add(this.MVPBodyPanel);
            this.MailViewport.Controls.Add(this.MVPHeaderPanel);
            this.MailViewport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MailViewport.Location = new System.Drawing.Point(460, 32);
            this.MailViewport.Name = "MailViewport";
            this.MailViewport.Size = new System.Drawing.Size(820, 688);
            this.MailViewport.TabIndex = 9;
            // 
            // MVPBodyPanel
            // 
            this.MVPBodyPanel.Controls.Add(this.MVPBody);
            this.MVPBodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MVPBodyPanel.Location = new System.Drawing.Point(0, 70);
            this.MVPBodyPanel.Name = "MVPBodyPanel";
            this.MVPBodyPanel.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.MVPBodyPanel.Size = new System.Drawing.Size(820, 618);
            this.MVPBodyPanel.TabIndex = 1;
            // 
            // MVPBody
            // 
            this.MVPBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MVPBody.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MVPBody.ForeColor = System.Drawing.Color.White;
            this.MVPBody.Location = new System.Drawing.Point(30, 0);
            this.MVPBody.Name = "MVPBody";
            this.MVPBody.Size = new System.Drawing.Size(760, 618);
            this.MVPBody.TabIndex = 0;
            this.MVPBody.Text = resources.GetString("MVPBody.Text");
            // 
            // MVPHeaderPanel
            // 
            this.MVPHeaderPanel.Controls.Add(this.panel1);
            this.MVPHeaderPanel.Controls.Add(this.MVPTitleControlsPanel);
            this.MVPHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MVPHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.MVPHeaderPanel.Name = "MVPHeaderPanel";
            this.MVPHeaderPanel.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.MVPHeaderPanel.Size = new System.Drawing.Size(820, 70);
            this.MVPHeaderPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(30, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 20);
            this.panel1.TabIndex = 1;
            // 
            // MVPTitleControlsPanel
            // 
            this.MVPTitleControlsPanel.Controls.Add(this.MVPTitleTextPanel);
            this.MVPTitleControlsPanel.Controls.Add(this.MVPControlsPanel);
            this.MVPTitleControlsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MVPTitleControlsPanel.Location = new System.Drawing.Point(30, 0);
            this.MVPTitleControlsPanel.Name = "MVPTitleControlsPanel";
            this.MVPTitleControlsPanel.Size = new System.Drawing.Size(760, 50);
            this.MVPTitleControlsPanel.TabIndex = 0;
            // 
            // MVPTitleTextPanel
            // 
            this.MVPTitleTextPanel.Controls.Add(this.MVPTitleLabel);
            this.MVPTitleTextPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MVPTitleTextPanel.Location = new System.Drawing.Point(0, 0);
            this.MVPTitleTextPanel.Name = "MVPTitleTextPanel";
            this.MVPTitleTextPanel.Padding = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.MVPTitleTextPanel.Size = new System.Drawing.Size(528, 50);
            this.MVPTitleTextPanel.TabIndex = 1;
            // 
            // MVPTitleLabel
            // 
            this.MVPTitleLabel.AutoSize = true;
            this.MVPTitleLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MVPTitleLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MVPTitleLabel.ForeColor = System.Drawing.Color.White;
            this.MVPTitleLabel.Location = new System.Drawing.Point(0, 10);
            this.MVPTitleLabel.Name = "MVPTitleLabel";
            this.MVPTitleLabel.Size = new System.Drawing.Size(108, 30);
            this.MVPTitleLabel.TabIndex = 0;
            this.MVPTitleLabel.Text = "Email Title";
            // 
            // MVPControlsPanel
            // 
            this.MVPControlsPanel.Controls.Add(this.ReplyBtn);
            this.MVPControlsPanel.Controls.Add(this.ForwardBtn);
            this.MVPControlsPanel.Controls.Add(this.FlagBtn);
            this.MVPControlsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.MVPControlsPanel.Location = new System.Drawing.Point(528, 0);
            this.MVPControlsPanel.Name = "MVPControlsPanel";
            this.MVPControlsPanel.Size = new System.Drawing.Size(232, 50);
            this.MVPControlsPanel.TabIndex = 0;
            // 
            // ReplyBtn
            // 
            this.ReplyBtn.BackColor = System.Drawing.Color.Transparent;
            this.ReplyBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ReplyBtn.FlatAppearance.BorderSize = 0;
            this.ReplyBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.ReplyBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.ReplyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReplyBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReplyBtn.ForeColor = settings1.tds_01dp;
            this.ReplyBtn.Location = new System.Drawing.Point(82, 0);
            this.ReplyBtn.Name = "ReplyBtn";
            this.ReplyBtn.Size = new System.Drawing.Size(50, 50);
            this.ReplyBtn.TabIndex = 8;
            this.ReplyBtn.Text = "";
            this.ReplyBtn.UseVisualStyleBackColor = false;
            // 
            // ForwardBtn
            // 
            this.ForwardBtn.BackColor = System.Drawing.Color.Transparent;
            this.ForwardBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ForwardBtn.FlatAppearance.BorderSize = 0;
            this.ForwardBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.ForwardBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.ForwardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForwardBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForwardBtn.ForeColor = settings1.tds_01dp;
            this.ForwardBtn.Location = new System.Drawing.Point(132, 0);
            this.ForwardBtn.Name = "ForwardBtn";
            this.ForwardBtn.Size = new System.Drawing.Size(50, 50);
            this.ForwardBtn.TabIndex = 7;
            this.ForwardBtn.Text = "";
            this.ForwardBtn.UseVisualStyleBackColor = false;
            // 
            // FlagBtn
            // 
            this.FlagBtn.BackColor = System.Drawing.Color.Transparent;
            this.FlagBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.FlagBtn.FlatAppearance.BorderSize = 0;
            this.FlagBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.FlagBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.FlagBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlagBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlagBtn.ForeColor = settings1.tds_01dp;
            this.FlagBtn.Location = new System.Drawing.Point(182, 0);
            this.FlagBtn.Name = "FlagBtn";
            this.FlagBtn.Size = new System.Drawing.Size(50, 50);
            this.FlagBtn.TabIndex = 5;
            this.FlagBtn.Text = "";
            this.FlagBtn.UseVisualStyleBackColor = false;
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
            this.Controls.Add(this.MailScreen);
            this.Controls.Add(this.LoginScreen);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmailClient";
            this.Text = "     ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ControlPanel.ResumeLayout(false);
            this.MailPanel.ResumeLayout(false);
            this.MailListView.ResumeLayout(false);
            this.MailThumbnailContainer.ResumeLayout(false);
            this.MailThumbnail.ResumeLayout(false);
            this.TextWrapper.ResumeLayout(false);
            this.ThumbnailBody.ResumeLayout(false);
            this.ThumbBodyContainer.ResumeLayout(false);
            this.ThumbBodyContainer.PerformLayout();
            this.ThumbInfoPanel.ResumeLayout(false);
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
            this.LoginScreen.ResumeLayout(false);
            this.MailScreen.ResumeLayout(false);
            this.MailViewport.ResumeLayout(false);
            this.MVPBodyPanel.ResumeLayout(false);
            this.MVPHeaderPanel.ResumeLayout(false);
            this.MVPTitleControlsPanel.ResumeLayout(false);
            this.MVPTitleTextPanel.ResumeLayout(false);
            this.MVPTitleTextPanel.PerformLayout();
            this.MVPControlsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Button SettingsBtn;
        private System.Windows.Forms.Panel MailPanel;
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
        private System.Windows.Forms.Button AccountsBtn;
        private System.Windows.Forms.Panel SearchTextPanel;
        private System.Windows.Forms.TextBox SearchText;
        private Panel MailThumbnailContainer;
        private Panel MailThumbnail;
        private Panel TextWrapper;
        private Panel ThumbnailBody;
        private Panel ThumbBodyContainer;
        private TextBox ThumbBody;
        private TextBox ThumbSubject;
        private TextBox ThumbSender;
        private Panel ThumbInfoPanel;
        private Panel ThumbTime;
        private TextBox ThumbTimeText;
        private Panel ThumbControls;
        private Button InstantReplyBtn;
        private Panel ColourMark;
        private Panel UnreadMark;
        private Panel MailListView;
        private Button CloseBtn;
        private Button MaxBtn;
        private Button MinBtn;
        private Panel TitleBar;
        private Panel LoginScreen;
        private Panel MailScreen;
        private Button LoginButton;
        private Panel MailViewport;
        private Panel MVPHeaderPanel;
        private Panel MVPTitleControlsPanel;
        private Panel MVPTitleTextPanel;
        private Panel MVPControlsPanel;
        private Button ReplyBtn;
        private Button ForwardBtn;
        private Button FlagBtn;
        private Label MVPTitleLabel;
        private Panel MVPBodyPanel;
        private Panel panel1;
        private Label MVPBody;
        private Button FolderBtn;
        private Button button5;
    }
}
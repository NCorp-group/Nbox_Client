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
            this.MenuSettingsBtn = new NCorp_Mail_Client.UserControls.MenuButton();
            this.MenuFoldersBtn = new NCorp_Mail_Client.UserControls.MenuButton();
            this.MenuAccountsBtn = new NCorp_Mail_Client.UserControls.MenuButton();
            this.MenuNewMailBtn = new NCorp_Mail_Client.UserControls.MenuButton();
            this.MenuBurgerBtn = new NCorp_Mail_Client.UserControls.MenuButton();
            this.LogoBtn = new System.Windows.Forms.Button();
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
            this.MVPPanel = new System.Windows.Forms.Panel();
            this.MVPBodyLabel = new System.Windows.Forms.Label();
            this.MVPHeaderPanel = new System.Windows.Forms.Panel();
            this.MVPTitlePanel = new System.Windows.Forms.Panel();
            this.MVPTitleLabel = new System.Windows.Forms.Label();
            this.MVPActionsPanel = new System.Windows.Forms.Panel();
            this.ColourBtn = new System.Windows.Forms.Button();
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
            this.MVPPanel.SuspendLayout();
            this.MVPHeaderPanel.SuspendLayout();
            this.MVPTitlePanel.SuspendLayout();
            this.MVPActionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(29)))));
            this.ControlPanel.Controls.Add(this.MenuSettingsBtn);
            this.ControlPanel.Controls.Add(this.MenuFoldersBtn);
            this.ControlPanel.Controls.Add(this.MenuAccountsBtn);
            this.ControlPanel.Controls.Add(this.MenuNewMailBtn);
            this.ControlPanel.Controls.Add(this.MenuBurgerBtn);
            this.ControlPanel.Controls.Add(this.LogoBtn);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ControlPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(60, 720);
            this.ControlPanel.TabIndex = 3;
            // 
            // MenuSettingsBtn
            // 
            this.MenuSettingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(29)))));
            this.MenuSettingsBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MenuSettingsBtn.icon = "";
            this.MenuSettingsBtn.Location = new System.Drawing.Point(0, 660);
            this.MenuSettingsBtn.Name = "MenuSettingsBtn";
            this.MenuSettingsBtn.Padding = new System.Windows.Forms.Padding(0, 18, 0, 18);
            this.MenuSettingsBtn.Size = new System.Drawing.Size(60, 60);
            this.MenuSettingsBtn.TabIndex = 32;
            this.MenuSettingsBtn.text = "Settings";
            // 
            // MenuFoldersBtn
            // 
            this.MenuFoldersBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(29)))));
            this.MenuFoldersBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuFoldersBtn.icon = "";
            this.MenuFoldersBtn.Location = new System.Drawing.Point(0, 240);
            this.MenuFoldersBtn.Name = "MenuFoldersBtn";
            this.MenuFoldersBtn.Padding = new System.Windows.Forms.Padding(0, 18, 0, 18);
            this.MenuFoldersBtn.Size = new System.Drawing.Size(60, 60);
            this.MenuFoldersBtn.TabIndex = 31;
            this.MenuFoldersBtn.text = "Folders";
            // 
            // MenuAccountsBtn
            // 
            this.MenuAccountsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(29)))));
            this.MenuAccountsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuAccountsBtn.icon = "";
            this.MenuAccountsBtn.Location = new System.Drawing.Point(0, 180);
            this.MenuAccountsBtn.Name = "MenuAccountsBtn";
            this.MenuAccountsBtn.Padding = new System.Windows.Forms.Padding(0, 18, 0, 18);
            this.MenuAccountsBtn.Size = new System.Drawing.Size(60, 60);
            this.MenuAccountsBtn.TabIndex = 30;
            this.MenuAccountsBtn.text = "Accounts";
            // 
            // MenuNewMailBtn
            // 
            this.MenuNewMailBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(29)))));
            this.MenuNewMailBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuNewMailBtn.icon = "";
            this.MenuNewMailBtn.Location = new System.Drawing.Point(0, 120);
            this.MenuNewMailBtn.Name = "MenuNewMailBtn";
            this.MenuNewMailBtn.Padding = new System.Windows.Forms.Padding(0, 18, 0, 18);
            this.MenuNewMailBtn.Size = new System.Drawing.Size(60, 60);
            this.MenuNewMailBtn.TabIndex = 29;
            this.MenuNewMailBtn.text = "New Mail";
            // 
            // MenuBurgerBtn
            // 
            this.MenuBurgerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(29)))));
            this.MenuBurgerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuBurgerBtn.icon = "";
            this.MenuBurgerBtn.Location = new System.Drawing.Point(0, 60);
            this.MenuBurgerBtn.Name = "MenuBurgerBtn";
            this.MenuBurgerBtn.Padding = new System.Windows.Forms.Padding(0, 18, 0, 18);
            this.MenuBurgerBtn.Size = new System.Drawing.Size(60, 60);
            this.MenuBurgerBtn.TabIndex = 28;
            this.MenuBurgerBtn.text = "Menu";
            this.MenuBurgerBtn.Click += new System.EventHandler(this.BurgerBtn_Click);
            // 
            // LogoBtn
            // 
            this.LogoBtn.BackColor = System.Drawing.Color.Transparent;
            this.LogoBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogoBtn.BackgroundImage")));
            this.LogoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LogoBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoBtn.FlatAppearance.BorderSize = 0;
            this.LogoBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.LogoBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.LogoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(226)))));
            this.LogoBtn.Location = new System.Drawing.Point(0, 0);
            this.LogoBtn.Name = "LogoBtn";
            this.LogoBtn.Size = new System.Drawing.Size(60, 60);
            this.LogoBtn.TabIndex = 22;
            this.LogoBtn.UseVisualStyleBackColor = false;
            // 
            // MailPanel
            // 
            this.MailPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
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
            this.MailListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
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
            this.MailThumbnail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
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
            this.ThumbBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ThumbBody.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ThumbBody.Dock = System.Windows.Forms.DockStyle.Top;
            this.ThumbBody.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThumbBody.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(174)))), ((int)(((byte)(179)))));
            this.ThumbBody.Location = new System.Drawing.Point(0, 44);
            this.ThumbBody.Name = "ThumbBody";
            this.ThumbBody.Size = new System.Drawing.Size(260, 22);
            this.ThumbBody.TabIndex = 2;
            this.ThumbBody.Text = "Preview of the email\'s body, which";
            // 
            // ThumbSubject
            // 
            this.ThumbSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ThumbSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ThumbSubject.Dock = System.Windows.Forms.DockStyle.Top;
            this.ThumbSubject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThumbSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(229)))), ((int)(((byte)(230)))));
            this.ThumbSubject.Location = new System.Drawing.Point(0, 22);
            this.ThumbSubject.Name = "ThumbSubject";
            this.ThumbSubject.Size = new System.Drawing.Size(260, 22);
            this.ThumbSubject.TabIndex = 1;
            this.ThumbSubject.Text = "The subject of the email";
            // 
            // ThumbSender
            // 
            this.ThumbSender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ThumbSender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ThumbSender.Dock = System.Windows.Forms.DockStyle.Top;
            this.ThumbSender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThumbSender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(229)))), ((int)(((byte)(230)))));
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
            this.ThumbTimeText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ThumbTimeText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ThumbTimeText.Dock = System.Windows.Forms.DockStyle.Top;
            this.ThumbTimeText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThumbTimeText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(229)))), ((int)(((byte)(230)))));
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
            this.InstantReplyBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
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
            this.MarkBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
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
            this.FilterIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
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
            this.FilterDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
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
            this.RefreshBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
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
            this.SearchUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
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
            this.SearchText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.SearchText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchText.Dock = System.Windows.Forms.DockStyle.Left;
            this.SearchText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(113)))), ((int)(((byte)(122)))));
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
            this.SearchBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
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
            this.CloseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.CloseBtn.Location = new System.Drawing.Point(774, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(46, 32);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Text = "";
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
            this.MaxBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
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
            this.MinBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
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
            this.MailScreen.BackColor = global::NCorp_Mail_Client.Properties.Settings.Default.bgd_00dp;
            this.MailScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MailScreen.Controls.Add(this.MVPPanel);
            this.MailScreen.Controls.Add(this.TitleBar);
            this.MailScreen.Controls.Add(this.MailPanel);
            this.MailScreen.Controls.Add(this.ControlPanel);
            this.MailScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MailScreen.Location = new System.Drawing.Point(0, 0);
            this.MailScreen.Name = "MailScreen";
            this.MailScreen.Size = new System.Drawing.Size(1280, 720);
            this.MailScreen.TabIndex = 0;
            // 
            // MVPPanel
            // 
            this.MVPPanel.Controls.Add(this.MVPBodyLabel);
            this.MVPPanel.Controls.Add(this.MVPHeaderPanel);
            this.MVPPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MVPPanel.Location = new System.Drawing.Point(460, 32);
            this.MVPPanel.Name = "MVPPanel";
            this.MVPPanel.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.MVPPanel.Size = new System.Drawing.Size(820, 688);
            this.MVPPanel.TabIndex = 10;
            // 
            // MVPBodyLabel
            // 
            this.MVPBodyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MVPBodyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MVPBodyLabel.ForeColor = System.Drawing.Color.White;
            this.MVPBodyLabel.Location = new System.Drawing.Point(30, 70);
            this.MVPBodyLabel.Name = "MVPBodyLabel";
            this.MVPBodyLabel.Size = new System.Drawing.Size(760, 618);
            this.MVPBodyLabel.TabIndex = 1;
            this.MVPBodyLabel.Text = resources.GetString("MVPBodyLabel.Text");
            // 
            // MVPHeaderPanel
            // 
            this.MVPHeaderPanel.Controls.Add(this.MVPTitlePanel);
            this.MVPHeaderPanel.Controls.Add(this.MVPActionsPanel);
            this.MVPHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MVPHeaderPanel.Location = new System.Drawing.Point(30, 0);
            this.MVPHeaderPanel.Name = "MVPHeaderPanel";
            this.MVPHeaderPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.MVPHeaderPanel.Size = new System.Drawing.Size(760, 70);
            this.MVPHeaderPanel.TabIndex = 0;
            // 
            // MVPTitlePanel
            // 
            this.MVPTitlePanel.Controls.Add(this.MVPTitleLabel);
            this.MVPTitlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MVPTitlePanel.Location = new System.Drawing.Point(0, 0);
            this.MVPTitlePanel.Name = "MVPTitlePanel";
            this.MVPTitlePanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.MVPTitlePanel.Size = new System.Drawing.Size(560, 50);
            this.MVPTitlePanel.TabIndex = 1;
            // 
            // MVPTitleLabel
            // 
            this.MVPTitleLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MVPTitleLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MVPTitleLabel.ForeColor = System.Drawing.Color.White;
            this.MVPTitleLabel.Location = new System.Drawing.Point(0, 10);
            this.MVPTitleLabel.Name = "MVPTitleLabel";
            this.MVPTitleLabel.Size = new System.Drawing.Size(108, 30);
            this.MVPTitleLabel.TabIndex = 1;
            this.MVPTitleLabel.Text = "Email Title";
            // 
            // MVPActionsPanel
            // 
            this.MVPActionsPanel.Controls.Add(this.ColourBtn);
            this.MVPActionsPanel.Controls.Add(this.ReplyBtn);
            this.MVPActionsPanel.Controls.Add(this.ForwardBtn);
            this.MVPActionsPanel.Controls.Add(this.FlagBtn);
            this.MVPActionsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.MVPActionsPanel.Location = new System.Drawing.Point(560, 0);
            this.MVPActionsPanel.Name = "MVPActionsPanel";
            this.MVPActionsPanel.Size = new System.Drawing.Size(200, 50);
            this.MVPActionsPanel.TabIndex = 0;
            // 
            // ColourBtn
            // 
            this.ColourBtn.BackColor = System.Drawing.Color.Transparent;
            this.ColourBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ColourBtn.FlatAppearance.BorderSize = 0;
            this.ColourBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.ColourBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.ColourBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColourBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColourBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.ColourBtn.Location = new System.Drawing.Point(0, 0);
            this.ColourBtn.Name = "ColourBtn";
            this.ColourBtn.Size = new System.Drawing.Size(50, 50);
            this.ColourBtn.TabIndex = 18;
            this.ColourBtn.Text = "";
            this.ColourBtn.UseVisualStyleBackColor = false;
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
            this.ReplyBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.ReplyBtn.Location = new System.Drawing.Point(50, 0);
            this.ReplyBtn.Name = "ReplyBtn";
            this.ReplyBtn.Size = new System.Drawing.Size(50, 50);
            this.ReplyBtn.TabIndex = 17;
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
            this.ForwardBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.ForwardBtn.Location = new System.Drawing.Point(100, 0);
            this.ForwardBtn.Name = "ForwardBtn";
            this.ForwardBtn.Size = new System.Drawing.Size(50, 50);
            this.ForwardBtn.TabIndex = 16;
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
            this.FlagBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.FlagBtn.Location = new System.Drawing.Point(150, 0);
            this.FlagBtn.Name = "FlagBtn";
            this.FlagBtn.Size = new System.Drawing.Size(50, 50);
            this.FlagBtn.TabIndex = 15;
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
            this.MVPPanel.ResumeLayout(false);
            this.MVPHeaderPanel.ResumeLayout(false);
            this.MVPTitlePanel.ResumeLayout(false);
            this.MVPActionsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Panel MailPanel;
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
        private Panel MVPPanel;
        private Label MVPBodyLabel;
        private Panel MVPHeaderPanel;
        private Panel MVPTitlePanel;
        private Label MVPTitleLabel;
        private Panel MVPActionsPanel;
        private Button ReplyBtn;
        private Button ForwardBtn;
        private Button FlagBtn;
        private Button ColourBtn;
        private UserControls.MenuButton MenuFoldersBtn;
        private UserControls.MenuButton MenuAccountsBtn;
        private UserControls.MenuButton MenuNewMailBtn;
        private UserControls.MenuButton MenuBurgerBtn;
        private Button LogoBtn;
        private UserControls.MenuButton MenuSettingsBtn;
    }
}
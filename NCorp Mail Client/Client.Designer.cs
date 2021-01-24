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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailClient));
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.SettingsOverline = new System.Windows.Forms.Panel();
            this.MenuSettingsBtn = new NCorp_Mail_Client.UserControls.MenuButton();
            this.FoldersListPanel = new System.Windows.Forms.Panel();
            this.FolderListView = new System.Windows.Forms.Panel();
            this.NewFolderBtn = new System.Windows.Forms.Button();
            this.FolderUnderline = new System.Windows.Forms.Panel();
            this.MenuFoldersBtn = new NCorp_Mail_Client.UserControls.MenuButton();
            this.MenuNewMailBtn = new NCorp_Mail_Client.UserControls.MenuButton();
            this.MenuBurgerBtn = new NCorp_Mail_Client.UserControls.MenuButton();
            this.LogoBtn = new System.Windows.Forms.Button();
            this.MailPanel = new System.Windows.Forms.Panel();
            this.MailListView = new System.Windows.Forms.Panel();
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
            this.LoginTitleBar = new System.Windows.Forms.Panel();
            this.LoginMinBtn = new System.Windows.Forms.Button();
            this.LoginMaxBtn = new System.Windows.Forms.Button();
            this.LoginCloseBtn = new System.Windows.Forms.Button();
            this.LoginLeftPanel = new System.Windows.Forms.Panel();
            this.LoginInputPanelWrapper = new System.Windows.Forms.Panel();
            this.LoginLeftSpacer3 = new System.Windows.Forms.Panel();
            this.LoginErrorLabel = new System.Windows.Forms.Label();
            this.LoginLeftSpacer2 = new System.Windows.Forms.Panel();
            this.LoginPassPanel = new System.Windows.Forms.Panel();
            this.LoginPassTextBox = new System.Windows.Forms.TextBox();
            this.LoginPassUnderline = new System.Windows.Forms.Panel();
            this.LoginPassLabel = new System.Windows.Forms.Label();
            this.LoginLeftSpacer = new System.Windows.Forms.Panel();
            this.LoginMailPanel = new System.Windows.Forms.Panel();
            this.LoginMailTextBox = new System.Windows.Forms.TextBox();
            this.LoginMailUnderline = new System.Windows.Forms.Panel();
            this.LoginMailLabel = new System.Windows.Forms.Label();
            this.LoginLogoPanel = new System.Windows.Forms.Panel();
            this.LoginLogo = new System.Windows.Forms.Panel();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.LoginLeftTitleBar = new System.Windows.Forms.Panel();
            this.MailScreen = new System.Windows.Forms.Panel();
            this.MVPWrapperPanel = new System.Windows.Forms.Panel();
            this.GeneralToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ControlPanel.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            this.FoldersListPanel.SuspendLayout();
            this.FolderListView.SuspendLayout();
            this.MailPanel.SuspendLayout();
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
            this.LoginTitleBar.SuspendLayout();
            this.LoginLeftPanel.SuspendLayout();
            this.LoginInputPanelWrapper.SuspendLayout();
            this.LoginPassPanel.SuspendLayout();
            this.LoginMailPanel.SuspendLayout();
            this.LoginLogoPanel.SuspendLayout();
            this.MailScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(29)))));
            this.ControlPanel.Controls.Add(this.SettingsPanel);
            this.ControlPanel.Controls.Add(this.FoldersListPanel);
            this.ControlPanel.Controls.Add(this.MenuNewMailBtn);
            this.ControlPanel.Controls.Add(this.MenuBurgerBtn);
            this.ControlPanel.Controls.Add(this.LogoBtn);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ControlPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(60, 720);
            this.ControlPanel.TabIndex = 3;
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.Controls.Add(this.LogoutBtn);
            this.SettingsPanel.Controls.Add(this.SettingsOverline);
            this.SettingsPanel.Controls.Add(this.MenuSettingsBtn);
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SettingsPanel.Location = new System.Drawing.Point(0, 660);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(60, 60);
            this.SettingsPanel.TabIndex = 34;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.LogoutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogoutBtn.FlatAppearance.BorderSize = 0;
            this.LogoutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.LogoutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.LogoutBtn.Location = new System.Drawing.Point(0, -35);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.LogoutBtn.Size = new System.Drawing.Size(60, 30);
            this.LogoutBtn.TabIndex = 35;
            this.LogoutBtn.Text = "Log Out";
            this.LogoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // SettingsOverline
            // 
            this.SettingsOverline.BackColor = global::NCorp_Mail_Client.Properties.Settings.Default.bgd_01dp;
            this.SettingsOverline.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SettingsOverline.Location = new System.Drawing.Point(0, -5);
            this.SettingsOverline.Name = "SettingsOverline";
            this.SettingsOverline.Size = new System.Drawing.Size(60, 5);
            this.SettingsOverline.TabIndex = 34;
            // 
            // MenuSettingsBtn
            // 
            this.MenuSettingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(29)))));
            this.MenuSettingsBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MenuSettingsBtn.icon = "";
            this.MenuSettingsBtn.Location = new System.Drawing.Point(0, 0);
            this.MenuSettingsBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MenuSettingsBtn.Name = "MenuSettingsBtn";
            this.MenuSettingsBtn.Padding = new System.Windows.Forms.Padding(0, 18, 0, 18);
            this.MenuSettingsBtn.Size = new System.Drawing.Size(60, 60);
            this.MenuSettingsBtn.TabIndex = 33;
            this.MenuSettingsBtn.text = "Settings";
            this.GeneralToolTip.SetToolTip(this.MenuSettingsBtn, "Show settings");
            this.MenuSettingsBtn.Click += new System.EventHandler(this.MenuSettingsBtn_Click);
            // 
            // FoldersListPanel
            // 
            this.FoldersListPanel.Controls.Add(this.FolderListView);
            this.FoldersListPanel.Controls.Add(this.FolderUnderline);
            this.FoldersListPanel.Controls.Add(this.MenuFoldersBtn);
            this.FoldersListPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FoldersListPanel.Location = new System.Drawing.Point(0, 180);
            this.FoldersListPanel.Name = "FoldersListPanel";
            this.FoldersListPanel.Size = new System.Drawing.Size(60, 60);
            this.FoldersListPanel.TabIndex = 33;
            // 
            // FolderListView
            // 
            this.FolderListView.Controls.Add(this.NewFolderBtn);
            this.FolderListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FolderListView.Location = new System.Drawing.Point(0, 65);
            this.FolderListView.Name = "FolderListView";
            this.FolderListView.Size = new System.Drawing.Size(60, 0);
            this.FolderListView.TabIndex = 37;
            // 
            // NewFolderBtn
            // 
            this.NewFolderBtn.BackColor = System.Drawing.Color.Transparent;
            this.NewFolderBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NewFolderBtn.FlatAppearance.BorderSize = 0;
            this.NewFolderBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.NewFolderBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.NewFolderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewFolderBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewFolderBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.NewFolderBtn.Location = new System.Drawing.Point(0, -30);
            this.NewFolderBtn.Name = "NewFolderBtn";
            this.NewFolderBtn.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.NewFolderBtn.Size = new System.Drawing.Size(60, 30);
            this.NewFolderBtn.TabIndex = 18;
            this.NewFolderBtn.Text = "";
            this.NewFolderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GeneralToolTip.SetToolTip(this.NewFolderBtn, "New folder");
            this.NewFolderBtn.UseVisualStyleBackColor = false;
            this.NewFolderBtn.Click += new System.EventHandler(this.NewFolderBtn_Click);
            // 
            // FolderUnderline
            // 
            this.FolderUnderline.BackColor = global::NCorp_Mail_Client.Properties.Settings.Default.bgd_01dp;
            this.FolderUnderline.Dock = System.Windows.Forms.DockStyle.Top;
            this.FolderUnderline.Location = new System.Drawing.Point(0, 60);
            this.FolderUnderline.Name = "FolderUnderline";
            this.FolderUnderline.Size = new System.Drawing.Size(60, 5);
            this.FolderUnderline.TabIndex = 33;
            // 
            // MenuFoldersBtn
            // 
            this.MenuFoldersBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(29)))));
            this.MenuFoldersBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuFoldersBtn.icon = "";
            this.MenuFoldersBtn.Location = new System.Drawing.Point(0, 0);
            this.MenuFoldersBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MenuFoldersBtn.Name = "MenuFoldersBtn";
            this.MenuFoldersBtn.Padding = new System.Windows.Forms.Padding(0, 18, 0, 18);
            this.MenuFoldersBtn.Size = new System.Drawing.Size(60, 60);
            this.MenuFoldersBtn.TabIndex = 32;
            this.MenuFoldersBtn.text = "Folders";
            this.GeneralToolTip.SetToolTip(this.MenuFoldersBtn, "Show folders");
            this.MenuFoldersBtn.Click += new System.EventHandler(this.MenuFoldersBtn_Click);
            // 
            // MenuNewMailBtn
            // 
            this.MenuNewMailBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(29)))));
            this.MenuNewMailBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuNewMailBtn.icon = "";
            this.MenuNewMailBtn.Location = new System.Drawing.Point(0, 120);
            this.MenuNewMailBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MenuNewMailBtn.Name = "MenuNewMailBtn";
            this.MenuNewMailBtn.Padding = new System.Windows.Forms.Padding(0, 18, 0, 18);
            this.MenuNewMailBtn.Size = new System.Drawing.Size(60, 60);
            this.MenuNewMailBtn.TabIndex = 29;
            this.MenuNewMailBtn.text = "New Mail";
            this.GeneralToolTip.SetToolTip(this.MenuNewMailBtn, "Compose new mail");
            this.MenuNewMailBtn.Click += new System.EventHandler(this.MenuNewMailBtn_Click);
            // 
            // MenuBurgerBtn
            // 
            this.MenuBurgerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(29)))));
            this.MenuBurgerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuBurgerBtn.icon = "";
            this.MenuBurgerBtn.Location = new System.Drawing.Point(0, 60);
            this.MenuBurgerBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MenuBurgerBtn.Name = "MenuBurgerBtn";
            this.MenuBurgerBtn.Padding = new System.Windows.Forms.Padding(0, 18, 0, 18);
            this.MenuBurgerBtn.Size = new System.Drawing.Size(60, 60);
            this.MenuBurgerBtn.TabIndex = 28;
            this.MenuBurgerBtn.text = "Menu";
            this.GeneralToolTip.SetToolTip(this.MenuBurgerBtn, "Expand menu");
            this.MenuBurgerBtn.Click += new System.EventHandler(this.BurgerBtn_Click);
            // 
            // LogoBtn
            // 
            this.LogoBtn.BackColor = System.Drawing.Color.Transparent;
            this.LogoBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogoBtn.BackgroundImage")));
            this.LogoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LogoBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoBtn.FlatAppearance.BorderSize = 0;
            this.LogoBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(29)))));
            this.LogoBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(29)))));
            this.LogoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(226)))));
            this.LogoBtn.Location = new System.Drawing.Point(0, 0);
            this.LogoBtn.Name = "LogoBtn";
            this.LogoBtn.Size = new System.Drawing.Size(60, 60);
            this.LogoBtn.TabIndex = 22;
            this.LogoBtn.UseVisualStyleBackColor = false;
            this.LogoBtn.DoubleClick += new System.EventHandler(this.TitleBar_DoubleClick);
            this.LogoBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
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
            this.MailListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MailListView.Location = new System.Drawing.Point(0, 105);
            this.MailListView.Name = "MailListView";
            this.MailListView.Size = new System.Drawing.Size(400, 615);
            this.MailListView.TabIndex = 3;
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
            this.GeneralToolTip.SetToolTip(this.MarkBtn, "Select mails");
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
            this.GeneralToolTip.SetToolTip(this.RefreshBtn, "Refresh");
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
            this.GeneralToolTip.SetToolTip(this.SearchBtn, "Search");
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
            this.GeneralToolTip.SetToolTip(this.CloseBtn, "Close");
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
            this.GeneralToolTip.SetToolTip(this.MaxBtn, "Maximize");
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
            this.GeneralToolTip.SetToolTip(this.MinBtn, "Minimize");
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
            this.TitleBar.DoubleClick += new System.EventHandler(this.TitleBar_DoubleClick);
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            // 
            // LoginScreen
            // 
            this.LoginScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginScreen.BackgroundImage")));
            this.LoginScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginScreen.Controls.Add(this.LoginTitleBar);
            this.LoginScreen.Controls.Add(this.LoginLeftPanel);
            this.LoginScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginScreen.Location = new System.Drawing.Point(0, 0);
            this.LoginScreen.Name = "LoginScreen";
            this.LoginScreen.Size = new System.Drawing.Size(1280, 720);
            this.LoginScreen.TabIndex = 0;
            // 
            // LoginTitleBar
            // 
            this.LoginTitleBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoginTitleBar.BackColor = System.Drawing.Color.Transparent;
            this.LoginTitleBar.Controls.Add(this.LoginMinBtn);
            this.LoginTitleBar.Controls.Add(this.LoginMaxBtn);
            this.LoginTitleBar.Controls.Add(this.LoginCloseBtn);
            this.LoginTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginTitleBar.Location = new System.Drawing.Point(460, 0);
            this.LoginTitleBar.Name = "LoginTitleBar";
            this.LoginTitleBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LoginTitleBar.Size = new System.Drawing.Size(820, 32);
            this.LoginTitleBar.TabIndex = 12;
            this.LoginTitleBar.DoubleClick += new System.EventHandler(this.TitleBar_DoubleClick);
            this.LoginTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            // 
            // LoginMinBtn
            // 
            this.LoginMinBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.LoginMinBtn.FlatAppearance.BorderSize = 0;
            this.LoginMinBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.LoginMinBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.LoginMinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginMinBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginMinBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.LoginMinBtn.Location = new System.Drawing.Point(682, 0);
            this.LoginMinBtn.Name = "LoginMinBtn";
            this.LoginMinBtn.Size = new System.Drawing.Size(46, 32);
            this.LoginMinBtn.TabIndex = 2;
            this.LoginMinBtn.Text = "";
            this.GeneralToolTip.SetToolTip(this.LoginMinBtn, "Minimize");
            this.LoginMinBtn.UseVisualStyleBackColor = false;
            this.LoginMinBtn.Click += new System.EventHandler(this.MinBtn_Click);
            // 
            // LoginMaxBtn
            // 
            this.LoginMaxBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.LoginMaxBtn.FlatAppearance.BorderSize = 0;
            this.LoginMaxBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.LoginMaxBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.LoginMaxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginMaxBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginMaxBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.LoginMaxBtn.Location = new System.Drawing.Point(728, 0);
            this.LoginMaxBtn.Name = "LoginMaxBtn";
            this.LoginMaxBtn.Size = new System.Drawing.Size(46, 32);
            this.LoginMaxBtn.TabIndex = 1;
            this.LoginMaxBtn.Text = "";
            this.GeneralToolTip.SetToolTip(this.LoginMaxBtn, "Maximise");
            this.LoginMaxBtn.UseVisualStyleBackColor = false;
            this.LoginMaxBtn.Click += new System.EventHandler(this.MaxBtn_Click);
            // 
            // LoginCloseBtn
            // 
            this.LoginCloseBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.LoginCloseBtn.FlatAppearance.BorderSize = 0;
            this.LoginCloseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.LoginCloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.LoginCloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginCloseBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginCloseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.LoginCloseBtn.Location = new System.Drawing.Point(774, 0);
            this.LoginCloseBtn.Name = "LoginCloseBtn";
            this.LoginCloseBtn.Size = new System.Drawing.Size(46, 32);
            this.LoginCloseBtn.TabIndex = 0;
            this.LoginCloseBtn.Text = "";
            this.GeneralToolTip.SetToolTip(this.LoginCloseBtn, "Close");
            this.LoginCloseBtn.UseVisualStyleBackColor = false;
            this.LoginCloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // LoginLeftPanel
            // 
            this.LoginLeftPanel.BackColor = global::NCorp_Mail_Client.Properties.Settings.Default.bgd_00dp;
            this.LoginLeftPanel.Controls.Add(this.LoginInputPanelWrapper);
            this.LoginLeftPanel.Controls.Add(this.LoginLeftTitleBar);
            this.LoginLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LoginLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginLeftPanel.Name = "LoginLeftPanel";
            this.LoginLeftPanel.Size = new System.Drawing.Size(460, 720);
            this.LoginLeftPanel.TabIndex = 11;
            // 
            // LoginInputPanelWrapper
            // 
            this.LoginInputPanelWrapper.Controls.Add(this.LoginLeftSpacer3);
            this.LoginInputPanelWrapper.Controls.Add(this.LoginErrorLabel);
            this.LoginInputPanelWrapper.Controls.Add(this.LoginLeftSpacer2);
            this.LoginInputPanelWrapper.Controls.Add(this.LoginPassPanel);
            this.LoginInputPanelWrapper.Controls.Add(this.LoginPassLabel);
            this.LoginInputPanelWrapper.Controls.Add(this.LoginLeftSpacer);
            this.LoginInputPanelWrapper.Controls.Add(this.LoginMailPanel);
            this.LoginInputPanelWrapper.Controls.Add(this.LoginMailLabel);
            this.LoginInputPanelWrapper.Controls.Add(this.LoginLogoPanel);
            this.LoginInputPanelWrapper.Controls.Add(this.LoginBtn);
            this.LoginInputPanelWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginInputPanelWrapper.Location = new System.Drawing.Point(0, 32);
            this.LoginInputPanelWrapper.Name = "LoginInputPanelWrapper";
            this.LoginInputPanelWrapper.Padding = new System.Windows.Forms.Padding(60, 20, 60, 20);
            this.LoginInputPanelWrapper.Size = new System.Drawing.Size(460, 688);
            this.LoginInputPanelWrapper.TabIndex = 7;
            // 
            // LoginLeftSpacer3
            // 
            this.LoginLeftSpacer3.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginLeftSpacer3.Location = new System.Drawing.Point(60, 308);
            this.LoginLeftSpacer3.Margin = new System.Windows.Forms.Padding(2);
            this.LoginLeftSpacer3.Name = "LoginLeftSpacer3";
            this.LoginLeftSpacer3.Size = new System.Drawing.Size(340, 13);
            this.LoginLeftSpacer3.TabIndex = 25;
            // 
            // LoginErrorLabel
            // 
            this.LoginErrorLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginErrorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginErrorLabel.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.cm_red;
            this.LoginErrorLabel.Location = new System.Drawing.Point(60, 293);
            this.LoginErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoginErrorLabel.Name = "LoginErrorLabel";
            this.LoginErrorLabel.Size = new System.Drawing.Size(340, 15);
            this.LoginErrorLabel.TabIndex = 24;
            // 
            // LoginLeftSpacer2
            // 
            this.LoginLeftSpacer2.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginLeftSpacer2.Location = new System.Drawing.Point(60, 280);
            this.LoginLeftSpacer2.Margin = new System.Windows.Forms.Padding(2);
            this.LoginLeftSpacer2.Name = "LoginLeftSpacer2";
            this.LoginLeftSpacer2.Size = new System.Drawing.Size(340, 13);
            this.LoginLeftSpacer2.TabIndex = 23;
            // 
            // LoginPassPanel
            // 
            this.LoginPassPanel.Controls.Add(this.LoginPassTextBox);
            this.LoginPassPanel.Controls.Add(this.LoginPassUnderline);
            this.LoginPassPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginPassPanel.Location = new System.Drawing.Point(60, 253);
            this.LoginPassPanel.Margin = new System.Windows.Forms.Padding(2);
            this.LoginPassPanel.Name = "LoginPassPanel";
            this.LoginPassPanel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LoginPassPanel.Size = new System.Drawing.Size(340, 27);
            this.LoginPassPanel.TabIndex = 22;
            // 
            // LoginPassTextBox
            // 
            this.LoginPassTextBox.BackColor = global::NCorp_Mail_Client.Properties.Settings.Default.bgd_00dp;
            this.LoginPassTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginPassTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginPassTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPassTextBox.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tds_00dp;
            this.LoginPassTextBox.Location = new System.Drawing.Point(3, 0);
            this.LoginPassTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.LoginPassTextBox.Name = "LoginPassTextBox";
            this.LoginPassTextBox.Size = new System.Drawing.Size(337, 22);
            this.LoginPassTextBox.TabIndex = 7;
            this.LoginPassTextBox.UseSystemPasswordChar = true;
            this.LoginPassTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginTextBox_KeyPress);
            // 
            // LoginPassUnderline
            // 
            this.LoginPassUnderline.BackColor = global::NCorp_Mail_Client.Properties.Settings.Default.bgd_02dp;
            this.LoginPassUnderline.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoginPassUnderline.Location = new System.Drawing.Point(3, 23);
            this.LoginPassUnderline.Margin = new System.Windows.Forms.Padding(2);
            this.LoginPassUnderline.Name = "LoginPassUnderline";
            this.LoginPassUnderline.Size = new System.Drawing.Size(337, 4);
            this.LoginPassUnderline.TabIndex = 5;
            // 
            // LoginPassLabel
            // 
            this.LoginPassLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginPassLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPassLabel.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tds_00dp;
            this.LoginPassLabel.Location = new System.Drawing.Point(60, 225);
            this.LoginPassLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoginPassLabel.Name = "LoginPassLabel";
            this.LoginPassLabel.Size = new System.Drawing.Size(340, 28);
            this.LoginPassLabel.TabIndex = 21;
            this.LoginPassLabel.Text = "Password";
            // 
            // LoginLeftSpacer
            // 
            this.LoginLeftSpacer.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginLeftSpacer.Location = new System.Drawing.Point(60, 195);
            this.LoginLeftSpacer.Margin = new System.Windows.Forms.Padding(2);
            this.LoginLeftSpacer.Name = "LoginLeftSpacer";
            this.LoginLeftSpacer.Size = new System.Drawing.Size(340, 30);
            this.LoginLeftSpacer.TabIndex = 20;
            // 
            // LoginMailPanel
            // 
            this.LoginMailPanel.Controls.Add(this.LoginMailTextBox);
            this.LoginMailPanel.Controls.Add(this.LoginMailUnderline);
            this.LoginMailPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginMailPanel.Location = new System.Drawing.Point(60, 168);
            this.LoginMailPanel.Name = "LoginMailPanel";
            this.LoginMailPanel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LoginMailPanel.Size = new System.Drawing.Size(340, 27);
            this.LoginMailPanel.TabIndex = 19;
            // 
            // LoginMailTextBox
            // 
            this.LoginMailTextBox.BackColor = global::NCorp_Mail_Client.Properties.Settings.Default.bgd_00dp;
            this.LoginMailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginMailTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginMailTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginMailTextBox.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tds_00dp;
            this.LoginMailTextBox.Location = new System.Drawing.Point(3, 0);
            this.LoginMailTextBox.Name = "LoginMailTextBox";
            this.LoginMailTextBox.Size = new System.Drawing.Size(337, 22);
            this.LoginMailTextBox.TabIndex = 7;
            this.LoginMailTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginTextBox_KeyPress);
            // 
            // LoginMailUnderline
            // 
            this.LoginMailUnderline.BackColor = global::NCorp_Mail_Client.Properties.Settings.Default.bgd_02dp;
            this.LoginMailUnderline.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoginMailUnderline.Location = new System.Drawing.Point(3, 23);
            this.LoginMailUnderline.Margin = new System.Windows.Forms.Padding(2);
            this.LoginMailUnderline.Name = "LoginMailUnderline";
            this.LoginMailUnderline.Size = new System.Drawing.Size(337, 4);
            this.LoginMailUnderline.TabIndex = 5;
            // 
            // LoginMailLabel
            // 
            this.LoginMailLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginMailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginMailLabel.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tds_00dp;
            this.LoginMailLabel.Location = new System.Drawing.Point(60, 140);
            this.LoginMailLabel.Name = "LoginMailLabel";
            this.LoginMailLabel.Size = new System.Drawing.Size(340, 28);
            this.LoginMailLabel.TabIndex = 18;
            this.LoginMailLabel.Text = "Username";
            // 
            // LoginLogoPanel
            // 
            this.LoginLogoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LoginLogoPanel.Controls.Add(this.LoginLogo);
            this.LoginLogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginLogoPanel.Location = new System.Drawing.Point(60, 20);
            this.LoginLogoPanel.Name = "LoginLogoPanel";
            this.LoginLogoPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 80);
            this.LoginLogoPanel.Size = new System.Drawing.Size(340, 120);
            this.LoginLogoPanel.TabIndex = 17;
            // 
            // LoginLogo
            // 
            this.LoginLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginLogo.BackgroundImage")));
            this.LoginLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LoginLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.LoginLogo.Location = new System.Drawing.Point(0, 0);
            this.LoginLogo.Name = "LoginLogo";
            this.LoginLogo.Size = new System.Drawing.Size(96, 40);
            this.LoginLogo.TabIndex = 1;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoginBtn.FlatAppearance.BorderSize = 0;
            this.LoginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.LoginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tds_00dp;
            this.LoginBtn.Location = new System.Drawing.Point(60, 638);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(340, 30);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "Login";
            this.GeneralToolTip.SetToolTip(this.LoginBtn, "Log in");
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // LoginLeftTitleBar
            // 
            this.LoginLeftTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginLeftTitleBar.Location = new System.Drawing.Point(0, 0);
            this.LoginLeftTitleBar.Name = "LoginLeftTitleBar";
            this.LoginLeftTitleBar.Size = new System.Drawing.Size(460, 32);
            this.LoginLeftTitleBar.TabIndex = 0;
            this.LoginLeftTitleBar.DoubleClick += new System.EventHandler(this.TitleBar_DoubleClick);
            this.LoginLeftTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            // 
            // MailScreen
            // 
            this.MailScreen.BackColor = global::NCorp_Mail_Client.Properties.Settings.Default.bgd_00dp;
            this.MailScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MailScreen.Controls.Add(this.MVPWrapperPanel);
            this.MailScreen.Controls.Add(this.TitleBar);
            this.MailScreen.Controls.Add(this.MailPanel);
            this.MailScreen.Controls.Add(this.ControlPanel);
            this.MailScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MailScreen.Location = new System.Drawing.Point(0, 0);
            this.MailScreen.Name = "MailScreen";
            this.MailScreen.Size = new System.Drawing.Size(1280, 720);
            this.MailScreen.TabIndex = 0;
            // 
            // MVPWrapperPanel
            // 
            this.MVPWrapperPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MVPWrapperPanel.Location = new System.Drawing.Point(460, 32);
            this.MVPWrapperPanel.Name = "MVPWrapperPanel";
            this.MVPWrapperPanel.Size = new System.Drawing.Size(820, 688);
            this.MVPWrapperPanel.TabIndex = 9;
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
            this.Controls.Add(this.LoginScreen);
            this.Controls.Add(this.MailScreen);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmailClient";
            this.Text = "     ";
            this.Load += new System.EventHandler(this.Client_Load);
            this.ControlPanel.ResumeLayout(false);
            this.SettingsPanel.ResumeLayout(false);
            this.FoldersListPanel.ResumeLayout(false);
            this.FolderListView.ResumeLayout(false);
            this.MailPanel.ResumeLayout(false);
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
            this.LoginTitleBar.ResumeLayout(false);
            this.LoginLeftPanel.ResumeLayout(false);
            this.LoginInputPanelWrapper.ResumeLayout(false);
            this.LoginPassPanel.ResumeLayout(false);
            this.LoginPassPanel.PerformLayout();
            this.LoginMailPanel.ResumeLayout(false);
            this.LoginMailPanel.PerformLayout();
            this.LoginLogoPanel.ResumeLayout(false);
            this.MailScreen.ResumeLayout(false);
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
        private Button CloseBtn;
        private Button MaxBtn;
        private Button MinBtn;
        private Panel TitleBar;
        private Panel LoginScreen;
        private Panel MailScreen;
        private Button LogoBtn;
        public Panel MVPWrapperPanel;
        private Panel LoginTitleBar;
        private Button LoginMinBtn;
        private Button LoginMaxBtn;
        private Button LoginCloseBtn;
        private Panel LoginLeftPanel;
        private Panel LoginLeftTitleBar;
        private Panel MailListView;
        private Panel LoginInputPanelWrapper;
        private Button LoginBtn;
        private Panel FoldersListPanel;
        private Panel FolderUnderline;
        private UserControls.MenuButton MenuFoldersBtn;
        private UserControls.MenuButton MenuNewMailBtn;
        private UserControls.MenuButton MenuBurgerBtn;
        private Panel FolderListView;
        private Button NewFolderBtn;
        private Panel SettingsPanel;
        private Button LogoutBtn;
        private Panel SettingsOverline;
        private UserControls.MenuButton MenuSettingsBtn;
        private ToolTip GeneralToolTip;
        public Panel LoginPassPanel;
        public TextBox LoginPassTextBox;
        public Panel LoginPassUnderline;
        private Label LoginPassLabel;
        private Panel LoginLeftSpacer;
        public Panel LoginMailPanel;
        public TextBox LoginMailTextBox;
        public Panel LoginMailUnderline;
        private Label LoginMailLabel;
        private Panel LoginLogoPanel;
        private Panel LoginLogo;
        private Label LoginErrorLabel;
        private Panel LoginLeftSpacer2;
        private Panel LoginLeftSpacer3;
    }
}
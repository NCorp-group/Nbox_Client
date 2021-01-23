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
            this.FoldersListPanel = new System.Windows.Forms.Panel();
            this.FolderListView = new System.Windows.Forms.Panel();
            this.NewFolderBtn = new System.Windows.Forms.Button();
            this.FolderUnderline = new System.Windows.Forms.Panel();
            this.MenuFoldersBtn = new NCorp_Mail_Client.UserControls.MenuButton();
            this.MenuSettingsBtn = new NCorp_Mail_Client.UserControls.MenuButton();
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
            this.LoginPassPanel = new System.Windows.Forms.Panel();
            this.LoginPassTexBox = new System.Windows.Forms.TextBox();
            this.LoginPassUnderline = new System.Windows.Forms.Panel();
            this.LoginPassLabel = new System.Windows.Forms.Label();
            this.LoginLeftSpacer = new System.Windows.Forms.Panel();
            this.LoginMailPanel = new System.Windows.Forms.Panel();
            this.LoginMailTextBox = new System.Windows.Forms.TextBox();
            this.LoginMailUnderline = new System.Windows.Forms.Panel();
            this.LoginMailLabel = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.LoginLeftTitleBar = new System.Windows.Forms.Panel();
            this.MailScreen = new System.Windows.Forms.Panel();
            this.MVPWrapperPanel = new System.Windows.Forms.Panel();
            this.MVPPanel = new System.Windows.Forms.Panel();
            this.MVPBodyLabel = new System.Windows.Forms.Label();
            this.MVPHeaderPanel = new System.Windows.Forms.Panel();
            this.MVPTitlePanel = new System.Windows.Forms.Panel();
            this.MVPSenderLabel = new System.Windows.Forms.Label();
            this.MVPTitleLabel = new System.Windows.Forms.Label();
            this.MVPActionsPanel = new System.Windows.Forms.Panel();
            this.ColourBtn = new System.Windows.Forms.Button();
            this.ReplyBtn = new System.Windows.Forms.Button();
            this.ForwardBtn = new System.Windows.Forms.Button();
            this.FlagBtn = new System.Windows.Forms.Button();
            this.ControlPanel.SuspendLayout();
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
            this.MailScreen.SuspendLayout();
            this.MVPWrapperPanel.SuspendLayout();
            this.MVPPanel.SuspendLayout();
            this.MVPHeaderPanel.SuspendLayout();
            this.MVPTitlePanel.SuspendLayout();
            this.MVPActionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(29)))));
            this.ControlPanel.Controls.Add(this.FoldersListPanel);
            this.ControlPanel.Controls.Add(this.MenuSettingsBtn);
            this.ControlPanel.Controls.Add(this.MenuNewMailBtn);
            this.ControlPanel.Controls.Add(this.MenuBurgerBtn);
            this.ControlPanel.Controls.Add(this.LogoBtn);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ControlPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(90, 1108);
            this.ControlPanel.TabIndex = 3;
            // 
            // FoldersListPanel
            // 
            this.FoldersListPanel.Controls.Add(this.FolderListView);
            this.FoldersListPanel.Controls.Add(this.FolderUnderline);
            this.FoldersListPanel.Controls.Add(this.MenuFoldersBtn);
            this.FoldersListPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FoldersListPanel.Location = new System.Drawing.Point(0, 276);
            this.FoldersListPanel.Name = "FoldersListPanel";
            this.FoldersListPanel.Size = new System.Drawing.Size(90, 60);
            this.FoldersListPanel.TabIndex = 33;
            // 
            // FolderListView
            // 
            this.FolderListView.Controls.Add(this.NewFolderBtn);
            this.FolderListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FolderListView.Location = new System.Drawing.Point(0, 65);
            this.FolderListView.Name = "FolderListView";
            this.FolderListView.Size = new System.Drawing.Size(90, 0);
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
            this.NewFolderBtn.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.NewFolderBtn.Size = new System.Drawing.Size(90, 30);
            this.NewFolderBtn.TabIndex = 18;
            this.NewFolderBtn.Text = "";
            this.NewFolderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewFolderBtn.UseVisualStyleBackColor = false;
            // 
            // FolderUnderline
            // 
            this.FolderUnderline.BackColor = global::NCorp_Mail_Client.Properties.Settings.Default.bgd_01dp;
            this.FolderUnderline.Dock = System.Windows.Forms.DockStyle.Top;
            this.FolderUnderline.Location = new System.Drawing.Point(0, 60);
            this.FolderUnderline.Name = "FolderUnderline";
            this.FolderUnderline.Size = new System.Drawing.Size(90, 5);
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
            this.MenuFoldersBtn.Size = new System.Drawing.Size(90, 60);
            this.MenuFoldersBtn.TabIndex = 32;
            this.MenuFoldersBtn.text = "Folders";
            this.MenuFoldersBtn.Click += new System.EventHandler(this.MenuFoldersBtn_Click);
            // 
            // MenuSettingsBtn
            // 
            this.MenuSettingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(29)))));
            this.MenuSettingsBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MenuSettingsBtn.icon = "";
            this.MenuSettingsBtn.Location = new System.Drawing.Point(0, 1048);
            this.MenuSettingsBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MenuSettingsBtn.Name = "MenuSettingsBtn";
            this.MenuSettingsBtn.Padding = new System.Windows.Forms.Padding(0, 18, 0, 18);
            this.MenuSettingsBtn.Size = new System.Drawing.Size(90, 60);
            this.MenuSettingsBtn.TabIndex = 32;
            this.MenuSettingsBtn.text = "Settings";
            // 
            // MenuNewMailBtn
            // 
            this.MenuNewMailBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(29)))));
            this.MenuNewMailBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuNewMailBtn.icon = "";
            this.MenuNewMailBtn.Location = new System.Drawing.Point(0, 184);
            this.MenuNewMailBtn.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MenuNewMailBtn.Name = "MenuNewMailBtn";
            this.MenuNewMailBtn.Padding = new System.Windows.Forms.Padding(0, 28, 0, 28);
            this.MenuNewMailBtn.Size = new System.Drawing.Size(90, 92);
            this.MenuNewMailBtn.TabIndex = 29;
            this.MenuNewMailBtn.text = "New Mail";
            this.MenuNewMailBtn.Load += new System.EventHandler(this.MenuNewMailBtn_Click);
            // 
            // MenuBurgerBtn
            // 
            this.MenuBurgerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(29)))));
            this.MenuBurgerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuBurgerBtn.icon = "";
            this.MenuBurgerBtn.Location = new System.Drawing.Point(0, 92);
            this.MenuBurgerBtn.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MenuBurgerBtn.Name = "MenuBurgerBtn";
            this.MenuBurgerBtn.Padding = new System.Windows.Forms.Padding(0, 28, 0, 28);
            this.MenuBurgerBtn.Size = new System.Drawing.Size(90, 92);
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
            this.LogoBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LogoBtn.Name = "LogoBtn";
            this.LogoBtn.Size = new System.Drawing.Size(90, 92);
            this.LogoBtn.TabIndex = 22;
            this.LogoBtn.UseVisualStyleBackColor = false;
            this.LogoBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            // 
            // MailPanel
            // 
            this.MailPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.MailPanel.Controls.Add(this.MailListView);
            this.MailPanel.Controls.Add(this.FilterPanel);
            this.MailPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MailPanel.Location = new System.Drawing.Point(90, 0);
            this.MailPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MailPanel.Name = "MailPanel";
            this.MailPanel.Size = new System.Drawing.Size(600, 1108);
            this.MailPanel.TabIndex = 4;
            // 
            // MailListView
            // 
            this.MailListView.AutoScroll = true;
            this.MailListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.MailListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MailListView.Location = new System.Drawing.Point(0, 162);
            this.MailListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MailListView.Name = "MailListView";
            this.MailListView.Size = new System.Drawing.Size(600, 946);
            this.MailListView.TabIndex = 3;
            // 
            // FilterPanel
            // 
            this.FilterPanel.Controls.Add(this.FilterBottom);
            this.FilterPanel.Controls.Add(this.SearchPanel);
            this.FilterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FilterPanel.Location = new System.Drawing.Point(0, 0);
            this.FilterPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FilterPanel.Name = "FilterPanel";
            this.FilterPanel.Size = new System.Drawing.Size(600, 162);
            this.FilterPanel.TabIndex = 2;
            // 
            // FilterBottom
            // 
            this.FilterBottom.Controls.Add(this.MarkBtn);
            this.FilterBottom.Controls.Add(this.FilterDropdownPanel);
            this.FilterBottom.Controls.Add(this.RefreshBtn);
            this.FilterBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilterBottom.Location = new System.Drawing.Point(0, 85);
            this.FilterBottom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FilterBottom.Name = "FilterBottom";
            this.FilterBottom.Padding = new System.Windows.Forms.Padding(45, 0, 45, 0);
            this.FilterBottom.Size = new System.Drawing.Size(600, 77);
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
            this.MarkBtn.Location = new System.Drawing.Point(405, 0);
            this.MarkBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MarkBtn.Name = "MarkBtn";
            this.MarkBtn.Size = new System.Drawing.Size(75, 77);
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
            this.FilterDropdownPanel.Location = new System.Drawing.Point(45, 0);
            this.FilterDropdownPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FilterDropdownPanel.Name = "FilterDropdownPanel";
            this.FilterDropdownPanel.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.FilterDropdownPanel.Size = new System.Drawing.Size(174, 77);
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
            this.FilterDropdownIcon.Location = new System.Drawing.Point(140, 15);
            this.FilterDropdownIcon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FilterDropdownIcon.Name = "FilterDropdownIcon";
            this.FilterDropdownIcon.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.FilterDropdownIcon.Size = new System.Drawing.Size(34, 47);
            this.FilterDropdownIcon.TabIndex = 3;
            // 
            // FilterIcon
            // 
            this.FilterIcon.AutoSize = true;
            this.FilterIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.FilterIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.FilterIcon.Location = new System.Drawing.Point(0, 5);
            this.FilterIcon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FilterIcon.Name = "FilterIcon";
            this.FilterIcon.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.FilterIcon.Size = new System.Drawing.Size(34, 32);
            this.FilterIcon.TabIndex = 1;
            this.FilterIcon.Text = "";
            // 
            // FilterDropdownText
            // 
            this.FilterDropdownText.AutoSize = true;
            this.FilterDropdownText.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FilterDropdownText.Controls.Add(this.FilterDesc);
            this.FilterDropdownText.Dock = System.Windows.Forms.DockStyle.Left;
            this.FilterDropdownText.Location = new System.Drawing.Point(0, 15);
            this.FilterDropdownText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FilterDropdownText.Name = "FilterDropdownText";
            this.FilterDropdownText.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.FilterDropdownText.Size = new System.Drawing.Size(140, 47);
            this.FilterDropdownText.TabIndex = 0;
            // 
            // FilterDesc
            // 
            this.FilterDesc.AutoSize = true;
            this.FilterDesc.Dock = System.Windows.Forms.DockStyle.Left;
            this.FilterDesc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.FilterDesc.Location = new System.Drawing.Point(0, 5);
            this.FilterDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FilterDesc.Name = "FilterDesc";
            this.FilterDesc.Size = new System.Drawing.Size(140, 32);
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
            this.RefreshBtn.Location = new System.Drawing.Point(480, 0);
            this.RefreshBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(75, 77);
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
            this.SearchPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Padding = new System.Windows.Forms.Padding(45, 0, 45, 0);
            this.SearchPanel.Size = new System.Drawing.Size(600, 85);
            this.SearchPanel.TabIndex = 0;
            // 
            // SearchUnderline
            // 
            this.SearchUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.SearchUnderline.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SearchUnderline.Location = new System.Drawing.Point(45, 77);
            this.SearchUnderline.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchUnderline.Name = "SearchUnderline";
            this.SearchUnderline.Size = new System.Drawing.Size(510, 8);
            this.SearchUnderline.TabIndex = 4;
            // 
            // FilterTopPanel
            // 
            this.FilterTopPanel.BackColor = System.Drawing.Color.Transparent;
            this.FilterTopPanel.Controls.Add(this.SearchTextPanel);
            this.FilterTopPanel.Controls.Add(this.SearchBtn);
            this.FilterTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FilterTopPanel.Location = new System.Drawing.Point(45, 0);
            this.FilterTopPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FilterTopPanel.Name = "FilterTopPanel";
            this.FilterTopPanel.Size = new System.Drawing.Size(510, 77);
            this.FilterTopPanel.TabIndex = 0;
            // 
            // SearchTextPanel
            // 
            this.SearchTextPanel.Controls.Add(this.SearchText);
            this.SearchTextPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchTextPanel.Location = new System.Drawing.Point(0, 0);
            this.SearchTextPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchTextPanel.Name = "SearchTextPanel";
            this.SearchTextPanel.Padding = new System.Windows.Forms.Padding(0, 23, 0, 0);
            this.SearchTextPanel.Size = new System.Drawing.Size(435, 77);
            this.SearchTextPanel.TabIndex = 3;
            // 
            // SearchText
            // 
            this.SearchText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.SearchText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchText.Dock = System.Windows.Forms.DockStyle.Left;
            this.SearchText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(113)))), ((int)(((byte)(122)))));
            this.SearchText.Location = new System.Drawing.Point(0, 23);
            this.SearchText.Margin = new System.Windows.Forms.Padding(4, 5, 75, 5);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(405, 32);
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
            this.SearchBtn.Location = new System.Drawing.Point(435, 0);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 77);
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
            this.CloseBtn.Location = new System.Drawing.Point(1161, 0);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(69, 49);
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
            this.MaxBtn.Location = new System.Drawing.Point(1092, 0);
            this.MaxBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaxBtn.Name = "MaxBtn";
            this.MaxBtn.Size = new System.Drawing.Size(69, 49);
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
            this.MinBtn.Location = new System.Drawing.Point(1023, 0);
            this.MinBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(69, 49);
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
            this.TitleBar.Location = new System.Drawing.Point(690, 0);
            this.TitleBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TitleBar.Size = new System.Drawing.Size(1230, 49);
            this.TitleBar.TabIndex = 8;
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
            this.LoginScreen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginScreen.Name = "LoginScreen";
            this.LoginScreen.Size = new System.Drawing.Size(1920, 1108);
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
            this.LoginTitleBar.Location = new System.Drawing.Point(690, 0);
            this.LoginTitleBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginTitleBar.Name = "LoginTitleBar";
            this.LoginTitleBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LoginTitleBar.Size = new System.Drawing.Size(1230, 49);
            this.LoginTitleBar.TabIndex = 12;
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
            this.LoginMinBtn.Location = new System.Drawing.Point(1023, 0);
            this.LoginMinBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginMinBtn.Name = "LoginMinBtn";
            this.LoginMinBtn.Size = new System.Drawing.Size(69, 49);
            this.LoginMinBtn.TabIndex = 2;
            this.LoginMinBtn.Text = "";
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
            this.LoginMaxBtn.Location = new System.Drawing.Point(1092, 0);
            this.LoginMaxBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginMaxBtn.Name = "LoginMaxBtn";
            this.LoginMaxBtn.Size = new System.Drawing.Size(69, 49);
            this.LoginMaxBtn.TabIndex = 1;
            this.LoginMaxBtn.Text = "";
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
            this.LoginCloseBtn.Location = new System.Drawing.Point(1161, 0);
            this.LoginCloseBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginCloseBtn.Name = "LoginCloseBtn";
            this.LoginCloseBtn.Size = new System.Drawing.Size(69, 49);
            this.LoginCloseBtn.TabIndex = 0;
            this.LoginCloseBtn.Text = "";
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
            this.LoginLeftPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginLeftPanel.Name = "LoginLeftPanel";
            this.LoginLeftPanel.Size = new System.Drawing.Size(690, 1108);
            this.LoginLeftPanel.TabIndex = 11;
            // 
            // LoginInputPanelWrapper
            // 
            this.LoginInputPanelWrapper.Controls.Add(this.LoginPassPanel);
            this.LoginInputPanelWrapper.Controls.Add(this.LoginPassLabel);
            this.LoginInputPanelWrapper.Controls.Add(this.LoginLeftSpacer);
            this.LoginInputPanelWrapper.Controls.Add(this.LoginMailPanel);
            this.LoginInputPanelWrapper.Controls.Add(this.LoginMailLabel);
            this.LoginInputPanelWrapper.Controls.Add(this.LoginBtn);
            this.LoginInputPanelWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginInputPanelWrapper.Location = new System.Drawing.Point(0, 49);
            this.LoginInputPanelWrapper.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginInputPanelWrapper.Name = "LoginInputPanelWrapper";
            this.LoginInputPanelWrapper.Padding = new System.Windows.Forms.Padding(30, 31, 30, 31);
            this.LoginInputPanelWrapper.Size = new System.Drawing.Size(690, 1059);
            this.LoginInputPanelWrapper.TabIndex = 7;
            // 
            // LoginPassPanel
            // 
            this.LoginPassPanel.Controls.Add(this.LoginPassTexBox);
            this.LoginPassPanel.Controls.Add(this.LoginPassUnderline);
            this.LoginPassPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginPassPanel.Location = new System.Drawing.Point(30, 212);
            this.LoginPassPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginPassPanel.Name = "LoginPassPanel";
            this.LoginPassPanel.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.LoginPassPanel.Size = new System.Drawing.Size(630, 49);
            this.LoginPassPanel.TabIndex = 16;
            // 
            // LoginPassTexBox
            // 
            this.LoginPassTexBox.BackColor = global::NCorp_Mail_Client.Properties.Settings.Default.bgd_00dp;
            this.LoginPassTexBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginPassTexBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginPassTexBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPassTexBox.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tds_00dp;
            this.LoginPassTexBox.Location = new System.Drawing.Point(6, 0);
            this.LoginPassTexBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginPassTexBox.Name = "LoginPassTexBox";
            this.LoginPassTexBox.Size = new System.Drawing.Size(624, 32);
            this.LoginPassTexBox.TabIndex = 7;
            // 
            // LoginPassUnderline
            // 
            this.LoginPassUnderline.BackColor = global::NCorp_Mail_Client.Properties.Settings.Default.bgd_02dp;
            this.LoginPassUnderline.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoginPassUnderline.Location = new System.Drawing.Point(6, 43);
            this.LoginPassUnderline.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginPassUnderline.Name = "LoginPassUnderline";
            this.LoginPassUnderline.Size = new System.Drawing.Size(624, 6);
            this.LoginPassUnderline.TabIndex = 5;
            // 
            // LoginPassLabel
            // 
            this.LoginPassLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginPassLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPassLabel.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tds_00dp;
            this.LoginPassLabel.Location = new System.Drawing.Point(30, 169);
            this.LoginPassLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginPassLabel.Name = "LoginPassLabel";
            this.LoginPassLabel.Size = new System.Drawing.Size(630, 43);
            this.LoginPassLabel.TabIndex = 15;
            this.LoginPassLabel.Text = "Password";
            // 
            // LoginLeftSpacer
            // 
            this.LoginLeftSpacer.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginLeftSpacer.Location = new System.Drawing.Point(30, 123);
            this.LoginLeftSpacer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginLeftSpacer.Name = "LoginLeftSpacer";
            this.LoginLeftSpacer.Size = new System.Drawing.Size(630, 46);
            this.LoginLeftSpacer.TabIndex = 13;
            // 
            // LoginMailPanel
            // 
            this.LoginMailPanel.Controls.Add(this.LoginMailTextBox);
            this.LoginMailPanel.Controls.Add(this.LoginMailUnderline);
            this.LoginMailPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginMailPanel.Location = new System.Drawing.Point(30, 74);
            this.LoginMailPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginMailPanel.Name = "LoginMailPanel";
            this.LoginMailPanel.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.LoginMailPanel.Size = new System.Drawing.Size(630, 49);
            this.LoginMailPanel.TabIndex = 12;
            // 
            // LoginMailTextBox
            // 
            this.LoginMailTextBox.BackColor = global::NCorp_Mail_Client.Properties.Settings.Default.bgd_00dp;
            this.LoginMailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginMailTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginMailTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginMailTextBox.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tds_00dp;
            this.LoginMailTextBox.Location = new System.Drawing.Point(6, 0);
            this.LoginMailTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginMailTextBox.Name = "LoginMailTextBox";
            this.LoginMailTextBox.Size = new System.Drawing.Size(624, 32);
            this.LoginMailTextBox.TabIndex = 7;
            // 
            // LoginMailUnderline
            // 
            this.LoginMailUnderline.BackColor = global::NCorp_Mail_Client.Properties.Settings.Default.bgd_02dp;
            this.LoginMailUnderline.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoginMailUnderline.Location = new System.Drawing.Point(6, 43);
            this.LoginMailUnderline.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginMailUnderline.Name = "LoginMailUnderline";
            this.LoginMailUnderline.Size = new System.Drawing.Size(624, 6);
            this.LoginMailUnderline.TabIndex = 5;
            // 
            // LoginMailLabel
            // 
            this.LoginMailLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginMailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginMailLabel.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tds_00dp;
            this.LoginMailLabel.Location = new System.Drawing.Point(30, 31);
            this.LoginMailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginMailLabel.Name = "LoginMailLabel";
            this.LoginMailLabel.Size = new System.Drawing.Size(630, 43);
            this.LoginMailLabel.TabIndex = 11;
            this.LoginMailLabel.Text = "Mail Address";
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
            this.LoginBtn.Location = new System.Drawing.Point(30, 982);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(630, 46);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // LoginLeftTitleBar
            // 
            this.LoginLeftTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginLeftTitleBar.Location = new System.Drawing.Point(0, 0);
            this.LoginLeftTitleBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginLeftTitleBar.Name = "LoginLeftTitleBar";
            this.LoginLeftTitleBar.Size = new System.Drawing.Size(690, 49);
            this.LoginLeftTitleBar.TabIndex = 0;
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
            this.MailScreen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MailScreen.Name = "MailScreen";
            this.MailScreen.Size = new System.Drawing.Size(1920, 1108);
            this.MailScreen.TabIndex = 0;
            // 
            // MVPWrapperPanel
            // 
            this.MVPWrapperPanel.Controls.Add(this.MVPPanel);
            this.MVPWrapperPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MVPWrapperPanel.Location = new System.Drawing.Point(690, 49);
            this.MVPWrapperPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MVPWrapperPanel.Name = "MVPWrapperPanel";
            this.MVPWrapperPanel.Size = new System.Drawing.Size(1230, 1059);
            this.MVPWrapperPanel.TabIndex = 9;
            // 
            // MVPPanel
            // 
            this.MVPPanel.Controls.Add(this.MVPBodyLabel);
            this.MVPPanel.Controls.Add(this.MVPHeaderPanel);
            this.MVPPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MVPPanel.Location = new System.Drawing.Point(0, 0);
            this.MVPPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MVPPanel.Name = "MVPPanel";
            this.MVPPanel.Padding = new System.Windows.Forms.Padding(45, 0, 45, 0);
            this.MVPPanel.Size = new System.Drawing.Size(1230, 1059);
            this.MVPPanel.TabIndex = 13;
            // 
            // MVPBodyLabel
            // 
            this.MVPBodyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MVPBodyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MVPBodyLabel.ForeColor = System.Drawing.Color.White;
            this.MVPBodyLabel.Location = new System.Drawing.Point(45, 90);
            this.MVPBodyLabel.Name = "MVPBodyLabel";
            this.MVPBodyLabel.Size = new System.Drawing.Size(1140, 969);
            this.MVPBodyLabel.TabIndex = 1;
            this.MVPBodyLabel.Text = "This is the body";
            // 
            // MVPHeaderPanel
            // 
            this.MVPHeaderPanel.Controls.Add(this.MVPTitlePanel);
            this.MVPHeaderPanel.Controls.Add(this.MVPActionsPanel);
            this.MVPHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MVPHeaderPanel.Location = new System.Drawing.Point(45, 0);
            this.MVPHeaderPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MVPHeaderPanel.Name = "MVPHeaderPanel";
            this.MVPHeaderPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.MVPHeaderPanel.Size = new System.Drawing.Size(1140, 90);
            this.MVPHeaderPanel.TabIndex = 0;
            // 
            // MVPTitlePanel
            // 
            this.MVPTitlePanel.Controls.Add(this.MVPSenderLabel);
            this.MVPTitlePanel.Controls.Add(this.MVPTitleLabel);
            this.MVPTitlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MVPTitlePanel.Location = new System.Drawing.Point(0, 0);
            this.MVPTitlePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MVPTitlePanel.Name = "MVPTitlePanel";
            this.MVPTitlePanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.MVPTitlePanel.Size = new System.Drawing.Size(940, 70);
            this.MVPTitlePanel.TabIndex = 1;
            // 
            // MVPSenderLabel
            // 
            this.MVPSenderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MVPSenderLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MVPSenderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.MVPSenderLabel.Location = new System.Drawing.Point(0, 40);
            this.MVPSenderLabel.Name = "MVPSenderLabel";
            this.MVPSenderLabel.Size = new System.Drawing.Size(940, 21);
            this.MVPSenderLabel.TabIndex = 2;
            this.MVPSenderLabel.Text = "sender@mail.com";
            // 
            // MVPTitleLabel
            // 
            this.MVPTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MVPTitleLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MVPTitleLabel.ForeColor = System.Drawing.Color.White;
            this.MVPTitleLabel.Location = new System.Drawing.Point(0, 10);
            this.MVPTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MVPTitleLabel.Name = "MVPTitleLabel";
            this.MVPTitleLabel.Size = new System.Drawing.Size(940, 30);
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
            this.MVPActionsPanel.Location = new System.Drawing.Point(940, 0);
            this.MVPActionsPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MVPActionsPanel.Name = "MVPActionsPanel";
            this.MVPActionsPanel.Size = new System.Drawing.Size(200, 70);
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
            this.ColourBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ColourBtn.Name = "ColourBtn";
            this.ColourBtn.Size = new System.Drawing.Size(50, 70);
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
            this.ReplyBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReplyBtn.Name = "ReplyBtn";
            this.ReplyBtn.Size = new System.Drawing.Size(50, 70);
            this.ReplyBtn.TabIndex = 17;
            this.ReplyBtn.Text = "";
            this.ReplyBtn.UseVisualStyleBackColor = false;
            this.ReplyBtn.Click += new System.EventHandler(this.ReplyBtn_Click);
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
            this.ForwardBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ForwardBtn.Name = "ForwardBtn";
            this.ForwardBtn.Size = new System.Drawing.Size(50, 70);
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
            this.FlagBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FlagBtn.Name = "FlagBtn";
            this.FlagBtn.Size = new System.Drawing.Size(50, 70);
            this.FlagBtn.TabIndex = 15;
            this.FlagBtn.Text = "";
            this.FlagBtn.UseVisualStyleBackColor = false;
            // 
            // EmailClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1108);
            this.ControlBox = false;
            this.Controls.Add(this.LoginScreen);
            this.Controls.Add(this.MailScreen);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EmailClient";
            this.Text = "     ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ControlPanel.ResumeLayout(false);
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
            this.MailScreen.ResumeLayout(false);
            this.MVPWrapperPanel.ResumeLayout(false);
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
        private Button CloseBtn;
        private Button MaxBtn;
        private Button MinBtn;
        private Panel TitleBar;
        private Panel LoginScreen;
        private Panel MailScreen;
        private UserControls.MenuButton MenuSettingsBtn;
        private Button LogoBtn;
        private Panel MVPWrapperPanel;
        private Panel MVPPanel;
        private Label MVPBodyLabel;
        private Panel MVPHeaderPanel;
        private Panel MVPTitlePanel;
        private Label MVPTitleLabel;
        private Panel MVPActionsPanel;
        private Button ColourBtn;
        private Button ReplyBtn;
        private Button ForwardBtn;
        private Button FlagBtn;
        private Panel LoginTitleBar;
        private Button LoginMinBtn;
        private Button LoginMaxBtn;
        private Button LoginCloseBtn;
        private Panel LoginLeftPanel;
        private Panel LoginLeftTitleBar;
        private Panel MailListView;
        private Panel LoginInputPanelWrapper;
        public Panel LoginMailPanel;
        public TextBox LoginMailTextBox;
        public Panel LoginMailUnderline;
        private Label LoginMailLabel;
        private Button LoginBtn;
        public Panel LoginPassPanel;
        public TextBox LoginPassTexBox;
        public Panel LoginPassUnderline;
        private Label LoginPassLabel;
        private Panel LoginLeftSpacer;
        private Panel FoldersListPanel;
        private Panel FolderUnderline;
        private UserControls.MenuButton MenuFoldersBtn;
        private UserControls.MenuButton MenuNewMailBtn;
        private UserControls.MenuButton MenuBurgerBtn;
        private Panel FolderListView;
        private Button NewFolderBtn;
        private Label MVPSenderLabel;
    }
}
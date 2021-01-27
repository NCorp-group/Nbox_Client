namespace NCorp_Mail_Client.UserControls
{
    partial class MailViewport
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
            this.components = new System.ComponentModel.Container();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.SenderLabel = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.TextBox();
            this.ActionsPanel = new System.Windows.Forms.Panel();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.ColourBtn = new System.Windows.Forms.Button();
            this.FolderBtn = new System.Windows.Forms.Button();
            this.ReplyAllBtn = new System.Windows.Forms.Button();
            this.ReplyBtn = new System.Windows.Forms.Button();
            this.ForwardBtn = new System.Windows.Forms.Button();
            this.FlagBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.BtnTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.ColourDropDown = new System.Windows.Forms.Panel();
            this.PurpleBtn = new System.Windows.Forms.Button();
            this.MagentaBtn = new System.Windows.Forms.Button();
            this.RedBtn = new System.Windows.Forms.Button();
            this.OrangeBtn = new System.Windows.Forms.Button();
            this.YellowBtn = new System.Windows.Forms.Button();
            this.GreenBtn = new System.Windows.Forms.Button();
            this.CyanBtn = new System.Windows.Forms.Button();
            this.BlueBtn = new System.Windows.Forms.Button();
            this.FoldersDropDown = new System.Windows.Forms.Panel();
            this.BodyLabel = new System.Windows.Forms.RichTextBox();
            this.NoneBtn = new System.Windows.Forms.Button();
            this.HeaderPanel.SuspendLayout();
            this.TitlePanel.SuspendLayout();
            this.ActionsPanel.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.ColourDropDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.TitlePanel);
            this.HeaderPanel.Controls.Add(this.ActionsPanel);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(30, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.HeaderPanel.Size = new System.Drawing.Size(760, 90);
            this.HeaderPanel.TabIndex = 2;
            // 
            // TitlePanel
            // 
            this.TitlePanel.Controls.Add(this.SenderLabel);
            this.TitlePanel.Controls.Add(this.TitleLabel);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.TitlePanel.Size = new System.Drawing.Size(410, 70);
            this.TitlePanel.TabIndex = 1;
            // 
            // SenderLabel
            // 
            this.SenderLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(29)))));
            this.SenderLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SenderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SenderLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SenderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(226)))));
            this.SenderLabel.Location = new System.Drawing.Point(0, 38);
            this.SenderLabel.Name = "SenderLabel";
            this.SenderLabel.ReadOnly = true;
            this.SenderLabel.Size = new System.Drawing.Size(410, 22);
            this.SenderLabel.TabIndex = 12;
            // 
            // TitleLabel
            // 
            this.TitleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(29)))));
            this.TitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(226)))));
            this.TitleLabel.Location = new System.Drawing.Point(0, 10);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.ReadOnly = true;
            this.TitleLabel.Size = new System.Drawing.Size(410, 28);
            this.TitleLabel.TabIndex = 11;
            // 
            // ActionsPanel
            // 
            this.ActionsPanel.Controls.Add(this.ButtonsPanel);
            this.ActionsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ActionsPanel.Location = new System.Drawing.Point(410, 0);
            this.ActionsPanel.Name = "ActionsPanel";
            this.ActionsPanel.Size = new System.Drawing.Size(350, 70);
            this.ActionsPanel.TabIndex = 0;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Controls.Add(this.ColourBtn);
            this.ButtonsPanel.Controls.Add(this.FolderBtn);
            this.ButtonsPanel.Controls.Add(this.ReplyAllBtn);
            this.ButtonsPanel.Controls.Add(this.ReplyBtn);
            this.ButtonsPanel.Controls.Add(this.ForwardBtn);
            this.ButtonsPanel.Controls.Add(this.FlagBtn);
            this.ButtonsPanel.Controls.Add(this.DeleteBtn);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 0);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(350, 50);
            this.ButtonsPanel.TabIndex = 0;
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
            this.ColourBtn.TabIndex = 33;
            this.ColourBtn.Text = "";
            this.BtnTooltip.SetToolTip(this.ColourBtn, "Change colour");
            this.ColourBtn.UseVisualStyleBackColor = false;
            this.ColourBtn.Click += new System.EventHandler(this.ColourBtn_Click);
            // 
            // FolderBtn
            // 
            this.FolderBtn.BackColor = System.Drawing.Color.Transparent;
            this.FolderBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.FolderBtn.FlatAppearance.BorderSize = 0;
            this.FolderBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.FolderBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.FolderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FolderBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FolderBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.FolderBtn.Location = new System.Drawing.Point(50, 0);
            this.FolderBtn.Name = "FolderBtn";
            this.FolderBtn.Size = new System.Drawing.Size(50, 50);
            this.FolderBtn.TabIndex = 35;
            this.FolderBtn.Text = "";
            this.BtnTooltip.SetToolTip(this.FolderBtn, "Change folder");
            this.FolderBtn.UseVisualStyleBackColor = false;
            this.FolderBtn.Click += new System.EventHandler(this.FolderBtn_Click);
            // 
            // ReplyAllBtn
            // 
            this.ReplyAllBtn.BackColor = System.Drawing.Color.Transparent;
            this.ReplyAllBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ReplyAllBtn.FlatAppearance.BorderSize = 0;
            this.ReplyAllBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.ReplyAllBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.ReplyAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReplyAllBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReplyAllBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.ReplyAllBtn.Location = new System.Drawing.Point(100, 0);
            this.ReplyAllBtn.Name = "ReplyAllBtn";
            this.ReplyAllBtn.Size = new System.Drawing.Size(50, 50);
            this.ReplyAllBtn.TabIndex = 32;
            this.ReplyAllBtn.Text = "";
            this.BtnTooltip.SetToolTip(this.ReplyAllBtn, "Reply All");
            this.ReplyAllBtn.UseVisualStyleBackColor = false;
            this.ReplyAllBtn.Click += new System.EventHandler(this.ReplyAllBtn_Click);
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
            this.ReplyBtn.Location = new System.Drawing.Point(150, 0);
            this.ReplyBtn.Name = "ReplyBtn";
            this.ReplyBtn.Size = new System.Drawing.Size(50, 50);
            this.ReplyBtn.TabIndex = 31;
            this.ReplyBtn.Text = "";
            this.BtnTooltip.SetToolTip(this.ReplyBtn, "Reply");
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
            this.ForwardBtn.Location = new System.Drawing.Point(200, 0);
            this.ForwardBtn.Name = "ForwardBtn";
            this.ForwardBtn.Size = new System.Drawing.Size(50, 50);
            this.ForwardBtn.TabIndex = 30;
            this.ForwardBtn.Text = "";
            this.BtnTooltip.SetToolTip(this.ForwardBtn, "Forward");
            this.ForwardBtn.UseVisualStyleBackColor = false;
            this.ForwardBtn.Click += new System.EventHandler(this.ForwardBtn_Click);
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
            this.FlagBtn.Location = new System.Drawing.Point(250, 0);
            this.FlagBtn.Name = "FlagBtn";
            this.FlagBtn.Size = new System.Drawing.Size(50, 50);
            this.FlagBtn.TabIndex = 29;
            this.FlagBtn.Text = "";
            this.BtnTooltip.SetToolTip(this.FlagBtn, "Flag as spam");
            this.FlagBtn.UseVisualStyleBackColor = false;
            this.FlagBtn.Click += new System.EventHandler(this.FlagBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.DeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.DeleteBtn.Location = new System.Drawing.Point(300, 0);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(50, 50);
            this.DeleteBtn.TabIndex = 34;
            this.DeleteBtn.Text = "";
            this.BtnTooltip.SetToolTip(this.DeleteBtn, "Delete");
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleBtn_Click);
            // 
            // ColourDropDown
            // 
            this.ColourDropDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ColourDropDown.BackColor = global::NCorp_Mail_Client.Properties.Settings.Default.bgd_02dp;
            this.ColourDropDown.Controls.Add(this.NoneBtn);
            this.ColourDropDown.Controls.Add(this.PurpleBtn);
            this.ColourDropDown.Controls.Add(this.MagentaBtn);
            this.ColourDropDown.Controls.Add(this.RedBtn);
            this.ColourDropDown.Controls.Add(this.OrangeBtn);
            this.ColourDropDown.Controls.Add(this.YellowBtn);
            this.ColourDropDown.Controls.Add(this.GreenBtn);
            this.ColourDropDown.Controls.Add(this.CyanBtn);
            this.ColourDropDown.Controls.Add(this.BlueBtn);
            this.ColourDropDown.Location = new System.Drawing.Point(440, 50);
            this.ColourDropDown.Name = "ColourDropDown";
            this.ColourDropDown.Size = new System.Drawing.Size(50, 0);
            this.ColourDropDown.TabIndex = 4;
            // 
            // PurpleBtn
            // 
            this.PurpleBtn.BackColor = System.Drawing.Color.Transparent;
            this.PurpleBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.PurpleBtn.FlatAppearance.BorderSize = 0;
            this.PurpleBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.PurpleBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.PurpleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PurpleBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurpleBtn.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.cm_purple;
            this.PurpleBtn.Location = new System.Drawing.Point(0, 350);
            this.PurpleBtn.Name = "PurpleBtn";
            this.PurpleBtn.Size = new System.Drawing.Size(50, 50);
            this.PurpleBtn.TabIndex = 49;
            this.PurpleBtn.Text = "";
            this.PurpleBtn.UseVisualStyleBackColor = false;
            this.PurpleBtn.Click += new System.EventHandler(this.PurpleColourBtn_Click);
            // 
            // MagentaBtn
            // 
            this.MagentaBtn.BackColor = System.Drawing.Color.Transparent;
            this.MagentaBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.MagentaBtn.FlatAppearance.BorderSize = 0;
            this.MagentaBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.MagentaBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.MagentaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MagentaBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MagentaBtn.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.cm_magenta;
            this.MagentaBtn.Location = new System.Drawing.Point(0, 300);
            this.MagentaBtn.Name = "MagentaBtn";
            this.MagentaBtn.Size = new System.Drawing.Size(50, 50);
            this.MagentaBtn.TabIndex = 48;
            this.MagentaBtn.Text = "";
            this.MagentaBtn.UseVisualStyleBackColor = false;
            this.MagentaBtn.Click += new System.EventHandler(this.MagentaColourBtn_Click);
            // 
            // RedBtn
            // 
            this.RedBtn.BackColor = System.Drawing.Color.Transparent;
            this.RedBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.RedBtn.FlatAppearance.BorderSize = 0;
            this.RedBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.RedBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.RedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RedBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedBtn.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.cm_red;
            this.RedBtn.Location = new System.Drawing.Point(0, 250);
            this.RedBtn.Name = "RedBtn";
            this.RedBtn.Size = new System.Drawing.Size(50, 50);
            this.RedBtn.TabIndex = 47;
            this.RedBtn.Text = "";
            this.RedBtn.UseVisualStyleBackColor = false;
            this.RedBtn.Click += new System.EventHandler(this.RedColourBtn_Click);
            // 
            // OrangeBtn
            // 
            this.OrangeBtn.BackColor = System.Drawing.Color.Transparent;
            this.OrangeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrangeBtn.FlatAppearance.BorderSize = 0;
            this.OrangeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.OrangeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.OrangeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrangeBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrangeBtn.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.cm_orange;
            this.OrangeBtn.Location = new System.Drawing.Point(0, 200);
            this.OrangeBtn.Name = "OrangeBtn";
            this.OrangeBtn.Size = new System.Drawing.Size(50, 50);
            this.OrangeBtn.TabIndex = 46;
            this.OrangeBtn.Text = "";
            this.OrangeBtn.UseVisualStyleBackColor = false;
            this.OrangeBtn.Click += new System.EventHandler(this.OrangeColourBtn_Click);
            // 
            // YellowBtn
            // 
            this.YellowBtn.BackColor = System.Drawing.Color.Transparent;
            this.YellowBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.YellowBtn.FlatAppearance.BorderSize = 0;
            this.YellowBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.YellowBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.YellowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YellowBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YellowBtn.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.cm_yellow;
            this.YellowBtn.Location = new System.Drawing.Point(0, 150);
            this.YellowBtn.Name = "YellowBtn";
            this.YellowBtn.Size = new System.Drawing.Size(50, 50);
            this.YellowBtn.TabIndex = 45;
            this.YellowBtn.Text = "";
            this.YellowBtn.UseVisualStyleBackColor = false;
            this.YellowBtn.Click += new System.EventHandler(this.YellowColourBtn_Click);
            // 
            // GreenBtn
            // 
            this.GreenBtn.BackColor = System.Drawing.Color.Transparent;
            this.GreenBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.GreenBtn.FlatAppearance.BorderSize = 0;
            this.GreenBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.GreenBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.GreenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GreenBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenBtn.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.cm_green;
            this.GreenBtn.Location = new System.Drawing.Point(0, 100);
            this.GreenBtn.Name = "GreenBtn";
            this.GreenBtn.Size = new System.Drawing.Size(50, 50);
            this.GreenBtn.TabIndex = 44;
            this.GreenBtn.Text = "";
            this.GreenBtn.UseVisualStyleBackColor = false;
            this.GreenBtn.Click += new System.EventHandler(this.GreenColourBtn_Click);
            // 
            // CyanBtn
            // 
            this.CyanBtn.BackColor = System.Drawing.Color.Transparent;
            this.CyanBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CyanBtn.FlatAppearance.BorderSize = 0;
            this.CyanBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.CyanBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.CyanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CyanBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CyanBtn.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.cm_cyan;
            this.CyanBtn.Location = new System.Drawing.Point(0, 50);
            this.CyanBtn.Name = "CyanBtn";
            this.CyanBtn.Size = new System.Drawing.Size(50, 50);
            this.CyanBtn.TabIndex = 43;
            this.CyanBtn.Text = "";
            this.CyanBtn.UseVisualStyleBackColor = false;
            this.CyanBtn.Click += new System.EventHandler(this.CyanColourBtn_Click);
            // 
            // BlueBtn
            // 
            this.BlueBtn.BackColor = System.Drawing.Color.Transparent;
            this.BlueBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.BlueBtn.FlatAppearance.BorderSize = 0;
            this.BlueBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.BlueBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.BlueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BlueBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlueBtn.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.cm_blue;
            this.BlueBtn.Location = new System.Drawing.Point(0, 0);
            this.BlueBtn.Name = "BlueBtn";
            this.BlueBtn.Size = new System.Drawing.Size(50, 50);
            this.BlueBtn.TabIndex = 42;
            this.BlueBtn.Text = "";
            this.BlueBtn.UseVisualStyleBackColor = false;
            this.BlueBtn.Click += new System.EventHandler(this.BlueColourBtn_Click);
            // 
            // FoldersDropDown
            // 
            this.FoldersDropDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FoldersDropDown.BackColor = global::NCorp_Mail_Client.Properties.Settings.Default.bgd_02dp;
            this.FoldersDropDown.Location = new System.Drawing.Point(490, 50);
            this.FoldersDropDown.Name = "FoldersDropDown";
            this.FoldersDropDown.Size = new System.Drawing.Size(100, 0);
            this.FoldersDropDown.TabIndex = 5;
            // 
            // BodyLabel
            // 
            this.BodyLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(29)))));
            this.BodyLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BodyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BodyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(226)))));
            this.BodyLabel.Location = new System.Drawing.Point(30, 90);
            this.BodyLabel.Name = "BodyLabel";
            this.BodyLabel.ReadOnly = true;
            this.BodyLabel.Size = new System.Drawing.Size(760, 598);
            this.BodyLabel.TabIndex = 8;
            this.BodyLabel.Text = "";
            // 
            // NoneBtn
            // 
            this.NoneBtn.BackColor = System.Drawing.Color.Transparent;
            this.NoneBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.NoneBtn.FlatAppearance.BorderSize = 0;
            this.NoneBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.NoneBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.NoneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoneBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoneBtn.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.bgd_08dp;
            this.NoneBtn.Location = new System.Drawing.Point(0, 400);
            this.NoneBtn.Name = "NoneBtn";
            this.NoneBtn.Size = new System.Drawing.Size(50, 50);
            this.NoneBtn.TabIndex = 50;
            this.NoneBtn.Text = "";
            this.NoneBtn.UseVisualStyleBackColor = false;
            this.NoneBtn.Click += new System.EventHandler(this.NoneColourBtn_Click);
            // 
            // MailViewport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FoldersDropDown);
            this.Controls.Add(this.ColourDropDown);
            this.Controls.Add(this.BodyLabel);
            this.Controls.Add(this.HeaderPanel);
            this.Name = "MailViewport";
            this.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.Size = new System.Drawing.Size(820, 688);
            this.BtnTooltip.SetToolTip(this, "Reply");
            this.HeaderPanel.ResumeLayout(false);
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.ActionsPanel.ResumeLayout(false);
            this.ButtonsPanel.ResumeLayout(false);
            this.ColourDropDown.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Panel ActionsPanel;
        private System.Windows.Forms.Panel ButtonsPanel;
        public System.Windows.Forms.Button ColourBtn;
        private System.Windows.Forms.Button ReplyAllBtn;
        private System.Windows.Forms.Button ReplyBtn;
        private System.Windows.Forms.Button ForwardBtn;
        public System.Windows.Forms.Button FlagBtn;
        private System.Windows.Forms.ToolTip BtnTooltip;
        private System.Windows.Forms.Panel ColourDropDown;
        public System.Windows.Forms.Button PurpleBtn;
        public System.Windows.Forms.Button MagentaBtn;
        public System.Windows.Forms.Button RedBtn;
        public System.Windows.Forms.Button OrangeBtn;
        public System.Windows.Forms.Button YellowBtn;
        public System.Windows.Forms.Button GreenBtn;
        public System.Windows.Forms.Button CyanBtn;
        public System.Windows.Forms.Button BlueBtn;
        public System.Windows.Forms.Button DeleteBtn;
        public System.Windows.Forms.Button FolderBtn;
        private System.Windows.Forms.Panel FoldersDropDown;
        public System.Windows.Forms.RichTextBox BodyLabel;
        public System.Windows.Forms.TextBox SenderLabel;
        public System.Windows.Forms.TextBox TitleLabel;
        public System.Windows.Forms.Button NoneBtn;
    }
}

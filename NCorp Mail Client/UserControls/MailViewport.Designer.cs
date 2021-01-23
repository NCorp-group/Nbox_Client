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
            this.BodyLabel = new System.Windows.Forms.Label();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.SenderLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ActionsPanel = new System.Windows.Forms.Panel();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.ColourBtn = new System.Windows.Forms.Button();
            this.ReplyAllBtn = new System.Windows.Forms.Button();
            this.ReplyBtn = new System.Windows.Forms.Button();
            this.ForwardBtn = new System.Windows.Forms.Button();
            this.FlagBtn = new System.Windows.Forms.Button();
            this.HeaderPanel.SuspendLayout();
            this.TitlePanel.SuspendLayout();
            this.ActionsPanel.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BodyLabel
            // 
            this.BodyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BodyLabel.ForeColor = System.Drawing.Color.White;
            this.BodyLabel.Location = new System.Drawing.Point(30, 90);
            this.BodyLabel.Name = "BodyLabel";
            this.BodyLabel.Size = new System.Drawing.Size(760, 598);
            this.BodyLabel.TabIndex = 3;
            this.BodyLabel.Text = "This is the body";
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
            this.TitlePanel.Size = new System.Drawing.Size(510, 70);
            this.TitlePanel.TabIndex = 1;
            // 
            // SenderLabel
            // 
            this.SenderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SenderLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SenderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.SenderLabel.Location = new System.Drawing.Point(0, 40);
            this.SenderLabel.Name = "SenderLabel";
            this.SenderLabel.Size = new System.Drawing.Size(510, 21);
            this.SenderLabel.TabIndex = 2;
            this.SenderLabel.Text = "sender@mail.com";
            // 
            // TitleLabel
            // 
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(0, 10);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(510, 30);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Email Title";
            // 
            // ActionsPanel
            // 
            this.ActionsPanel.Controls.Add(this.ButtonsPanel);
            this.ActionsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ActionsPanel.Location = new System.Drawing.Point(510, 0);
            this.ActionsPanel.Name = "ActionsPanel";
            this.ActionsPanel.Size = new System.Drawing.Size(250, 70);
            this.ActionsPanel.TabIndex = 0;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Controls.Add(this.ColourBtn);
            this.ButtonsPanel.Controls.Add(this.ReplyAllBtn);
            this.ButtonsPanel.Controls.Add(this.ReplyBtn);
            this.ButtonsPanel.Controls.Add(this.ForwardBtn);
            this.ButtonsPanel.Controls.Add(this.FlagBtn);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 0);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(250, 50);
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
            this.ColourBtn.UseVisualStyleBackColor = false;
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
            this.ReplyAllBtn.Location = new System.Drawing.Point(50, 0);
            this.ReplyAllBtn.Name = "ReplyAllBtn";
            this.ReplyAllBtn.Size = new System.Drawing.Size(50, 50);
            this.ReplyAllBtn.TabIndex = 32;
            this.ReplyAllBtn.Text = "";
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
            this.ReplyBtn.Location = new System.Drawing.Point(100, 0);
            this.ReplyBtn.Name = "ReplyBtn";
            this.ReplyBtn.Size = new System.Drawing.Size(50, 50);
            this.ReplyBtn.TabIndex = 31;
            this.ReplyBtn.Text = "";
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
            this.ForwardBtn.Location = new System.Drawing.Point(150, 0);
            this.ForwardBtn.Name = "ForwardBtn";
            this.ForwardBtn.Size = new System.Drawing.Size(50, 50);
            this.ForwardBtn.TabIndex = 30;
            this.ForwardBtn.Text = "";
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
            this.FlagBtn.Location = new System.Drawing.Point(200, 0);
            this.FlagBtn.Name = "FlagBtn";
            this.FlagBtn.Size = new System.Drawing.Size(50, 50);
            this.FlagBtn.TabIndex = 29;
            this.FlagBtn.Text = "";
            this.FlagBtn.UseVisualStyleBackColor = false;
            this.FlagBtn.Click += new System.EventHandler(this.FlagBtn_Click);
            // 
            // MailViewport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BodyLabel);
            this.Controls.Add(this.HeaderPanel);
            this.Name = "MailViewport";
            this.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.Size = new System.Drawing.Size(820, 688);
            this.HeaderPanel.ResumeLayout(false);
            this.TitlePanel.ResumeLayout(false);
            this.ActionsPanel.ResumeLayout(false);
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label BodyLabel;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel TitlePanel;
        public System.Windows.Forms.Label SenderLabel;
        public System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel ActionsPanel;
        private System.Windows.Forms.Panel ButtonsPanel;
        public System.Windows.Forms.Button ColourBtn;
        private System.Windows.Forms.Button ReplyAllBtn;
        private System.Windows.Forms.Button ReplyBtn;
        private System.Windows.Forms.Button ForwardBtn;
        public System.Windows.Forms.Button FlagBtn;
    }
}

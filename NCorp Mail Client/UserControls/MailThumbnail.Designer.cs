using System.ComponentModel;
using System.Windows.Forms;

namespace NCorp_Mail_Client.UserControls
{
    partial class MailThumbnail
    {
        /*
        private Mail mail;

        public Mail GetMail()
        { return mail; }
        public void SetMail(Mail mail)
        { this.mail = mail; }
        */
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.ColourMark = new System.Windows.Forms.Panel();
            this.UnreadMark = new System.Windows.Forms.Panel();
            this.InnerPanel = new System.Windows.Forms.Panel();
            this.BodyPreviewLabel = new System.Windows.Forms.Label();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.SenderLabel = new System.Windows.Forms.Label();
            this.ActionsPanel = new System.Windows.Forms.Panel();
            this.TimestampPanel = new System.Windows.Forms.Panel();
            this.TimestampLabel = new System.Windows.Forms.Label();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.InnerWrapperPanel = new System.Windows.Forms.Panel();
            this.InnerPanel.SuspendLayout();
            this.ActionsPanel.SuspendLayout();
            this.TimestampPanel.SuspendLayout();
            this.InnerWrapperPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ColourMark
            // 
            this.ColourMark.Dock = System.Windows.Forms.DockStyle.Left;
            this.ColourMark.Location = new System.Drawing.Point(0, 5);
            this.ColourMark.Name = "ColourMark";
            this.ColourMark.Size = new System.Drawing.Size(6, 95);
            this.ColourMark.TabIndex = 4;
            this.ColourMark.Click += new System.EventHandler(this.MailThumbnail_Click);
            // 
            // UnreadMark
            // 
            this.UnreadMark.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UnreadMark.Location = new System.Drawing.Point(0, 100);
            this.UnreadMark.Name = "UnreadMark";
            this.UnreadMark.Size = new System.Drawing.Size(1502, 5);
            this.UnreadMark.TabIndex = 3;
            this.UnreadMark.Click += new System.EventHandler(this.MailThumbnail_Click);
            // 
            // InnerPanel
            // 
            this.InnerPanel.Controls.Add(this.BodyPreviewLabel);
            this.InnerPanel.Controls.Add(this.SubjectLabel);
            this.InnerPanel.Controls.Add(this.SenderLabel);
            this.InnerPanel.Controls.Add(this.ActionsPanel);
            this.InnerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InnerPanel.Location = new System.Drawing.Point(26, 0);
            this.InnerPanel.Name = "InnerPanel";
            this.InnerPanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.InnerPanel.Size = new System.Drawing.Size(1440, 95);
            this.InnerPanel.TabIndex = 0;
            this.InnerPanel.Click += new System.EventHandler(this.MailThumbnail_Click);
            // 
            // BodyPreviewLabel
            // 
            this.BodyPreviewLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BodyPreviewLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BodyPreviewLabel.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tdm_24dp;
            this.BodyPreviewLabel.Location = new System.Drawing.Point(0, 56);
            this.BodyPreviewLabel.Name = "BodyPreviewLabel";
            this.BodyPreviewLabel.Size = new System.Drawing.Size(1370, 23);
            this.BodyPreviewLabel.TabIndex = 3;
            this.BodyPreviewLabel.Text = "BodyPeview";
            this.BodyPreviewLabel.Click += new System.EventHandler(this.MailThumbnail_Click);
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubjectLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectLabel.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tds_24dp;
            this.SubjectLabel.Location = new System.Drawing.Point(0, 33);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(1370, 23);
            this.SubjectLabel.TabIndex = 2;
            this.SubjectLabel.Text = "subject";
            this.SubjectLabel.Click += new System.EventHandler(this.MailThumbnail_Click);
            // 
            // SenderLabel
            // 
            this.SenderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SenderLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SenderLabel.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tds_24dp;
            this.SenderLabel.Location = new System.Drawing.Point(0, 10);
            this.SenderLabel.Name = "SenderLabel";
            this.SenderLabel.Size = new System.Drawing.Size(1370, 23);
            this.SenderLabel.TabIndex = 1;
            this.SenderLabel.Text = "sender";
            this.SenderLabel.Click += new System.EventHandler(this.MailThumbnail_Click);
            // 
            // ActionsPanel
            // 
            this.ActionsPanel.Controls.Add(this.TimestampPanel);
            this.ActionsPanel.Controls.Add(this.ButtonsPanel);
            this.ActionsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ActionsPanel.Location = new System.Drawing.Point(1370, 10);
            this.ActionsPanel.Name = "ActionsPanel";
            this.ActionsPanel.Size = new System.Drawing.Size(70, 75);
            this.ActionsPanel.TabIndex = 0;
            // 
            // TimestampPanel
            // 
            this.TimestampPanel.Controls.Add(this.TimestampLabel);
            this.TimestampPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimestampPanel.Location = new System.Drawing.Point(0, 30);
            this.TimestampPanel.Name = "TimestampPanel";
            this.TimestampPanel.Size = new System.Drawing.Size(70, 45);
            this.TimestampPanel.TabIndex = 5;
            this.TimestampLabel.Click += new System.EventHandler(this.MailThumbnail_Click);
            // 
            // TimestampLabel
            // 
            this.TimestampLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TimestampLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimestampLabel.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tdm_24dp;
            this.TimestampLabel.Location = new System.Drawing.Point(0, 0);
            this.TimestampLabel.Name = "TimestampLabel";
            this.TimestampLabel.Size = new System.Drawing.Size(70, 23);
            this.TimestampLabel.TabIndex = 0;
            this.TimestampLabel.Text = "timestamp";
            this.TimestampLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TimestampLabel.Click += new System.EventHandler(this.MailThumbnail_Click);
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 0);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(70, 30);
            this.ButtonsPanel.TabIndex = 4;
            // 
            // InnerWrapperPanel
            // 
            this.InnerWrapperPanel.Controls.Add(this.InnerPanel);
            this.InnerWrapperPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InnerWrapperPanel.Location = new System.Drawing.Point(6, 5);
            this.InnerWrapperPanel.Name = "InnerWrapperPanel";
            this.InnerWrapperPanel.Padding = new System.Windows.Forms.Padding(26, 0, 30, 0);
            this.InnerWrapperPanel.Size = new System.Drawing.Size(1496, 95);
            this.InnerWrapperPanel.TabIndex = 5;
            this.InnerWrapperPanel.Click += new System.EventHandler(this.MailThumbnail_Click);
            // 
            // MailThumbnail
            // 
            this.Controls.Add(this.InnerWrapperPanel);
            this.Controls.Add(this.ColourMark);
            this.Controls.Add(this.UnreadMark);
            this.Name = "MailThumbnail";
            this.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.Size = new System.Drawing.Size(350, 110);
            this.InnerPanel.ResumeLayout(false);
            this.ActionsPanel.ResumeLayout(false);
            this.TimestampPanel.ResumeLayout(false);
            this.InnerWrapperPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Panel ColourMark;

        #endregion

        private Panel UnreadMark;
        private Panel InnerPanel;
        public Label BodyPreviewLabel;
        public Label SubjectLabel;
        private Label SenderLabel;
        private Panel ActionsPanel;
        private Panel TimestampPanel;
        private Label TimestampLabel;
        private Panel ButtonsPanel;
        private Panel InnerWrapperPanel;
    }
}

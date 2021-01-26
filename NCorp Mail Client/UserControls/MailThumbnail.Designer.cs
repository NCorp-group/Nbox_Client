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
            this.InnerWrapperPanel = new System.Windows.Forms.Panel();
            this.DateLabel = new System.Windows.Forms.Label();
            this.TimestampLabel = new System.Windows.Forms.Label();
            this.TimestampPanel = new System.Windows.Forms.Panel();
            this.InnerPanel.SuspendLayout();
            this.ActionsPanel.SuspendLayout();
            this.InnerWrapperPanel.SuspendLayout();
            this.TimestampPanel.SuspendLayout();
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
            this.UnreadMark.Size = new System.Drawing.Size(350, 5);
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
            this.InnerPanel.Size = new System.Drawing.Size(288, 95);
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
            this.BodyPreviewLabel.Size = new System.Drawing.Size(193, 23);
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
            this.SubjectLabel.Size = new System.Drawing.Size(193, 23);
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
            this.SenderLabel.Size = new System.Drawing.Size(193, 23);
            this.SenderLabel.TabIndex = 1;
            this.SenderLabel.Text = "sender";
            this.SenderLabel.Click += new System.EventHandler(this.MailThumbnail_Click);
            // 
            // ActionsPanel
            // 
            this.ActionsPanel.Controls.Add(this.TimestampPanel);
            this.ActionsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ActionsPanel.Location = new System.Drawing.Point(193, 10);
            this.ActionsPanel.Name = "ActionsPanel";
            this.ActionsPanel.Size = new System.Drawing.Size(95, 75);
            this.ActionsPanel.TabIndex = 0;
            // 
            // InnerWrapperPanel
            // 
            this.InnerWrapperPanel.Controls.Add(this.InnerPanel);
            this.InnerWrapperPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InnerWrapperPanel.Location = new System.Drawing.Point(6, 5);
            this.InnerWrapperPanel.Name = "InnerWrapperPanel";
            this.InnerWrapperPanel.Padding = new System.Windows.Forms.Padding(26, 0, 30, 0);
            this.InnerWrapperPanel.Size = new System.Drawing.Size(344, 95);
            this.InnerWrapperPanel.TabIndex = 5;
            this.InnerWrapperPanel.Click += new System.EventHandler(this.MailThumbnail_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tdm_24dp;
            this.DateLabel.Location = new System.Drawing.Point(0, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(95, 23);
            this.DateLabel.TabIndex = 0;
            this.DateLabel.Text = "date";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DateLabel.Click += new System.EventHandler(this.MailThumbnail_Click);
            // 
            // TimestampLabel
            // 
            this.TimestampLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TimestampLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimestampLabel.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tdm_24dp;
            this.TimestampLabel.Location = new System.Drawing.Point(0, 23);
            this.TimestampLabel.Name = "TimestampLabel";
            this.TimestampLabel.Size = new System.Drawing.Size(95, 23);
            this.TimestampLabel.TabIndex = 1;
            this.TimestampLabel.Text = "timestamp";
            this.TimestampLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TimestampPanel
            // 
            this.TimestampPanel.Controls.Add(this.TimestampLabel);
            this.TimestampPanel.Controls.Add(this.DateLabel);
            this.TimestampPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimestampPanel.Location = new System.Drawing.Point(0, 0);
            this.TimestampPanel.Name = "TimestampPanel";
            this.TimestampPanel.Size = new System.Drawing.Size(95, 75);
            this.TimestampPanel.TabIndex = 5;
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
            this.InnerWrapperPanel.ResumeLayout(false);
            this.TimestampPanel.ResumeLayout(false);
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
        private Panel InnerWrapperPanel;
        private Panel TimestampPanel;
        private Label TimestampLabel;
        private Label DateLabel;
    }
}

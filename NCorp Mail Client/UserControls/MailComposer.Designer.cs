namespace NCorp_Mail_Client.UserControls
{
    partial class MailComposer
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
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.SubjectPanel = new System.Windows.Forms.Panel();
            this.SubjectTextBox = new System.Windows.Forms.TextBox();
            this.SubjectLabelPanel = new System.Windows.Forms.Panel();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.SubjectUnderline = new System.Windows.Forms.Panel();
            this.ToPanel = new System.Windows.Forms.Panel();
            this.ToTextBox = new System.Windows.Forms.TextBox();
            this.ToLabelPanel = new System.Windows.Forms.Panel();
            this.ToLabel = new System.Windows.Forms.Label();
            this.ToUnderline = new System.Windows.Forms.Panel();
            this.FromPanel = new System.Windows.Forms.Panel();
            this.FromTextBox = new System.Windows.Forms.TextBox();
            this.FromLabelPanel = new System.Windows.Forms.Panel();
            this.FromLabel = new System.Windows.Forms.Label();
            this.FromUnderline = new System.Windows.Forms.Panel();
            this.ActionsPanel = new System.Windows.Forms.Panel();
            this.DiscardBtn = new System.Windows.Forms.Button();
            this.SendBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.HeaderPanel.SuspendLayout();
            this.SubjectPanel.SuspendLayout();
            this.SubjectLabelPanel.SuspendLayout();
            this.ToPanel.SuspendLayout();
            this.ToLabelPanel.SuspendLayout();
            this.FromPanel.SuspendLayout();
            this.FromLabelPanel.SuspendLayout();
            this.ActionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.SubjectPanel);
            this.HeaderPanel.Controls.Add(this.ToPanel);
            this.HeaderPanel.Controls.Add(this.FromPanel);
            this.HeaderPanel.Controls.Add(this.ActionsPanel);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(30, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(760, 180);
            this.HeaderPanel.TabIndex = 0;
            // 
            // SubjectPanel
            // 
            this.SubjectPanel.Controls.Add(this.SubjectTextBox);
            this.SubjectPanel.Controls.Add(this.SubjectLabelPanel);
            this.SubjectPanel.Controls.Add(this.SubjectUnderline);
            this.SubjectPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubjectPanel.Location = new System.Drawing.Point(0, 124);
            this.SubjectPanel.Name = "SubjectPanel";
            this.SubjectPanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.SubjectPanel.Size = new System.Drawing.Size(760, 42);
            this.SubjectPanel.TabIndex = 5;
            // 
            // SubjectTextBox
            // 
            this.SubjectTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.SubjectTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SubjectTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubjectTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectTextBox.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tds_00dp;
            this.SubjectTextBox.Location = new System.Drawing.Point(100, 10);
            this.SubjectTextBox.Name = "SubjectTextBox";
            this.SubjectTextBox.Size = new System.Drawing.Size(660, 22);
            this.SubjectTextBox.TabIndex = 7;
            // 
            // SubjectLabelPanel
            // 
            this.SubjectLabelPanel.Controls.Add(this.SubjectLabel);
            this.SubjectLabelPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SubjectLabelPanel.Location = new System.Drawing.Point(0, 10);
            this.SubjectLabelPanel.Name = "SubjectLabelPanel";
            this.SubjectLabelPanel.Size = new System.Drawing.Size(100, 28);
            this.SubjectLabelPanel.TabIndex = 6;
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubjectLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectLabel.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tds_00dp;
            this.SubjectLabel.Location = new System.Drawing.Point(0, 0);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(100, 28);
            this.SubjectLabel.TabIndex = 2;
            this.SubjectLabel.Text = "Subject:";
            // 
            // SubjectUnderline
            // 
            this.SubjectUnderline.BackColor = global::NCorp_Mail_Client.Properties.Settings.Default.bgd_02dp;
            this.SubjectUnderline.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SubjectUnderline.Location = new System.Drawing.Point(0, 38);
            this.SubjectUnderline.Name = "SubjectUnderline";
            this.SubjectUnderline.Size = new System.Drawing.Size(760, 4);
            this.SubjectUnderline.TabIndex = 5;
            // 
            // ToPanel
            // 
            this.ToPanel.Controls.Add(this.ToTextBox);
            this.ToPanel.Controls.Add(this.ToLabelPanel);
            this.ToPanel.Controls.Add(this.ToUnderline);
            this.ToPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToPanel.Location = new System.Drawing.Point(0, 82);
            this.ToPanel.Name = "ToPanel";
            this.ToPanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.ToPanel.Size = new System.Drawing.Size(760, 42);
            this.ToPanel.TabIndex = 4;
            // 
            // ToTextBox
            // 
            this.ToTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.ToTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ToTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToTextBox.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tds_00dp;
            this.ToTextBox.Location = new System.Drawing.Point(100, 10);
            this.ToTextBox.Name = "ToTextBox";
            this.ToTextBox.Size = new System.Drawing.Size(660, 22);
            this.ToTextBox.TabIndex = 7;
            // 
            // ToLabelPanel
            // 
            this.ToLabelPanel.Controls.Add(this.ToLabel);
            this.ToLabelPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ToLabelPanel.Location = new System.Drawing.Point(0, 10);
            this.ToLabelPanel.Name = "ToLabelPanel";
            this.ToLabelPanel.Size = new System.Drawing.Size(100, 28);
            this.ToLabelPanel.TabIndex = 6;
            // 
            // ToLabel
            // 
            this.ToLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToLabel.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tds_00dp;
            this.ToLabel.Location = new System.Drawing.Point(0, 0);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(100, 28);
            this.ToLabel.TabIndex = 2;
            this.ToLabel.Text = "To:";
            // 
            // ToUnderline
            // 
            this.ToUnderline.BackColor = global::NCorp_Mail_Client.Properties.Settings.Default.bgd_02dp;
            this.ToUnderline.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToUnderline.Location = new System.Drawing.Point(0, 38);
            this.ToUnderline.Name = "ToUnderline";
            this.ToUnderline.Size = new System.Drawing.Size(760, 4);
            this.ToUnderline.TabIndex = 5;
            // 
            // FromPanel
            // 
            this.FromPanel.Controls.Add(this.FromTextBox);
            this.FromPanel.Controls.Add(this.FromLabelPanel);
            this.FromPanel.Controls.Add(this.FromUnderline);
            this.FromPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FromPanel.Location = new System.Drawing.Point(0, 40);
            this.FromPanel.Name = "FromPanel";
            this.FromPanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.FromPanel.Size = new System.Drawing.Size(760, 42);
            this.FromPanel.TabIndex = 3;
            // 
            // FromTextBox
            // 
            this.FromTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.FromTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FromTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FromTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromTextBox.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tds_00dp;
            this.FromTextBox.Location = new System.Drawing.Point(100, 10);
            this.FromTextBox.Name = "FromTextBox";
            this.FromTextBox.Size = new System.Drawing.Size(660, 22);
            this.FromTextBox.TabIndex = 7;
            // 
            // FromLabelPanel
            // 
            this.FromLabelPanel.Controls.Add(this.FromLabel);
            this.FromLabelPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.FromLabelPanel.Location = new System.Drawing.Point(0, 10);
            this.FromLabelPanel.Name = "FromLabelPanel";
            this.FromLabelPanel.Size = new System.Drawing.Size(100, 28);
            this.FromLabelPanel.TabIndex = 6;
            // 
            // FromLabel
            // 
            this.FromLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FromLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromLabel.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tds_00dp;
            this.FromLabel.Location = new System.Drawing.Point(0, 0);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(100, 28);
            this.FromLabel.TabIndex = 1;
            this.FromLabel.Text = "From:";
            // 
            // FromUnderline
            // 
            this.FromUnderline.BackColor = global::NCorp_Mail_Client.Properties.Settings.Default.bgd_02dp;
            this.FromUnderline.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FromUnderline.Location = new System.Drawing.Point(0, 38);
            this.FromUnderline.Name = "FromUnderline";
            this.FromUnderline.Size = new System.Drawing.Size(760, 4);
            this.FromUnderline.TabIndex = 5;
            // 
            // ActionsPanel
            // 
            this.ActionsPanel.Controls.Add(this.DiscardBtn);
            this.ActionsPanel.Controls.Add(this.SendBtn);
            this.ActionsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ActionsPanel.Location = new System.Drawing.Point(0, 0);
            this.ActionsPanel.Name = "ActionsPanel";
            this.ActionsPanel.Size = new System.Drawing.Size(760, 40);
            this.ActionsPanel.TabIndex = 1;
            // 
            // DiscardBtn
            // 
            this.DiscardBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.DiscardBtn.FlatAppearance.BorderSize = 0;
            this.DiscardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DiscardBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscardBtn.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tds_00dp;
            this.DiscardBtn.Location = new System.Drawing.Point(680, 0);
            this.DiscardBtn.Name = "DiscardBtn";
            this.DiscardBtn.Size = new System.Drawing.Size(40, 40);
            this.DiscardBtn.TabIndex = 1;
            this.DiscardBtn.Text = "";
            this.DiscardBtn.UseVisualStyleBackColor = true;
            // 
            // SendBtn
            // 
            this.SendBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.SendBtn.FlatAppearance.BorderSize = 0;
            this.SendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendBtn.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tds_00dp;
            this.SendBtn.Location = new System.Drawing.Point(720, 0);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(40, 40);
            this.SendBtn.TabIndex = 0;
            this.SendBtn.Text = "";
            this.SendBtn.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = global::NCorp_Mail_Client.Properties.Settings.Default.tds_00dp;
            this.richTextBox1.Location = new System.Drawing.Point(30, 180);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(760, 508);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // MailComposer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.HeaderPanel);
            this.Name = "MailComposer";
            this.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.Size = new System.Drawing.Size(820, 688);
            this.HeaderPanel.ResumeLayout(false);
            this.SubjectPanel.ResumeLayout(false);
            this.SubjectPanel.PerformLayout();
            this.SubjectLabelPanel.ResumeLayout(false);
            this.ToPanel.ResumeLayout(false);
            this.ToPanel.PerformLayout();
            this.ToLabelPanel.ResumeLayout(false);
            this.FromPanel.ResumeLayout(false);
            this.FromPanel.PerformLayout();
            this.FromLabelPanel.ResumeLayout(false);
            this.ActionsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel HeaderPanel;
        public System.Windows.Forms.Panel FromPanel;
        public System.Windows.Forms.Panel FromUnderline;
        public System.Windows.Forms.Panel ActionsPanel;
        public System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.Panel SubjectPanel;
        public System.Windows.Forms.TextBox SubjectTextBox;
        public System.Windows.Forms.Panel SubjectLabelPanel;
        public System.Windows.Forms.Label SubjectLabel;
        public System.Windows.Forms.Panel SubjectUnderline;
        public System.Windows.Forms.Panel ToPanel;
        public System.Windows.Forms.TextBox ToTextBox;
        public System.Windows.Forms.Panel ToLabelPanel;
        public System.Windows.Forms.Label ToLabel;
        public System.Windows.Forms.Panel ToUnderline;
        public System.Windows.Forms.TextBox FromTextBox;
        public System.Windows.Forms.Panel FromLabelPanel;
        public System.Windows.Forms.Label FromLabel;
        public System.Windows.Forms.Button DiscardBtn;
        public System.Windows.Forms.Button SendBtn;
    }
}

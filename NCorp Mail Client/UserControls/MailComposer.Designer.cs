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
            this.components = new System.ComponentModel.Container();
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
            this.DraftBtn = new System.Windows.Forms.Button();
            this.DiscardBtn = new System.Windows.Forms.Button();
            this.SendBtn = new System.Windows.Forms.Button();
            this.BodyTextBox = new System.Windows.Forms.RichTextBox();
            this.ComposerToolTip = new System.Windows.Forms.ToolTip(this.components);
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
            this.HeaderPanel.Location = new System.Drawing.Point(45, 0);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1140, 277);
            this.HeaderPanel.TabIndex = 0;
            // 
            // SubjectPanel
            // 
            this.SubjectPanel.Controls.Add(this.SubjectTextBox);
            this.SubjectPanel.Controls.Add(this.SubjectLabelPanel);
            this.SubjectPanel.Controls.Add(this.SubjectUnderline);
            this.SubjectPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubjectPanel.Location = new System.Drawing.Point(0, 192);
            this.SubjectPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubjectPanel.Name = "SubjectPanel";
            this.SubjectPanel.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.SubjectPanel.Size = new System.Drawing.Size(1140, 65);
            this.SubjectPanel.TabIndex = 5;
            // 
            // SubjectTextBox
            // 
            this.SubjectTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(29)))));
            this.SubjectTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SubjectTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubjectTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(226)))));
            this.SubjectTextBox.Location = new System.Drawing.Point(105, 15);
            this.SubjectTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubjectTextBox.Name = "SubjectTextBox";
            this.SubjectTextBox.Size = new System.Drawing.Size(1035, 32);
            this.SubjectTextBox.TabIndex = 7;
            // 
            // SubjectLabelPanel
            // 
            this.SubjectLabelPanel.Controls.Add(this.SubjectLabel);
            this.SubjectLabelPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SubjectLabelPanel.Location = new System.Drawing.Point(0, 15);
            this.SubjectLabelPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubjectLabelPanel.Name = "SubjectLabelPanel";
            this.SubjectLabelPanel.Size = new System.Drawing.Size(105, 44);
            this.SubjectLabelPanel.TabIndex = 6;
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubjectLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(226)))));
            this.SubjectLabel.Location = new System.Drawing.Point(0, 0);
            this.SubjectLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(105, 44);
            this.SubjectLabel.TabIndex = 4;
            this.SubjectLabel.Text = "Subject:";
            // 
            // SubjectUnderline
            // 
            this.SubjectUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.SubjectUnderline.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SubjectUnderline.Location = new System.Drawing.Point(0, 59);
            this.SubjectUnderline.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubjectUnderline.Name = "SubjectUnderline";
            this.SubjectUnderline.Size = new System.Drawing.Size(1140, 6);
            this.SubjectUnderline.TabIndex = 5;
            // 
            // ToPanel
            // 
            this.ToPanel.Controls.Add(this.ToTextBox);
            this.ToPanel.Controls.Add(this.ToLabelPanel);
            this.ToPanel.Controls.Add(this.ToUnderline);
            this.ToPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToPanel.Location = new System.Drawing.Point(0, 127);
            this.ToPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ToPanel.Name = "ToPanel";
            this.ToPanel.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.ToPanel.Size = new System.Drawing.Size(1140, 65);
            this.ToPanel.TabIndex = 4;
            // 
            // ToTextBox
            // 
            this.ToTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(29)))));
            this.ToTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ToTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(226)))));
            this.ToTextBox.Location = new System.Drawing.Point(105, 15);
            this.ToTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ToTextBox.Name = "ToTextBox";
            this.ToTextBox.Size = new System.Drawing.Size(1035, 32);
            this.ToTextBox.TabIndex = 7;
            // 
            // ToLabelPanel
            // 
            this.ToLabelPanel.Controls.Add(this.ToLabel);
            this.ToLabelPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ToLabelPanel.Location = new System.Drawing.Point(0, 15);
            this.ToLabelPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ToLabelPanel.Name = "ToLabelPanel";
            this.ToLabelPanel.Size = new System.Drawing.Size(105, 44);
            this.ToLabelPanel.TabIndex = 6;
            // 
            // ToLabel
            // 
            this.ToLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(226)))));
            this.ToLabel.Location = new System.Drawing.Point(0, 0);
            this.ToLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(105, 44);
            this.ToLabel.TabIndex = 4;
            this.ToLabel.Text = "To:";
            // 
            // ToUnderline
            // 
            this.ToUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.ToUnderline.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToUnderline.Location = new System.Drawing.Point(0, 59);
            this.ToUnderline.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ToUnderline.Name = "ToUnderline";
            this.ToUnderline.Size = new System.Drawing.Size(1140, 6);
            this.ToUnderline.TabIndex = 5;
            // 
            // FromPanel
            // 
            this.FromPanel.Controls.Add(this.FromTextBox);
            this.FromPanel.Controls.Add(this.FromLabelPanel);
            this.FromPanel.Controls.Add(this.FromUnderline);
            this.FromPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FromPanel.Location = new System.Drawing.Point(0, 62);
            this.FromPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FromPanel.Name = "FromPanel";
            this.FromPanel.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.FromPanel.Size = new System.Drawing.Size(1140, 65);
            this.FromPanel.TabIndex = 3;
            // 
            // FromTextBox
            // 
            this.FromTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(29)))));
            this.FromTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FromTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FromTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(226)))));
            this.FromTextBox.Location = new System.Drawing.Point(105, 15);
            this.FromTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FromTextBox.Name = "FromTextBox";
            this.FromTextBox.ReadOnly = true;
            this.FromTextBox.Size = new System.Drawing.Size(1035, 32);
            this.FromTextBox.TabIndex = 7;
            // 
            // FromLabelPanel
            // 
            this.FromLabelPanel.Controls.Add(this.FromLabel);
            this.FromLabelPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.FromLabelPanel.Location = new System.Drawing.Point(0, 15);
            this.FromLabelPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FromLabelPanel.Name = "FromLabelPanel";
            this.FromLabelPanel.Size = new System.Drawing.Size(105, 44);
            this.FromLabelPanel.TabIndex = 6;
            // 
            // FromLabel
            // 
            this.FromLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FromLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(226)))));
            this.FromLabel.Location = new System.Drawing.Point(0, 0);
            this.FromLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(105, 44);
            this.FromLabel.TabIndex = 3;
            this.FromLabel.Text = "From:";
            // 
            // FromUnderline
            // 
            this.FromUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.FromUnderline.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FromUnderline.Location = new System.Drawing.Point(0, 59);
            this.FromUnderline.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FromUnderline.Name = "FromUnderline";
            this.FromUnderline.Size = new System.Drawing.Size(1140, 6);
            this.FromUnderline.TabIndex = 5;
            // 
            // ActionsPanel
            // 
            this.ActionsPanel.Controls.Add(this.DraftBtn);
            this.ActionsPanel.Controls.Add(this.DiscardBtn);
            this.ActionsPanel.Controls.Add(this.SendBtn);
            this.ActionsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ActionsPanel.Location = new System.Drawing.Point(0, 0);
            this.ActionsPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ActionsPanel.Name = "ActionsPanel";
            this.ActionsPanel.Size = new System.Drawing.Size(1140, 62);
            this.ActionsPanel.TabIndex = 1;
            // 
            // DraftBtn
            // 
            this.DraftBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.DraftBtn.FlatAppearance.BorderSize = 0;
            this.DraftBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.DraftBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.DraftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DraftBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DraftBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(226)))));
            this.DraftBtn.Location = new System.Drawing.Point(960, 0);
            this.DraftBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DraftBtn.Name = "DraftBtn";
            this.DraftBtn.Size = new System.Drawing.Size(60, 62);
            this.DraftBtn.TabIndex = 2;
            this.DraftBtn.Text = "";
            this.ComposerToolTip.SetToolTip(this.DraftBtn, "Save as draft");
            this.DraftBtn.UseVisualStyleBackColor = true;
            this.DraftBtn.Click += new System.EventHandler(this.DraftBtn_Click);
            // 
            // DiscardBtn
            // 
            this.DiscardBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.DiscardBtn.FlatAppearance.BorderSize = 0;
            this.DiscardBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.DiscardBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.DiscardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DiscardBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscardBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(226)))));
            this.DiscardBtn.Location = new System.Drawing.Point(1020, 0);
            this.DiscardBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DiscardBtn.Name = "DiscardBtn";
            this.DiscardBtn.Size = new System.Drawing.Size(60, 62);
            this.DiscardBtn.TabIndex = 1;
            this.DiscardBtn.Text = "";
            this.ComposerToolTip.SetToolTip(this.DiscardBtn, "Discard");
            this.DiscardBtn.UseVisualStyleBackColor = true;
            this.DiscardBtn.Click += new System.EventHandler(this.DiscardBtn_Click);
            // 
            // SendBtn
            // 
            this.SendBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.SendBtn.FlatAppearance.BorderSize = 0;
            this.SendBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.SendBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.SendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(226)))));
            this.SendBtn.Location = new System.Drawing.Point(1080, 0);
            this.SendBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(60, 62);
            this.SendBtn.TabIndex = 0;
            this.SendBtn.Text = "";
            this.ComposerToolTip.SetToolTip(this.SendBtn, "Send");
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // BodyTextBox
            // 
            this.BodyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(29)))));
            this.BodyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BodyTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BodyTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(226)))));
            this.BodyTextBox.Location = new System.Drawing.Point(45, 277);
            this.BodyTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BodyTextBox.Name = "BodyTextBox";
            this.BodyTextBox.Size = new System.Drawing.Size(1140, 781);
            this.BodyTextBox.TabIndex = 1;
            this.BodyTextBox.Text = "";
            // 
            // MailComposer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BodyTextBox);
            this.Controls.Add(this.HeaderPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MailComposer";
            this.Padding = new System.Windows.Forms.Padding(45, 0, 45, 0);
            this.Size = new System.Drawing.Size(1230, 1058);
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
        public System.Windows.Forms.RichTextBox BodyTextBox;
        public System.Windows.Forms.Panel SubjectPanel;
        public System.Windows.Forms.TextBox SubjectTextBox;
        public System.Windows.Forms.Panel SubjectLabelPanel;
        public System.Windows.Forms.Panel SubjectUnderline;
        public System.Windows.Forms.Panel ToPanel;
        public System.Windows.Forms.TextBox ToTextBox;
        public System.Windows.Forms.Panel ToLabelPanel;
        public System.Windows.Forms.Panel ToUnderline;
        public System.Windows.Forms.TextBox FromTextBox;
        public System.Windows.Forms.Panel FromLabelPanel;
        public System.Windows.Forms.Button DiscardBtn;
        public System.Windows.Forms.Button SendBtn;
        public System.Windows.Forms.Label SubjectLabel;
        public System.Windows.Forms.Label ToLabel;
        public System.Windows.Forms.Label FromLabel;
        public System.Windows.Forms.Button DraftBtn;
        private System.Windows.Forms.ToolTip ComposerToolTip;
    }
}

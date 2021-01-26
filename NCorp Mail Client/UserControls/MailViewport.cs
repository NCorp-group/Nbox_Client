using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCorp_Mail_Client.UserControls
{
    public partial class MailViewport : UserControl
    {
        private EmailClient client;
        private MailThumbnail thumbnail;

        private bool colourDropDownExpanded = false;
        private bool foldersDropDownExpanded = false;
        public MailViewport(EmailClient client, MailThumbnail thumbnail)
        {
            openColourDropTimer.Interval = 10;
            openColourDropTimer.Tick += new EventHandler(openColourDropTimer_Tick);
            closeColourDropTimer.Interval = 10;
            closeColourDropTimer.Tick += new EventHandler(closeColourDropTimer_Tick);

            openFoldersDropTimer.Interval = 10;
            openFoldersDropTimer.Tick += new EventHandler(openFoldersDropTimer_Tick);
            closeFoldersDropTimer.Interval = 10;
            closeFoldersDropTimer.Tick += new EventHandler(closeFoldersDropTimer_Tick);

            InitializeComponent();
            this.client = client;
            this.thumbnail = thumbnail;
        }

        private void ReplyBtn_Click(object sender, EventArgs e)
        {
            client.ComposeMail(EmailClient.ComposeType.Reply);
        }

        private void ReplyAllBtn_Click(object sender, EventArgs e)
        {
            client.ComposeMail(EmailClient.ComposeType.ReplyAll);
        }

        private void ForwardBtn_Click(object sender, EventArgs e)
        {
            client.ComposeMail(EmailClient.ComposeType.Forward);
        }

        private void FlagBtn_Click(object sender, EventArgs e)
        {
            if (!client.currentUser.folders.Any(folder => folder == "Spam"))
            {
                client.currentUser.folders.Add("Spam");
                client.ShowFolders();
                if (client.foldersExpanded)
                {
                    client.openFoldersTimer.Start();
                }
            }
            var mail = client.currentMail;
            if (mail.metadata.folder == "Spam")
            {
                mail.metadata.folder = "Inbox";
                FlagBtn.Text = client.currentMail.GetFlagIcon();
                //client.currentFolder = "Spam";
                client.ShowMails();
                client.MVPWrapperPanel.Controls.Clear();
            }
            else
            {
                mail.metadata.folder = "Spam";
                FlagBtn.Text = client.currentMail.GetFlagIcon();
                client.ShowMails();
                client.MVPWrapperPanel.Controls.Clear();
            }
        }

        Timer openColourDropTimer = new Timer();
        Timer closeColourDropTimer = new Timer();

        private void openColourDropTimer_Tick(object sender, EventArgs e)
        {
            if (this.ColourDropDown.Height >= 400)
            {
                this.openColourDropTimer.Stop();
            }
            else
            {
                this.ColourDropDown.Height += 25;
            }
        }
        private void closeColourDropTimer_Tick(object sender, EventArgs e)
        {
            if (this.ColourDropDown.Height <= 0)
            {
                this.closeColourDropTimer.Stop();
                this.ColourBtn.BackColor = Properties.Settings.Default.bgd_00dp;
            }
            else
            {
                this.ColourDropDown.Height -= 25;
            }
        }

        private void ExpandColourDropDown()
        {
            if (foldersDropDownExpanded)
            {
                this.ExpandFoldersDropDown();
            }
            if (openColourDropTimer.Enabled)
            {
                openColourDropTimer.Stop();
            }
            if (closeColourDropTimer.Enabled)
            {
                closeColourDropTimer.Stop();
            }

            if (colourDropDownExpanded)
            {
                closeColourDropTimer.Start();
            }
            else
            {
                openColourDropTimer.Start();
                this.ColourBtn.BackColor = Properties.Settings.Default.bgd_02dp;
            }
            colourDropDownExpanded = !colourDropDownExpanded;
        }

        private void ColourBtn_Click(object sender, EventArgs e)
        {
            this.ExpandColourDropDown();
        }

        private void BlueColourBtn_Click(object sender, EventArgs e)
        {
            this.ExpandColourDropDown();
            client.currentMail.metadata.colour = "blue";
            client.MarkColour(client.currentMail);
            this.ColourBtn.ForeColor = client.currentMail.GetColour();
            this.thumbnail.CheckColour();
        }
        private void CyanColourBtn_Click(object sender, EventArgs e)
        {
            this.ExpandColourDropDown();
            client.currentMail.metadata.colour = "cyan";
            client.MarkColour(client.currentMail);
            this.ColourBtn.ForeColor = client.currentMail.GetColour();
            this.thumbnail.CheckColour();
        }
        private void GreenColourBtn_Click(object sender, EventArgs e)
        {
            this.ExpandColourDropDown();
            client.currentMail.metadata.colour = "green";
            client.MarkColour(client.currentMail);
            this.ColourBtn.ForeColor = client.currentMail.GetColour();
            this.thumbnail.CheckColour();
        }
        private void YellowColourBtn_Click(object sender, EventArgs e)
        {
            this.ExpandColourDropDown();
            client.currentMail.metadata.colour = "yellow";
            client.MarkColour(client.currentMail);
            this.ColourBtn.ForeColor = client.currentMail.GetColour();
            this.thumbnail.CheckColour();
        }
        private void OrangeColourBtn_Click(object sender, EventArgs e)
        {
            this.ExpandColourDropDown();
            client.currentMail.metadata.colour = "orange";
            client.MarkColour(client.currentMail);
            this.ColourBtn.ForeColor = client.currentMail.GetColour();
            this.thumbnail.CheckColour();
        }
        private void RedColourBtn_Click(object sender, EventArgs e)
        {
            this.ExpandColourDropDown();
            client.currentMail.metadata.colour = "red";
            client.MarkColour(client.currentMail);
            this.ColourBtn.ForeColor = client.currentMail.GetColour();
            this.thumbnail.CheckColour();
        }
        private void MagentaColourBtn_Click(object sender, EventArgs e)
        {
            this.ExpandColourDropDown();
            client.currentMail.metadata.colour = "magenta";
            client.MarkColour(client.currentMail);
            this.ColourBtn.ForeColor = client.currentMail.GetColour();
            this.thumbnail.CheckColour();
        }
        private void PurpleColourBtn_Click(object sender, EventArgs e)
        {
            this.ExpandColourDropDown();
            client.currentMail.metadata.colour = "purple";
            client.MarkColour(client.currentMail);
            this.ColourBtn.ForeColor = client.currentMail.GetColour();
            this.thumbnail.CheckColour();
        }

        private void DeleBtn_Click(object sender, EventArgs e)
        {
            client.currentMail.metadata.deleted = true;
            client.currentUser.mails.Remove(client.currentMail);
            
            client.DeleteMail(this.client.currentMail);

            client.MVPWrapperPanel.Controls.Clear();
            client.UpdateUserFile();

            client.ShowMails();
            this.Dispose();
        }

        Timer openFoldersDropTimer = new Timer();
        Timer closeFoldersDropTimer = new Timer();

        private void openFoldersDropTimer_Tick(object sender, EventArgs e)
        {
            if (this.FoldersDropDown.Height >= this.foldersDropHeight)
            {
                this.openFoldersDropTimer.Stop();
            }
            else
            {
                this.FoldersDropDown.Height += 20;
            }
        }
        private void closeFoldersDropTimer_Tick(object sender, EventArgs e)
        {
            if (this.FoldersDropDown.Height <= 0)
            {
                this.closeFoldersDropTimer.Stop();
                this.FolderBtn.BackColor = Properties.Settings.Default.bgd_00dp;
            }
            else
            {
                this.FoldersDropDown.Height -= 20;
            }
        }

        private void ExpandFoldersDropDown()
        {
            if (colourDropDownExpanded)
            {
                this.ExpandColourDropDown();
            }
            if (openFoldersDropTimer.Enabled)
            {
                openFoldersDropTimer.Stop();
            }
            if (closeFoldersDropTimer.Enabled)
            {
                closeFoldersDropTimer.Stop();
            }

            if (foldersDropDownExpanded)
            {
                closeFoldersDropTimer.Start();
            }
            else
            {
                openFoldersDropTimer.Start();
                this.FolderBtn.BackColor = Properties.Settings.Default.bgd_02dp;
            }
            foldersDropDownExpanded = !foldersDropDownExpanded;
        }

        private void ChangeFolder_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            string folder = btn.Text;

            client.currentMail.metadata.folder = folder;
            client.currentFolder = folder;
            client.ShowMails();
            client.UpdateUserFile();
            client.ChangeFolder(client.currentFolder, this.client.currentMail);
        }

        private int foldersDropHeight = 0;

        private void FolderBtn_Click(object sender, EventArgs e)
        {
            if (!client.currentUser.folders.Any())
            {
                return;
            }
            foreach (string folder in client.currentUser.folders)
            {
                var btn = new Button()
                {
                    Name = folder + "MVPBtn",
                    Text = folder,
                    Dock = DockStyle.Top,
                    FlatStyle = FlatStyle.Flat,
                    TextAlign = ContentAlignment.MiddleLeft,
                    ForeColor = Properties.Settings.Default.tds_02dp,
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                    Size = new Size(100, 40)
                };
                btn.FlatAppearance.MouseOverBackColor = Properties.Settings.Default.bgd_06dp;
                btn.FlatAppearance.MouseDownBackColor = Properties.Settings.Default.bgd_01dp;
                btn.FlatAppearance.BorderSize = 0;
                btn.Click += new System.EventHandler(ChangeFolder_Click);

                this.FoldersDropDown.Controls.Add(btn);
            }
            this.foldersDropHeight = client.currentUser.folders.Count * 40;
            this.ExpandFoldersDropDown();
        }
    }
}
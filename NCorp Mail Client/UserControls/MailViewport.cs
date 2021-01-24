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

        private bool dropDownExpanded = false;
        public MailViewport(EmailClient client, MailThumbnail thumbnail)
        {
            openDropTimer.Interval = 10;
            openDropTimer.Tick += new EventHandler(openDropTimer_Tick);
            closeDropTimer.Interval = 10;
            closeDropTimer.Tick += new EventHandler(closeDropTimer_Tick);

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
                client.ShowMails("Spam");
                client.MVPWrapperPanel.Controls.Clear();
            }
            else
            {
                mail.metadata.folder = "Spam";
                FlagBtn.Text = client.currentMail.GetFlagIcon();
                client.ShowMails("Inbox");
                client.MVPWrapperPanel.Controls.Clear();
            }
        }

        Timer openDropTimer = new Timer();
        Timer closeDropTimer = new Timer();

        private void openDropTimer_Tick(object sender, EventArgs e)
        {
            if (this.ColourDropDown.Height >= 400)
            {
                this.openDropTimer.Stop();
            }
            else
            {
                this.ColourDropDown.Height += 25;
            }
        }
        private void closeDropTimer_Tick(object sender, EventArgs e)
        {
            if (this.ColourDropDown.Height <= 0)
            {
                this.closeDropTimer.Stop();
            }
            else
            {
                this.ColourDropDown.Height -= 25;
            }
        }

        private void ExpandDropDown()
        {
            if (openDropTimer.Enabled)
            {
                openDropTimer.Stop();
            }
            if (closeDropTimer.Enabled)
            {
                closeDropTimer.Stop();
            }

            if (dropDownExpanded)
            {
                closeDropTimer.Start();
            }
            else
            {
                openDropTimer.Start();
            }
            dropDownExpanded = !dropDownExpanded;
        }

        private void ColourBtn_Click(object sender, EventArgs e)
        {
            this.ExpandDropDown();
        }

        private void BlueColourBtn_Click(object sender, EventArgs e)
        {
            this.ExpandDropDown();
            client.currentMail.metadata.colour = "blue";
            this.ColourBtn.ForeColor = client.currentMail.GetColour();
            this.thumbnail.CheckColour();
        }
        private void CyanColourBtn_Click(object sender, EventArgs e)
        {
            this.ExpandDropDown();
            client.currentMail.metadata.colour = "cyan";
            this.ColourBtn.ForeColor = client.currentMail.GetColour();
            this.thumbnail.CheckColour();
        }
        private void GreenColourBtn_Click(object sender, EventArgs e)
        {
            this.ExpandDropDown();
            client.currentMail.metadata.colour = "green";
            this.ColourBtn.ForeColor = client.currentMail.GetColour();
            this.thumbnail.CheckColour();
        }
        private void YellowColourBtn_Click(object sender, EventArgs e)
        {
            this.ExpandDropDown();
            client.currentMail.metadata.colour = "yellow";
            this.ColourBtn.ForeColor = client.currentMail.GetColour();
            this.thumbnail.CheckColour();
        }
        private void OrangeColourBtn_Click(object sender, EventArgs e)
        {
            this.ExpandDropDown();
            client.currentMail.metadata.colour = "orange";
            this.ColourBtn.ForeColor = client.currentMail.GetColour();
            this.thumbnail.CheckColour();
        }
        private void RedColourBtn_Click(object sender, EventArgs e)
        {
            this.ExpandDropDown();
            client.currentMail.metadata.colour = "red";
            this.ColourBtn.ForeColor = client.currentMail.GetColour();
            this.thumbnail.CheckColour();
        }
        private void MagentaColourBtn_Click(object sender, EventArgs e)
        {
            this.ExpandDropDown();
            client.currentMail.metadata.colour = "magenta";
            this.ColourBtn.ForeColor = client.currentMail.GetColour();
            this.thumbnail.CheckColour();
        }
        private void PurpleColourBtn_Click(object sender, EventArgs e)
        {
            this.ExpandDropDown();
            client.currentMail.metadata.colour = "purple";
            this.ColourBtn.ForeColor = client.currentMail.GetColour();
            this.thumbnail.CheckColour();
        }

        private void DeleBtn_Click(object sender, EventArgs e)
        {
            client.currentMail.metadata.deleted = true;
            client.MVPWrapperPanel.Controls.Clear();
            client.ShowMails(null);
            this.Dispose();
        }
    }
}

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

        private bool dropDownExpanded = false;
        public MailViewport(EmailClient client)
        {
            openDropTimer.Interval = 10;
            openDropTimer.Tick += new EventHandler(openDropTimer_Tick);
            closeDropTimer.Interval = 10;
            closeDropTimer.Tick += new EventHandler(closeDropTimer_Tick);

            InitializeComponent();
            this.client = client;
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
            if (dropDownExpanded)
            {
                this.ExpandDropDown();
            }
            else
            {
                this.ExpandDropDown();
            }
        }
    }
}

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
        public Control viewportWrapper { get; set; }
        private EmailClient client;
        public MailViewport(EmailClient client)
        {
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
    }
}

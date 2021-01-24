using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace NCorp_Mail_Client.UserControls
{
    public partial class MailComposer : UserControl
    {
        private TCPHandler TCPconnection { get; set; }
        private EmailClient client;
        public MailComposer(TCPHandler TCPH, EmailClient client)
        {
            InitializeComponent();
            TCPconnection = TCPH;
            this.client = client;
        }
        public void SaveAsDraft()
        {
            if (!client.currentUser.folders.Any(folder => folder == "Drafts"))
            {
                client.currentUser.folders.Add("Drafts");
                client.ShowFolders();
                if (client.foldersExpanded)
                {
                    client.openFoldersTimer.Start();
                }
            }
            string newToString = this.ToTextBox.Text;

            List<string> newToList = client.ToList(newToString);

            string newFrom = this.FromTextBox.Text;
            string newSubject = this.SubjectTextBox.Text;
            string newBody = this.BodyTextBox.Text;

            Mail newDraft = new Mail()
            {
                from = newFrom,
                to = newToList,
                subject = newSubject,
                body = newBody,
                metadata = new Mail.Metadata("Drafts", "none", true)
            };
            this.client.currentUser.mails.Add(newDraft);
        }
        private void SendBtn_Click(object sender, EventArgs e)
        {
            string from = FromTextBox.Text;
            string to = ToTextBox.Text;
            string subject = SubjectTextBox.Text;
            string body = BodyTextBox.Text;

            var mail = new Mail
            {
                to = new List<string> { to },
                from = client.currentUser.username,
                subject = subject,
                body = body,
            };

            string mailJsonString = JsonConvert.SerializeObject(mail);

            NMAPRequest mailMessage = new NMAPRequest("send_mails", new List<String>(),  new List<String> { mailJsonString });

            string mailMessageStr = JsonConvert.SerializeObject(mailMessage);

            (int response_status, List<String> response_body) = TCPconnection.message(mailMessageStr);

            if(response_status == 200)
            {
                // Server has confirmed the mail is sent successfully
                // Jens, could you make some UI feecback, that would be triggered in this scope?
                // Until then, this print will do.
                Console.WriteLine("Mail successfully sent!");
                client.MVPWrapperPanel.Controls.Clear();
            }
            else
            {
                Console.WriteLine("Mail not sent, error code {0}", response_status);
                // Give feedback to user, that the email is not sent
            }
            
        }
        private void DiscardBtn_Click(object sender, EventArgs e)
        {
            client.MVPWrapperPanel.Controls.Clear();
            this.Dispose();
        }

        private void DraftBtn_Click(object sender, EventArgs e)
        {
            this.SaveAsDraft();
            client.MVPWrapperPanel.Controls.Clear();
            this.Dispose();
        }
    }
}

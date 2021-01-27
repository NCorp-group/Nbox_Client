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
using System.Threading;

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
            // Make Drafts folder if it doesn't exist
            if (!client.currentUser.folders.Any(f => f == "Drafts"))
            {
                client.currentUser.folders.Add("Drafts");
                client.ShowFolders();
                if (client.foldersExpanded)
                {
                    client.openFoldersTimer.Start();
                }
            }

            if (client.currentMail != null && client.currentMail.metadata.folder == "Drafts")
            {
                client.currentUser.mails.Remove(client.currentMail);
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
                {
                    read = true
                }
            };
            this.client.currentUser.mails.Add(newDraft);
            client.ShowMails();
            client.UpdateUserFile();

            // The following sends the draft to the server.
            string mailJsonString = JsonConvert.SerializeObject(newDraft);

            NMAPRequest mailMessage = new NMAPRequest("add_draft", new List<String>(), new List<String> { mailJsonString });

            string mailMessageStr = JsonConvert.SerializeObject(mailMessage);

            (int response_status, List<String> response_body) = TCPconnection.message(mailMessageStr);

            if (response_status == 200)
            {
                // Server has confirmed the draft is sent successfully
                Console.WriteLine("Draft successfully sent!");
                if (client.currentMail != null && client.currentMail.metadata.folder == "Drafts")
                {
                    client.currentUser.mails.Remove(client.currentMail);
                }
                client.MVPWrapperPanel.Controls.Clear();
                client.ShowMails();
            }
            else
            {
                Console.WriteLine("Mail not sent, error code {0}", response_status);
            }

        }
        private void SendBtn_Click(object sender, EventArgs e)
        {
            string from = FromTextBox.Text;
            string toString = ToTextBox.Text;
            List<string> toList = client.ToList(toString);  
            string subject = SubjectTextBox.Text;
            string body = BodyTextBox.Text;

            var mail = new Mail
            {
                to = toList,
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

                // If Sent folder does not exist, make one
                if (!client.currentUser.folders.Any(f => f == "Sent"))
                {
                    client.currentUser.folders.Add("Sent");
                    client.ShowFolders();
                    if (client.foldersExpanded)
                    {
                        client.openFoldersTimer.Start();
                    }
                }
                Console.WriteLine("Mail successfully sent!");
                if (client.currentMail != null && client.currentMail.metadata.folder == "Drafts")
                {
                    client.currentMail.metadata.read = false;
                    client.currentMail.metadata.folder = "Inbox";
                    client.currentMail.metadata.seen = false;
                    client.currentUser.mails.Remove(client.currentMail);
                }
                client.MVPWrapperPanel.Controls.Clear();
                client.FetchMails();
                client.ShowMails();
                client.UpdateUserFile();
            }
            else if(response_status == 501)
            {
                while (this.client.Login(this.client.currentUser.username, this.client.currentUser.password) != 200)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("Trying to reestablish connection to the server.");
                }
                SendBtn_Click(sender, e);
            }
            else
            {
                Console.WriteLine("Mail not sent, error code {0}", response_status);
                // Give feedback to user, that the email is not sent
            }
        }
        private void DiscardBtn_Click(object sender, EventArgs e)
        {
            if (client.currentMail.metadata.folder == "Drafts")
            {
                client.currentUser.mails.Remove(client.currentMail);
                client.ShowFolders();
                client.UpdateUserFile();
                client.currentMail.metadata.deleted = true;

                // Send discard to server
                client.DeleteMail(client.currentMail);
                // Delete mail
                client.currentUser.mails.Remove(client.currentMail);
                this.client.ShowMails();
            }
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

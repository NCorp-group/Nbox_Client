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
                timestamp = DateTime.Now,
                metadata = new Mail.Metadata("Drafts", "none", true)
            };
            this.client.currentUser.mails.Add(newDraft);
        }
        private void SendBtn_Click(object sender, EventArgs e)
        {

            // Go here Kevork
            string from = FromTextBox.Text;
            string to = ToTextBox.Text;
            string subject = SubjectTextBox.Text;
            string body = BodyTextBox.Text;

            var mail = new Mail
            {
                to = new List<string> { to },
                from = from,
                subject = subject,
                body = body,
                timestamp = DateTime.Now,
            };

            string mailJsonString = JsonConvert.SerializeObject(mail);

            NMAPRequest mailMessage = new NMAPRequest("send_mails", new List<String>(),  new List<String> { mailJsonString });

            string mailMessageStr = JsonConvert.SerializeObject(mailMessage);

            (int response_status, List<String> response_body) = TCPconnection.message(mailMessageStr);
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

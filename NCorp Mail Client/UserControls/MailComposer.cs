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
        public Form _parentForm { get; set; }
        public MailComposer(TCPHandler TCPH)
        {
            InitializeComponent();
            TCPconnection = TCPH;
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
            };

            string mailJsonString = JsonConvert.SerializeObject(mail);

            NMAPRequest mailMessage = new NMAPRequest("send_mails", new List<String>(),  new List<String> { mailJsonString });

            string mailMessageStr = JsonConvert.SerializeObject(mailMessage);

            (int response_status, List<String> response_body) = TCPconnection.message(mailMessageStr);

            // Use _parentForm.currentUser.metadata.user_GUID &
            //     _parentForm.currentUser.metadata.mail_adress
        }
        private void DiscardBtn_Click(object sender, EventArgs e)
        {

        }

        private void FromTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

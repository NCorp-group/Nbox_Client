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
    public partial class MailThumbnail : UserControl
    {
        private EmailClient client;
        private Mail mail;

        // TODO: Proper binding with a binding class to specify all colours and such
        // This specific binding class will be instantiated when the MailThumbnail is created

        private Binding bindingSender;
        private Binding bindingSubject;
        private Binding bindingBody;

        public MailThumbnail(Mail mail, EmailClient client)
        {
            InitializeComponent();
            this.mail = mail;
            this.client = client;
            this.Bind();
        }
        private void MailThumbnail_Click(object sender, EventArgs e)
        {
            client.currentMail = this.mail;
            foreach (Control control in client.MVPWrapperPanel.Controls)
            {
                if (control is MailComposer)
                {
                    var mc = control as MailComposer;

                    mc.SaveAsDraft();
                    client.MVPWrapperPanel.Controls.Remove(control);
                    mc.Dispose();
                }
            }
            client.MVPWrapperPanel.Controls.Clear();

            if (this.mail.metadata.folder == "Drafts")
            {
                client.ComposeMail(EmailClient.ComposeType.Draft);
            }
            else
            {
                if (this.mail.metadata.read == false)
                {
                    this.mail.metadata.read = true;
                    int status = this.client.MarkAsRead(this.mail);

                    if (status != 200)
                    {
                        Console.WriteLine("Could not mark mail as read, server returned {0}", status);
                    }
                    else
                    {
                        client.UpdateUserFile();
                    }
                }
                client.ShowCurrentMail(this);
                CheckRead();
            }
        }

        public void CheckColour()
        {
            // Colour mark calibration
            this.ColourMark.BackColor = this.mail.GetColour();
        }

        private void CheckRead()
        {
            // Read/Unread calibration colour binding
            if (mail.metadata.read == false)
            {
                this.InnerWrapperPanel.BackColor = Properties.Settings.Default.bgd_24dp;
                this.UnreadMark.BackColor = Properties.Settings.Default.tds_24dp;
            }
            else
            {
                this.UnreadMark.Visible = false;
                this.InnerWrapperPanel.BackColor = Properties.Settings.Default.bgd_08dp;
                this.CheckColour();
            }
        }

        private void Bind()
        {
            // Sender Label text binding
            this.bindingSender = new Binding("Text", mail, "from", true, DataSourceUpdateMode.OnPropertyChanged);
            this.SenderLabel.DataBindings.Add(bindingSender);

            // Subject Label text binding
            this.bindingSubject = new Binding("Text", mail, "subject", true, DataSourceUpdateMode.OnPropertyChanged);
            this.SubjectLabel.DataBindings.Add(bindingSubject);

            // Body Label text binding
            this.bindingBody = new Binding("Text", mail, "body", true, DataSourceUpdateMode.OnPropertyChanged);
            this.BodyPreviewLabel.DataBindings.Add(bindingBody);

            // Timestamp Label text binding
            //var bindingTimestamp = new Binding("Text", this, "timeStamp");
            //this.TimestampLabel.DataBindings.Add(bindingTimestamp);
            this.TimestampLabel.Text = mail.metadata.timestamp.ToShortTimeString();
            this.DateLabel.Text = mail.metadata.timestamp.ToShortDateString();

            this.CheckRead();

            this.CheckColour();
        }
    }
}

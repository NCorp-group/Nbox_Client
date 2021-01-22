using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NCorp_Mail_Client.UserControls;

namespace NCorp_Mail_Client
{

    public partial class EmailClient
    {
        private void ComposeMail()
        {
            MailComposer newMail = new MailComposer();
            newMail.Dock = System.Windows.Forms.DockStyle.Fill;
            newMail.Location = MVPPanel.Location;
            newMail.Name = "MailComposer";
            newMail._parentForm = this;
            this.MVPWrapperPanel.Controls.Add(newMail);
            MVPPanel.Hide();
        }
    }
}

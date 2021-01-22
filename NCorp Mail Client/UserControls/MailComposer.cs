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
    public partial class MailComposer : UserControl
    {
        public Form _parentForm { get; set; }
        public MailComposer()
        {
            InitializeComponent();
        }
        private void SendBtn_Click(object sender, EventArgs e)
        {
            // Go here Kevork
            // Use _parentForm.currentUser.metadata.user_GUID &
            //     _parentForm.currentUser.metadata.mail_adress
        }
        private void DiscardBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

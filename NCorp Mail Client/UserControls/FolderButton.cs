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
    public partial class FolderButton : UserControl
    {
        private EmailClient client;
        public string labelText
        {
            get { return this.FolderNameLabel.Text; }
            set { this.FolderNameLabel.Text = value; }
        }

        public FolderButton(EmailClient client)
        {
            InitializeComponent();
            this.client = client;
        }

        private void FolderButton_Click(object sender, EventArgs e)
        {
            client.ShowMails(this.FolderNameLabel.Text);
            //client.ExpandFolders();
        }
        private void Panel_MouseIn(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            this.BackColor = Properties.Settings.Default.bgd_01dp;
        }
        private void Panel_MouseOut(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            this.BackColor = Properties.Settings.Default.bgd_00dp;
        }
        private void Panel_MouseDown(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            this.BackColor = Properties.Settings.Default.bgd_08dp;
        }
        private void Panel_Reset(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            this.BackColor = Properties.Settings.Default.bgd_01dp;
        }
    }
}

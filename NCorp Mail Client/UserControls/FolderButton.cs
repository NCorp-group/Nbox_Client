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
        public string labelText
        {
            get { return this.FolderNameLabel.Text; }
            set { this.FolderNameLabel.Text = value; }
        }

        public FolderButton()
        {
            InitializeComponent();
        }
        public void Panel_MouseIn(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            this.BackColor = Properties.Settings.Default.bgd_01dp;
        }
        public void Panel_MouseOut(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            this.BackColor = Properties.Settings.Default.bgd_00dp;
        }
        public void Panel_MouseDown(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            this.BackColor = Properties.Settings.Default.bgd_08dp;
        }
        public void Panel_Reset(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            this.BackColor = Properties.Settings.Default.bgd_01dp;
        }
    }
}

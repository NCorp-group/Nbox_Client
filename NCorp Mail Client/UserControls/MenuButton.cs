using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCorp_Mail_Client.UserControls
{
    public partial class MenuButton : UserControl
    {
        public string text
        {
            get { return this.ButtonLabel.Text; }
            set { this.ButtonLabel.Text = value; }
        }
        public string icon 
        { 
            get { return this.IconLabel.Text; }
            set { this.IconLabel.Text = value; }
        }
        public MenuButton()
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
            this.BackColor = Properties.Settings.Default.bgd_02dp;
        }
        public void Panel_Reset(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            this.BackColor = Properties.Settings.Default.bgd_01dp;
        }
    }
}

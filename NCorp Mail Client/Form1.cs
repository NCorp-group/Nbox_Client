using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace NCorp_Mail_Client
{
    public partial class EmailClient : Form
    {
        private Controller FormControl;
        private List<Mail> Mails = new List<Mail>();
        public EmailClient()
        {
            InitializeComponent();
            FormControl = new Controller(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.MailScreen.BringToFront();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void TitleBar_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public void RemoveSearchPlaceholder(object sender, EventArgs e)
        {
            if (SearchText.Text == "Search")
            {
                SearchText.Text = "";
                SearchText.ForeColor = Properties.Settings.Default.tds_01dp;
            }
        }

        public void AddSearchPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchText.Text))
            {
                SearchText.ForeColor = Properties.Settings.Default.tdw_01dp;
                SearchText.Text = "Search";
            }
        }

        public void Panel_MouseIn(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            panel.BackColor = Properties.Settings.Default.bgd_02dp;
        }
        public void Panel_MouseOut(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            panel.BackColor = Color.Transparent;
        }
        public void Panel_Click(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            panel.BackColor = Properties.Settings.Default.bgd_08dp;
        }
        public void Panel_Reset(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            panel.BackColor = Properties.Settings.Default.bgd_02dp;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MaxBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                MaxBtn.Text = "";
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                MaxBtn.Text = "";
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            this.LoginScreen.Hide();
        }

        // ClearMailList method
        // Clear the mail list view
        // Removes everything from the MailListView Panel
        private void ClearMailList()
        {
            this.MailListView.Controls.Clear();
        }

        // ShowMails method
        // Show all mails on client side
        // Inserts all mails from the Mail list mails into the MailListView
        private void ShowMails()
        {
            foreach (Mail mail in this.Mails)
            {
                Panel thumbnail = FormControl.NewMail(mail);
                this.MailListView.Controls.Add(thumbnail);
            }
        }

        // RefreshMailList method
        // Refresh mails in list
        // Takes the mails list of Mails and shows them in the list view, clearing it first
        // TODO: Fetch new mails from server
        /*
        private void RefreshMailList()
        {
            this.ClearMailList();
            this.ShowMails();
        }
        */

        // Refresh button
        // Take all files in path C:/Program Files/NCorp/Nbox/mails/ and read them into Mail objects.
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            List<string> paths = Directory.EnumerateFiles(@"C:/Program Files/NCorp/Nbox/mails/", "*.json").ToList();
            foreach (string filepath in paths)
            {
                string json;
                using (var sr = new StreamReader(filepath))
                {
                    json = sr.ReadToEnd();
                }

                this.ClearMailList();

                bool have_mail = false;
                Mail new_mail = new Mail(json);
                foreach (Mail mail in this.Mails)
                {
                    if (new_mail.metadata.mail_GUID == mail.metadata.mail_GUID)
                    {
                        have_mail = true;
                    }
                }
                if (!have_mail)
                {
                    Mails.Add(new_mail);
                }
                this.ShowMails();
                /*
                Mail new_mail = new Mail(json);

                Panel new_mail_thumb = FormControl.NewMail(new_mail);
                this.MailListView.Controls.Add(new_mail_thumb);
                */
            }
        }
    }
}
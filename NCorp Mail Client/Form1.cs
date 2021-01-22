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
using NCorp_Mail_Client.UserControls;

namespace NCorp_Mail_Client
{
    public partial class EmailClient : Form
    {
        private User currentUser;
        private List<Mail> Mails = new List<Mail>();
        private bool menuExpanded = false;
        //private TCPHandler TCPconnection = new TCPHandler();
        public EmailClient()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openTimer.Interval = 10;
            openTimer.Tick += new EventHandler(openTimer_Tick);
            closeTimer.Interval = 10;
            closeTimer.Tick += new EventHandler(closeTimer_Tick);

            this.MenuBurgerBtn.IconPanel.Click += new System.EventHandler(BurgerBtn_Click);
            this.MenuBurgerBtn.TextPanel.Click += new System.EventHandler(BurgerBtn_Click);
            this.MenuBurgerBtn.ButtonLabel.Click += new System.EventHandler(BurgerBtn_Click);
            this.MenuBurgerBtn.IconLabel.Click += new System.EventHandler(BurgerBtn_Click);

            this.MenuNewMailBtn.IconPanel.Click += new System.EventHandler(MenuNewMailBtn_Click);
            this.MenuNewMailBtn.TextPanel.Click += new System.EventHandler(MenuNewMailBtn_Click);
            this.MenuNewMailBtn.ButtonLabel.Click += new System.EventHandler(MenuNewMailBtn_Click);
            this.MenuNewMailBtn.IconLabel.Click += new System.EventHandler(MenuNewMailBtn_Click);
            //this.LoginScreen.BringToFront();
        }

        // 
        // DRAGGABLE WINDOW
        //

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

        //
        // SEARCH FIELD
        //

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

        //
        // PANEL MOUSE INTERACTION
        //

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

        //
        // TITLE BAR BUTTONS
        //

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            //TCPconnection.close_connection();
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

        //
        // EMAIL MANIPULATION
        //

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
                var newThumbnail = new MailThumbnail(mail);
                newThumbnail.Dock = DockStyle.Top;
                newThumbnail._viewportWrapper = this.MVPWrapperPanel;
                this.MailListView.Controls.Add(newThumbnail);
                //Panel thumbnail = Builder.Thumbnail(mail);
                //this.MailListView.Controls.Add(thumbnail);
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
            List<string> paths = Directory.EnumerateFiles(@"..\\..\\testing_assets", "*.json").ToList();
            List<Mail> NewMails = new List<Mail>();
            foreach (string filepath in paths)
            {
                string json;
                using (var sr = new StreamReader(filepath))
                {
                    json = sr.ReadToEnd();
                }

                Mail new_mail = new Mail(json);

                this.MailListView.Controls.Clear();

                bool exists = false;
                foreach (Mail mail in Mails)
                {
                    if (mail.metadata.mail_GUID == new_mail.metadata.mail_GUID)
                    {
                        exists = true;
                    }
                }

                if (!exists)
                {
                    this.Mails.Add(new_mail);
                }

                NewMails.Add(new_mail);
            }
            
            // Delete emails that are no longer as files
            foreach (Mail mail in this.Mails)
            {
                bool match = false;
                foreach (Mail new_mail in NewMails)
                {
                    if (mail.metadata.mail_GUID == new_mail.metadata.mail_GUID)
                    {
                        match = true;
                    }
                }

                // If the file for the mail is no longer there
                // remove it from the internal list
                if (!match)
                {
                    Mails.Remove(mail);
                }
            }

            this.ShowMails();
        }

        //
        // CONTROLS BUTTONS
        //

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            this.LoginScreen.Hide();
        }

        private void FolderBtn_Click(object sender, EventArgs e)
        {
            //string folderJSON = TCPconnection.message("fetch_folders");

            // Ready to be deserialized into an object
        }

        //
        // MENU TRANSITION
        //

        Timer openTimer = new Timer();
        Timer closeTimer = new Timer();

        void openTimer_Tick(object sender, EventArgs e)
        {
            if (ControlPanel.Width >= 220)
            {
                openTimer.Stop();
            }
            else
            {
                this.ControlPanel.Width += 40;
            }
        }

        void closeTimer_Tick(object sender, EventArgs e)
        {
            if (ControlPanel.Width <= 60)
            {
                closeTimer.Stop();
            }
            else
            {
                this.ControlPanel.Width -= 40;
            }
        }

        private void BurgerBtn_Click(object sender, EventArgs e)
        {
            if (openTimer.Enabled)
            {
                openTimer.Stop();
            }
            if (closeTimer.Enabled)
            {
                closeTimer.Stop();
            }

            if (menuExpanded)
            {
                closeTimer.Start();
            }
            else
            {
                openTimer.Start();
            }
            menuExpanded = !menuExpanded;
        }

        private void MenuNewMailBtn_Click(object sender, EventArgs e)
        {
            if (this.MVPPanel.Visible)
            {
                //MVPPanel.Visible = false;
            }
            this.ComposeMail();
        }
    }
}
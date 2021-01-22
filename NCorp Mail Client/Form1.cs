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
        private readonly string MAILDIR_ROOT = Path.Combine(Environment.GetEnvironmentVariable("appdata"), "NBox");
        private User currentUser;
        //private List<Mail> Mails = new List<Mail>();
        //private List<string> Folders = new List<string>();

        private bool menuExpanded = false;
        public bool foldersExpanded = false;

        private TCPHandler TCPconnection = new TCPHandler();
        public EmailClient()
        {
            //
            // Dummy testing code for user
            // 
            currentUser = new User("kevork");
            currentUser.folders.Add("folder1");
            currentUser.folders.Add("folder2");

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openMenuTimer.Interval = 10;
            openMenuTimer.Tick += new EventHandler(openMenuTimer_Tick);
            closeMenuTimer.Interval = 10;
            closeMenuTimer.Tick += new EventHandler(closeMenuTimer_Tick);

            openFoldersTimer.Interval = 10;
            openFoldersTimer.Tick += new EventHandler(openFoldersTimer_Tick);
            closeFoldersTimer.Interval = 10;
            closeFoldersTimer.Tick += new EventHandler(closeFoldersTimer_Tick);

            this.MenuBurgerBtn.IconPanel.Click += new System.EventHandler(BurgerBtn_Click);
            this.MenuBurgerBtn.TextPanel.Click += new System.EventHandler(BurgerBtn_Click);
            this.MenuBurgerBtn.ButtonLabel.Click += new System.EventHandler(BurgerBtn_Click);
            this.MenuBurgerBtn.IconLabel.Click += new System.EventHandler(BurgerBtn_Click);

            this.MenuNewMailBtn.IconPanel.Click += new System.EventHandler(MenuNewMailBtn_Click);
            this.MenuNewMailBtn.TextPanel.Click += new System.EventHandler(MenuNewMailBtn_Click);
            this.MenuNewMailBtn.ButtonLabel.Click += new System.EventHandler(MenuNewMailBtn_Click);
            this.MenuNewMailBtn.IconLabel.Click += new System.EventHandler(MenuNewMailBtn_Click);

            this.MenuFoldersBtn.IconPanel.Click += new System.EventHandler(MenuFoldersBtn_Click);
            this.MenuFoldersBtn.TextPanel.Click += new System.EventHandler(MenuFoldersBtn_Click);
            this.MenuFoldersBtn.ButtonLabel.Click += new System.EventHandler(MenuFoldersBtn_Click);
            this.MenuFoldersBtn.IconLabel.Click += new System.EventHandler(MenuFoldersBtn_Click);

            this.ShowFolders();
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
            foreach (Mail mail in this.currentUser.mails)
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
                foreach (Mail mail in currentUser.mails)
                {
                    if (mail.metadata.mail_GUID == new_mail.metadata.mail_GUID)
                    {
                        exists = true;
                    }
                }

                if (!exists)
                {
                    this.currentUser.mails.Add(new_mail);
                }

                NewMails.Add(new_mail);
            }
            
            // Delete emails that are no longer as files
            foreach (Mail mail in this.currentUser.mails)
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
                    currentUser.mails.Remove(mail);
                }
            }

            this.ShowMails();
        }

        //
        // CONTROLS BUTTONS
        //

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string mail = this.LoginMailTextBox.Text;
            string password = this.LoginPassTexBox.Text;
            int status = login(mail, password);

            Console.WriteLine("mail: {0}\npassword: {1}", mail, password);

            
            if (status == 200)
            {
                this.currentUser = new User(mail);
                // sync with server to get new unseen mails
                fetchEmails();
                this.currentUser.folders.AddRange(getFolders());
                this.LoginScreen.Hide();
            }
        }

        private void FolderBtn_Click(object sender, EventArgs e)
        {
            //string folderJSON = TCPconnection.message("fetch_folders");

            // Ready to be deserialized into an object
        }

        //
        // MENU TRANSITION
        //

        Timer openMenuTimer = new Timer();
        Timer closeMenuTimer = new Timer();

        void openMenuTimer_Tick(object sender, EventArgs e)
        {
            if (ControlPanel.Width >= 220)
            {
                openMenuTimer.Stop();
            }
            else
            {
                this.ControlPanel.Width += 20;
            }
        }

        void closeMenuTimer_Tick(object sender, EventArgs e)
        {
            if (closeFoldersTimer.Enabled)
            {
                return;
            }
            if (ControlPanel.Width <= 60)
            {
                closeMenuTimer.Stop();
            }
            else
            {
                this.ControlPanel.Width -= 20;
            }
        }

        private void ExpandMenu()
        {
            if (openMenuTimer.Enabled)
            {
                openMenuTimer.Stop();
            }
            if (closeMenuTimer.Enabled)
            {
                closeMenuTimer.Stop();
            }

            if (menuExpanded)
            {
                if (foldersExpanded)
                {
                    this.ExpandFolders();
                }
                closeMenuTimer.Start();
            }
            else
            {
                openMenuTimer.Start();
            }
            menuExpanded = !menuExpanded;
        }

        private void BurgerBtn_Click(object sender, EventArgs e)
        {
            this.ExpandMenu();
        }
        private void ComposeMail()
        {
            // TODO: When the mail composer is hidden it should store the input values in a draft mail and delete the mailcomposer.
            //       If nothing was typed in the mail composer a draft should not be created.
            //       
            //       Fix when clicking the Folder menu button the folders should be revealed instead of collapsing the button itself.
            MailComposer theMailComposer = (MailComposer)this.Controls["MailComposer"];
            
            if (theMailComposer == null)
            {
                MailComposer newMail = new MailComposer();
                newMail.Dock = System.Windows.Forms.DockStyle.Fill;
                newMail.Location = MVPPanel.Location;
                newMail.Name = "MailComposer";
                newMail.FromTextBox.Text = currentUser.username + "@nbox.com";
                newMail._parentForm = this;
                this.MVPWrapperPanel.Controls.Add(newMail);
            }
            else
            {
                theMailComposer.ToTextBox.Clear();
                theMailComposer.Show();
            }

            if (MVPPanel.Visible)
            {
                MVPPanel.Hide();
            }
        }
        private void ComposeMail_Reply()
        {
            MailComposer theMailComposer = (MailComposer)this.Controls["MailComposer"];
            if (theMailComposer == null)
            {
                MailComposer newMail = new MailComposer();
                newMail.Dock = System.Windows.Forms.DockStyle.Fill;
                newMail.Location = MVPPanel.Location;
                newMail.Name = "MailComposer";
                newMail.FromTextBox.Text = currentUser.username + "@nbox.com";
                newMail.ToTextBox.Text = this.MVPSenderLabel.Text;
                newMail._parentForm = this;
                this.MVPWrapperPanel.Controls.Add(newMail);
            }
            else
            {
                theMailComposer.ToTextBox.Clear();
                theMailComposer.Show();
                theMailComposer.ToTextBox.Text = this.MVPSenderLabel.Text;
            }

            if (MVPPanel.Visible)
            {
                MVPPanel.Hide();
            }
        }

        private void MenuNewMailBtn_Click(object sender, EventArgs e)
        {
            this.ComposeMail();
        }

        private void ReplyBtn_Click(object sender, EventArgs e)
        {
            this.ComposeMail_Reply();
        }

        private void ShowFolders()
        {
            foreach (string folder in currentUser.folders)
            {
                FolderButton newFolderButton = new FolderButton();
                newFolderButton.Controls["FolderNameLabel"].Text = folder;
                newFolderButton.Dock = DockStyle.Top;
                this.FolderListView.Controls.Add(newFolderButton);
            }
        }

        public Timer openFoldersTimer = new Timer();
        public Timer closeFoldersTimer = new Timer();

        void openFoldersTimer_Tick(object sender, EventArgs e)
        {
            if (openMenuTimer.Enabled)
            {
                return;
            }
            if (FoldersListPanel.Height >= (currentUser.folders.Count * 30) + 95)
            {
                openFoldersTimer.Stop();
            }
            else if (FoldersListPanel.Height >= (currentUser.folders.Count * 30) + 90)
            {
                this.FoldersListPanel.Height += 5;
            }
            else
            {
                this.FoldersListPanel.Height += 15;
            }
        }

        void closeFoldersTimer_Tick(object sender, EventArgs e)
        {
            if (FoldersListPanel.Height <= 60)
            {
                closeFoldersTimer.Stop();
            }
            else if (FoldersListPanel.Height <= 65)
            {
                this.FoldersListPanel.Height -= 5;
            }
            else
            {
                this.FoldersListPanel.Height -= 15;
            }
        }

        private void ExpandFolders()
        {
            if (openFoldersTimer.Enabled)
            {
                openFoldersTimer.Stop();
            }
            if (closeFoldersTimer.Enabled)
            {
                closeFoldersTimer.Stop();
            }

            if (foldersExpanded)
            {
                closeFoldersTimer.Start();
            }
            else
            {
                openFoldersTimer.Start();
            }
            foldersExpanded = !foldersExpanded;
        }

        private void MenuFoldersBtn_Click(object sender, EventArgs e)
        {
            if (!menuExpanded)
            {
                this.ExpandMenu();
            }
            this.ExpandFolders();
        }
    }
}
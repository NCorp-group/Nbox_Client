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
        public enum ComposeType
        {
            Standard,
            Reply,
            ReplyAll,
            Forward
        }

        public User currentUser;
        //private List<Mail> Mails = new List<Mail>();
        //private List<string> Folders = new List<string>();
        public Mail currentMail;
        private readonly string MAILDIR_ROOT = Path.Combine(Environment.GetEnvironmentVariable("appdata"), "NBox", "Client");

        //
        // Keeping track of menu expansions
        //
        private bool menuExpanded = false;
        private bool foldersExpanded = false;
        private bool settingsExpanded = false;

        //
        // The TCPHandler
        //
        private TCPHandler TCPconnection = new TCPHandler();
        public EmailClient()
        {
            //
            // Dummy testing code for user
            // 
            if (!Directory.Exists(MAILDIR_ROOT))
            {
                Directory.CreateDirectory(MAILDIR_ROOT);
            }

            InitializeComponent();

            //this.FetchMails();
            //this.GetMails();
            //currentMail = currentUser.mails[0];
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

            openSettingsTimer.Interval = 10;
            openSettingsTimer.Tick += new EventHandler(openSettingsTimer_Tick);
            closeSettingsTimer.Interval = 10;
            closeSettingsTimer.Tick += new EventHandler(closeSettingsTimer_Tick);

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

            this.MenuSettingsBtn.IconPanel.Click += new System.EventHandler(this.MenuSettingsBtn_Click);
            this.MenuSettingsBtn.TextPanel.Click += new System.EventHandler(this.MenuSettingsBtn_Click);
            this.MenuSettingsBtn.ButtonLabel.Click += new System.EventHandler(this.MenuSettingsBtn_Click);
            this.MenuSettingsBtn.IconLabel.Click += new System.EventHandler(this.MenuSettingsBtn_Click);

            //this.ShowFolders();
            //this.ShowMails(null);
            //this.LoginScreen.BringToFront();
        }

        // 
        // DRAGGABLE WINDOW
        //

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
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
        // Manipulates panel hover colour and mouse down colour
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
                this.GeneralToolTip.SetToolTip(MaxBtn, "Normalize");
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                MaxBtn.Text = "";
                this.GeneralToolTip.SetToolTip(MaxBtn, "Maximize");
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
        public void ShowMails(string folderName)
        {
            this.ClearMailList();
            if (folderName == null)
            {
                foreach (Mail mail in this.currentUser.mails)
                {
                    var newThumbnail = new MailThumbnail(mail, this);
                    newThumbnail.Dock = DockStyle.Top;
                    this.MailListView.Controls.Add(newThumbnail);
                }
            }
            else
            {
                foreach (Mail mail in this.currentUser.mails)
                {
                    if (mail.metadata.folder == folderName)
                    {
                        var newThumbnail = new MailThumbnail(mail, this);
                        newThumbnail.Dock = DockStyle.Top;
                        this.MailListView.Controls.Add(newThumbnail);
                    }
                }
            }
        }

        // Show Current Mail
        public void ShowCurrentMail()
        {
            if (this.MVPWrapperPanel.HasChildren)
            {
                if (this.Controls["MailComposer"] != null)
                {
                    var mc = (MailComposer)this.Controls["MailComposer"];
                    mc.SaveAsDraft();
                    this.Controls.RemoveByKey("MailComposer");
                }
                else
                {
                    this.MVPWrapperPanel.Controls.Clear();
                }
            }
            this.currentMail.metadata.read = true;

            MailViewport newViewport = new MailViewport(this)
            {
                Dock = DockStyle.Fill,
                Name = "MailViewport"
            };
            //newViewport.viewportWrapper = _viewportWrapper;
            newViewport.TitleLabel.Text = this.currentMail.subject;
            newViewport.SenderLabel.Text = this.currentMail.from;
            newViewport.BodyLabel.Text = this.currentMail.body;
            newViewport.ColourBtn.ForeColor = currentMail.GetColour();
            newViewport.FlagBtn.Text = currentMail.GetFlagIcon();
            this.MVPWrapperPanel.Controls.Add(newViewport);
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

        private void GetMails()
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

                if (this.MailListView.HasChildren)
                {
                    this.MailListView.Controls.Clear();
                }

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
        }

        // Refresh button
        // Take all files in path C:/Program Files/NCorp/Nbox/mails/ and read them into Mail objects.
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.FetchMails();
            //this.GetMails();
            this.ClearMailList();
            this.ShowMails(null);
        }

        //
        // CONTROLS BUTTONS
        //

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string user = LoginMailTextBox.Text;
            string pass = LoginPassTexBox.Text;
            int status = login(user, pass);
            if (status == 200)
            {
                this.currentUser = new User(user);
                this.LoginScreen.Hide();
            }
            else
            {
                Console.WriteLine(String.Format("Could not login, error code {0}", status));
            }
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
            if (closeFoldersTimer.Enabled || closeSettingsTimer.Enabled)
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
                if (settingsExpanded)
                {
                    this.ExpandSettings();
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

        //
        // NEW MAIL & REPLY
        //
        public List<string> ToList(string inString)
        {
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            string[] arr = inString.Split(delimiterChars);
            List<string> outList = new List<string>(arr);
            return outList;
        }
        /*
        public void SaveAsDraft()
        {
            if (this.Controls["MailComposer"] == null)
            {
                Console.WriteLine("MailComposer not found");
                return;
            }
            var mailComposer = this.Controls["MailComposer"];
            string newToString = mailComposer.Controls["HeaderPanel"]
                                             .Controls["ToPanel"]
                                             .Controls["ToTextBox"].Text;

            List<string> newToList = ToList(newToString);

            string newFrom = this.Controls["MailComposer"].Controls["FromTextBox"].Text;
            string newSubject = this.Controls["MailComposer"].Controls["SubjectTextBox"].Text;
            string newBody = this.Controls["MailComposer"].Controls["BodyTextBox"].Text;

            Mail newDraft = new Mail()
            {
                from = newFrom,
                to = newToList,
                subject = newSubject,
                body = newBody,
                metadata = new Mail.Metadata("Drafts", "none", true)
            };
            this.currentUser.mails.Add(newDraft);
        }
        */

        public void ComposeMail(ComposeType Type)
        {
            if (this.Controls["MailComposer"] != null)
            {
                var mc = (MailComposer)this.Controls["MailComposer"];
                mc.SaveAsDraft();
                this.Controls.RemoveByKey("MailComposer");
            }
            this.MVPWrapperPanel.Controls.Clear();

            MailComposer newComposer = new MailComposer(TCPconnection, this)
            {
                Dock = DockStyle.Fill,
                Name = "MailComposer"
            };

            newComposer.FromTextBox.Text = currentUser.username + "@nbox.com";
            switch (Type)
            {
                case ComposeType.Standard:
                    break;
                case ComposeType.Reply:
                    newComposer.ToTextBox.Text = currentMail.from;
                    break;
                case ComposeType.ReplyAll:
                    string toString = currentMail.from;
                    int count = 0;
                    foreach (string recipient in currentMail.to)
                    {
                        count++;
                        if (recipient == currentUser.username + "@nbox.com")
                        {
                            continue;
                        }
                        else
                        {
                            toString += ", " + recipient;
                        }
                    }
                    newComposer.ToTextBox.Text = toString;
                    break;
                case ComposeType.Forward:
                    newComposer.SubjectTextBox.Text = currentMail.subject;
                    newComposer.BodyTextBox.Text = "Sent by: " + currentMail.from
                                                 + "\nOn: " + currentMail.metadata.timestamp.ToShortDateString()
                                                 + "\nAt time: " + currentMail.metadata.timestamp.ToShortTimeString()
                                                 + "\nSubject: " + currentMail.subject
                                                 + "\n\n" + currentMail.body;
                    break;
            }
            this.MVPWrapperPanel.Controls.Add(newComposer);
        }

        private void MenuNewMailBtn_Click(object sender, EventArgs e)
        {
            this.ComposeMail(ComposeType.Standard);
        }

        //
        // SHOW FOLDERS
        // Will be called when the user logs in
        // Generates UI elements for each folder
        //

        private void ShowFolders()
        {
            foreach (string folder in currentUser.folders)
            {
                FolderButton newFolderButton = new FolderButton(this);
                newFolderButton.Controls["FolderNameLabel"].Text = folder;
                newFolderButton.Dock = DockStyle.Top;
                newFolderButton.Name = folder + "Btn";
                this.FolderListView.Controls.Add(newFolderButton);
            }
        }

        //
        // FOLDERS MENU
        // Expanding the folders menu
        //

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

        //
        // SETTINGS MENU
        // Expanding the settings menu
        //

        public Timer openSettingsTimer = new Timer();
        public Timer closeSettingsTimer = new Timer();

        void openSettingsTimer_Tick(object sender, EventArgs e)
        {
            if (openMenuTimer.Enabled)
            {
                return;
            }
            if (SettingsPanel.Height >= 95)
            {
                openSettingsTimer.Stop();
            }
            else
            {
                this.SettingsPanel.Height += 15;
            }
        }

        void closeSettingsTimer_Tick(object sender, EventArgs e)
        {
            if (SettingsPanel.Height <= 60)
            {
                closeSettingsTimer.Stop();
            }
            else
            {
                this.SettingsPanel.Height -= 15;
            }
        }

        private void ExpandSettings()
        {
            if (openSettingsTimer.Enabled)
            {
                openSettingsTimer.Stop();
            }
            if (closeSettingsTimer.Enabled)
            {
                closeSettingsTimer.Stop();
            }

            if (settingsExpanded)
            {
                closeSettingsTimer.Start();
            }
            else
            {
                openSettingsTimer.Start();
            }
            settingsExpanded = !settingsExpanded;
        }

        private void MenuSettingsBtn_Click(object sender, EventArgs e)
        {
            if (!menuExpanded)
            {
                this.ExpandMenu();
            }
            this.ExpandSettings();
        }

        //
        // Showing a mail from the list
        //
    }
}
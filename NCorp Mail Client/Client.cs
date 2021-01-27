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
            Forward,
            Draft
        }

        public User currentUser;
        public Mail currentMail;
        public string currentFolder;
        private readonly string MAILDIR_ROOT = Path.Combine(Environment.GetEnvironmentVariable("appdata"), "NBox", "Client");

        //
        // Keeping track of menu expansions
        //
        public bool menuExpanded = false;
        public bool foldersExpanded = false;
        public bool settingsExpanded = false;

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
            this.Icon = Properties.Resources.icon;

            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
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
        }

        // 
        // DRAGGABLE WINDOW
        // This was reused as explained in the article
        // https://www.codeproject.com/Articles/11114/Move-window-form-without-Titlebar-in-C
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

        /// <summary>
        /// On GotFocus Event of the search text box
        /// Remove the placeholder in the search bar
        /// Emphasise text by setting to the strongest colour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void RemoveSearchPlaceholder(object sender, EventArgs e)
        {
            if (SearchText.Text == "Search")
            {
                SearchText.Text = "";
                SearchText.ForeColor = Properties.Settings.Default.tds_01dp;
            }
        }

        /// <summary>
        /// On LostFocus event of the search text box
        /// Adds the string "search" to the text box and makes the text colour disabled
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// On MouseEnter event of the given panel
        /// As the mouse hovers over the panel, change to a hover colour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Panel_MouseIn(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            panel.BackColor = Properties.Settings.Default.bgd_02dp;
        }
        /// <summary>
        /// On MouseLeave event of the given panel
        /// Changes the colour back to default instead of the hover colour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Panel_MouseOut(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            panel.BackColor = Color.Transparent;
        }
        /// <summary>
        /// On MouseDown event of the given panel
        /// Changes the colour of the panel to a much lighter colour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Panel_Click(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            panel.BackColor = Properties.Settings.Default.bgd_08dp;
        }
        /// <summary>
        /// On MouseUp event of the given panel
        /// Resets the panels colour when the mouse isn't pressed anymore
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Panel_Reset(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            panel.BackColor = Properties.Settings.Default.bgd_02dp;
        }

        //
        // TITLE BAR BUTTONS
        //

        /// <summary>
        /// On Click event of the close button
        /// For both the login screen and after login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Toggle Maximize
        private void ToggleMaximize()
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                MaxBtn.Text = "";
                LoginMaxBtn.Text = "";
                this.GeneralToolTip.SetToolTip(MaxBtn, "Normalize");
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                MaxBtn.Text = "";
                LoginMaxBtn.Text = "";
                this.GeneralToolTip.SetToolTip(MaxBtn, "Maximize");
            }
        }

        private void MaxBtn_Click(object sender, EventArgs e)
        {
            this.ToggleMaximize();
        }

        // Maximize window when double clicking the titlebar
        private void TitleBar_DoubleClick(object sender, EventArgs e)
        {
            this.ToggleMaximize();
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

        /// <summary>
        /// Triggered whenever the Mail list panel should be updated
        /// syncronising with the local memory.
        /// Inserts all mails from the currentUser.mails list into the MailListView
        /// </summary>
        /// <param name="folderName"></param>
        public void ShowMails(string folderName = null)
        {
            this.ClearMailList();
            if (folderName == null)
            {
                foreach (Mail mail in this.currentUser.mails)
                {
                    if (mail.metadata.deleted)
                    {
                        continue;
                    }
                    if (mail.metadata.folder == currentFolder)
                    {
                        var newThumbnail = new MailThumbnail(mail, this);
                        newThumbnail.Dock = DockStyle.Top;
                        this.MailListView.Controls.Add(newThumbnail);
                    }
                }
            }
            else
            {
                foreach (Mail mail in this.currentUser.mails)
                {
                    if (mail.metadata.deleted)
                    {
                        continue;
                    }
                    if (mail.metadata.folder == folderName)
                    {
                        var newThumbnail = new MailThumbnail(mail, this);
                        newThumbnail.Dock = DockStyle.Top;
                        this.MailListView.Controls.Add(newThumbnail);
                    }
                }
            }
        }

        /// <summary>
        /// Shows the mail clicked on in the MailListView Panel
        /// Generates a MailViewport with text from the currentMail
        /// </summary>
        /// <param name="thumbnail"></param>
        public void ShowCurrentMail(MailThumbnail thumbnail)
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

            MailViewport newViewport = new MailViewport(this, thumbnail)
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

        /// <summary>
        /// On Click event of the Refresh Button
        /// Clears any mail currently being shown, incoming or outgoing
        /// Fetches mails from the server, not a deep fetch
        /// Shows the mails in the MailListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.MVPWrapperPanel.Controls.Clear();
            this.FetchMails();
            this.ShowMails();
        }

        //
        // CONTROLS BUTTONS
        //

        /// <summary>
        /// On Click event of the Login Button
        /// On KeyPress event of any of the two text boxes if the user presses Enter
        /// </summary>
        private void TryLogin()
        {
            string user = LoginMailTextBox.Text;
            string pass = LoginPassTextBox.Text;
            int status = Login(user, pass);
            if (status == 200)
            {
                this.LoginErrorLabel.Text = "";
                this.currentUser = new User(user);
                this.currentUser.password = pass;


                string user_path = Path.Combine(MAILDIR_ROOT, this.currentUser.username + ".json");
                if (!File.Exists(user_path))
                {
                    using (FileStream fs = File.Create(user_path)) { }
                    FetchMails(true);
                }
                this.LoginScreen.Hide();
                FetchMails(false);
                this.currentFolder = "Inbox";
                this.ShowMails();
                this.CurrentAccountLabel.Text = currentUser.username;
                this.GeneralToolTip.SetToolTip(this.CurrentAccountLabel, this.CurrentAccountLabel.Text);
                this.GetFolders();
                this.ShowFolders();
                this.LoginScreen.Hide();
            }
            else if (status == 401)
            {
                this.LoginErrorLabel.Text = "Incorrect username or password";
            }
            else
            {
                this.LoginErrorLabel.Text = "Server Error";
            }
        }

        /// <summary>
        /// On KeyPress event of the username and password text boxes
        /// Calls TryLogin as the user intends to log in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.TryLogin();
                e.Handled = true;
            }
        }

        /// <summary>
        /// On Click event of the login button
        /// Calls TryLogin to log the user in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            this.TryLogin();
        }

        //
        // MENU TRANSITION
        // Timer logic to animate the opening and closing of the left menu panel
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

        /// <summary>
        /// On click Event of the burger button
        /// Expand the left menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BurgerBtn_Click(object sender, EventArgs e)
        {
            this.ExpandMenu();
        }

        //
        // NEW MAIL & REPLY
        //
        public List<string> ToList(string inString)
        {
            char[] delimiterChars = { ',', '.', ':', '\t' };
            string[] arr = inString.Split(delimiterChars); // name1 name2
            List<string> outList = new List<string>(arr);
            for(int i = 0; i < outList.Count(); i++)
            {
                outList[i] = outList[i].Replace(" ", "");
                outList[i] = outList[i].Replace(",", "");
            }
            return outList;
        }

        /// <summary>
        /// Called when the user intends to compose a mail
        /// Composing a new mail, editing a draft or using the reply, replyall, forward functions
        /// Takes a ComposeType which specifies which type of composer to generate
        /// This determines if any text boxes should be prefilled.
        /// </summary>
        /// <param name="Type"></param>
        public void ComposeMail(ComposeType Type)
        {
            foreach (Control control in this.MVPWrapperPanel.Controls)
            {
                if (control is MailComposer)
                {
                    var mc = control as MailComposer;
                    mc.SaveAsDraft();
                    this.MVPWrapperPanel.Controls.Remove(control);
                }
            }
            this.MVPWrapperPanel.Controls.Clear();

            MailComposer newComposer = new MailComposer(TCPconnection, this)
            {
                Dock = DockStyle.Fill,
                Name = "MailComposer"
            };

            newComposer.FromTextBox.Text = currentUser.username;
            switch (Type)
            {
                case ComposeType.Standard:
                    break;
                case ComposeType.Reply:
                    {
                        newComposer.ToTextBox.Text = currentMail.from;
                    }
                    break;
                case ComposeType.ReplyAll:
                    {
                        string toString = currentMail.from;
                        foreach (string recipient in currentMail.to)
                        {
                            if (recipient == currentUser.username)
                            {
                                continue;
                            }
                            else
                            {
                                toString += ", " + recipient;
                            }
                        }
                        newComposer.ToTextBox.Text = toString;
                    }
                    break;
                case ComposeType.Forward:
                    {
                        newComposer.SubjectTextBox.Text = currentMail.subject;
                        newComposer.BodyTextBox.Text = "Sent by: " + currentMail.from
                                                     + "\nOn: " + currentMail.metadata.timestamp.ToShortDateString()
                                                     + "\nAt time: " + currentMail.metadata.timestamp.ToShortTimeString()
                                                     + "\nSubject: " + currentMail.subject
                                                     + "\n\n" + currentMail.body;
                    }
                    break;
                case ComposeType.Draft:
                    {
                        newComposer.FromTextBox.Text = currentMail.from;
                        string toString = "";
                        foreach (string recipient in currentMail.to)
                        {
                            if (recipient == currentMail.to.First())
                            {
                                toString += recipient;
                            }
                            else
                            {
                                toString += ", " + recipient;
                            }
                        }
                        newComposer.ToTextBox.Text = toString;
                        newComposer.SubjectTextBox.Text = currentMail.subject;
                        newComposer.BodyTextBox.Text = currentMail.body;
                    }
                    break;
            }
            this.MVPWrapperPanel.Controls.Add(newComposer);
        }

        /// <summary>
        /// On Click event of the new mail button
        /// Calls ComposeMail with the standard composition
        /// No text boxes are prefilled
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuNewMailBtn_Click(object sender, EventArgs e)
        {
            this.ComposeMail(ComposeType.Standard);
        }

        //
        // SHOW FOLDERS
        // Will be called when the user logs in
        // Generates UI elements for each folder
        //

        /// <summary>
        /// Generates a folder button UI element with the label foldername
        /// </summary>
        /// <param name="folderName"></param>
        /// <returns></returns>
        public FolderButton CreateNewFolder(string folderName)
        {
            FolderButton newFolderButton = new FolderButton(this)
            {
                labelText = folderName,
                Dock = DockStyle.Top,
                Name = folderName + "Btn"
            };
            return newFolderButton;
        }

        /// <summary>
        /// Whenever the folder list for a user needs to be generated
        /// Iterates through the currentUser.folders list
        /// Generates the UI elements necessary for each folder by calling CreateNewFolder
        /// </summary>
        public void ShowFolders()
        {
            foreach (string folder in currentUser.folders)
            {
                FolderButton newFolderButton = this.CreateNewFolder(folder);
                this.FolderListView.Controls.Add(newFolderButton);
            }
        }

        //
        // CREATE NEW FOLDER
        //

        // Empty new folder string, updated as user inputs a folder name
        string newFolderName = "";

        /// <summary>
        /// Removes the input field for a new folder
        /// </summary>
        private void RemoveNewFolderInput()
        {
            this.creatingFolder = 0;
            foreach (Control item in this.FoldersListPanel.Controls.OfType<Control>())
            {
                if (item.Name == "NewFolderInputPanel")
                    this.FoldersListPanel.Controls.Remove(item);
            }
        }

        /// <summary>
        /// On TextChanged event for the new folder input text box
        /// Updates the newFolderName string to be used to generate a new folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewFolderTextBox_TextChanged(object sender, EventArgs e)
        {
            this.newFolderName = (sender as TextBox).Text;
        }

        private void AddFolder()
        {
            string folderName = this.newFolderName;

            if (!string.IsNullOrWhiteSpace(folderName))
            {
                if (this.currentUser.folders.Any(f => f == folderName))
                {
                    Console.WriteLine("Folder already exists");
                }
                else
                {
                    this.currentUser.folders.Add(folderName);
                }
            }
            this.RemoveNewFolderInput();
        }

        /// <summary>
        /// On KeyPress event of the new folder input textbox
        /// If the key press is Enter, then generale a new folder.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewFolderTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.AddFolder();
                this.ShowFolders();
                if (this.foldersExpanded)
                {
                    this.openFoldersTimer.Start();
                }
                e.Handled = true;
            }
        }

        // Keep track whether a folder is currently being created
        // using an int to make it easier to resize the folders menu

        private int creatingFolder = 0;

        /// <summary>
        /// On Click event of the plus button in the folders menu
        /// Generates an input field for the user to enter a new folder name
        /// If the input field is already present, then the button generates a new folder with the given name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void NewFolderBtn_Click(object sender, EventArgs e)
        {
            if (creatingFolder > 0)
            {
                this.AddFolder();
                this.ShowFolders();
                if (this.foldersExpanded)
                {
                    this.openFoldersTimer.Start();
                }
            }
            else
            {
                this.creatingFolder = 1;
                var wrapper = new Panel()
                {
                    Dock = DockStyle.Bottom,
                    Padding = new Padding(60, 0, 10, 0),
                    Size = new Size(220, 30),
                    Name = "NewFolderInputPanel"
                };
                var input = new TextBox()
                {
                    Dock = DockStyle.Top,
                    Name = "NewFolderInputTextBox",
                    BorderStyle = BorderStyle.None,
                    BackColor = Properties.Settings.Default.bgd_01dp,
                    ForeColor = Properties.Settings.Default.tds_00dp,
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                };
                input.TextChanged += new EventHandler(NewFolderTextBox_TextChanged);
                input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(NewFolderTextBox_KeyPress);
                wrapper.Controls.Add(input);
                this.FoldersListPanel.Controls.Add(wrapper);
                if (foldersExpanded)
                {
                    openFoldersTimer.Start();
                }
            }
        }

        //
        // FOLDERS MENU
        // Expanding the folders menu
        // Timer logic to animate the expansion of the folder menu
        // Can only expand this menu if the left menu is already expanded
        // If it isn't this is done first
        //

        public Timer openFoldersTimer = new Timer();
        public Timer closeFoldersTimer = new Timer();

        void openFoldersTimer_Tick(object sender, EventArgs e)
        {
            int offset = creatingFolder * 30;
            if (openMenuTimer.Enabled)
            {
                return;
            }
            if (FoldersListPanel.Height >= (currentUser.folders.Count * 30) + 95 + offset)
            {
                openFoldersTimer.Stop();
            }
            else if (FoldersListPanel.Height >= (currentUser.folders.Count * 30) + 90 + offset)
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

        public void ExpandFolders()
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
            if (creatingFolder != 0)
            {
                this.RemoveNewFolderInput();
            }
            this.ExpandFolders();
        }

        //
        // SETTINGS MENU
        // Expanding the settings menu
        // Timger logic to expand the settings menu
        // Can only expand this menu as soon ad the left emnu is expanded
        // If not expand the left menu first, then the settings menu
        //

        public Timer openSettingsTimer = new Timer();
        public Timer closeSettingsTimer = new Timer();

        void openSettingsTimer_Tick(object sender, EventArgs e)
        {
            if (openMenuTimer.Enabled)
            {
                return;
            }
            if (SettingsPanel.Height >= 140)
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

        /// <summary>
        /// On Click event of the logout button
        /// Calls Logout function defined in ServerCommunication.cs
        /// If the log out is succesful the view is changed to the login screen
        /// and the underlying UI is reset for the next user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            int status = Logout();
            if(status != 200)
            {
                // Logout failed
                Console.WriteLine("Logout failed with server error {0}", status);
            }
            else
            {
                this.LoginMailTextBox.Text = "";
                this.LoginPassTextBox.Text = "";

                this.LoginScreen.Show();
                this.ResetView();
            }
        }

        /// <summary>
        /// Resets the UI
        /// Called when the user logs out
        /// On next log in the UI will be as familiar as each time
        /// </summary>
        private void ResetView()
        {
            if (menuExpanded)
            {
                this.ExpandMenu();
            }
            if (this.MVPWrapperPanel.HasChildren)
            {
                this.MVPWrapperPanel.Controls.Clear();
            }
            if (this.MailListView.HasChildren)
            {
                this.MailListView.Controls.Clear();
            }
        }
    }
}
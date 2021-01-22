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
    public partial class MailThumbnail : UserControl
    {
        public Control _viewportWrapper { get; set; }
        private Mail _mail;

        // TODO: Proper binding with a binding class to specify all colours and such
        // This specific binding class will be instantiated when the MailThumbnail is created

        private Binding bindingSender;
        private Binding bindingSubject;
        private Binding bindingBody;

        // Reads the mail's metadata colour, returning it in a System.Drawing.Color type
        private Color GetColour()
        {
            switch (_mail.metadata.colour)
            {
                case "blue":
                    return Properties.Settings.Default.cm_blue;
                case "cyan":
                    return Properties.Settings.Default.cm_cyan;
                case "green":
                    return Properties.Settings.Default.cm_green;
                case "yellow":
                    return Properties.Settings.Default.cm_yellow;
                case "orange":
                    return Properties.Settings.Default.cm_orange;
                case "red":
                    return Properties.Settings.Default.cm_red;
                case "magenta":
                    return Properties.Settings.Default.cm_magenta;
                case "purple":
                    return Properties.Settings.Default.cm_purple;
                default:
                    return _mail.metadata.read == false ? Properties.Settings.Default.bgd_24dp : Properties.Settings.Default.bgd_08dp;
            }
        }

        private string GetFlagIcon()
        {
            return _mail.metadata.folder == "Spam" ? Properties.Settings.Default.icon_flagged : Properties.Settings.Default.icon_unflagged;
        }

        private void MailThumbnail_Click(object sender, EventArgs e)
        {
            _mail.metadata.read = true;
            CheckRead();
            Control viewport = _viewportWrapper.Controls["MVPPanel"];

            if (!viewport.Visible)
            {
                _viewportWrapper.Controls["MailComposer"].Hide();
                viewport.Show();
            }

            viewport.Controls["MVPBodyLabel"]
                     .Text = _mail.body;

            // Title
            // Setting the mail subject into the title of the viewport
            viewport.Controls["MVPHeaderPanel"]
                     .Controls["MVPTitlePanel"]
                     .Controls["MVPTitleLabel"]
                     .Text = _mail.subject;
            // Sender
            // Setting the mail subject into the title of the viewport
            viewport.Controls["MVPHeaderPanel"]
                     .Controls["MVPTitlePanel"]
                     .Controls["MVPSenderLabel"]
                     .Text = _mail.from;

            // Colour
            // Setting the viewport colour button's colour to the mail's colour
            viewport.Controls["MVPHeaderPanel"]
                     .Controls["MVPActionsPanel"]
                     .Controls["ColourBtn"]
                     .ForeColor = GetColour();

            // Body
            // Setting the body from the mail object into the viewport body
            viewport.Controls["MVPHeaderPanel"]
                     .Controls["MVPActionsPanel"]
                     .Controls["FlagBtn"]
                     .Text = GetFlagIcon();
        }

        private void CheckColour()
        {
            // Colour mark calibration
            this.ColourMark.BackColor = GetColour();
        }

        private void CheckRead()
        {
            // Read/Unread calibration colour binding
            if (_mail.metadata.read == false)
            {
                this.InnerWrapperPanel.BackColor = Properties.Settings.Default.bgd_24dp;
                this.UnreadMark.BackColor = Properties.Settings.Default.tds_24dp;
            }
            else
            {
                this.UnreadMark.Visible = false;
                this.InnerWrapperPanel.BackColor = Properties.Settings.Default.bgd_08dp;
                this.CheckColour();
            }
        }

        private void Bind()
        {
            // Sender Label text binding
            this.bindingSender = new Binding("Text", _mail, "from", true, DataSourceUpdateMode.OnPropertyChanged);
            this.SenderLabel.DataBindings.Add(bindingSender);

            // Subject Label text binding
            this.bindingSubject = new Binding("Text", _mail, "subject", true, DataSourceUpdateMode.OnPropertyChanged);
            this.SubjectLabel.DataBindings.Add(bindingSubject);

            // Body Label text binding
            this.bindingBody = new Binding("Text", _mail, "body", true, DataSourceUpdateMode.OnPropertyChanged);
            this.BodyPreviewLabel.DataBindings.Add(bindingBody);

            // Timestamp Label text binding
            //var bindingTimestamp = new Binding("Text", this, "timeStamp");
            //this.TimestampLabel.DataBindings.Add(bindingTimestamp);
            this.TimestampLabel.Text = _mail.timestamp.ToShortTimeString();

            this.CheckRead();

            this.CheckColour();
        }
        
        public MailThumbnail(Mail mail)
        {
            InitializeComponent();
            _mail = mail;
            this.Bind();
        }
    }
}

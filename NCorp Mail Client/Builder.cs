using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCorp_Mail_Client
{
    class MailViewport
    {
        private Mail mail;
        public Mail Mail
        {
            get { return mail; }
        }

        private Panel outer_wrapper_panel = new Panel();

        public Panel Element
        {
            get { return outer_wrapper_panel; }
        }

        // The UI elements for the title and info part of the email
        private Panel inner_top_panel = new Panel();        // Panel for title and info about the mail

        private Panel title_panel = new Panel();            // Contains title elements
        private Panel title_actions_panel = new Panel();    // Contains buttons to manipulate current mail  
        private Panel title_text_panel = new Panel();       // Contains title_label
        private Label title_label = new Label();            // Contains the "title" - the subject of the mail

        private Panel extra_panel = new Panel();            // Contains the sender info of the mail
        private Panel extra_actions_panel = new Panel();    // Contains buttons to manipulate the sender address - eg. save as contact
        private Panel extra_text_panel = new Panel();       // Contains extra_label
        private Label extra_label = new Label();            // Contains the sender's mail address

        // The UI elements for the body part of the email
        private Panel inner_bot_panel = new Panel();        // Panel for the mail's body

        private Panel body_text_panel = new Panel();        // Contains body_label
        private Label body_label = new Label();             // Contains the body text of the mail

        public MailViewport(Mail mail)
        {
            this.mail = mail;
            //
            // Outer Wrapper
            //
            outer_wrapper_panel.Dock = DockStyle.Fill;
            outer_wrapper_panel.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);

            //
            // Top Panel
            //
            outer_wrapper_panel.Controls.Add(inner_top_panel);
            inner_top_panel.Dock = DockStyle.Top;
            inner_top_panel.Height = 100;

            //
            // Title Content Panel
            //
            inner_top_panel.Controls.Add(title_panel);
            title_panel.Dock = DockStyle.Top;
            title_panel.Height = 50;

            //
            // Actions Panel
            //
            title_panel.Controls.Add(title_actions_panel);
            title_actions_panel.Dock = DockStyle.Right;
            title_actions_panel.Width = 100;

            // TODO: Add action buttons to manipulate email
            //title_actions_panel.Controls.Add(button);

            //
            // Title Text
            //
            title_panel.Controls.Add(title_text_panel);
            title_text_panel.Dock = DockStyle.Fill;

            //
            // Title Label
            //
            title_text_panel.Controls.Add(title_label);
            title_label.Dock = DockStyle.Top;
            title_label.Text = mail.subject;
            title_label.Font = Properties.Settings.Default.std_font;
            title_label.ForeColor = Properties.Settings.Default.tds_24dp;

            //
            // Bot Panel
            //
            outer_wrapper_panel.Controls.Add(inner_bot_panel);
            inner_bot_panel.Dock = DockStyle.Fill;

            //
            // Body Label
            //
            inner_bot_panel.Controls.Add(body_label);
            body_label.Dock = DockStyle.Top;
            body_label.Text = mail.body;
            body_label.Font = Properties.Settings.Default.std_font;
            body_label.ForeColor = Properties.Settings.Default.tds_24dp;

        }
    }
    class Thumbnail
    {
        private Mail mail;
        public Mail Mail
        {
            get { return mail; }
        }

        private Panel outer_wrapper_panel = new Panel();    // Outer wrapper panel

        public Panel Element
        {
            get { return outer_wrapper_panel; }
        }

        private Panel outer_panel = new Panel();            // Outer content panel
        private Panel inner_wrapper_panel = new Panel();    // Inner wrapper panel
        private Panel inner_panel = new Panel();            // Inner content panel

        private Panel unread_mark = new Panel();            // Unread mark Panel
        private Panel colour_mark = new Panel();            // Panel for colour mark if present

        private Panel text_panel = new Panel();             // Panel for showing the text

        private Panel info_panel = new Panel();             // Panel for timestamp and quick actions
        private Panel info_time_panel = new Panel();        // Contain the timestamp of the email
        private Panel info_actions_panel = new Panel();     // Actions panel to contain wuick action
        private Label timestamp_label = new Label();        // The timestamp label

        private Label sender_label = new Label();           // The sender's email address
        private Label subject_label = new Label();          // The sujbject of the email
        private Label body_preview_label = new Label();     // A Preview of the email's body

        public Thumbnail(Mail mail)
        {
            this.mail = mail;
            // TODO: implement method to cut string to a preview string - for body and subject, maybe sender mail address.

            //
            // Outer Wrapper
            // the outer most wrapper
            //
            outer_wrapper_panel.Dock = DockStyle.Top;
            outer_wrapper_panel.Height = 100;
            outer_wrapper_panel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);

            //
            // Outer Panel
            // outer panel properties
            //
            outer_wrapper_panel.Controls.Add(outer_panel);
            outer_panel.Dock = DockStyle.Fill;
            if (mail.metadata.read)
            {
                outer_panel.BackColor = Properties.Settings.Default.bgd_04dp;
            }
            else
            {
                outer_panel.BackColor = Properties.Settings.Default.bgd_24dp;
            }

            //
            // Colour Mark
            // Setting the colour mark properties
            //
            outer_panel.Controls.Add(colour_mark);
            colour_mark.Dock = DockStyle.Left;
            colour_mark.Width = 6;
            switch (mail.metadata.colour)
            {
                case "blue":
                    colour_mark.BackColor = Properties.Settings.Default.cm_blue;
                    break;
                case "cyan":
                    colour_mark.BackColor = Properties.Settings.Default.cm_cyan;
                    break;
                case "green":
                    colour_mark.BackColor = Properties.Settings.Default.cm_green;
                    break;
                case "yellow":
                    colour_mark.BackColor = Properties.Settings.Default.cm_yellow;
                    break;
                case "orange":
                    colour_mark.BackColor = Properties.Settings.Default.cm_orange;
                    break;
                case "red":
                    colour_mark.BackColor = Properties.Settings.Default.cm_red;
                    break;
                case "magenta":
                    colour_mark.BackColor = Properties.Settings.Default.cm_magenta;
                    break;
                case "purple":
                    colour_mark.BackColor = Properties.Settings.Default.cm_purple;
                    break;
                default:
                    //colour_mark.BackColor = Properties.Settings.Default.bgd_24dp;
                    break;
            }

            //
            // Unread Mark
            // Setting the unread mark properties
            //
            outer_panel.Controls.Add(unread_mark);
            unread_mark.Dock = DockStyle.Bottom;
            unread_mark.Height = 5;
            if (mail.metadata.read)
            {
                unread_mark.Visible = false;
            }
            else
            {
                unread_mark.BackColor = Properties.Settings.Default.tds_24dp;
            }

            //
            // Inner Wrapper
            // Setting the inner wrapper panel
            //
            outer_panel.Controls.Add(inner_wrapper_panel);
            inner_wrapper_panel.Dock = DockStyle.Fill;
            //inner_wrapper_panel.BackColor = Properties.Settings.Default.bgd_24dp;
            inner_wrapper_panel.Padding = new System.Windows.Forms.Padding(24, 0, 30, 0);

            //
            // Inner Content Panel
            // Setting the inner content panel
            //
            inner_wrapper_panel.Controls.Add(inner_panel);
            inner_panel.Dock = DockStyle.Fill;
            //inner_panel.BackColor = Properties.Settings.Default.bgd_01dp;
            inner_panel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);

            //
            // Info Panel
            // Setting the inner actions panel
            //
            inner_panel.Controls.Add(info_panel);
            info_panel.Dock = DockStyle.Right;
            info_panel.Width = 50;

            // The timestamp panel settings
            info_panel.Controls.Add(info_time_panel);
            info_time_panel.Dock = DockStyle.Bottom;
            info_time_panel.Height = 50;

            // The timestamp text settings
            info_time_panel.Controls.Add(timestamp_label);
            timestamp_label.Dock = DockStyle.Top;
            timestamp_label.Text = mail.timestamp.ToShortTimeString();
            timestamp_label.Font = Properties.Settings.Default.std_font;
            timestamp_label.ForeColor = Properties.Settings.Default.tds_24dp;

            // The actions panel settings
            info_panel.Controls.Add(info_actions_panel);
            info_actions_panel.Dock = DockStyle.Fill;

            //
            // Text Panel
            // Setting the inner text content panel
            //
            inner_panel.Controls.Add(text_panel);
            text_panel.Dock = DockStyle.Fill;
            //text_panel.BackColor = Properties.Settings.Default.bgd_24dp;

            // Body Preview Label
            text_panel.Controls.Add(body_preview_label);
            body_preview_label.Dock = DockStyle.Top;
            body_preview_label.Text = mail.body;
            body_preview_label.Font = Properties.Settings.Default.std_font;
            body_preview_label.ForeColor = Properties.Settings.Default.tdm_24dp;

            // Subject Preview Label
            text_panel.Controls.Add(subject_label);
            subject_label.Dock = DockStyle.Top;
            subject_label.Text = mail.subject;
            subject_label.Font = Properties.Settings.Default.std_font;
            subject_label.ForeColor = Properties.Settings.Default.tds_24dp;

            // Sender Label
            text_panel.Controls.Add(sender_label);
            sender_label.Dock = DockStyle.Top;
            sender_label.Text = mail.from;
            sender_label.Font = Properties.Settings.Default.std_font;
            sender_label.ForeColor = Properties.Settings.Default.tds_24dp;

            // Add the new mail thumbnail to the list view
            // Panel mail_list_panel = Application.OpenForms["EmailClient"].Controls["MailListView"] as Panel;
            // Control list = FormView.Controls["MailListView"];
            // list.Controls.Add(outer_panel);

            //return outer_wrapper_panel;
        }
    }
    partial class EmailClient
    {
        /*
        private EmailClient Client;
        public Builder(EmailClient client)
        {
            Client = client;
        }
        */
        private void CreateThumbnail(Mail new_mail)
        {
            Thumbnail temp = new Thumbnail(new_mail);
            Panel new_tn = temp.Element;
            new_tn.Click += new System.EventHandler(this.Thumbnail_Click);
            MailListView.Controls.Add(new_tn);
        }

        private void CreateMailViewport(Mail mail)
        {
            MailViewport mvp = new MailViewport(mail);
            Panel new_mvp = mvp.Element;
            MailViewportPanel.Controls.Add(new_mvp);
        }
    }
}

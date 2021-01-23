using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCorp_Mail_Client
{
    class Builder
    {
        public Builder()
        {
        }
        public Panel Thumbnail(Mail new_mail)
        {
            Panel outer_wrapper_panel = new Panel();    // Outer wrapper panel
            Panel outer_panel = new Panel();            // Outer content panel
            Panel inner_wrapper_panel = new Panel();    // Inner wrapper panel
            Panel inner_panel = new Panel();            // Inner content panel

            Panel unread_mark = new Panel();            // Unread mark Panel
            Panel colour_mark = new Panel();            // Panel for colour mark if present

            Panel text_panel = new Panel();             // Panel for showing the text

            Panel info_panel = new Panel();             // Panel for timestamp and quick actions
            Panel info_time_panel = new Panel();        // Contain the timestamp of the email
            Panel info_actions_panel = new Panel();     // Actions panel to contain wuick action
            Label timestamp_label = new Label();        // The timestamp label

            Label sender_label = new Label();           // The sender's email address
            Label subject_label = new Label();          // The sujbject of the email
            Label body_preview_label = new Label();     // A Preview of the email's body

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
            if (new_mail.metadata.read)
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
            switch (new_mail.metadata.colour)
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
            if (new_mail.metadata.read)
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
            timestamp_label.Text = new_mail.metadata.timestamp.ToShortTimeString();
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
            body_preview_label.Text = new_mail.body;
            body_preview_label.Font = Properties.Settings.Default.std_font;
            body_preview_label.ForeColor = Properties.Settings.Default.tdm_24dp;

            // Subject Preview Label
            text_panel.Controls.Add(subject_label);
            subject_label.Dock = DockStyle.Top;
            subject_label.Text = new_mail.subject;
            subject_label.Font = Properties.Settings.Default.std_font;
            subject_label.ForeColor = Properties.Settings.Default.tds_24dp;

            // Sender Label
            text_panel.Controls.Add(sender_label);
            sender_label.Dock = DockStyle.Top;
            sender_label.Text = new_mail.from;
            sender_label.Font = Properties.Settings.Default.std_font;
            sender_label.ForeColor = Properties.Settings.Default.tds_24dp;

            // Add the new mail thumbnail to the list view
            // Panel mail_list_panel = Application.OpenForms["EmailClient"].Controls["MailListView"] as Panel;
            // Control list = FormView.Controls["MailListView"];
            // list.Controls.Add(outer_panel);
            return outer_wrapper_panel;
        }
    }
}

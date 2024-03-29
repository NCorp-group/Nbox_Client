﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Drawing;

namespace NCorp_Mail_Client
{    public class Mail
    {
        public class Metadata
        {
            public Guid mail_GUID { get; set; }
            public Guid user_GUID { get; set; }
            public bool read { get; set; }
            public bool seen { get; set; }
            public bool draft { get; set; }
            public bool deleted { get; set; }
            public string folder { get; set; }
            public string colour { get; set; }
            public DateTime timestamp { get; set; }
            public Metadata(string folder, string colour, bool draft)
            {
                mail_GUID = Guid.NewGuid();
                this.read = false;
                this.seen = false;
                this.draft = draft;
                this.deleted = false;
                this.folder = folder;
                this.colour = colour;
                this.timestamp = DateTime.Now;

            }
        }
        public Metadata metadata;

        public string from { get; set; }
        public List<string> to = new List<string>();
        public List<string> cc = new List<string>();
        public string subject { get; set; }
        public string body { get; set; }

        public Mail(string in_mail_string)
        {
            this.metadata = new Metadata("Inbox", "none", false);
            this.from_json(in_mail_string);
        }

        public Mail(string folder, string colour, bool draft)
        {
            this.metadata = new Metadata(folder, colour, draft);
        }

        public Mail()
        {
            this.metadata = new Metadata("Inbox", "none", false);
        }

        public void from_json(string in_mail)
        {
            Mail in_obj = JsonConvert.DeserializeObject<Mail>(in_mail);

            // The mail fields
            this.from = in_obj.from;
            this.to = in_obj.to;
            this.cc = in_obj.cc;
            this.subject = in_obj.subject;
            this.body = in_obj.body;
            this.metadata.timestamp = in_obj.metadata.timestamp;

            // Metadata fields
            // GUID for mail and metadata
            this.metadata.mail_GUID = in_obj.metadata.mail_GUID;

            // The boolean fields
            this.metadata.read = in_obj.metadata.read;
            this.metadata.seen = in_obj.metadata.seen;
            this.metadata.draft = in_obj.metadata.draft;
            this.metadata.deleted = in_obj.metadata.deleted;

            // The string fields
            this.metadata.folder = in_obj.metadata.folder;
            this.metadata.colour = in_obj.metadata.colour;
        }

        public void Test_mail(string in_from, string in_to, string in_cc, string in_subject, string in_body)
        {
            this.from = in_from;
            this.to.Add(in_to);
            this.cc.Add(in_cc);
            this.subject = in_subject;
            this.body = in_body;
        }

        public string to_json()
        {
            string out_string = JsonConvert.SerializeObject(this, Formatting.Indented);
            return out_string;
        }

        public Color GetColour()
        {
            switch (this.metadata.colour)
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
                    return this.metadata.read == false ? Properties.Settings.Default.bgd_24dp : Properties.Settings.Default.bgd_08dp;
            }
        }
        public string GetFlagIcon()
        {
            return this.metadata.folder == "Spam" ? Properties.Settings.Default.icon_flagged : Properties.Settings.Default.icon_unflagged;
        }
    }
}

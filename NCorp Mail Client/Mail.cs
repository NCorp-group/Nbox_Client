using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NCorp_Mail_Client
{
    class Mail
    {
        private string from;
        private List<string> to;
        private List<string> Cc;
        private string subject;
        private string body;
        private string timestamp;

        public Mail(string in_mail_string)
        {
            this.from_json(in_mail_string);
        }

        public Mail()
        {

        }

        public void from_json(string in_mail)
        {
            Mail in_obj = JsonConvert.DeserializeObject<Mail>(in_mail);
            this.from = in_obj.from;
            this.to = in_obj.to;
            this.Cc = in_obj.Cc;
            this.subject = in_obj.subject;
            this.body = in_obj.body;
            this.timestamp = in_obj.timestamp;
        }

        public void test(string in_from, string in_to, string Cc, string subject, string body)
        {

        }

        public void to_json()
        {
            string out_string = JsonConvert.SerializeObject(this);
        }
    }
}

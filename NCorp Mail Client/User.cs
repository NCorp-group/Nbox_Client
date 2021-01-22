using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NCorp_Mail_Client
{
    public class User
    {
        public class Metadata
        {
            public Guid user_GUID;
            public string mail_address;
        }
        public Metadata metadata;
        public List<Mail> mails = new List<Mail>();
    }
}

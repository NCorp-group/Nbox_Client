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
        public string username;
        public List<Mail> mails = new List<Mail>();
        public List<string> folders = new List<string>();
        public User(string username)
        {
            this.username = username;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NCorp_Mail_Client
{
    class NMAPRequest
    {
        public String command { get; set; }
        public List<String> arguments { get; set; }
        public List<String> body { get; set; }

        public NMAPRequest(String command, List<String> attributes, List<String> body)
        {
            this.command = command;
            this.arguments = attributes;
            this.body = body;
        }
    };

    class NMAPResponse
    {
        public int status { get; set; }
        public List<String> body { get; set; }

        public NMAPResponse(int status, List<String> body)
        {
            this.status = status;
            this.body = body;
        }
    };
    public partial class EmailClient
    {
        /// <summary>
        /// Fetch emails from the server from the given user.
        /// If @param deep is true, then fetch all files received by the user, else
        /// only the mails which have not been seen by the user i.e. new mails which
        /// have not been fetched before.
        /// </summary>
        /// <param name="deep"> </param>
        public void FetchMails(bool deep = false)
        {
            string userPath = Path.Combine(MAILDIR_ROOT, this.currentUser.username + ".json");
            var opts = new List<String>();
            // If the user doesn't have a .json file, deep fetch.
            if (!File.Exists(userPath) || deep)
            {
                if (deep) opts.Add("deep");
            }
  
            NMAPRequest message = new NMAPRequest("fetch_mails", opts, new List<String>());
            string json_msg = JsonConvert.SerializeObject(message);
            (int status, List<String> body) = TCPconnection.message(json_msg);

            if (status != 200)
            {
                throw new Exception(String.Format("Could not fetch mails, error code {0}", status));
            }

            // concatenate to a single string, to macth the DeserializeObject<T> interface
            String strings = String.Join("", body);

            var fetchedMails = new List<Mail>();
            foreach(String str in body)
            {
                Mail mail = JsonConvert.DeserializeObject<Mail>(str);
                fetchedMails.Add(mail);
            }
            fetchedMails.Reverse();
            
            List<Mail> existingMails = new List<Mail>();

            if (File.Exists(userPath))
            {
                string text = File.ReadAllText(userPath);                               // Reading all existing mails in the found file
                existingMails = JsonConvert.DeserializeObject<List<Mail>>(text);        // Deserialize existing mails into objects into a list of mails
            }
            if (existingMails == null) existingMails = new List<Mail>();                // Please don't remove this line
            if (fetchedMails != null)
            {
                foreach (var mail in fetchedMails)
                {
                    if (!existingMails.Any(m => m.metadata.mail_GUID == mail.metadata.mail_GUID))
                    {
                        existingMails.Add(mail);
                    }
                }
            }
            Console.WriteLine(existingMails);
            this.currentUser.mails = existingMails;
            string emailListString = JsonConvert.SerializeObject(existingMails, Formatting.Indented);

            File.WriteAllText(userPath, emailListString);
        }

        public void updateUserFile()
        {
            string mailPath = Path.Combine(MAILDIR_ROOT, this.currentUser.username + ".json");
            this.currentUser.mails.RemoveAll(mail => mail.metadata.deleted == true);
            string userMailStr = JsonConvert.SerializeObject(this.currentUser.mails);
            File.WriteAllText(mailPath, userMailStr);
        }

        /// <summary>
        /// Use this for the user login screen to authenticate the user. 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>Returns the error code, which should be handled by the caller.</returns>
        public int login(string email, string password)
        {
            var user_credentials = new List<String> { email, password };
            NMAPRequest message = new NMAPRequest("login", user_credentials, new List<string>());
            string messageJsonStr = JsonConvert.SerializeObject(message);
            (int status, List<String> body) = TCPconnection.message(messageJsonStr);
            return status;
        }

        public int markAsRead(Mail mail)
        {
            var arguments = new List<String> { mail.metadata.mail_GUID.ToString() };
            NMAPRequest message = new NMAPRequest("mark_read", arguments, new List<string>());
            string messageJsonStr = JsonConvert.SerializeObject(message);
            Console.WriteLine("in markAsRead sending request NMAPRequest {0}", messageJsonStr);
            (int status, List<String> body) = TCPconnection.message(messageJsonStr);
            return status;
        }

        public int markColour(Mail mail)
        {
            var arguments = new List<String> { mail.metadata.colour, mail.metadata.mail_GUID.ToString() };
            NMAPRequest message = new NMAPRequest("mark_colour", arguments, new List<string>());
            string messageJsonStr = JsonConvert.SerializeObject(message);
            Console.WriteLine("in markAsRead sending request NMAPRequest {0}", messageJsonStr);
            (int status, List<String> body) = TCPconnection.message(messageJsonStr);
            return status;
        }

        public int deleteMail(Mail mail)
        {
            var arguments = new List<String> { mail.metadata.mail_GUID.ToString() };
            NMAPRequest message = new NMAPRequest("delete_mail", arguments, new List<string>());
            string messageJsonStr = JsonConvert.SerializeObject(message);
            Console.WriteLine("in markAsRead sending request NMAPRequest {0}", messageJsonStr);
            (int status, List<String> body) = TCPconnection.message(messageJsonStr);
            return status;

        }

        private HashSet<string> getFolders()
        {
            string path = Path.Combine(MAILDIR_ROOT, currentUser.username + ".json");
            var folders = new HashSet<string>();
            if (File.Exists(path))
            {
                var text = File.ReadAllText(path);
                var mails = JsonConvert.DeserializeObject<List<Mail>>(text);
                mails.ForEach(mail => folders.Add(mail.metadata.folder));
            }
            return folders;
        }

        public int logout()
        {
            NMAPRequest message = new NMAPRequest("logout", new List<string>(), new List<string>());
            string messageStr = JsonConvert.SerializeObject(message);
            (int status, List<String> body) = TCPconnection.message(messageStr);

            return status;
        }

        public int changeFolder(string folder, Mail mail)
        {
            var arguments = new List<String> { folder , mail.metadata.mail_GUID.ToString()};
            NMAPRequest message = new NMAPRequest("change_folder", arguments, new List<string>());
            string messageJsonStr = JsonConvert.SerializeObject(message);
            Console.WriteLine("in markAsRead sending request NMAPRequest {0}", messageJsonStr);
            (int status, List<String> body) = TCPconnection.message(messageJsonStr);
            return status;
        }
    }
}

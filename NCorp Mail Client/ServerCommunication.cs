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
            var opts = new List<String>();
            if (deep) opts.Add("deep");
  
            NMAPRequest message = new NMAPRequest("fetch_mails", opts, new List<String>());
            string json_msg = JsonConvert.SerializeObject(message);
            (int status, List<String> body) = TCPconnection.message(json_msg);

            //NMAPResponse response_obj = JsonConvert.DeserializeObject<NMAPResponse>(response_raw);

            if (status != 200)
            {
                throw new Exception(String.Format("Could not fetch mails, error code {0}", status));
            }

            // concatenate to a single string, to macth the DeserializeObject<T> interface
            String strings = String.Join("", body);
            //Console.WriteLine(strings);

            var fetchedMails = new List<Mail>();
            foreach(String str in body)
            {
                Mail mail = JsonConvert.DeserializeObject<Mail>(str);
                fetchedMails.Add(mail);
            }
            fetchedMails.Reverse();

            // List<Mail> fetchedMails = JsonConvert.DeserializeObject<List<Mail>>(strings);  // Deserialize fetched mails intoo bjects into a list of mails

            string mailPath = Path.Combine(MAILDIR_ROOT, this.currentUser.username + ".json");
            List<Mail> existingMails = new List<Mail>();

            if (File.Exists(mailPath))
            {
                string text = File.ReadAllText(mailPath);                               // Reading all existing mails in the found file
                existingMails = JsonConvert.DeserializeObject<List<Mail>>(text);        // Deserialize existing mails into objects into a list of mails
                                                                                        // fetchedMails.ForEach(mail => existingMails.Add(mail));               // Dump all existing fetchedMails into existingMails
                if (existingMails == null) existingMails = new List<Mail>();
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
                
            }
            Console.WriteLine(existingMails);
            this.currentUser.mails = existingMails;
            string emailListString = JsonConvert.SerializeObject(existingMails, Formatting.Indented);

            File.WriteAllText(mailPath, emailListString);
        }

        public void updateUserFile()
        {
            string mailPath = Path.Combine(MAILDIR_ROOT, this.currentUser.username + ".json");
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
    }
}

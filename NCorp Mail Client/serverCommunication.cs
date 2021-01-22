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
        public List<String> attributes { get; set; }
        public List<String> body { get; set; }

        public NMAPRequest(String command, List<String> attributes, List<String> body)
        {
            this.command = command;
            this.attributes = attributes;
            this.body = body;
        }
    };

    class NMAPResponse
    {
        public int status { get; set; }
        public String[] body { get; set; }

        public NMAPResponse(int status, String[] body)
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
        public void fetchEmails(bool deep = false)
        {
            var opts = new List<String>();
            if (deep) opts.Add("deep");

            NMAPRequest message = new NMAPRequest("fetch_emails", opts, null);
            string json_msg = JsonConvert.SerializeObject(message);
            string response_raw = TCPconnection.message(json_msg);
            NMAPResponse response_obj = JsonConvert.DeserializeObject<NMAPResponse>(response_raw);

            if (response_obj.status != 200)
            {
                throw new Exception(String.Format("Could not fetch emails, error code {0}", response_obj.status));
            }

            // concatenate to a single string, to macth the DeserializeObject<T> interface
            String strings = String.Join("", response_obj.body);
            List<Mail> fetchedMails = JsonConvert.DeserializeObject<List<Mail>>(strings);  // Deserialize fetched mails intoo bjects into a list of mails

            string path = "mails.json"; // TODO: Make path dependant on user
            List<Mail> existingMails = new List<Mail>();

            if (File.Exists(path))
            {
                string text = File.ReadAllText(path);                                   // Reading all existing mails in the found file
                existingMails = JsonConvert.DeserializeObject<List<Mail>>(text);        // Deserialize existing mails into objects into a list of mails
                fetchedMails.ForEach(mail => existingMails.Append(mail));               // Dump all existing fetchedMails into existingMails
            }

            string emailListString = JsonConvert.SerializeObject(existingMails);
            File.WriteAllText(path, emailListString);

            // TODO how does the application access the mails (RAM, or read entire file)???
        }

        /// <summary>
        /// Use this for the user login screen to authenticate the user. 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>Returns the error code, which should be handled by the caller.</returns>
        public int login(string username = "test", string password = "test")
        {
            var user_credentials = new List<String> { username, password };
            NMAPRequest message = new NMAPRequest("login", user_credentials, null);
            string json_msg = JsonConvert.SerializeObject(message);
            string response_raw = TCPconnection.message(json_msg);
            NMAPResponse response_obj = JsonConvert.DeserializeObject<NMAPResponse>(response_raw);

            return response_obj.status;

        }
    }
}

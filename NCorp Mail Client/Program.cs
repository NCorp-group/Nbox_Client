using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NCorp_Mail_Client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
            Mail out_mail = new Mail("Inbox", "none");
            out_mail.Test_mail("jens", "kevork", "kristoffer", "this is a subject", "this is the body");
            string out_json = out_mail.to_json();
            Console.Write(out_json);

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "out.json")))
            {
                outputFile.Write(out_json);
            }

            string in_json;
            using (var sr = new StreamReader("C:/Users/jensj/Documents/out.json"))
            {
                in_json = sr.ReadToEnd();
            }
            Mail in_mail = new Mail(in_json);
            in_mail.to.Add("lorenzo");
            in_mail.cc.Add("lorenzo");
            in_mail.Read();
            in_mail.MoveToFolder("Spam");
            in_mail.MarkColour("green");
            string in_mjson = in_mail.to_json();

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "new.json")))
            {
                outputFile.Write(in_mjson);
            }
            */

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EmailClient());
        }
    }
}

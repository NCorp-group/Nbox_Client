using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCorp_Mail_Client
{
    class TCPHandler
    {
        private TcpClient client;
        private int privatePort;
        public TCPHandler()
        {
            try
            {
                this.client = new TcpClient("127.0.0.1", 61100);
            }
            catch (SocketException exp)
            {
                Console.WriteLine("{0}", exp.Message);
                return;
            }
            NetworkStream stream = client.GetStream();

            // Asking for a private port
            byte[] message_bytes = Encoding.ASCII.GetBytes("port_request");

            // Sending the message over the connection
            stream.Write(message_bytes, 0, message_bytes.Length);

            // Read the first batch of the TcpServer response bytes
            Byte[] response = new Byte[256];
            Int32 bytes = stream.Read(response, 0, response.Length);

            // Translating bytes to the responseData string variable
            String privatePortStr = String.Empty;
            privatePortStr = System.Text.Encoding.ASCII.GetString(response, 0, bytes);

            this.client.Close();
            try
            {
                privatePort = Int32.Parse(privatePortStr);
            }
            catch (FormatException)
            {
                Console.WriteLine("Input string is invalid.");
                return;
            }
        }
        /*~TCPHandler()
        {
            this.close_connection();
        }
        public void close_connection()
        {
            client.Close();
        }*/
        public string message(string message_str)
        {
            //
            // Following the Single-responsibility principle, this function encapsulates and simplifies the way clients interacts with the servers.
            //
            this.client = new TcpClient("127.0.0.1", privatePort);

            NetworkStream stream = this.client.GetStream();
            byte[] message_bytes = Encoding.ASCII.GetBytes(message_str);

            // Sending the message over the connection
            stream.Write(message_bytes, 0, message_bytes.Length);

            Byte[] response = new Byte[256];
            String responseStr = String.Empty;

            // Read the first batch of the TcpServer response bytes
            Int32 bytes = stream.Read(response, 0, response.Length);
            // Translating bytes to the responseData string variable
            responseStr = System.Text.Encoding.ASCII.GetString(response, 0, bytes);

            return responseStr;
        }

    }
}

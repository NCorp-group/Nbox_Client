using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace NCorp_Mail_Client
{
    public class TCPHandler
    {
        private TcpClient client;
        private int privatePort;
        private int serverPort;
        private string serverIP;
        public TCPHandler()
        {
            serverIP = "127.0.0.1";
            serverPort = 61100;
        }
        /// <summary>
        /// Use this for getting a private port and after timeouts.
        /// </summary>
        /// <returns>Returns true if a new private port is registered.</returns>
        public bool Handshake()
        {
            try
            {
                this.client = new TcpClient(this.serverIP, this.serverPort);
            }
            catch (SocketException exp)
            {
                Console.WriteLine("{0}", exp.Message);
                return false;
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
                return false;
            }
            return true;
        }
        public (int, List<String>) message(string message_str)
        {
            //
            // Following the Single-responsibility principle, this function encapsulates and simplifies the way clients interacts with the servers.
            //

            try
            {
                this.client = new TcpClient("127.0.0.1", privatePort);
            }
            catch (SocketException exp)
            {
                Console.WriteLine("exception caught: {0}", exp.Message);
                Console.WriteLine("Trying to reconnect to mail server...");
                if (Handshake())
                {
                    this.client = new TcpClient("127.0.0.1", privatePort);
                }
                else
                {
                    Console.WriteLine("failed to reconnect to server, no further action is taken");
                    return (11, new List<string>());
                }      
            }

            NetworkStream stream = this.client.GetStream();
            byte[] message_bytes = Encoding.ASCII.GetBytes(message_str);

            // Sending the message over the connection
            stream.Write(message_bytes, 0, message_bytes.Length);

            Byte[] response = new Byte[1000000];
            String responseStr = String.Empty;
            Console.WriteLine("response length {0}", response.Length);

            // Read the first batch of the TcpServer response bytes
            Int32 bytes = stream.Read(response, 0, response.Length);
            // Translating bytes to the responseData string variable
            responseStr = System.Text.Encoding.ASCII.GetString(response, 0, bytes);

            NMAPResponse responseObj = JsonConvert.DeserializeObject<NMAPResponse>(responseStr);

            return (responseObj.status, responseObj.body);
        }

    }
}

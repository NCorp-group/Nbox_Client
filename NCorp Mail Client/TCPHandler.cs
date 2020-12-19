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
        public TCPHandler()
        {
            this.client = new TcpClient("127.0.0.1", 61100);
            NetworkStream stream = client.GetStream();

            // Asking for a private port
            byte[] message_bytes = Encoding.ASCII.GetBytes("port_request");

            // Sending the message over the connection
            stream.Write(message_bytes, 0, message_bytes.Length);

            // Read the first batch of the TcpServer response bytes
            Byte[] response = new Byte[256];
            Int32 bytes = stream.Read(response, 0, response.Length);

            // Translating bytes to the responseData string variable
            String private_port = String.Empty;
            private_port = System.Text.Encoding.ASCII.GetString(response, 0, bytes);

            this.client.Close();

            int private_port_int;
            try
            {
                private_port_int = Int32.Parse(private_port);
            }
            catch (FormatException)
            {
                Console.WriteLine("Input string is invalid.");
                return;
            }


            this.client = new TcpClient("127.0.0.1", private_port_int);

        }
        ~TCPHandler()
        {
            this.close_connection();
        }
        public void close_connection()
        {
            client.Close();
        }
        public string message(string message_str)
        {
            //
            // Following the Single-responsibility principle, this function encapsulates and simplifies the way clients interacts with the servers.
            //

            NetworkStream stream = this.client.GetStream();
            byte[] message_bytes = Encoding.ASCII.GetBytes(message_str);

            // Sending the message over the connection
            stream.Write(message_bytes, 0, message_bytes.Length);

            Byte[] response = new Byte[256];
            String response_str = String.Empty;

            // Read the first batch of the TcpServer response bytes
            Int32 bytes = stream.Read(response, 0, response.Length);
            // Translating bytes to the responseData string variable
            response_str = System.Text.Encoding.ASCII.GetString(response, 0, bytes);

            return response_str;
        }

    }
}

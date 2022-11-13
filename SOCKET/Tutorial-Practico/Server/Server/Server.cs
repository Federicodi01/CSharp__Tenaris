using System;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    class Server
    {
        IPHostEntry host;
        IPAddress ipAddress;
        IPEndPoint endPoint;

        Socket s_Server;
        Socket s_Client;

        public Server(string ip, int port)
        {
            host = Dns.GetHostByName(ip);
            ipAddress = host.AddressList[0];
            endPoint = new IPEndPoint(ipAddress, port);

            s_Server = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            s_Server.Bind(endPoint);
            s_Server.Listen(10);
        }

        public void Start()
        {
            byte[] buffer = new byte[1024];
            string message;
            s_Client = s_Server.Accept();

            s_Client.Receive(buffer);
            message = Encoding.ASCII.GetString(buffer);
            Console.WriteLine($"Se recibio el siguiente mensaje: {message}");
        }
    }
}

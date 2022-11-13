using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    class Client
    {
        IPHostEntry host;
        IPAddress ipAddress;
        IPEndPoint endPoint;

        Socket s_Client;

        public Client(string ip, int port)
        {
            host = Dns.GetHostByName(ip);
            ipAddress = host.AddressList[0];
            endPoint = new IPEndPoint(ipAddress, port);

            s_Client = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Start()
        {
            s_Client.Connect(endPoint);
        }
        public void Send(string message)
        {
            byte[] byteMessage = Encoding.ASCII.GetBytes(message);
            s_Client.Send(byteMessage);
        }
    }
}

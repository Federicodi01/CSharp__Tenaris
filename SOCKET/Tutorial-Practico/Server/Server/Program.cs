using System;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server("localhost", 4404);
            server.Start();
        }
    }
}

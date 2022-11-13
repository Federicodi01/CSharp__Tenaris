using System;
using System.Threading;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("localhost", 4404);
            client.Start();
            client.Send("Hola, soy el cliente");
            Thread.Sleep(20000);
            client.Send("Hola, soy el cliente de nuevo");
            Console.ReadKey();
        }
    }
}

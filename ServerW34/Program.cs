using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace ServerW34
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener server = new TcpListener(IPAddress.Any, 11000);
            server.Start();
            while (true)
            {
                Socket client = server.AcceptSocket();
                ClientHandler c = new ClientHandler(client);
                Thread m = new Thread(new ThreadStart(c.Comunication));
                m.Start();
                //Comunication
                //NetworkStream stream = new NetworkStream(client);
                //Console.WriteLine("READY");
                //StreamReader reader = new StreamReader(stream);
                //StreamWriter writer = new StreamWriter(stream);
                //writer.AutoFlush = true;
                //Console.WriteLine(reader.ReadLine());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Sockets;
using System.Net;

namespace ClientW34
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClient server = new TcpClient("127.0.0.1", 11000);
            NetworkStream stream = server.GetStream();
            StreamReader reader = new StreamReader(stream);
            StreamWriter writer = new StreamWriter(stream);
            string text = "";
            text = Console.ReadLine();
            writer.AutoFlush = true;
            writer.WriteLine(text);
            writer.WriteLine(Console.ReadLine());
            writer.WriteLine(Console.ReadLine());
            writer.WriteLine(Console.ReadLine());
            writer.WriteLine(Console.ReadLine());
            Console.ReadKey();
        }
    }
}

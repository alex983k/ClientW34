using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;

namespace ServerW34
{
    class ClientHandler
    {
        private Socket Socket;

        public ClientHandler(Socket socket)
        {
            Socket = socket;
        }

        public void Comunication ()
        {
            NetworkStream stream = new NetworkStream(Socket);
            Console.WriteLine("READY");
            StreamReader reader = new StreamReader(stream);
            StreamWriter writer = new StreamWriter(stream);
            writer.AutoFlush = true;
            while(true)
            Console.WriteLine(reader.ReadLine());
        }
    }
}

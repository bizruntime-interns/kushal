using System;
using System.Net;
using System.Net.Sockets;
using System.Linq;
using System.Text;

namespace clientforclientserver
{
    class Program
    {
        static Socket sck;
        static void Main(string[] args)
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse("106.51.39.173"), 1234);
            try
            {
                sck.Connect(localEndPoint);
            }

            catch
            {
                Console.WriteLine("Unable to connect to remote end point");
                Main(args);
            }

            Console.Write("Enter Text:");
            string text = Console.ReadLine();
            byte[] data = Encoding.ASCII.GetBytes(text);

            sck.Send(data);
            Console.WriteLine("Data Sent");
            Console.Write("Press Any Key to continue...");
            Console.Read();
            sck.Close();

        }
    }
}

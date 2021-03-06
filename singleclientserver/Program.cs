﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace singleclientserver
{
    class Program
    {
        static byte[] Buffer { get; set; }
        static Socket sck;
        static void Main(string[] args)
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sck.Bind(new IPEndPoint(0, 1234));
            sck.Listen(100);

            Socket accepted = sck.Accept();
            Buffer = new byte[accepted.SendBufferSize];
            int bytesRead = accepted.Receive(Buffer);

            byte[] formatted = new byte[bytesRead];
            for (int i=0; i<bytesRead; i++)
            {
                formatted[i] = Buffer[i];
            }
            string strData = Encoding.ASCII.GetString(formatted);
            Console.WriteLine(strData);
            Console.Read();
            sck.Close();
            accepted.Close();
            
        }
    }
}

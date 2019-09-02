using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace perf
{
    class Program
    {
        private static DateTime log;

        static void Main(string[] args)
        {
            string mode;
            string _ip;
            log = DateTime.Now;
            
            Console.WriteLine("Define Server or Client.");
            Console.WriteLine("1. Server \n2. Client\n");
            mode = Console.ReadLine();

            int a = Convert.ToInt32(mode);

            Console.WriteLine("You Selected:{0}!",mode);
            Console.ReadKey();

            _ip = Console.ReadLine();
            // Console.WriteLine("TCP or UDP?");
            if (a == 1)
            {
                Console.WriteLine("No further input required...");
                _server();
            }
            else
            {            
                Console.WriteLine("Now enter the IP you'd like to connect to...");
                _ip = Console.ReadLine();
                _client(_ip);
            }
        }

        static void _server()
        {
            string strCmdText;
            strCmdText= "iperf -f m -i 1 -o -u -s";
            System.Diagnostics.Process.Start("CMD.exe",strCmdText + log);
        }

        static void _client(string _ip)
        {
            string strCmdText;
            strCmdText= "iperf -c -b 1 -u -t 30";
            System.Diagnostics.Process.Start("CMD.exe",strCmdText + _ip);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace webSiteIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            for (long ip = 0; ip < 4294967296; ip++)
            {
                try
                {
                    IPAddress ipAddress = new IPAddress(ip);
                    string hostName = Dns.GetHostEntry(ipAddress).HostName;
                    Console.WriteLine("IP: " + ipAddress);
                    Console.WriteLine("Host Name: " + hostName);

                }
                catch { }
            }

            Console.ReadLine();
        }
    }
}

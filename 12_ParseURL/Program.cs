using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseURL
{
    class Program
    {
        static void Main(string[] args)
        {
            string address = Console.ReadLine();

            // Protocol
            int protocolLength = address.IndexOf(':');
            string protocol = "[protocol] = " + address.Substring(0,protocolLength);
            Console.WriteLine(protocol);

            // Server
            int serverIndex = protocolLength + 3; 
            int serverLength = address.IndexOf('/',serverIndex) - serverIndex;
            string server = "[server] = " + address.Substring(serverIndex, serverLength);
            Console.WriteLine(server);

            //Resource
            int resourseIndex = serverIndex + serverLength;
            string resource = "[resource] = " + address.Substring(resourseIndex);
            Console.WriteLine(resource);
        }
    }
}

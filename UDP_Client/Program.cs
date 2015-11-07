using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace UDP_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyUdpClient.UdpServiceClient client = new MyUdpClient.UdpServiceClient("UdpBinding_IUdpService"))
            {
                client.DoWork();
                var d = new MyUdpClient.Datagram();
                d.Message = "Hali!";
                client.ProcessDatagram(d);

                Console.Read();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel;
using System.Text;
using UDP_Client.MyUdpClient;

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
                d.Message = "Called from UdpServiceClient!";
                client.ProcessDatagram(d);

            }

            var addressStr = ConfigurationManager.AppSettings["server.address"];
            var factory = new ChannelFactory<IUdpService>(new UdpBinding(),addressStr);
            var channel = factory.CreateChannel();

            channel.DoWork();

            var d2 = new MyUdpClient.Datagram();
            d2.Message = "Called with Chennel!";
            channel.ProcessDatagram(d2);

            //Console.Read();
        }
    }
}

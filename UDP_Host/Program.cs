using System;
using System.Configuration;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using UDP_Service;

namespace UDP_Host
{
    class Program
    {
        static void Main(string[] args)
        {
            //string address = ConfigurationManager.AppSettings["service.adress"];
            using (ServiceHost host = new ServiceHost(typeof(UdpService)))
            {
                host.Open();

                Console.WriteLine("Udp Service Host has started up.");
                Console.ReadLine();
            }       
        }
    }
}

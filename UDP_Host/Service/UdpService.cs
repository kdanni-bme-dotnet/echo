using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace UDP_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UdpService" in both code and config file together.
    public class UdpService : IUdpService
    {
        public void DoWork()
        {
            Console.WriteLine("Working...");
        }

        public void ProcessDatagram(Datagram datagram)
        {
            Console.WriteLine("Datagram: " + datagram.Message);
        }
    }
}

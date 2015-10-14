using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;

namespace WCF_Echo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Echo..");

            Uri baseAddress = new Uri("http://localhost:8000/echo");
            using (ServiceHost selfHost = new ServiceHost(typeof(EchoService), baseAddress))
            {
                //selfHost.AddServiceEndpoint(typeof(EchoService), new BasicHttpBinding(), "EchoService");
                selfHost.AddServiceEndpoint(typeof(EchoService), new WSHttpBinding(), "EchoService");

                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Add(smb);

                selfHost.Open();
                Console.WriteLine("The service is ready.");
                Console.ReadLine();

            }
        }
    }
}

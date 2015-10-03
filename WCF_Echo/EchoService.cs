using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Echo
{
    [ServiceContract]
    class EchoService
    {

        [OperationContract]
        void Echo(string line)
        {

            Console.WriteLine(line);
        }

    }
}

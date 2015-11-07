using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace UDP_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUdpService" in both code and config file together.
    [ServiceContract]
    public interface IUdpService
    {
        [OperationContract(IsOneWay = true)]
        void DoWork();

        [OperationContract(IsOneWay = true)]
        void ProcessDatagram(Datagram datagram);
    }

    [DataContract]
    public class Datagram
    {

        [DataMember]
        public string Metadata { get; set; }

        [DataMember(IsRequired = true)]
        public string Message { get; set; }

        [DataMember]
        public DateTime Timestamp { get; set; }

    }
}

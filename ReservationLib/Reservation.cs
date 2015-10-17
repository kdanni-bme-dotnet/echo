using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReservationLib
{
    [DataContract]
    public class Reservation
    {
        [DataMember]
        public string Sender { get; set; }

        [DataMember]
        public string Desc { get; set; }
    }
}

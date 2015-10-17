using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ReservationLib
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ReservationService" in both code and config file together.
    public class ReservationService : IReservationService
    {
        public string ReserveRoom(Reservation r)
        {
            Debug.WriteLine("Sender: " + r.Sender + ", Desc: " + r.Desc );
            return "Köszi!";
        }
    }
}

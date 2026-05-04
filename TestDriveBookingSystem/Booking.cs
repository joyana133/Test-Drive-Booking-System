using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDriveBookingSystem
{
    public class Booking
    {
        public Customer CustomerDetails { get; set; }
        public Vehicle VehicleAssigned { get; set; }
        public Staff StaffMember { get; set; }
        public DateTime DateTime { get; set; }
        public string Status { get; set; }

    }
}

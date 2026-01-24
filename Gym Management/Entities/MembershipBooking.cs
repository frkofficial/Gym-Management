using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management.Entities
{
    public class MembershipBooking
    {
        public int BookingID { get; set; }
        public string UserName { get; set; }
        public int UserID { get; set; }
        public string PackageName { get; set; }
        public decimal Price { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}

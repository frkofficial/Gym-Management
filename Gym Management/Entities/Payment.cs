using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management.Entities
{
    public class Payment
    {

        public int PaymentID { get; set; }
        public int CustomerID { get; set; }
        public int PackageId { get; set; }
        public string CustomerName { get; set; }
        public decimal PackageAmount { get; set; }
        public decimal TrainerPriceAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime PayingDate { get; set; }
        public string Status { get; set; }
        public string PaymentMethod { get; set; }
    }
}

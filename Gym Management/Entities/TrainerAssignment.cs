using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management.Entities
{
    public class TrainerAssignment
    {
        public int AssignmentId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string TrainerId { get; set; }
        public string TrainerName { get; set; }
        public string BookingDate { get; set; }
        public string ExpireDate { get; set; }
        public string TrainerPrice { get; set; }
    }
}

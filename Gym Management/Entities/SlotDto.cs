using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management.Entities
{
    public class SlotDto
    {
        public int Id { get; set; }
        public TimeSpan SlotTime { get; set; }
        public bool IsBooked { get; set; }
    }
}

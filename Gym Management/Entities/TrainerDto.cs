using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management.Entities
{
    public class TrainerDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Specialization { get; set; }
        public decimal HourlyRate { get; set; }
        public decimal Rating { get; set; }   // e.g. 4.9
        public List<string> ShiftNames { get; set; }   // ["Morning","Evening"]
    }
}

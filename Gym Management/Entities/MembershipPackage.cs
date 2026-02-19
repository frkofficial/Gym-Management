using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management.Entities
{
    internal class MembershipPackage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Decimal Price { get; set; }
        public Decimal AdmissionFee { get; set; }
        public bool IsStudentPlan { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }

    }
}

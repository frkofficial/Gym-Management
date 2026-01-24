using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management.Entities
{
    public class Admins
    {
        public int AdminId { get; set; }
        public string AdminUserName { get; set; }
        public string AdminPass { get; set; }
        public string UserType { get; set; }
    }
}

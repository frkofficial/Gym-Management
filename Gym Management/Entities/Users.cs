using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management.Entities
{
    public class Users
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
       
        public string UserPass { get; set; }
        
        public string UserType { get; set; }
        
        public string UserFirstName { get; set; }
        public string? UserLastName { get; set; }
        
        public string UserConPass { get; set; }
        public string UserPhone { get; set; }
        public string UserEmail { get; set; }
        public string UserAddress { get; set; }
        public string UserGender { get; set; }
        public int UserAge { get; set; }
        public float UserHeight { get; set; }
        public int UserWeight { get; set; }
        public int? UserWeightGoal { get; set; }
        public string UserTrainer { get; set; }
        public string? UserEmrPhone { get; set; }
        public string? UserMembership { get; set; }
        public string? UserJoinDate { get; set; }
        public string? UserLeaveDate { get; set; }


    }
}

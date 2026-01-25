using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using Gym_Management.Entities;

namespace Gym_Management.Repo
{
    
    internal class DashBoardRepo
    {
        DataAccess dataaccess;
        public DashBoardRepo()
        {
            dataaccess = new DataAccess();
        }

        public int EmployeeCount()
        {
            SqlCommand cmd = dataaccess.GetCommand(
                "SELECT COUNT(*) FROM EmpInfo"
            );
            return Convert.ToInt32(dataaccess.ExecuteScalar(cmd));
        }

        public int RegisteredMemberCount()
        {
            SqlCommand cmd = dataaccess.GetCommand(
                "SELECT COUNT(*) FROM UserInfo WHERE UserType = 'Member'"
            );
            return Convert.ToInt32(dataaccess.ExecuteScalar(cmd));
        }
        public int ActiveMemberCount()
        {
            SqlCommand cmd = dataaccess.GetCommand(
                "SELECT COUNT(DISTINCT CustomerID) FROM Payment WHERE Status = 'Paid'"
            );
            return Convert.ToInt32(dataaccess.ExecuteScalar(cmd));
        }

        public int DueMemberCount()
        {
            SqlCommand cmd = dataaccess.GetCommand(
                "SELECT COUNT(DISTINCT CustomerID) FROM Payment WHERE Status = 'Due'"
            );
            return Convert.ToInt32(dataaccess.ExecuteScalar(cmd));
        }

    }
}

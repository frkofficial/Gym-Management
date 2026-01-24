using Gym_Management.Entities;
using System;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management.Repo
{
    
    public class EmpRepo
    {
        DataAccess DataAccess;
        public EmpRepo()
        {
            DataAccess = new DataAccess();
        }

        public Employees LoginEmployee(string username, string password)
        {
            SqlCommand cmd = DataAccess.GetCommand("SELECT * FROM EmpInfo WHERE EmpName=@username AND EmpPass=@password");
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            DataTable dt = DataAccess.Execute(cmd);
            var rows = dt.Rows;
            if (rows.Count == 1)
            {
                return new Employees
                {
                    EmpId = Convert.ToInt32(rows[0]["EmpId"]),
                    EmpName = rows[0]["EmpName"].ToString(),
                    UserType = rows[0]["UserType"].ToString().ToLower()
                };
            }
            return null;
        }

    }
}

using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gym_Management.Entities;
namespace Gym_Management.Repo
{
   
    public class AdminRepo
    {
        DataAccess dataAccess;
      public AdminRepo()
        {
            dataAccess = new DataAccess();
        }
        public Admins LoginAdmin(string username, string password)
        {
            SqlCommand cmd = dataAccess.GetCommand("SELECT * FROM AdminInfo WHERE AdminUserName=@username AND AdminPass=@password");
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            DataTable dt = dataAccess.Execute(cmd);
            var rows = dt.Rows;
            if (rows.Count == 1)
            {
                return new Admins
                {
                    AdminId = Convert.ToInt32(rows[0]["AdminId"]),
                    AdminUserName = rows[0]["AdminUserName"].ToString(),
                    UserType = rows[0]["UserType"].ToString().ToLower()
                };
            }
            return null;
        }

    }
}

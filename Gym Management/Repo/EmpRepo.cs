using Gym_Management.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
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

        public string GetName(int id)
        {

            SqlCommand cmd = DataAccess.GetCommand(@"SELECT EmpName FROM EmpInfo WHERE EmpId=@id");
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            DataTable dt = DataAccess.Execute(cmd);
            var rows = dt.Rows;
            if (rows.Count > 0)
            {
                return rows[0]["EmpName"].ToString();
            }


            return "Unknown";
        }

        public string GetMembershipStatus(int Mid)
        {
            SqlCommand cmd = DataAccess.GetCommand(@"
                SELECT TOP 1
                    mb.ExpireDate,
                    ISNULL(p.Status, 'Due') AS PaymentStatus
                FROM MembershipBooking mb
                LEFT JOIN Payment p ON mb.UserId = p.CustomerID
                WHERE mb.UserId = @id
                ORDER BY mb.BookingId DESC");

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = Mid;

            DataTable dt = DataAccess.Execute(cmd);

            if (dt.Rows.Count == 0)
                return "No Package";

            if (dt.Rows[0]["ExpireDate"] == DBNull.Value)
                return "Pending";

            DateTime expireDate = Convert.ToDateTime(dt.Rows[0]["ExpireDate"]);
            string paymentStatus = dt.Rows[0]["PaymentStatus"].ToString();

            DateTime today = DateTime.Now.Date;
            DateTime expire = expireDate.Date;

            if (today > expire)
                return "Inactive";

            if (paymentStatus == "Paid")
            {
                int daysLeft = (expire - today).Days;
                if (daysLeft <= 7)
                    return "Expiring Soon";
                return "Active";
            }

            return "Due";
        }

        public void UpdateAllMembershipStatuses()
        {
            SqlCommand cmd = DataAccess.GetCommand(@"
                UPDATE mb
                SET mb.Status = 
                    CASE 
                        WHEN mb.ExpireDate IS NULL THEN 'Pending'
                        WHEN CAST(GETDATE() AS DATE) > CAST(mb.ExpireDate AS DATE) THEN 'Inactive'
                        WHEN ISNULL(p.Status, 'Due') <> 'Paid' THEN 'Due'
                        WHEN DATEDIFF(DAY, CAST(GETDATE() AS DATE), CAST(mb.ExpireDate AS DATE)) <= 7 
                            AND ISNULL(p.Status, 'Due') = 'Paid' THEN 'Expiring Soon'
                        WHEN ISNULL(p.Status, 'Due') = 'Paid' THEN 'Active'
                        ELSE 'Inactive'
                    END
                FROM MembershipBooking mb
                LEFT JOIN Payment p ON mb.UserId = p.CustomerID");

            DataAccess.ExecuteNonQuery(cmd);
        }

        public DataTable GetAssignedMembers()
        {
            SqlCommand cmd = DataAccess.GetCommand(@"
        SELECT 
            u.UserName AS Name,
            v.PackageName AS Package,
            v.CalculatedStatus AS Status,
            v.ExpireDate,
            v.DaysLeft AS [Days Left],
            v.PaymentStatus AS [Payment Status]
        FROM vw_MembershipStatus v
        INNER JOIN MemberInfo u ON v.UserId = u.UserId
        ORDER BY 
            CASE v.CalculatedStatus
                WHEN 'Due' THEN 1
                WHEN 'Expiring Soon' THEN 2
                WHEN 'Active' THEN 3
                WHEN 'Inactive' THEN 4
                ELSE 5
            END,
            v.ExpireDate ASC");

            return DataAccess.Execute(cmd);
        }
    }
}


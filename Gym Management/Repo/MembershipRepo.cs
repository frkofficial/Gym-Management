using Gym_Management.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management.Repo
{
    public class MembershipRepo
    {
        DataAccess dataAccess;
        public MembershipRepo()
        {
            dataAccess = new DataAccess();
        }

        public List<MembershipPackage> GetAll()
        {
            List<MembershipPackage> list = new List<MembershipPackage>();
            SqlCommand cmd = dataAccess.GetCommand("SELECT * FROM MembershipPackages");
        DataTable dt = dataAccess.Execute(cmd);
        var rows = dt.Rows;
           foreach(DataRow row in rows)
            {
               list.Add(new MembershipPackage{
                    Id = Convert.ToInt32(row["Id"]),
                    Name = row["Name"].ToString(),
                    Price = Convert.ToDecimal(row["Price"]),
                    AdmissionFee = Convert.ToDecimal(row["AdmissionFee"]),
                    Description = row["Description"].ToString(),
                    IsStudentPlan = Convert.ToBoolean(row["IsStudentPlan"]),
                    Duration = Convert.ToInt32(row["DurationMonths"])


                 });
               
            }
                  return list;


        }

        public int Insert(MembershipPackage package)
        {
            SqlCommand cmd = dataAccess.GetCommand(@"INSERT INTO MembershipPackages
                (Name, Price, AdmissionFee, Description, IsStudentPlan, DurationMonths)
                VALUES
                (@name, @price, @admission, @desc, @student, @duration)");
            cmd.Parameters.AddWithValue("@name",package.Name);
            cmd.Parameters.AddWithValue("@price", package.Price);
            cmd.Parameters.AddWithValue("@admission", package.AdmissionFee);
            cmd.Parameters.AddWithValue("@desc",package.Description);
            cmd.Parameters.AddWithValue("@student", package.IsStudentPlan);
            cmd.Parameters.AddWithValue("@duration", package.Duration);

            return dataAccess.ExecuteNonQuery(cmd);

        }

        public int Update(MembershipPackage package)
        {
            SqlCommand cmd = dataAccess.GetCommand(@"
                UPDATE MembershipPackages
                SET Name=@name,
                    Price=@price,
                    AdmissionFee=@admission,
                    Description=@desc,
                    IsStudentPlan=@student,
                    DurationMonths=@duration
                WHERE Id=@id");

            cmd.Parameters.AddWithValue("@id", package.Id);
            cmd.Parameters.AddWithValue("@name", package.Name);
            cmd.Parameters.AddWithValue("@price", package.Price);
            cmd.Parameters.AddWithValue("@admission", package.AdmissionFee);
            cmd.Parameters.AddWithValue("@desc", package.Description ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@student", package.IsStudentPlan);
            cmd.Parameters.AddWithValue("@duration", package.Duration);

            return dataAccess.ExecuteNonQuery(cmd);
        }
        public int Delete(int id)
        {
            SqlCommand cmd = dataAccess.GetCommand(
                "DELETE FROM MembershipPackages WHERE Id=@id");

            cmd.Parameters.AddWithValue("@id", id);

            return dataAccess.ExecuteNonQuery(cmd);
        }
    }
}

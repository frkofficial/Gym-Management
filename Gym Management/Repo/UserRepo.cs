using Gym_Management.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Gym_Management.Repo
{
    public class UserRepo
    {
        DataAccess dataAccess;
        public UserRepo()
        {
            dataAccess = new DataAccess();
        }
        public Users LoginMember(string username, string password)
        {
            SqlCommand cmd = dataAccess.GetCommand("SELECT * FROM UserInfo WHERE UserName=@username AND UserPass=@password");
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            DataTable dt = dataAccess.Execute(cmd);
            var rows = dt.Rows;
            if (rows.Count == 1)
            {
                return new Users
                {
                    UserId = Convert.ToInt32(rows[0]["UserId"]),
                    UserName = rows[0]["UserName"].ToString(),
                    UserType = rows[0]["UserType"].ToString().ToLower()
                };
            }
            return null;
           
        }

        public int MemberRegister(Users users)
        {
            SqlCommand Usercmd = dataAccess.GetCommand(@"INSERT INTO UserInfo(UserName,UserFirstName,UserLastName,UserPass,UserConPass,UserType,UserPhone,UserEmail,UserAddress,UserGender,UserAge,UserHeight,UserWeight,UserWeightGoal,UserTrainer,UserEmrPhone,UserMembership, UserJoinDate, UserLeaveDate) VALUES (@username,@userfname,@userlname,@pass,@conpass,@usertype,@phone,@email,@address,@gender,@age,@height,@weight,@goalweight,@trainer,@emrphone,@membership,@join,@leave);");
            Usercmd.Parameters.AddWithValue("@userfname", users.UserFirstName);
            Usercmd.Parameters.AddWithValue("@userlname", string.IsNullOrWhiteSpace(users.UserLastName) ? DBNull.Value : (object)users.UserLastName);
            Usercmd.Parameters.AddWithValue("@username", users.UserName);
            Usercmd.Parameters.AddWithValue("@pass", users.UserPass);
            Usercmd.Parameters.AddWithValue("@conpass", users.UserConPass);
            Usercmd.Parameters.AddWithValue("@usertype", "Member");
            Usercmd.Parameters.AddWithValue("@phone", users.UserPhone);
            Usercmd.Parameters.AddWithValue("@email", users.UserEmail);
            Usercmd.Parameters.AddWithValue("@address", users.UserAddress);
            Usercmd.Parameters.AddWithValue("@gender", users.UserGender);
            Usercmd.Parameters.Add("@age", SqlDbType.Int).Value = users.UserAge;
            Usercmd.Parameters.Add("@height", SqlDbType.Float).Value = users.UserHeight;
            Usercmd.Parameters.Add("@weight", SqlDbType.Int).Value = users.UserWeight;


            // Handle optional GoalWeight
            if (users.UserWeightGoal.HasValue)
            {
                Usercmd.Parameters.Add("@goalweight", SqlDbType.Int).Value = users.UserWeightGoal.Value;
            }
            else
            {
                Usercmd.Parameters.Add("@goalweight", SqlDbType.Int).Value = DBNull.Value;
            }


            Usercmd.Parameters.AddWithValue("@trainer", users.UserTrainer);

            // Handle optional EmrPhone
            Usercmd.Parameters.AddWithValue("@emrphone",string.IsNullOrWhiteSpace(users.UserEmrPhone) ? DBNull.Value : (object)users.UserEmrPhone);
            Usercmd.Parameters.AddWithValue("@membership", "No Membership");
            Usercmd.Parameters.AddWithValue("@join", DBNull.Value);
            Usercmd.Parameters.AddWithValue("@leave", DBNull.Value);

            return dataAccess.ExecuteNonQuery(Usercmd);
        }



        public int BookMembership(MembershipBooking booking)
        {
            

            SqlCommand command = dataAccess.GetCommand(@"INSERT INTO MembershipBooking (UserName, UserID, PackageName, Price, BookingDate, ExpireDate)
                       VALUES (@username, @userid, @package, @price, @bookingdate, @expiredate);");
            command.Parameters.AddWithValue("@username", booking.UserName);
            command.Parameters.AddWithValue("@userid", booking.UserID);
            command.Parameters.AddWithValue("@package", booking.PackageName);
            command.Parameters.AddWithValue("@price", booking.Price);
            command.Parameters.Add("@bookingdate", SqlDbType.Date).Value = booking.BookingDate;
            command.Parameters.Add("@expiredate", SqlDbType.Date).Value = booking.ExpireDate;

            return dataAccess.ExecuteNonQuery(command);
        }



        public DataTable DataGridV()
        {
           
            SqlCommand command = dataAccess.GetCommand("SELECT * FROM MemberShipBooking");
            return dataAccess.Execute(command);
        }
        public int UpdateBooking(MembershipBooking booking)
        {
            

            SqlCommand bcmd = dataAccess.GetCommand(@"UPDATE MembershipBooking 
                       SET UserName = @username, 
                           UserID = @userid, 
                           PackageName = @package, 
                           Price = @price, 
                           BookingDate = @bookingdate, 
                           ExpireDate = @expiredate 
                       WHERE BookingID = @bookingid");

            bcmd.Parameters.AddWithValue("@bookingid", booking.BookingID);
            bcmd.Parameters.AddWithValue("@username", booking.UserName);
            bcmd.Parameters.AddWithValue("@userid", booking.UserID);
            bcmd.Parameters.AddWithValue("@package", booking.PackageName);
            bcmd.Parameters.AddWithValue("@price", booking.Price);
            bcmd.Parameters.Add("@bookingdate", SqlDbType.Date).Value = booking.BookingDate;
            bcmd.Parameters.Add("@expiredate", SqlDbType.Date).Value = booking.ExpireDate;

            return dataAccess.ExecuteNonQuery(bcmd);

        }
        public int DeleteBooking(int bookingId)
        {
            
            SqlCommand cmd = dataAccess.GetCommand("DELETE FROM MembershipBooking WHERE BookingID = @bookingid");
            cmd.Parameters.AddWithValue("@bookingid", bookingId);

            return dataAccess.ExecuteNonQuery(cmd);
        }

        public DataTable Assignments()
        {
           
            SqlCommand cmd = dataAccess.GetCommand("SELECT * FROM CustomerAssignmentTrainerInfo");
            return dataAccess.Execute(cmd);
        }
        public int InsertAssignment(TrainerAssignment assignment)
        {
            

            SqlCommand cmd = dataAccess.GetCommand(@"INSERT INTO CustomerAssignmentTrainerInfo (UserId, UserName, TrainerId, TrainerName, BookingDate, ExpireDate, TrainerPrice)
                       VALUES (@userid, @username, @trainerid, @trainername, @bookingdate, @expiredate, @price)");
            cmd.Parameters.AddWithValue("@userid", assignment.UserId);
            cmd.Parameters.AddWithValue("@username", assignment.UserName ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@trainerid", assignment.TrainerId ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@trainername", assignment.TrainerName ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@bookingdate", assignment.BookingDate ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@expiredate", assignment.ExpireDate ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@price", assignment.TrainerPrice ?? (object)DBNull.Value);

            return dataAccess.ExecuteNonQuery(cmd);
        }
        public int UpdateAssignment(TrainerAssignment assignment)
        {
            

            SqlCommand cmd = dataAccess.GetCommand(@"UPDATE CustomerAssignmentTrainerInfo 
                       SET UserId = @userid, 
                           UserName = @username, 
                           TrainerId = @trainerid, 
                           TrainerName = @trainername, 
                           BookingDate = @bookingdate, 
                           ExpireDate = @expiredate, 
                           TrainerPrice = @price 
                       WHERE AssignmentId = @assignmentid");
            cmd.Parameters.AddWithValue("@assignmentid", assignment.AssignmentId);
            cmd.Parameters.AddWithValue("@userid", assignment.UserId);
            cmd.Parameters.AddWithValue("@username", assignment.UserName ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@trainerid", assignment.TrainerId ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@trainername", assignment.TrainerName ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@bookingdate", assignment.BookingDate ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@expiredate", assignment.ExpireDate ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@price", assignment.TrainerPrice ?? (object)DBNull.Value);

            return dataAccess.ExecuteNonQuery(cmd);
        }
        public int DeleteAssignment(int assignmentId)
        {
            
            var command = dataAccess.GetCommand("DELETE FROM CustomerAssignmentTrainerInfo WHERE AssignmentId = @assignmentid");
            command.Parameters.AddWithValue("@assignmentid", assignmentId);

            return dataAccess.ExecuteNonQuery(command);
        }



        public string GetCustomerName(int customerId)
        {
            var sql = "SELECT UserName FROM UserInfo WHERE UserId = @customerid";
            var command = dataAccess.GetCommand(sql);
            command.Parameters.AddWithValue("@customerid", customerId);
            var result = dataAccess.Execute(command);

            if (result.Rows.Count > 0)
            {
                return result.Rows[0]["UserName"].ToString();
            }
            return "";
        }

        public decimal GetPackageAmountByCustomer(int customerId)
        {
            var sql = @"SELECT TOP 1 Price FROM MemberShipBooking 
                       WHERE UserId = @customerid 
                       ORDER BY BookingId DESC";

            var command = dataAccess.GetCommand(sql);
            command.Parameters.AddWithValue("@customerid", customerId);
            var result = dataAccess.Execute(command);

            if (result.Rows.Count > 0 && result.Rows[0]["Price"] != DBNull.Value)
            {
                if (decimal.TryParse(result.Rows[0]["Price"].ToString(), out decimal price))
                    return price;
            }
            return 0;
        }
        public decimal GetTrainerPriceByCustomer(int customerId)
        {
            var sql = @"SELECT TOP 1 TrainerPrice FROM CustomerAssignmentTrainerInfo 
                       WHERE UserId = @customerid 
                       ORDER BY AssignmentId DESC";

            var command = dataAccess.GetCommand(sql);
            command.Parameters.AddWithValue("@customerid", customerId);
            var result = dataAccess.Execute(command);

            if (result.Rows.Count > 0 && result.Rows[0]["TrainerPrice"] != DBNull.Value)
            {
                if (decimal.TryParse(result.Rows[0]["TrainerPrice"].ToString(), out decimal price))
                    return price;
            }
            return 0;
        }
        public int InsertPayment(Payment payment)
        {
            var sql = @"INSERT INTO Payment (CustomerID, CustomerName, PackageAmount, TrainerPriceAmount, TotalAmount, PayingDate, Status, PaymentMethod)
                       VALUES (@customerid, @customername, @packageamount, @trainerpriceamount, @totalamount, @payingdate, @status, @paymentmethod)";

            var command = dataAccess.GetCommand(sql);
            command.Parameters.AddWithValue("@customerid", payment.CustomerID);
            command.Parameters.AddWithValue("@customername", payment.CustomerName ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@packageamount", payment.PackageAmount);
            command.Parameters.AddWithValue("@trainerpriceamount", payment.TrainerPriceAmount);
            command.Parameters.AddWithValue("@totalamount", payment.TotalAmount);
            command.Parameters.Add("@payingdate", SqlDbType.Date).Value = payment.PayingDate;
            command.Parameters.AddWithValue("@status", payment.Status);
            command.Parameters.AddWithValue("@paymentmethod", payment.PaymentMethod ?? (object)DBNull.Value);

            return dataAccess.ExecuteNonQuery(command);
        }
    }
}

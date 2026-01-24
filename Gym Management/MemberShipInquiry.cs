using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym_Management.Entities;
using Gym_Management.Repo;


namespace Gym_Management
{
    public partial class MemberShipInquiry : Form

    {

       
        UserRepo userrepo;
        string PackageName;
        decimal price;
        int Duration;
        private MemberShipControl memberShipControl;
        public MemberShipInquiry (MemberShipControl memberShipControl,string PackageName, decimal price, int Duration)
        {
            InitializeComponent();
           
            userrepo = new UserRepo();
            this.PackageName = PackageName;
            this.price = price;
            this.Duration = Duration;
            bookdatedtp.Value=DateTime.Now;
            this.memberShipControl = memberShipControl;
            CalculateExpireDate();
        }
        public void CalculateExpireDate()
        {
            DateTime bookingdate=bookdatedtp.Value;
            DateTime expiredate=bookingdate.AddMonths(Duration);
            expiredatedtp.Value=expiredate;

        }

        private void MemberShipInquiry_Load(object sender, EventArgs e)
        {

        }

        private void Bookbtn_Click(object sender, EventArgs e)
        {

        }

        private void Bookbtn_Click_1(object sender, EventArgs e)
        {
            var username= usernametxt.Text;
            var userid= useridtxt.Text;
            var join = bookdatedtp.Value;
            var expire= expiredatedtp.Value;
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter user name", "Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(userid))
            {
                MessageBox.Show("Please enter user ID", "Error");
                return;
            }
            if (!int.TryParse(userid, out int userId))
            {
                MessageBox.Show("User ID must be a number", "Error");
                return;
            }
            try
            {
                MembershipBooking booking = new MembershipBooking();
                booking.UserID = userId;
                booking.UserName = username;
                booking.PackageName = PackageName;
                booking.Price = price;
                booking.BookingDate = bookdatedtp.Value; 
                booking.ExpireDate = bookdatedtp.Value.AddMonths(Duration);
                int result = userrepo.BookMembership(booking);

                if (result > 0)
                {
                    MessageBox.Show(
                        $"Booking Successful!\n" +
                        $"Package: {PackageName}\n" +
                        $"Price: {price} BDT\n" +
                        $"Booking Date: {booking.BookingDate.ToShortDateString()}\n" +
                        $"Expire Date: {booking.ExpireDate.ToShortDateString()}",
                        "Success"
                    );
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Booking failed. Please try again.", "Error");
                }


            }
            catch (Exception ex)
             {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            memberShipControl.Show();
            this.Close();
        }
    }
}

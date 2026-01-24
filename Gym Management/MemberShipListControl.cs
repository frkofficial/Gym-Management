using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.Data.SqlClient;
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
    public partial class MemberShipListControl : UserControl
    {
        UserRepo userrepo;
        DataAccess dataAccess;
        int bookingid;
        public MemberShipListControl()
        {
            userrepo= new UserRepo();
            dataAccess = new DataAccess();
            InitializeComponent();
        }

        private void MemberShipListControl_Load(object sender, EventArgs e)
        {
            LoadUser();
            bookdatedtp.Value = DateTime.Now;
            expiredatedtp.Value = DateTime.Now;
            updatebtn.Enabled = false;
            deletebtn.Enabled = false;
        }

        private void LoadUser()
        {
           
            DataTable dt = userrepo.DataGridV();
            MembershipGridView.DataSource = dt;
        }
        private void ResetForm()
        {
            void ResetControl(Control Parent)
            {


                foreach (Control c in Parent.Controls)
                {
                    if (c is TextBox tb)
                    {
                        tb.Clear();
                    }
                    else if (c is ComboBox cb)
                    {
                        cb.SelectedIndex = -1;
                    }
                    else
                    {
                        ResetControl(c);
                    }

                }
            }
            ResetControl(this);
            bookdatedtp.Value = DateTime.Now;
            expiredatedtp.Value = DateTime.Now;
            updatebtn.Enabled = false;
            deletebtn.Enabled = false;
            bookingid = 0;
            MembershipGridView.ClearSelection();
        }

        private void MembershipGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            string name = usernametxt.Text;
            string pack= pcknametxt.Text;
            if (bookingid == 0)
            {
                MessageBox.Show("Please select a booking to update", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validation
            if (string.IsNullOrWhiteSpace(usernametxt.Text))
            {
                MessageBox.Show("Please enter user name", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usernametxt.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(useridtxt.Text))
            {
                MessageBox.Show("Please enter user ID", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                useridtxt.Focus();
                return;
            }

            if (!int.TryParse(useridtxt.Text, out int userId))
            {
                MessageBox.Show("User ID must be a number", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                useridtxt.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(pcknametxt.Text))
            {
                MessageBox.Show("Please enter package name", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pcknametxt.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(pricetxt.Text))
            {
                MessageBox.Show("Please enter price", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pricetxt.Focus();
                return;
            }

            if (!decimal.TryParse(pricetxt.Text, out decimal price))
            {
                MessageBox.Show("Price must be a number", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pricetxt.Focus();
                return;
            }

            try
            {
                MembershipBooking booking = new MembershipBooking();
                booking.BookingID = bookingid;
                booking.UserName = name;
                booking.UserID = userId;
                booking.PackageName = pack;
                booking.Price = price;
                booking.BookingDate = bookdatedtp.Value;
                booking.ExpireDate = expiredatedtp.Value;

                var result = userrepo.UpdateBooking(booking);

                if (result > 0)
                {
                    MessageBox.Show("Booking updated successfully!", "Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUser();
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Update failed. Please try again.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            string username = usernametxt.Text;
            string pack = pcknametxt.Text;
            if (bookingid == 0)
            {
                MessageBox.Show("Please select a booking to delete", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dialogResult = MessageBox.Show(
                $"Are you sure you want to delete the booking for {username}?\n" +
                $"Package: {pack}\n" +
                $"This action cannot be undone.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    int result = userrepo.DeleteBooking(bookingid);

                    if (result > 0)
                    {
                        MessageBox.Show("Booking deleted successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadUser();
                        ResetForm();
                    }
                    else
                    {
                        MessageBox.Show("Delete failed. Please try again.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void MembershipGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0 || MembershipGridView.Rows[e.RowIndex].IsNewRow)
            {
                return;
            }
            else
            {

                var rows = MembershipGridView.Rows[e.RowIndex];
                bookingid = Convert.ToInt32(rows.Cells["BookingId"].Value);
                useridtxt.Text = rows.Cells["UserID"].Value.ToString();
                usernametxt.Text = rows.Cells["UserName"].Value.ToString();
                pcknametxt.Text = rows.Cells["PackageName"].Value.ToString();
                pricetxt.Text = rows.Cells["Price"].Value.ToString();

                if (rows.Cells["BookingDate"].Value != DBNull.Value)
                    bookdatedtp.Value = Convert.ToDateTime(rows.Cells["BookingDate"].Value);
                if (rows.Cells["ExpireDate"].Value != DBNull.Value)
                    expiredatedtp.Value = Convert.ToDateTime(rows.Cells["ExpireDate"].Value);

                updatebtn.Enabled = true;
                deletebtn.Enabled = true;
            }
        
        }
    }
}

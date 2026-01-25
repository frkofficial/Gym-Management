using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace Gym_Management
{
    public partial class Admincontrol : UserControl
    {
        private DataAccess dataAccess;

        public Admincontrol()
        {
            InitializeComponent();

            // Connection test
            try
            {
                dataAccess = new DataAccess();
                if (!dataAccess.TestConnection())
                {
                    MessageBox.Show("Database connection failed!", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Initialization Error");
            }
        }

        private void Admincontrol_Load(object sender, EventArgs e)
        {
            LoadAdminData();
            dataGridViewadmin.SelectionChanged += dataGridViewadmin_SelectionChanged;
        }

        // ================= LOAD ADMIN DATA =================
        private void LoadAdminData()
        {
            try
            {
                SqlCommand cmd = dataAccess.GetCommand(
                    @"SELECT AdminId, AdminUserName, AdminFirstName, AdminLastname, AdminPass, 
                             Rank, UserType, AdminPhone, AdminEmail, AdminAddress, AdminDOB, AdminGender
                      FROM AdminInfo"
                );

                DataTable dt = dataAccess.Execute(cmd);
                dataGridViewadmin.DataSource = dt;

                if (dataGridViewadmin.Rows.Count > 0)
                    dataGridViewadmin.Rows[0].Selected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Admin load error: " + ex.Message);
            }
        }

        // ================= GET NEXT ADMIN ID =================
        private int GetNextAdminId()
        {
            try
            {
                SqlCommand cmd = dataAccess.GetCommand("SELECT ISNULL(MAX(AdminId), 0) + 1 FROM AdminInfo");
                cmd.Connection.Open();
                int nextId = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Connection.Close();
                return nextId;
            }
            catch (Exception ex)
            {
                throw new Exception($"GetNextAdminId Error: {ex.Message}", ex);
            }
        }

       
        // ================= GRID → TEXTBOX =================
        private void dataGridViewadmin_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewadmin.CurrentRow == null) return;

            try
            {
                textBoxId.Text = dataGridViewadmin.CurrentRow.Cells["AdminId"].Value?.ToString();
                txtAdminName.Text = dataGridViewadmin.CurrentRow.Cells["AdminUserName"].Value?.ToString();
                adminFirstName.Text = dataGridViewadmin.CurrentRow.Cells["AdminFirstName"].Value?.ToString();
                txtLastName.Text = dataGridViewadmin.CurrentRow.Cells["AdminLastname"].Value?.ToString();
                //txtPassword.Text = dataGridViewadmin.CurrentRow.Cells["AdminPass"].Value?.ToString();
                txtRank.Text = dataGridViewadmin.CurrentRow.Cells["Rank"].Value?.ToString();
                //txtUserType.Text = dataGridViewadmin.CurrentRow.Cells["UserType"].Value?.ToString();
                txtPhone.Text = dataGridViewadmin.CurrentRow.Cells["AdminPhone"].Value?.ToString();
                //txtEmail.Text = dataGridViewadmin.CurrentRow.Cells["AdminEmail"].Value?.ToString();
                //txtAddress.Text = dataGridViewadmin.CurrentRow.Cells["AdminAddress"].Value?.ToString();
                //txtDOB.Text = dataGridViewadmin.CurrentRow.Cells["AdminDOB"].Value?.ToString();
                //txtGender.Text = dataGridViewadmin.CurrentRow.Cells["AdminGender"].Value?.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading row data: " + ex.Message);
            }
        }

        // ================= CLEAR FIELDS =================
        private void ClearAdminFields()
        {
            textBoxId.Clear();
            txtAdminName.Clear();
            adminFirstName.Clear();
            txtLastName.Clear();
            //txtPassword.Clear();
            txtRank.Clear();
            //txtUserType.Clear();
            txtPhone.Clear();
            //txtEmail.Clear();
            //txtAddress.Clear();
            //txtDOB.Clear();
            //txtGender.Clear();
        }




        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Keep as is
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Keep as is
        }



          //adminInsert
        private void btnInsertAdmin1_Click_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Get next AdminId
                int nextAdminId = GetNextAdminId();

                string AdminUserName = txtAdminName.Text.Trim();
                string AdminFirstName = adminFirstName.Text.Trim();
                string AdminLastname = txtLastName.Text.Trim();

                
                string AdminPass = "defaultpassword123"; 
                string Rank = txtRank.Text.Trim();
                string UserType = "Admin"; 
                string AdminPhone = txtPhone.Text.Trim();
                string AdminEmail = "admin@email.com"; 
                string AdminAddress = "Default Address"; 
                string AdminDOB = "1990-01-01"; 
                string AdminGender = "Male"; 

              
                if (string.IsNullOrWhiteSpace(AdminUserName) ||
                    string.IsNullOrWhiteSpace(AdminFirstName) ||
                    string.IsNullOrWhiteSpace(AdminPass) ||
                    string.IsNullOrWhiteSpace(Rank) ||
                    string.IsNullOrWhiteSpace(UserType) ||
                    string.IsNullOrWhiteSpace(AdminPhone) ||
                    string.IsNullOrWhiteSpace(AdminEmail) ||
                    string.IsNullOrWhiteSpace(AdminAddress) ||
                    string.IsNullOrWhiteSpace(AdminDOB) ||
                    string.IsNullOrWhiteSpace(AdminGender))
                {
                    MessageBox.Show("Please fill all required fields!", "Validation Error");
                    return;
                }

                // 4. SQL Command WITH AdminId
                SqlCommand cmd = dataAccess.GetCommand(@"
            INSERT INTO AdminInfo 
            (AdminId, AdminUserName, AdminFirstName, AdminLastname, AdminPass, 
             Rank, UserType, AdminPhone, AdminEmail, AdminAddress, AdminDOB, AdminGender)
            VALUES 
            (@adminid, @username, @firstname, @lastname, @password, @rank, 
             @usertype, @phone, @email, @address, @dob, @gender)
        ");

                
                cmd.Parameters.AddWithValue("@adminid", nextAdminId);
                cmd.Parameters.AddWithValue("@username", AdminUserName);
                cmd.Parameters.AddWithValue("@firstname", AdminFirstName);
                cmd.Parameters.AddWithValue("@lastname", string.IsNullOrEmpty(AdminLastname) ? (object)DBNull.Value : AdminLastname);
                cmd.Parameters.AddWithValue("@password", AdminPass);  
                cmd.Parameters.AddWithValue("@rank", Rank);
                cmd.Parameters.AddWithValue("@usertype", UserType);   
                cmd.Parameters.AddWithValue("@phone", AdminPhone);
                cmd.Parameters.AddWithValue("@email", AdminEmail);    
                cmd.Parameters.AddWithValue("@address", AdminAddress); 
                cmd.Parameters.AddWithValue("@dob", AdminDOB);        
                cmd.Parameters.AddWithValue("@gender", AdminGender);  

                // 6. Execute
                int rows = dataAccess.ExecuteNonQuery(cmd);

                if (rows > 0)
                {
                    MessageBox.Show($"✅ Success! Admin ID: {nextAdminId}", "Success");
                    LoadAdminData();
                    ClearAdminFields();
                }
                else
                {
                    MessageBox.Show("❌ Insert failed - No rows affected", "Error");
                }
            }
            catch (SqlException sqlEx)
            {
                // Specific error message
                if (sqlEx.Message.Contains("cannot insert the value NULL"))
                {
                    MessageBox.Show("ERROR: Trying to insert NULL into NOT NULL column.\n\n" +
                                  "Please provide values for:\n" +
                                  "- AdminPass\n" +
                                  "- UserType\n" +
                                  "- AdminEmail\n" +
                                  "- AdminAddress\n" +
                                  "- AdminDOB\n" +
                                  "- AdminGender",
                                  "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"SQL Error: {sqlEx.Message}", "Database Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n\nStack Trace: {ex.StackTrace}", "System Error");
            }
        }

        //private void btnDeleteAdmin_Click(object sender, EventArgs e)
        //{

        //}


        //dlt admin

        private void btnDeleteAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (dataGridViewadmin.CurrentRow == null)
                {
                    MessageBox.Show("Please select an admin to delete!", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

               
                int adminId = Convert.ToInt32(dataGridViewadmin.CurrentRow.Cells["AdminId"].Value);
                string adminName = dataGridViewadmin.CurrentRow.Cells["AdminUserName"].Value?.ToString();

                
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete Admin?\n\n" +
                    $"ID: {adminId}\n" +
                    $"Name: {adminName}\n\n" +
                    "This action cannot be undone!",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result != DialogResult.Yes)
                    return;

                
                SqlCommand cmd = dataAccess.GetCommand("DELETE FROM AdminInfo WHERE AdminId = @adminid");
                cmd.Parameters.AddWithValue("@adminid", adminId);

                // ৫. Execute
                int rows = dataAccess.ExecuteNonQuery(cmd);

                if (rows > 0)
                {
                    MessageBox.Show($"✅ Admin deleted successfully!\nID: {adminId}\nName: {adminName}",
                                  "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    LoadAdminData();
                    ClearAdminFields();
                }
                else
                {
                    MessageBox.Show("❌ Delete failed - Admin not found!", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Admin ID format!", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException sqlEx)
            {
                // Foreign key constraint error
                if (sqlEx.Number == 547)
                {
                    MessageBox.Show("Cannot delete this admin!\n\n" +
                                  "This admin is referenced in other tables.\n" +
                                  "Please remove related records first.",
                                  "Constraint Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"SQL Error: {sqlEx.Message}", "Database Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "System Error");
            }
        }
    }
}
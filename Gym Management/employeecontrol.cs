using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Gym_Management
{
    public partial class employeecontrol : UserControl
    {
        private DataAccess dataAccess;

        public employeecontrol()
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

        private void employeecontrol_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();
            dataGridViewemployee.SelectionChanged += dataGridViewemployee_SelectionChanged;
        }

        // ================= LOAD EMPLOYEE =================
        private void LoadEmployeeData()
        {
            try
            {
                SqlCommand cmd = dataAccess.GetCommand(
                    @"SELECT EmpId, EmpName, EmpFirstName, EmpLastName, EmpPass, 
                     EmpJob, UserType, EmpPhone, EmpAddress, EmpEmail, EmpGender
              FROM EmpInfo"
                );

                DataTable dt = dataAccess.Execute(cmd);
                dataGridViewemployee.DataSource = dt;

                if (dataGridViewemployee.Rows.Count > 0)
                    dataGridViewemployee.Rows[0].Selected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load Error: " + ex.Message, "Error");
            }
        }




        // ================= INSERT EMPLOYEE =================
        private void btnInsertEmployee_Click(object sender, EventArgs e)
        {
            try
            {

                // 1. Get next EmpId
                int nextEmpId = dataAccess.GetNextEmpId();

                // 2. Collect form data
                string EmpName = txtEmpName.Text.Trim();
                string EmpJob = txtEmpJob.Text.Trim();
                string EmpPhone = txtEmpPhone.Text.Trim();
                string EmpFirstName = textBoxfname.Text.Trim();
                string EmpLastName = textBoxLname.Text.Trim();
                string EmpPass = textBoxEpass.Text.Trim();
                string UserType = textBoxUserT.Text.Trim();
                string EmpAddress = "Not Provided";
                string EmpEmail = "notprovided@email.com";
                string EmpGender = "Not Specified";

                // 3. Validation
                if (string.IsNullOrWhiteSpace(EmpName) ||
                    string.IsNullOrWhiteSpace(EmpFirstName) ||
                    string.IsNullOrWhiteSpace(EmpPass) ||
                    string.IsNullOrWhiteSpace(EmpJob) ||
                    string.IsNullOrWhiteSpace(UserType) ||
                    string.IsNullOrWhiteSpace(EmpPhone))
                {
                    MessageBox.Show("Please fill all required fields!", "Validation Error");
                    return;
                }

                // 4. SQL Command WITH EmpId
                SqlCommand cmd = dataAccess.GetCommand(@"
            INSERT INTO EmpInfo 
            (EmpId, EmpName, EmpFirstName, EmpLastName, EmpPass, EmpJob, 
             UserType, EmpPhone, EmpAddress, EmpEmail, EmpGender)
            VALUES 
            (@empid, @name, @fname, @lname, @pass, @job, @usertype, 
             @phone, @address, @email, @gender)
        ");

                // 5. Add parameters
                cmd.Parameters.AddWithValue("@empid", nextEmpId);
                cmd.Parameters.AddWithValue("@name", EmpName);
                cmd.Parameters.AddWithValue("@fname", EmpFirstName);
                cmd.Parameters.AddWithValue("@lname", string.IsNullOrEmpty(EmpLastName) ? (object)DBNull.Value : EmpLastName);
                cmd.Parameters.AddWithValue("@pass", EmpPass);
                cmd.Parameters.AddWithValue("@job", EmpJob);
                cmd.Parameters.AddWithValue("@usertype", UserType);
                cmd.Parameters.AddWithValue("@phone", EmpPhone);
                cmd.Parameters.AddWithValue("@address", EmpAddress);
                cmd.Parameters.AddWithValue("@email", EmpEmail);
                cmd.Parameters.AddWithValue("@gender", EmpGender);

                // 6. Execute
                int rows = dataAccess.ExecuteNonQuery(cmd);

                if (rows > 0)
                {
                    MessageBox.Show($"✅ Success! Employee ID: {nextEmpId}", "Success");
                    LoadEmployeeData();
                    ClearFields();
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL Error: {sqlEx.Message}", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }

        // ================= GRID → TEXTBOX =================
        private void dataGridViewemployee_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewemployee.CurrentRow == null) return;

            try
            {
                txtEmpId.Text = dataGridViewemployee.CurrentRow.Cells["EmpId"].Value?.ToString();
                txtEmpName.Text = dataGridViewemployee.CurrentRow.Cells["EmpName"].Value?.ToString();
                txtEmpJob.Text = dataGridViewemployee.CurrentRow.Cells["EmpJob"].Value?.ToString();
                txtEmpPhone.Text = dataGridViewemployee.CurrentRow.Cells["EmpPhone"].Value?.ToString();
                textBoxfname.Text = dataGridViewemployee.CurrentRow.Cells["EmpFirstName"].Value?.ToString();
                textBoxLname.Text = dataGridViewemployee.CurrentRow.Cells["EmpLastName"].Value?.ToString();
                textBoxEpass.Text = dataGridViewemployee.CurrentRow.Cells["EmpPass"].Value?.ToString();
                textBoxUserT.Text = dataGridViewemployee.CurrentRow.Cells["UserType"].Value?.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading row data: " + ex.Message);
            }
        }
        // ================= CLEAR =================
        private void ClearFields()
        {
            txtEmpId.Clear();
            txtEmpName.Clear();
            txtEmpJob.Clear();
            txtEmpPhone.Clear();
            textBoxfname.Clear();
            textBoxLname.Clear();
            textBoxEpass.Clear();
            textBoxUserT.Clear();
        }



        //EMPLOYEEEDLETE CONTROLS
        private void btnemployeedlt_Click(object sender, EventArgs e)
        {
            try
            {
                //  selection check
                if (dataGridViewemployee.CurrentRow == null)
                {
                    MessageBox.Show("Please select an employee to delete!", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //  Employee 
                int empId = Convert.ToInt32(dataGridViewemployee.CurrentRow.Cells["EmpId"].Value);
                string empName = dataGridViewemployee.CurrentRow.Cells["EmpName"].Value?.ToString();

                
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete Employee?\n\n" +
                    $"ID: {empId}\n" +
                    $"Name: {empName}\n\n" +
                    "This action cannot be undone!",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result != DialogResult.Yes)
                    return;

                // ৪. SQL Command 
                SqlCommand cmd = dataAccess.GetCommand("DELETE FROM EmpInfo WHERE EmpId = @empid");
                cmd.Parameters.AddWithValue("@empid", empId);

                // ৫. Execute
                int rows = dataAccess.ExecuteNonQuery(cmd);

                if (rows > 0)
                {
                    MessageBox.Show($"✅ Employee deleted successfully!\nID: {empId}\nName: {empName}",
                                  "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   
                    LoadEmployeeData();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("❌ Delete failed - Employee not found!", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Employee ID format!", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException sqlEx)
            {
                // Foreign key constraint error (547 error number for SQL Server)
                if (sqlEx.Number == 547)
                {
                    MessageBox.Show("Cannot delete this employee!\n\n" +
                                  "This employee is referenced in other tables.\n" +
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

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
    public partial class employeecontrol : UserControl


    {
        DataAccess dataAccess;
        public employeecontrol()
        {
            InitializeComponent();
            dataAccess = new DataAccess();
        }

        private void employeecontrol_Load(object sender, EventArgs e)
        {
            
            LoadEmployeeData();
            dataGridViewemployee.SelectionChanged += dataGridViewemployee_SelectionChanged;

        }

        private void LoadEmployeeData()
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["GymsDB"].ConnectionString;

                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();

                    SqlDataAdapter da = new
                       SqlDataAdapter(
                        "SELECT EmpId, EmpName, EmpJob, EmpPhone, EmpFirstName, EmpLastName,EmpPass, UserType FROM EmpInfo",
                        con
                    );

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridViewemployee.DataSource = dt;

                    if (dataGridViewemployee.Rows.Count > 0)
                        dataGridViewemployee.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Employee load error: " + ex.Message);
            }
        }

       

        //to clear fields
        private void ClearFields()
        {
            txtEmpId.Clear();
            txtEmpName.Clear();
            txtEmpJob.Clear();
            txtEmpPhone.Clear();
        }



        private void btnInsertEmployee_Click(object sender, EventArgs e)
        {
            var EmpName = txtEmpName.Text.Trim();
            var EmpJob = txtEmpJob.Text.Trim();
            var EmpPhone = txtEmpPhone.Text.Trim();
            var EmpFirstName = textBoxfname.Text.Trim();
            var EmpLastName = textBoxLname.Text.Trim();
            var EmpPass = textBoxEpass.Text.Trim();
            var UserType = textBoxUserT.Text.Trim();
            // basic validation
            if (string.IsNullOrWhiteSpace(EmpName) ||
                string.IsNullOrWhiteSpace(EmpJob) ||
                string.IsNullOrWhiteSpace(EmpPhone) ||
                string.IsNullOrWhiteSpace(EmpPass) || 
                string.IsNullOrWhiteSpace(UserType) ||
                string.IsNullOrWhiteSpace(EmpFirstName))   

            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            // INSERT command (exact UserInfo style)
            SqlCommand empCmd = dataAccess.GetCommand(@"
        INSERT INTO EmpInfo (EmpName, EmpJob, EmpPhone, EmpFirstName, EmpLastName,EmpPass, UserType)
        VALUES (@name, @job, @phone, @Fname, @Lname, @pass, @Usertype);
    ");

            empCmd.Parameters.AddWithValue("@name", EmpName);
            empCmd.Parameters.AddWithValue("@job", EmpJob);
            empCmd.Parameters.Add("@phone", SqlDbType.VarChar,20).Value = EmpPhone;
            empCmd.Parameters.AddWithValue("@Fname", EmpFirstName);
            empCmd.Parameters.AddWithValue("@Lname", EmpLastName);
            empCmd.Parameters.AddWithValue("@pass", EmpPass);
            empCmd.Parameters.AddWithValue("@Usertype", UserType);

            try
            {
                var rows = dataAccess.ExecuteNonQuery(empCmd);

                if (rows > 0)
                {
                    MessageBox.Show("Employee inserted successfully ✅");
                }
                else
                {
                    MessageBox.Show("Employee insert failed ❌");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error");
            }

            LoadEmployeeData(); // grid refresh
            ClearFields();      // textbox clear
        }





        private void dataGridViewemployee_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewemployee.CurrentRow != null)
            {
                txtEmpId.Text = dataGridViewemployee.CurrentRow.Cells["EmpId"].Value?.ToString();
                txtEmpName.Text = dataGridViewemployee.CurrentRow.Cells["EmpName"].Value?.ToString();
                txtEmpJob.Text = dataGridViewemployee.CurrentRow.Cells["EmpJob"].Value?.ToString();
                txtEmpPhone.Text = dataGridViewemployee.CurrentRow.Cells["EmpPhone"].Value?.ToString();
            }
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void employeepannel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewemployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

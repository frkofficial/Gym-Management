using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using Microsoft.Data.SqlClient;


namespace Gym_Management
{
    public partial class AdminForm : Form
    {
        LoginForm login;
        int adminId;
        SqlConnection con;
        DataAccess access;
        private Form previousform;
        public AdminForm(Form previousform, int adminId)
        {
            InitializeComponent();
            //this.login = login;
            this.adminId = adminId;
            this.previousform = previousform;
            access = new DataAccess();
            this.FormClosing += AdminFormClosing;
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["GymsDB"].ConnectionString;
                con = new SqlConnection(cs);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection init error: " + ex.Message);
            }

        }

        private void LoadControl(UserControl control)
        {
            contentpannel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            contentpannel.Controls.Add(control);
        }

        public void AdminFormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }



        private void AdminForm_Load(object sender, EventArgs e)
        {
            
        }

        
        private void TestDb()
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["GymsDB"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    MessageBox.Show("Database connected successfully");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalCustomers_Click(object sender, EventArgs e)
        {

        }

        private void adminListbutton_Click(object sender, EventArgs e)
        {
            LoadControl(new Admincontrol());
            
        }

        private void CustomerListbutton_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeListbutton_Click(object sender, EventArgs e)
        {
            LoadControl(new employeecontrol());
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomerListbutton_Click_1(object sender, EventArgs e)
        {
            LoadControl(new customercontrol());
            //LoadControl(new dashboard());
        }

        private void dashboardbutton_Click(object sender, EventArgs e)
        {
            //panelDashboard.Visible = true;
            LoadControl(new dashboardcontrol());
        }

        private void Packagesbutton_Click(object sender, EventArgs e)
        {
            LoadControl(new packagescontrol());
        }

        private void Logoutbutton_Click(object sender, EventArgs e)
        {
            previousform.Show();
            this.Hide();
        }
    }
}




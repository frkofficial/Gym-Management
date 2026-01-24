using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace Gym_Management
{
    public partial class dashboardcontrol : UserControl
    {
        public dashboardcontrol()
        {
            InitializeComponent();
        }

        // Test DB connection
        private void TestDb()
        {
            try
            {
                string cs = ConfigurationManager
                            .ConnectionStrings["GymsDB"]
                            .ConnectionString;

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

        // Label click → load total customers
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestDb(); // optional test
        }

        private void dashboardcontrol_Load(object sender, EventArgs e)
        {
            try
            {
                string cs = ConfigurationManager
                            .ConnectionStrings["GymsDB"]
                            .ConnectionString;

                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();

                    SqlCommand cmd =
                        new SqlCommand("SELECT COUNT(*) FROM UserInfo", con);

                    int total = (int)cmd.ExecuteScalar();

                    lblTotalCustomers.Text = total.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading total customers: " + ex.Message);
            }


            //lblTotalEmployee
            try
            {
                string cs = ConfigurationManager
                            .ConnectionStrings["GymsDB"]
                            .ConnectionString;

                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();

                    SqlCommand cmd =
                        new SqlCommand("SELECT COUNT(*) FROM EmpInfo", con);

                    int total = (int)cmd.ExecuteScalar();

                    lblTotalEmployee.Text = total.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading total customers: " + ex.Message);
            }

            //lblTotalAdmin
            try
            {
                string cs = ConfigurationManager
                            .ConnectionStrings["GymsDB"]
                            .ConnectionString;

                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();

                    SqlCommand cmd =
                        new SqlCommand("SELECT COUNT(*) FROM AdminInfo", con);

                    int total = (int)cmd.ExecuteScalar();

                    lblTotalAdmin.Text = total.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading total customers: " + ex.Message);
            }

        }



        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblTotalAdmin_Click(object sender, EventArgs e)
        {

        }
    }
}

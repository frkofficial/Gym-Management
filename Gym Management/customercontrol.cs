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
    public partial class customercontrol : UserControl
    {
        public customercontrol()
        {
            InitializeComponent();
        }

        private void customercontrol_Load(object sender, EventArgs e)
        {
            //dataGridViewCustomer

            try
            {
                string cs = ConfigurationManager
                            .ConnectionStrings["GymsDB"]
                            .ConnectionString;

                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT UserId, UserName, UserType, UserPhone FROM UserInfo",
                        con
                    );

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridViewCustomer.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Admin load error: " + ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

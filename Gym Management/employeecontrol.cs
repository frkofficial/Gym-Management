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
        public employeecontrol()
        {
            InitializeComponent();
        }

        private void employeecontrol_Load(object sender, EventArgs e)
        {
            //dataGridViewemployee


            try
            {
                string cs = ConfigurationManager
                            .ConnectionStrings["GymsDB"]
                            .ConnectionString;

                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT EmpId, EmpName, EmpJob, EmpPhone FROM EmpInfo",
                        con
                    );

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridViewemployee.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Admin load error: " + ex.Message);
            }

        }
    }
}

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
        public Admincontrol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //dataGridViewadmin

        private void Admincontrol_Load(object sender, EventArgs e)
        {
            try
            {
                string cs = ConfigurationManager
                            .ConnectionStrings["GymsDB"]
                            .ConnectionString;

                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT AdminId, AdminUserName, Rank, AdminPhone FROM AdminInfo",
                        con
                    );

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridViewadmin.DataSource = dt; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Admin load error: " + ex.Message);
            }
            

        }
    }
}

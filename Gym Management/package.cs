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
    public partial class package : UserControl
    {
        public package()
        {
            InitializeComponent();
        }

        private void dataGridViewPackage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void package_Load(object sender, EventArgs e)
        {
            //dataGridViewPackage

            try
            {
                string cs = ConfigurationManager
                            .ConnectionStrings["GymsDB"]
                            .ConnectionString;

                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT * FROM package1",
                        con
                    );

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridViewPackage.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Customer load error: " + ex.Message);
            }

        }
    }
}

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
    public partial class trainercontrols : UserControl
    {
        public trainercontrols()
        {
            InitializeComponent();
        }

        private void trainercontrols_Load(object sender, EventArgs e)
        {
            //dataGridViewtrainer

            try
            {
                string cs = ConfigurationManager
                            .ConnectionStrings["GymsDB"]
                            .ConnectionString;

                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT TrainerId, TrainerName, TrainerPrice FROM TrainerTable",
                        con
                    );

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridViewtrainer.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Trainer load error: " + ex.Message);
            }
        }
    }
}

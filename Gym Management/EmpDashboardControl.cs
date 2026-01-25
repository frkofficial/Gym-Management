using Gym_Management.Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management
{
    public partial class EmpDashboardControl : UserControl
    {
        DashBoardRepo dash;
        public EmpDashboardControl()
        {
            dash = new DashBoardRepo();
            InitializeComponent();
        }
        private void LoadDashboardNumbers()
        {
            try
            {
                Emplbl.Text = dash.EmployeeCount().ToString();
                Rmemlbl.Text = dash.RegisteredMemberCount().ToString();
                ActMemlbl.Text = dash.ActiveMemberCount().ToString();
                inactmemlbl.Text = dash.DueMemberCount().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load dashboard data\n" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Emplbl_Click(object sender, EventArgs e)
        {

        }

        private void Rmemlbl_Click(object sender, EventArgs e)
        {

        }

        private void ActMemlbl_Click(object sender, EventArgs e)
        {

        }

        private void inactmemlbl_Click(object sender, EventArgs e)
        {

        }

        private void EmpDashboardControl_Load(object sender, EventArgs e)
        {
            LoadDashboardNumbers();
        }
    }
}

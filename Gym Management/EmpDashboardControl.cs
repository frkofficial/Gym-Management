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
        EmpRepo emprepo;
        Form previousform;
        int eid;
        DataAccess dataaccess;

        public EmpDashboardControl(Form previousform,int eid)
        {
            emprepo = new EmpRepo();
            this.eid = eid;
            this.previousform = previousform;
            dataaccess = new DataAccess();
            InitializeComponent();
            Membershipdatadgv.BackgroundColor = Color.FromArgb(20, 20, 20);
            Membershipdatadgv.DefaultCellStyle.BackColor = Color.FromArgb(20, 20, 20);
            Membershipdatadgv.DefaultCellStyle.ForeColor = Color.White;
            Membershipdatadgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 140, 0);
            Membershipdatadgv.DefaultCellStyle.SelectionForeColor = Color.White;
            Membershipdatadgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(20, 20, 20);
            Membershipdatadgv.GridColor = Color.FromArgb(255, 87, 34);
            Membershipdatadgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            Membershipdatadgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 20, 20);
            Membershipdatadgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            Membershipdatadgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            Membershipdatadgv.EnableHeadersVisualStyles = false;
            Membershipdatadgv.BorderStyle = BorderStyle.None;

        }
        //private void LoadDashboardNumbers()
        //{
        //    try
        //    {
        //        //Emplbl.Text = dash.EmployeeCount().ToString();
        //        //Rmemlbl.Text = dash.RegisteredMemberCount().ToString();
        //        //ActMemlbl.Text = dash.ActiveMemberCount().ToString();
        //        //inactmemlbl.Text = dash.DueMemberCount().ToString();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Failed to load dashboard data\n" + ex.Message);
        //    }
        //}

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
            //LoadDashboardNumbers();
            string name = emprepo.GetName(eid);
            namelbl.Text = name + "!";

            //emprepo.UpdateAllMembershipStatuses();

            // 2️⃣ Load grid
            Membershipdatadgv.DataSource = emprepo.GetAssignedMembers();

           

        }
        private void Membershipdatadgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (Membershipdatadgv.Columns[e.ColumnIndex].Name == "Status")
            {
                if (e.Value != null)
                {
                    string status = e.Value.ToString();

                    if (status == "Active")
                    {
                        e.CellStyle.ForeColor = Color.Green;
                    }
                    else if (status == "Expiring Soon")
                    {
                        e.CellStyle.ForeColor = Color.Orange;
                    }
                    else if (status == "Due")
                    {
                        e.CellStyle.ForeColor = Color.Red;
                    }
                    else if (status == "Inactive")
                    {
                        e.CellStyle.ForeColor = Color.Gray;
                    }
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

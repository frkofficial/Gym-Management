using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management
{
    public partial class EmployeeForm : Form
    {
        //LoginForm login;
        private Form previousform;
        DataAccess dataAccess;
        int empId;
        public EmployeeForm(Form previousform, int empId)
        {
            InitializeComponent();
            //this.login = login;
            this.previousform = previousform;
            this.empId = empId;
            this.FormClosing += EmpFormClosing;
            dataAccess = new DataAccess();
        }

        public void EmpFormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void DashBoardBtn_Click(object sender, EventArgs e)
        {
            LoadControl(new EmpDashboardControl());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void NameInfolbl_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            SqlCommand EmpNamecmd = dataAccess.GetCommand(@"SELECT EmpName FROM EmpInfo WHERE EmpId=@id");
            EmpNamecmd.Parameters.Add("@id", SqlDbType.Int).Value = empId;
            DataTable namedt = dataAccess.Execute(EmpNamecmd);
            var rows = namedt.Rows;
            if (rows.Count == 1)
            {
                NameInfolbl.Text = rows[0]["EmpName"].ToString();
            }
            else
            {
                NameInfolbl.Text = "Unknown";
            }
            LoadControl(new EmpDashboardControl());
        }
        private void LoadControl(UserControl control)
        {
            CenterPnl.Controls.Clear();
            control.Dock = DockStyle.Fill;
            CenterPnl.Controls.Add(control);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MembershipBtn_Click(object sender, EventArgs e)
        {
            //CenterPnl.Controls.Clear();
            //CenterPnl.Controls.Add(new Button() { Name = "btnx", Text = "Test Button" });
            LoadControl(new MemberShipControl());
        }

        private void MemberBtn_Click(object sender, EventArgs e)
        {
            LoadControl(new MemberControl());


        }

        private void StaffBtn_Click(object sender, EventArgs e)
        {

        }

        private void CenterPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MembershipListBtn_Click(object sender, EventArgs e)
        {
            LoadControl(new MemberShipListControl());
        }

        private void WorkoutBtn_Click(object sender, EventArgs e)
        {
            LoadControl(new AssignedControl());
        }

        private void PaymentBtn_Click(object sender, EventArgs e)
        {
            LoadControl(new CalPaymentCont());
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            previousform.Show();
            this.Hide();

        }

        private void GroupBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

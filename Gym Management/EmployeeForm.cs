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
        LoginForm login;
        DataAccess dataAccess;
        int empId;
        public EmployeeForm(LoginForm login, int empId)
        {
            InitializeComponent();
            this.login = login;
            this.empId = empId;
            this.FormClosing += EmpFormClosing;
            dataAccess = new DataAccess();
        }

        public void EmpFormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MembershipBtn_Click(object sender, EventArgs e)
        {
            CenterPnl.Controls.Clear();
            CenterPnl.Controls.Add(new Button() { Name = "btnx", Text = "Test Button" });
        }

        private void MemberBtn_Click(object sender, EventArgs e)
        {
            CenterPnl.Controls.Clear();

        }

        private void StaffBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Gym_Management.Entities;
using Gym_Management.Repo;


namespace Gym_Management
{
    public partial class MemberForm : Form
    {
        //LoginForm login;
        int Mid;
        Form previousform;
        DataAccess dataAccess;
        UserRepo userrepo;
        public MemberForm(Form previousform, int Mid)
        {
            InitializeComponent();
            userrepo = new UserRepo();

            this.Mid = Mid;
            this.FormClosing += MemberFormClosing;
            dataAccess = new DataAccess();
            this.previousform = previousform;
        }
        public void MemberFormClosing(object? sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void LoadControl(UserControl control)
        {
            panelMain.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelMain.Controls.Add(control);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadControl(new MemberDashboard(this, Mid));
                
        }

        private void btnmembershipPrice_Click(object sender, EventArgs e)
        {
            LoadControl(new MemberShipControl());
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadControl(new PaymrntControl(this,Mid));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            previousform.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        

        private void MemberForm_Load(object sender, EventArgs e)
        {
            string name = userrepo.GetMemberName(Mid);

            NameInfolbl.Text= name;

            LoadControl(new MemberDashboard(this,Mid));
        }
    }
}

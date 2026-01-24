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

namespace Gym_Management
{
    public partial class MemberForm : Form
    {
        LoginForm login;
        int userId;
        private Form previousform;
        public MemberForm(LoginForm login, int userId, Form previousform    )
        {
            InitializeComponent();
            this.login = login;
            this.userId = userId;
            this.FormClosing += MemberFormClosing;
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
            LoadControl(new MyProfileControl1())
                ;
        }

        private void btnmembershipPrice_Click(object sender, EventArgs e)
        {
            LoadControl(new MembershipPricingControl());
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadControl(new PaymentControl1());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            previousform.Show();
            this.Hide();
        }
    }
}

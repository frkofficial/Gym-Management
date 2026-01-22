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
    public partial class MemberForm : Form
    {
        LoginForm login;
        int userId;
        public MemberForm(LoginForm login, int userId)
        {
            InitializeComponent();
             this.login = login;
             this.userId = userId;
            this.FormClosing += MemberFormClosing;
        }
        public void MemberFormClosing(object sender, FormClosingEventArgs e)
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
            LoadControl(new MyProfileControl1());
        }

        private void btnmembershipPrice_Click(object sender, EventArgs e)
        {
            LoadControl(new MembershipPricingControl());
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

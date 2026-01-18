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
    public partial class EmployeeForm : Form
    {
        LoginForm login;
        public EmployeeForm(LoginForm login)
        {
            InitializeComponent();
            this.login = login;
            this.FormClosing += EmpFormClosing;
        }

        public void EmpFormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

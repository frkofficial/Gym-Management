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
    public partial class UserForm : Form
    {
        LoginForm login;
        public UserForm(LoginForm login)
        {
            InitializeComponent();
            this.login = login;
            this.FormClosing += UserFormClosing;

        }
        public void UserFormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

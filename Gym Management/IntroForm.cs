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
    public partial class IntroForm : Form
    {
        public LoginForm login { private get; set; }
        public RegistrationForm reg { private get; set; }
        public IntroForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            login = new LoginForm(this);
            this.Hide();
            login.Show();
        }

        private void LoginBtn_MouseEnter(object sender, EventArgs e)
        {
            LoginBtn.ForeColor = Color.Black;
            LoginBtn.BackColor = Color.White;
        }

        private void LoginBtn_MouseLeave(object sender, EventArgs e)
        {
            LoginBtn.ForeColor = Color.White;
            LoginBtn.BackColor = Color.Black;
        }

        private void GetStartedBtn_Click(object sender, EventArgs e)
        {
            reg = new RegistrationForm(this);
            this.Hide();
            reg.Show();
        }

        private void GetStarted_MouseEnter(object sender, EventArgs e)
        {
            GetStartedBtn.ForeColor = Color.White;
            GetStartedBtn.BackColor = Color.Black;
            GetStartedBtn.FlatStyle = FlatStyle.Flat;
            GetStartedBtn.FlatAppearance.BorderSize = 2;
            GetStartedBtn.FlatAppearance.BorderColor = Color.White;
        }

        private void GetStarted_MouseLeave(object sender, EventArgs e)
        {
            GetStartedBtn.ForeColor = Color.Black;
            GetStartedBtn.BackColor = Color.Orange;
        }
    }
}

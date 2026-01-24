using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using Gym_Management.Entities;
using Gym_Management.Repo;

namespace Gym_Management
{
    public partial class LoginForm : Form
    {
        UserRepo userrepo;
        AdminRepo adminrepo;
        EmpRepo emprepo;
        public AdminForm admin { private get; set; }
        public MemberForm user { private get; set; }
        public EmployeeForm emp { private get; set; }
        public RegistrationForm reg { private get; set; }
        public  IntroForm intro { private get; set; }
        
        DataAccess DataAccess;

        public LoginForm(IntroForm intro)
        {
            InitializeComponent();
            userrepo = new UserRepo();
            adminrepo = new AdminRepo();
            emprepo = new EmpRepo();
            DataAccess = new DataAccess();
            this.intro=intro ;
            this.FormClosing += LoginFormClosing;
        }
        public void LoginFormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void TestDb()
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["GymsDB"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    MessageBox.Show("Database connected successfully");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UserNameTextBox.Text = "Enter Username";
            UserNameTextBox.ForeColor = Color.Gray;

            PassTextBox.Text = "Enter Password";
            PassTextBox.ForeColor = Color.Gray;
            PassTextBox.UseSystemPasswordChar = false;

            UserNamePnl.Visible = false;
            PassPnl.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UserNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {

                UserNameTextBox.ForeColor = Color.White;
                UserNamePnl.Visible = false;
            }
            catch
            {

            }
        }

        private void PassTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {

                PassTextBox.ForeColor = Color.White;
                PassPnl.Visible = false;
            }
            catch
            {

            }
        }

        private void UserNameTextBox_Enter(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text == "Enter Username")
            {
                UserNameTextBox.Text = "";
                UserNameTextBox.ForeColor = Color.White;
            }
        }

        private void UserNameTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserNameTextBox.Text))
            {
                UserNameTextBox.Text = "Enter Username";
                UserNameTextBox.ForeColor = Color.Gray;
            }
        }
        private void PassTextBox_Enter(object sender, EventArgs e)
        {
            if (PassTextBox.Text == "Enter Password")
            {
                PassTextBox.Text = "";
                PassTextBox.ForeColor = Color.White;
                PassTextBox.UseSystemPasswordChar = true;
            }
        }

        private void PassTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PassTextBox.Text))
            {
                PassTextBox.UseSystemPasswordChar = false;
                PassTextBox.Text = "Enter Password";
                PassTextBox.ForeColor = Color.Gray;
            }
        }


        private void UserNameText_Click(object sender, EventArgs e)
        {
            //UserNameTextBox.SelectAll();
        }

        private void PassText_Click(object sender, EventArgs e)
        {
            //PassTextBox.SelectAll();
        }

        private void loginBtn_MouseEnter(object sender, EventArgs e)
        {
            LoginBtn.ForeColor = Color.Black;
        }

        private void loginBtn_MouseLeave(object sender, EventArgs e)
        {
            LoginBtn.ForeColor = Color.White;
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            // user u= new user(this);
            //this.Hide();
            //u.Show();



            bool hasError = false;

            if (UserNameTextBox.Text == "Enter Username")
            {
                UserNamePnl.Text = "Invalid User Name, Try Again";
                UserNamePnl.Visible = true;
                hasError = true;
            }
            else
            {
                UserNamePnl.Visible = false;
            }

            if (PassTextBox.Text == "Enter Password")
            {
                PassPnl.Text = "Invalid Password, Try Again";
                PassPnl.Visible = true;
                hasError = true;
            }
            else
            {
                PassPnl.Visible = false;
            }


            if (hasError) return;

            TestDb();
            string username = UserNameTextBox.Text.Trim();
            string password = PassTextBox.Text.Trim();


            Admins adminusers = adminrepo.LoginAdmin(username, password);

           
             if (adminusers !=null && adminusers.UserType == "admin")
             {
                    
                    
                        admin = new AdminForm(this,adminusers.AdminId);
                    
                    this.Hide();
                    admin.Text = "WelCome" + adminusers.AdminUserName;
                    admin.Show();
                    return;
             }

            Users member = userrepo.LoginMember(username, password);
           
                if (member!= null && member.UserType == "member")
                {
                    user = new MemberForm(this,member.UserId);
                    this.Hide();
                    user.Text = " Welcome" + member.UserName;
                    user.Show();
                    return;

                }

                Employees emps= emprepo.LoginEmployee(username, password);
            
           
                if (emps != null & emps.UserType == "employee")
                {
                    emp = new EmployeeForm(this,emps.EmpId);
                    this.Hide();
                    emp.Text = "WelCome " + emps.EmpName;
                    emp.Show();
                    return;
                }
            


            else
            {
                UserNamePnl.Visible = true;
                PassPnl.Visible = true;
            }

        }

        private void SignupLinllbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            reg = new RegistrationForm(this);
            this.Hide();
            reg.Show();
        }
    }
}

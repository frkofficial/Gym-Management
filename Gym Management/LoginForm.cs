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

namespace Gym_Management
{
    public partial class LoginForm : Form
    {
        public AdminForm admin { private get; set; }
        public UserForm user { private get; set; }
        DataAccess DataAccess;
        public LoginForm()
        {
            InitializeComponent();
            DataAccess = new DataAccess();
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
            catch(Exception ex)
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
           SqlCommand Admincmd= DataAccess.GetCommand(@"SELECT AdminId, AdminName,UserType
                       FROM AdminInfo
                         WHERE AdminName= @name AND AdminPass= @password");

            Admincmd.Parameters.AddWithValue("@name", UserNameTextBox.Text.Trim());
            Admincmd.Parameters.AddWithValue("@password", PassTextBox.Text.Trim());
            DataTable Admindt = DataAccess.Execute(Admincmd);
            var rows = Admindt.Rows;
            if(rows.Count==1)
            {
                string adminName = rows[0]["AdminName"].ToString();
                string userType = rows[0]["UserType"].ToString().ToLower();
                if(userType=="admin")
                {
                    if(admin==null)
                    {
                        admin = new AdminForm(this);
                    }
                    this.Hide();
                    admin.Text = "WelCome" + adminName;
                    admin.Show();
                }
                
            }
        SqlCommand Usercmd = DataAccess.GetCommand(@"SELECT UserId,UserName,UserType
                                  FROM UserInfo
                                   WHERE UserName= @name AND UserPass= @password");
            Usercmd.Parameters.AddWithValue("@name", UserNameTextBox.Text.Trim());
            Usercmd.Parameters.AddWithValue("password", PassTextBox.Text.Trim());
            DataTable Userdt = DataAccess.Execute(Usercmd);
            var rows1 = Userdt.Rows;
             if(rows1.Count==1)
            {
                string userName = rows1[0]["UserName"].ToString();
                string UserType = rows1[0]["UserType"].ToString().ToLower();
                if(UserType=="member")
                {
                    user = new UserForm(this);
                    this.Hide();
                    user.Text = " Welcome" + userName;
                    user.Show();

                }
            }



            else
            {
                UserNamePnl.Visible = true;
                PassPnl.Visible = true;
            }
               
        }

    }
}

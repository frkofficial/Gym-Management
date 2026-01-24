using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Gym_Management
{
    public partial class MyProfileControl1 : UserControl
    {
        DataAccess dataaccess;

        public MyProfileControl1()
        {
            InitializeComponent();
            dataaccess = new DataAccess();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand Usercmd = dataaccess.GetCommand(@"
UPDATE UserInfo
SET
    UserName        = @username,
    UserFirstName   = @userfname,
    UserLastName    = @userlname,
    UserPass        = @pass,
    UserConPass     = @conpass,
    UserType        = @usertype,
    UserPhone       = @phone,
    UserEmail       = @email,
    UserAddress     = @address,
    UserGender      = @gender,
    UserAge         = @age,
    UserHeight      = @height,
    UserWeight      = @weight,
    UserWeightGoal  = @goalweight,
    UserTrainer     = @trainer,
    UserEmrPhone    = @emrphone,
    UserMembership  = @membership,
    UserJoinDate    = @join,
     UserLeaveDate  = @leave
WHERE UserId = @id
");

            Usercmd.Parameters.AddWithValue("@id", textBox14.Text);
            Usercmd.Parameters.AddWithValue("@username", textBox3.Text);
            Usercmd.Parameters.AddWithValue("@userfname", textBox1.Text);
            Usercmd.Parameters.AddWithValue("@userlname", string.IsNullOrWhiteSpace(textBox2.Text) ? DBNull.Value : textBox2.Text);
            Usercmd.Parameters.AddWithValue("@pass", textBox5.Text);
            Usercmd.Parameters.AddWithValue("@conpass", textBox5.Text);
            Usercmd.Parameters.AddWithValue("@usertype", "Member");
            Usercmd.Parameters.AddWithValue("@phone", textBox8.Text);
            Usercmd.Parameters.AddWithValue("@email", textBox11.Text);
            Usercmd.Parameters.AddWithValue("@address", textBox12.Text);
            Usercmd.Parameters.AddWithValue("@gender", comboBox1.Text);
            int.TryParse(textBox4.Text, out int age);
            Usercmd.Parameters.Add("@age", SqlDbType.Int).Value = age;
            float.TryParse(textBox6.Text, out float height);
            Usercmd.Parameters.Add("@height", SqlDbType.Float).Value = height;
            int.TryParse(textBox7.Text, out int weight);
            Usercmd.Parameters.Add("@weight", SqlDbType.Int).Value = weight;
            Usercmd.Parameters.Add("@goalweight", SqlDbType.Int).Value = string.IsNullOrWhiteSpace(textBox9.Text) ? DBNull.Value : Convert.ToString(textBox9.Text);
            Usercmd.Parameters.AddWithValue("@trainer", comboBox2.Text);
            Usercmd.Parameters.AddWithValue("@emrphone", string.IsNullOrWhiteSpace(textBox10.Text) ? DBNull.Value : textBox10.Text);
            Usercmd.Parameters.AddWithValue("@membership", textBox13.Text);
            Usercmd.Parameters.Add("@join", SqlDbType.Date).Value = textBox16.Text;
            Usercmd.Parameters.Add("@leave", SqlDbType.Date).Value = textBox15.Text == null ? DBNull.Value : textBox15.Text;

            try
            {
                var rows = dataaccess.ExecuteNonQuery(Usercmd);
                if (rows > 0)
                {
                    MessageBox.Show($"{textBox3.Text}s User Information Updated");

                }
                else
                {
                    MessageBox.Show($"{textBox3.Text} User Information Update Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DataBase Error");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                SqlCommand cmd = dataaccess.GetCommand(
                    "SELECT * FROM UserInfo WHERE UserName = @username");

                cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value =
                 textBox14.Text.Trim();
                cmd.Connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    textBox1.Text = reader["UserFirstName"].ToString();
                    textBox2.Text = reader["UserLastName"].ToString();
                    textBox3.Text = reader["UserName"].ToString();
                    textBox5.Text = reader["UserPass"].ToString();
                    textBox7.Text = reader["UserWeight"].ToString();
                    textBox6.Text = reader["UserHeight"].ToString();
                    textBox4.Text = reader["UserAge"].ToString();
                    textBox9.Text = reader["UserWeightGoal"].ToString();
                    comboBox1.Text = reader["UserGender"].ToString();
                    textBox12.Text = reader["UserAddress"].ToString();
                    textBox10.Text = reader["UserEmrPhone"].ToString();
                    comboBox2.Text = reader["UserTrainer"].ToString();
                    textBox13.Text = reader["UserMembership"].ToString();
                    textBox16.Text = reader["UserJoinDate"].ToString();
                    textBox15.Text = reader["UserLeaveDate"].ToString();
                    textBox11.Text = reader["UserEmail"].ToString();
                    textBox8.Text = reader["UserPhone"].ToString();
                }
                else
                {
                    MessageBox.Show("User not found");
                }

            }
        }
    }
}


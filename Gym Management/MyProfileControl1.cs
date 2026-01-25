using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gym_Management
{
    public partial class MyProfileControl1 : UserControl
    {
        DataAccess dataaccess;
        private int currentUserId = 0;

        public MyProfileControl1()
        {
            InitializeComponent();
            textBox14.ReadOnly = true;  
            textBox15.ReadOnly = true;
            dataaccess = new DataAccess();
            LoadLoggedInUser();
        }

        private void LoadLoggedInUser()
        {
            if (Session.UserId == 0)
            {
                MessageBox.Show("No user logged in.");
                return;
            }

            SqlCommand cmd = dataaccess.GetCommand(
                "SELECT * FROM UserInfo WHERE UserId = @id");

            cmd.Parameters.AddWithValue("@id", Session.UserId);

            try
            {
                DataTable dt = dataaccess.Execute(cmd);

                if (dt.Rows.Count == 1)
                {
                    DataRow row = dt.Rows[0];
                    currentUserId = Session.UserId;

                    textBox1.Text = row["UserFirstName"].ToString();
                    textBox2.Text = row["UserLastName"].ToString();
                    textBox3.Text = row["UserName"].ToString();
                    textBox5.Text = row["UserPass"].ToString();
                    textBox7.Text = row["UserWeight"].ToString();
                    textBox6.Text = row["UserHeight"].ToString();
                    textBox4.Text = row["UserAge"].ToString();
                    textBox9.Text = row["UserWeightGoal"].ToString();
                    comboBox1.SelectedItem = row["UserGender"].ToString();
                    textBox12.Text = row["UserAddress"].ToString();
                    textBox10.Text = row["UserEmrPhone"].ToString();
                    comboBox2.SelectedItem = row["UserTrainer"].ToString();
                    textBox13.Text = row["UserMembership"].ToString();
                    textBox14.Text = row["UserJoinDate"].ToString();
                    textBox15.Text = row["UserLeaveDate"].ToString();
                    textBox11.Text = row["UserEmail"].ToString();
                    textBox8.Text = row["UserPhone"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // UPDATE
        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = dataaccess.GetCommand(@"
UPDATE UserInfo SET
UserFirstName=@fname,
UserLastName=@lname,
UserName=@username,
UserPass=@pass,
UserPhone=@phone,
UserEmail=@email,
UserAddress=@address,
UserGender=@gender,
UserAge=@age,
UserHeight=@height,
UserWeight=@weight,
UserWeightGoal=@goal,
UserTrainer=@trainer,
UserEmrPhone=@emr,
UserMembership=@membership,
UserJoinDate=@join,
UserLeaveDate=@leave
WHERE UserId=@id");

            cmd.Parameters.AddWithValue("@id", currentUserId);
            cmd.Parameters.AddWithValue("@fname", textBox1.Text);
            cmd.Parameters.AddWithValue("@lname", textBox2.Text);
            cmd.Parameters.AddWithValue("@username", textBox3.Text);
            cmd.Parameters.AddWithValue("@pass", textBox5.Text);
            cmd.Parameters.AddWithValue("@phone", textBox8.Text);
            cmd.Parameters.AddWithValue("@email", textBox11.Text);
            cmd.Parameters.AddWithValue("@address", textBox12.Text);
            cmd.Parameters.AddWithValue("@gender", comboBox1.Text);
            cmd.Parameters.AddWithValue("@age", textBox4.Text);
            cmd.Parameters.AddWithValue("@height", textBox6.Text);
            cmd.Parameters.AddWithValue("@weight", textBox7.Text);
            cmd.Parameters.AddWithValue("@goal", textBox9.Text);
            cmd.Parameters.AddWithValue("@trainer", comboBox2.Text);
            cmd.Parameters.AddWithValue("@emr", textBox10.Text);
            cmd.Parameters.AddWithValue("@membership", textBox13.Text);
           cmd.Parameters.AddWithValue("@join", textBox14.Text);
           cmd.Parameters.AddWithValue("@leave", textBox15.Text);

            int rows = dataaccess.ExecuteNonQuery(cmd);

            if (rows > 0)
                MessageBox.Show("Profile updated successfully");
            else
                MessageBox.Show("Update failed");
        }
    }

}

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
        private int currentUserId = 0; // Store the current user ID

        public MyProfileControl1()
        {
            InitializeComponent();
            dataaccess = new DataAccess();
            InitializeGenderComboBox();
            InitializeTrainerComboBox();
        }

        private void InitializeGenderComboBox()
        {
            comboBox1.Items.AddRange(new string[] { "Male", "Female", "Other" });
        }

        private void InitializeTrainerComboBox()
        {
            // You can load trainers from database here
            comboBox2.Items.AddRange(new string[] { "John", "Sarah", "Mike", "Emily" });
        }

        // SEARCH/LOAD EXISTING INFORMATION
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox14.Text))
            {
                MessageBox.Show("Please enter User ID to search", "Input Required");
                return;
            }

            SqlCommand cmd = dataaccess.GetCommand(
                "SELECT * FROM UserInfo WHERE UserId = @id");

            cmd.Parameters.AddWithValue("@id", textBox14.Text.Trim());

            try
            {
                DataTable dt = dataaccess.Execute(cmd);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    // Store the user ID for later use
                    currentUserId = Convert.ToInt32(row["UserId"]);

                    // Load data into textboxes
                    textBox1.Text = row["UserFirstName"].ToString();
                    textBox2.Text = row["UserLastName"].ToString();
                    textBox3.Text = row["UserName"].ToString();
                    textBox5.Text = row["UserPass"].ToString();
                    textBox7.Text = row["UserWeight"] != DBNull.Value ? row["UserWeight"].ToString() : "";
                    textBox6.Text = row["UserHeight"] != DBNull.Value ? row["UserHeight"].ToString() : "";
                    textBox4.Text = row["UserAge"] != DBNull.Value ? row["UserAge"].ToString() : "";
                    textBox9.Text = row["UserWeightGoal"] != DBNull.Value ? row["UserWeightGoal"].ToString() : "";

                    // ComboBox handling
                    comboBox1.SelectedItem = row["UserGender"] != DBNull.Value ? row["UserGender"].ToString() : "";

                    textBox12.Text = row["UserAddress"].ToString();
                    textBox10.Text = row["UserEmrPhone"] != DBNull.Value ? row["UserEmrPhone"].ToString() : "";

                    comboBox2.SelectedItem = row["UserTrainer"] != DBNull.Value ? row["UserTrainer"].ToString() : "";

                    textBox13.Text = row["UserMembership"] != DBNull.Value ? row["UserMembership"].ToString() : "";

                    // Date handling
                    if (row["UserJoinDate"] != DBNull.Value)
                        textBox16.Text = Convert.ToDateTime(row["UserJoinDate"]).ToString("yyyy-MM-dd");

                    if (row["UserLeaveDate"] != DBNull.Value)
                        textBox15.Text = Convert.ToDateTime(row["UserLeaveDate"]).ToString("yyyy-MM-dd");

                    textBox11.Text = row["UserEmail"].ToString();
                    textBox8.Text = row["UserPhone"].ToString();

                    MessageBox.Show("User information loaded successfully!", "Success");
                }
                else
                {
                    MessageBox.Show("User not found with the given ID", "Not Found");
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user: {ex.Message}", "Database Error");
            }
        }

        // UPDATE INFORMATION
        private void button2_Click(object sender, EventArgs e)
        {
            if (currentUserId == 0)
            {
                MessageBox.Show("Please search for a user first or enter User ID", "No User Selected");
                return;
            }

            // Validate required fields
            if (string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Username, First Name, and Password are required fields", "Validation Error");
                return;
            }

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
    UserLeaveDate   = @leave
WHERE UserId = @id
");

            try
            {
                // Add parameters
                Usercmd.Parameters.AddWithValue("@id", currentUserId);
                Usercmd.Parameters.AddWithValue("@username", textBox3.Text.Trim());
                Usercmd.Parameters.AddWithValue("@userfname", textBox1.Text.Trim());
                Usercmd.Parameters.AddWithValue("@userlname", string.IsNullOrWhiteSpace(textBox2.Text) ? DBNull.Value : (object)textBox2.Text.Trim());
                Usercmd.Parameters.AddWithValue("@pass", textBox5.Text);
                Usercmd.Parameters.AddWithValue("@conpass", textBox5.Text); 
                Usercmd.Parameters.AddWithValue("@usertype", "Member");
                Usercmd.Parameters.AddWithValue("@phone", textBox8.Text.Trim());
                Usercmd.Parameters.AddWithValue("@email", textBox11.Text.Trim());
                Usercmd.Parameters.AddWithValue("@address", textBox12.Text.Trim());
                //Usercmd.Parameters.AddWithValue("@gender", comboBox1.SelectedItem?.ToString() ?? DBNull.Value);

                // Handle numeric values with null
                if (int.TryParse(textBox4.Text, out int age) && age > 0)
                    Usercmd.Parameters.AddWithValue("@age", age);
                else
                    Usercmd.Parameters.AddWithValue("@age", DBNull.Value);

                if (float.TryParse(textBox6.Text, out float height) && height > 0)
                    Usercmd.Parameters.AddWithValue("@height", height);
                else
                    Usercmd.Parameters.AddWithValue("@height", DBNull.Value);

                if (int.TryParse(textBox7.Text, out int weight) && weight > 0)
                    Usercmd.Parameters.AddWithValue("@weight", weight);
                else
                    Usercmd.Parameters.AddWithValue("@weight", DBNull.Value);

                if (int.TryParse(textBox9.Text, out int goalWeight) && goalWeight > 0)
                    Usercmd.Parameters.AddWithValue("@goalweight", goalWeight);
                else
                    Usercmd.Parameters.AddWithValue("@goalweight", DBNull.Value);

                //Usercmd.Parameters.AddWithValue("@trainer", comboBox2.SelectedItem?.ToString() ?? DBNull.Value);
                Usercmd.Parameters.AddWithValue("@emrphone", string.IsNullOrWhiteSpace(textBox10.Text) ? DBNull.Value : (object)textBox10.Text.Trim());
                Usercmd.Parameters.AddWithValue("@membership", string.IsNullOrWhiteSpace(textBox13.Text) ? DBNull.Value : (object)textBox13.Text.Trim());

                // Handle dates
                if (DateTime.TryParse(textBox16.Text, out DateTime joinDate))
                    Usercmd.Parameters.AddWithValue("@join", joinDate);
                else
                    Usercmd.Parameters.AddWithValue("@join", DBNull.Value);

                if (DateTime.TryParse(textBox15.Text, out DateTime leaveDate))
                    Usercmd.Parameters.AddWithValue("@leave", leaveDate);
                else
                    Usercmd.Parameters.AddWithValue("@leave", DBNull.Value);

                // Execute update
                var rows = dataaccess.ExecuteNonQuery(Usercmd);

                if (rows > 0)
                {
                    MessageBox.Show($"{textBox3.Text}'s information has been updated successfully!", "Update Successful");
                }
                else
                {
                    MessageBox.Show("Update failed. No rows were affected.", "Update Failed");
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL Error: {sqlEx.Message}", "Database Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }

        // Helper method to clear the form
        private void ClearForm()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            currentUserId = 0;
        }

        // Clear button if you want to add one
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
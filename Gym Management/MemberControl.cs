using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Gym_Management
{
    public partial class MemberControl : UserControl
    {
        DataAccess dataAccess;
        int userid;
        public MemberControl()
        {
            InitializeComponent();
            dataAccess = new DataAccess();
            this.Dock = DockStyle.Fill;

        }
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void MemberControl_Load(object sender, EventArgs e)
        {
            Updatebtn.Enabled = false;
            DeleteBtn.Enabled = false;
            passerrorlbl.Visible = false;
            phoneerrorlbl.Visible = false;
            emailerrorlbl.Visible = false;
            ageerrorlbl.Visible = false;
            heighterrorlbl.Visible = false;
            weighterrorlbl.Visible = false;
            gweighterrorlbl.Visible = true;
            emailerrorlbl.Visible = false;
            MemberShipErrorlbl.Visible = false;
            Gendererrorlbl.Visible = false;
            TrainerErrorlbl.Visible = false;
            UserNameErrorlbl.Visible = false;
            Fnameerrorlbl.Visible = false;
            emrerrorlbl.Visible = true;
            LastNamelbl.Visible = true;
            MemberShipErrorlbl.Visible = false;
            AddressErrorlbl.Visible = false;
            joindatedtp.Value = DateTime.Today;
            leavedatedtp.Value = DateTime.Today.AddMonths(1);
            joinerroelbl.Visible = false;
            leaveerrorlbl.Visible = false;

            LoadUser();


        }
        private void LoadUser()
        {
            SqlCommand Usercmd = dataAccess.GetCommand("SELECT * FROM UserInfo");
            DataTable dt = dataAccess.Execute(Usercmd);
            UserDataGridView.DataSource = dt;
        }

        private void ResetForm()
        {
            void ResetControl(Control Parent)
            {


                foreach (Control c in Parent.Controls)
                {
                    if (c is TextBox tb)
                    {
                        tb.Clear();
                    }
                    else if (c is ComboBox cb)
                    {
                        cb.SelectedIndex = -1;
                    }
                    else
                    {
                        ResetControl(c);
                    }

                }
            }
            ResetControl(this);
            Updatebtn.Enabled = false;
            DeleteBtn.Enabled = false;
            userid = 0;
        }
        private void MembershipCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MembershipCombobox.SelectedItem?.ToString() == "No Membership")
            {
                joindatedtp.Enabled = false;
                leavedatedtp.Enabled = false;
            }
            else
            {
                joindatedtp.Enabled = true;
                leavedatedtp.Enabled = false; //auto calculated
            }
        }

        private void UserDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void UserDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0 || UserDataGridView.Rows[e.RowIndex].IsNewRow)
            {
                return;
            }
            else
            {

                var rows = UserDataGridView.Rows[e.RowIndex];
                userid = Convert.ToInt32(rows.Cells["UserId"].Value);
                UserNametxt.Text = rows.Cells["UserName"].Value.ToString();
                FirstNametxt.Text = rows.Cells["UserFirstName"].Value.ToString();
                LastNametxt.Text = rows.Cells["UserLastName"].Value?.ToString() ?? "";
                passtxt.Text = rows.Cells["UserPass"].Value.ToString();
                phonetxt.Text = rows.Cells["UserPhone"].Value.ToString();
                emailtxt.Text = rows.Cells["UserEmail"].Value.ToString();
                addresstxt.Text = rows.Cells["UserAddress"].Value.ToString();
                agetxt.Text = rows.Cells["UserAge"].Value.ToString();
                gendercombobox.SelectedItem = rows.Cells["UserGender"].Value.ToString();
                heighttxt.Text = rows.Cells["UserHeight"].Value.ToString();
                weighttxt.Text = rows.Cells["UserWeight"].Value.ToString();
                goalweighttxt.Text = rows.Cells["UserWeightGoal"].Value?.ToString() ?? "";
                TrainerCombobox.SelectedItem = rows.Cells["UserTrainer"].Value?.ToString();
                emergencytxt.Text = rows.Cells["UserEmrPhone"].Value.ToString();
                MembershipCombobox.SelectedItem = rows.Cells["UserMemberShip"].Value?.ToString();
                if (rows.Cells["UserJoinDate"].Value != DBNull.Value)
                    joindatedtp.Value = Convert.ToDateTime(rows.Cells["UserJoinDate"].Value);
                if (rows.Cells["UserLeaveDate"].Value != DBNull.Value)
                    leavedatedtp.Value = Convert.ToDateTime(rows.Cells["UserLeaveDate"].Value);
                    
                Updatebtn.Enabled = true;
                DeleteBtn.Enabled = true;
            }
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {

            var FirstName = FirstNametxt.Text;
            var LastName = LastNametxt.Text;
            var UserName = UserNametxt.Text;
            var Age = agetxt.Text;
            var Pass = passtxt.Text;
            //var ConPass = UserConfirmPasstextBox.Text;
            var Weight = weighttxt.Text;
            var GoalWeight = goalweighttxt.Text;
            var Height = heighttxt.Text;
            var Email = emailtxt.Text;
            var Phone = phonetxt.Text;
            var EmrPhone = emergencytxt.Text;
            var Address = addresstxt.Text;
            var Gender = gendercombobox.SelectedItem?.ToString();
            string UserTrainer = TrainerCombobox.SelectedItem?.ToString();
            string memberShip = MembershipCombobox.SelectedItem?.ToString();
            DateTime? joindate = null;
            DateTime? leavedate = null;

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            string passPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";

            bool hasError = false;

            if (FirstNametxt.Text == " Your First Name" || string.IsNullOrWhiteSpace(FirstName))
            {
                Fnameerrorlbl.Visible = true;
                hasError = true;
            }
            else
            {
                Fnameerrorlbl.Visible = false;
            }
            if (LastNametxt.Text == " Your Last Name" || string.IsNullOrWhiteSpace(LastName))
            {

            }
            else
            {

            }
            if (UserNametxt.Text == " Your User Name" || string.IsNullOrWhiteSpace(UserName))
            {
                UserNameErrorlbl.Visible = true;
                hasError = true;

            }
            else
            {
                UserNameErrorlbl.Visible = false;
            }
            if (passtxt.Text == " Password(Strong)" || string.IsNullOrWhiteSpace(Pass))
            {
                passerrorlbl.Text = "Enter Your Password";
                passerrorlbl.Visible = true;
                hasError = true;
            }

            else if (!Regex.IsMatch(Pass, passPattern))
            {
                // passlbl.Text = "Weak Password";
                passerrorlbl.ForeColor = Color.Red;
                passerrorlbl.Visible = true;
                hasError = true;
            }
            else
            {
                passerrorlbl.Visible = false;
            }



            if (agetxt.Text == " Your Age" || string.IsNullOrWhiteSpace(Age))
            {
                ageerrorlbl.Text = "Enter Your Age";
                ageerrorlbl.Visible = true;
                hasError = true;
            }

            else if (!int.TryParse(Age, out _))
            {
                ageerrorlbl.Text = "Age Must be Numeric";
                ageerrorlbl.ForeColor = Color.Red;
                ageerrorlbl.Visible = true;

                hasError = true;
            }



            else
            {
                ageerrorlbl.Visible = false;

            }
            if (heighttxt.Text == " Your Current Height" || string.IsNullOrWhiteSpace(Height))
            {
                heighterrorlbl.Visible = true;
                hasError = true;
            }


            else if (!float.TryParse(Height, out _))
            {
                heighterrorlbl.Text = "Height Must be Numeric";
                heighterrorlbl.ForeColor = Color.Red;
                heighterrorlbl.Visible = true;
                hasError = true;
            }
            else
            {
                heighterrorlbl.Visible = false;
            }

            if (phonetxt.Text == " Contact Number" || string.IsNullOrWhiteSpace(Phone))
            {
                phoneerrorlbl.Visible = true;
                hasError = true;
            }
            else if (!Regex.IsMatch(Phone, @"^\d{11}$"))
            {
                phoneerrorlbl.Text = "Invalid Contact";
                phoneerrorlbl.Visible = true;
                hasError = true;
            }
            else
            {
                phoneerrorlbl.Visible = false;
            }
            if (emailtxt.Text == " Email ID" || string.IsNullOrWhiteSpace(Email))
            {
                emailerrorlbl.Visible = true;
                hasError = true;
            }

            else if (!Regex.IsMatch(Email, emailPattern))
            {
                emailerrorlbl.Text = "Invalid Email Address";

                emailerrorlbl.ForeColor = Color.Red;
                emailerrorlbl.Visible = true;
                hasError = true;
            }
            else
            {
                emailerrorlbl.Visible = false;
            }
            if (phonetxt.Text == " Emergency Contact" || string.IsNullOrWhiteSpace(EmrPhone))
            {
                emrerrorlbl.Text = "Emergency is Optional";
                emrerrorlbl.ForeColor = Color.Lime;
                emrerrorlbl.Visible = true;
            }

            else if (EmrPhone == Phone && !string.IsNullOrWhiteSpace(EmrPhone))
            {
                emrerrorlbl.Text = "Use Diiferent Emergency Contact";
                emrerrorlbl.ForeColor = Color.Red;
                emrerrorlbl.Visible = true;
                hasError = true;
            }
            else if (!Regex.IsMatch(EmrPhone, @"^\d{11}$"))
            {
                emrerrorlbl.Text = "Invalid Contact";
                emrerrorlbl.ForeColor = Color.Red;
                emrerrorlbl.Visible = true;
                hasError = true;
            }
            else
            {
                emrerrorlbl.Text = "Emergency is Optional";
                emrerrorlbl.ForeColor = Color.Lime;
                emrerrorlbl.Visible = true;

            }

            if (weighttxt.Text == " You Current Weight" || string.IsNullOrWhiteSpace(Weight))
            {
                weighterrorlbl.Visible = true;
                hasError = true;

            }

            else if (!int.TryParse(Weight, out _))
            {
                weighterrorlbl.Text = "Weight Must be Numeric";
                weighterrorlbl.ForeColor = Color.Red;
                weighterrorlbl.Visible = true;
                hasError = true;
            }
            else
            {
                weighterrorlbl.Visible = false;
            }

            if (gweighterrorlbl.Text == " Goal Weight" || string.IsNullOrWhiteSpace(GoalWeight))
            {
                gweighterrorlbl.Text = "Goal Weight Optional";
                gweighterrorlbl.ForeColor = Color.Lime;
                gweighterrorlbl.Visible = true;
            }
            else if (!int.TryParse(GoalWeight, out _))
            {
                gweighterrorlbl.Text = "Weight Must be Numaric";
                gweighterrorlbl.ForeColor = Color.Red;
                gweighterrorlbl.Visible = true;

            }
            else
            {
                gweighterrorlbl.Text = "Goal Weight Optional";
                gweighterrorlbl.ForeColor = Color.Lime;
                gweighterrorlbl.Visible = true;
            }

            if (addresstxt.Text == " Your Address" || string.IsNullOrWhiteSpace(Address))
            {
                AddressErrorlbl.Visible = true;
                hasError = true;
            }
            else
            {
                AddressErrorlbl.Visible = false;
            }


            if (gendercombobox.SelectedIndex == -1)
            {
                Gendererrorlbl.Visible = true;
                //GendercomboBox.Focus();
                hasError = true;

            }
            else
            {
                Gendererrorlbl.Visible = false;
            }
            if (TrainerCombobox.SelectedIndex == -1)
            {
                TrainerErrorlbl.Visible = true;
                // UseTrainercomboBox2.Focus();
                hasError = true;
            }
            else
            {
                TrainerErrorlbl.Visible = false;

            }
            if (MembershipCombobox.SelectedIndex == -1)
            {
                MemberShipErrorlbl.Visible = true;
                //MembershipcomboBox3.Focus();
                hasError = true;
            }
            else
            {
                MemberShipErrorlbl.Visible = false;
            }
            
            if (hasError) return;



            switch (memberShip)
            {
                case "Regular Monthly":
                    joindate = joindatedtp.Value;
                    leavedate = joindatedtp.Value.AddMonths(1);
                    break;
                case "Student Monthly":
                    joindate = joindatedtp.Value;
                    leavedate = joindatedtp.Value.AddMonths(1);
                    break;

                case "6 Month Package":
                    joindate = joindatedtp.Value;
                    leavedate = joindatedtp.Value.AddMonths(6);
                    break;

                case "1 Year Package":
                    joindate = joindatedtp.Value;
                    leavedate = joindatedtp.Value.AddMonths(12);
                    break;

                case "No Membership":
                    joindate = null;
                    leavedate = null;
                    break;
            }




            SqlCommand Usercmd = dataAccess.GetCommand(@"INSERT INTO UserInfo(UserName,UserFirstName,UserLastName,UserPass,UserConPass,UserType,UserPhone,UserEmail,UserAddress,UserGender,UserAge,UserHeight,UserWeight,UserWeightGoal,UserTrainer,UserEmrPhone,UserMembership,UserJoinDate,UserLeaveDate) VALUES (@username,@userfname,@userlname,@pass,@conpass,@usertype,@phone,@email,@address,@gender,@age,@height,@weight,@goalweight,@trainer,@emrphone,@membership,@join,@leave);");
            Usercmd.Parameters.AddWithValue("@userfname", FirstName);
            Usercmd.Parameters.AddWithValue("@userlname", string.IsNullOrWhiteSpace(LastName) ? DBNull.Value : LastName);
            Usercmd.Parameters.AddWithValue("@username", UserName);
            Usercmd.Parameters.AddWithValue("@pass", Pass);
            Usercmd.Parameters.AddWithValue("@conpass", Pass);
            Usercmd.Parameters.AddWithValue("@usertype", "Member");
            Usercmd.Parameters.AddWithValue("@phone", Phone);
            Usercmd.Parameters.AddWithValue("@email", Email);
            Usercmd.Parameters.AddWithValue("@address", Address);
            Usercmd.Parameters.AddWithValue("@gender", Gender);
            Usercmd.Parameters.Add("@age", SqlDbType.Int).Value = int.Parse(Age);
            Usercmd.Parameters.Add("@height", SqlDbType.Float).Value = float.Parse(Height);
            Usercmd.Parameters.Add("@weight", SqlDbType.Int).Value = int.Parse(Weight);
            Usercmd.Parameters.Add("@join", SqlDbType.Date).Value =joindate == null ? DBNull.Value : joindate;
            Usercmd.Parameters.Add("@leave", SqlDbType.Date).Value = leavedate == null ? DBNull.Value : leavedate ;


            // Handle optional GoalWeight
            if (!string.IsNullOrWhiteSpace(GoalWeight) && int.TryParse(GoalWeight, out int goalWeightValue))
            {
                Usercmd.Parameters.Add("@goalweight", SqlDbType.Int).Value = goalWeightValue;
            }
            else
            {
                Usercmd.Parameters.Add("@goalweight", SqlDbType.Int).Value = DBNull.Value;
            }

            Usercmd.Parameters.AddWithValue("@trainer", UserTrainer);

            // Handle optional EmrPhone
            Usercmd.Parameters.AddWithValue("@emrphone", string.IsNullOrWhiteSpace(EmrPhone) ? DBNull.Value : EmrPhone);
            Usercmd.Parameters.AddWithValue("@membership", memberShip);

            try
            {
                var rows = dataAccess.ExecuteNonQuery(Usercmd);
                if (rows > 0)
                {
                    MessageBox.Show($"{UserName}s User Information Inserted");
                }
                else
                {
                    MessageBox.Show($"{UserName}s User Information Insertion Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }

            LoadUser();
            ResetForm();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            ResetForm();

        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            var FirstName = FirstNametxt.Text;
            var LastName = LastNametxt.Text;
            var UserName = UserNametxt.Text;
            var Age = agetxt.Text;
            var Pass = passtxt.Text;
            //var ConPass = UserConfirmPasstextBox.Text;
            var Weight = weighttxt.Text;
            var GoalWeight = goalweighttxt.Text;
            var Height = heighttxt.Text;
            var Email = emailtxt.Text;
            var Phone = phonetxt.Text;
            var EmrPhone = emergencytxt.Text;
            var Address = addresstxt.Text;
            var Gender = gendercombobox.SelectedItem?.ToString();
            string UserTrainer = TrainerCombobox.SelectedItem?.ToString();
            string memberShip = MembershipCombobox.SelectedItem?.ToString();
            DateTime? joindate = null;
            DateTime? leavedate = null;
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            string passPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";

            bool hasError = false;
            switch (memberShip)
            {
                case "Regular Monthly":
                    joindate = joindatedtp.Value;
                    leavedate = joindatedtp.Value.AddMonths(1);
                    break;
                case "Student Monthly":
                    joindate = joindatedtp.Value;
                    leavedate = joindatedtp.Value.AddMonths(1);
                    break;

                case "6 Month Package":
                    joindate = joindatedtp.Value;
                    leavedate = joindatedtp.Value.AddMonths(6);
                    break;

                case "1 Year Package":
                    joindate = joindatedtp.Value;
                    leavedate = joindatedtp.Value.AddMonths(12);
                    break;

                case "No Membership":
                    joindate = null;
                    leavedate = null;
                    break;
            }





            if (!Regex.IsMatch(Pass, passPattern))
            {
                // passlbl.Text = "Weak Password";
                passerrorlbl.ForeColor = Color.Red;
                passerrorlbl.Visible = true;
                hasError = true;
            }
            else
            {
                passerrorlbl.Visible = false;
            }



            if (!int.TryParse(Age, out _))
            {
                ageerrorlbl.Text = "Age Must be Numeric";
                ageerrorlbl.ForeColor = Color.Red;
                ageerrorlbl.Visible = true;

                hasError = true;
            }



            else
            {
                ageerrorlbl.Visible = false;

            }
            if (!float.TryParse(Height, out _))
            {
                heighterrorlbl.Text = "Height Must be Numeric";
                heighterrorlbl.ForeColor = Color.Red;
                heighterrorlbl.Visible = true;
                hasError = true;
            }
            else
            {
                heighterrorlbl.Visible = false;
            }

            if (!Regex.IsMatch(Phone, @"^\d{11}$"))
            {
                phoneerrorlbl.Text = "Invalid Contact";
                phoneerrorlbl.Visible = true;
                hasError = true;
            }
            else
            {
                phoneerrorlbl.Visible = false;
            }
            if (!Regex.IsMatch(Email, emailPattern))
            {
                emailerrorlbl.Text = "Invalid Email Address";

                emailerrorlbl.ForeColor = Color.Red;
                emailerrorlbl.Visible = true;
                hasError = true;
            }
            else
            {
                emailerrorlbl.Visible = false;
            }
            if (EmrPhone == Phone && !string.IsNullOrWhiteSpace(EmrPhone))
            {
                emrerrorlbl.Text = "Use Diiferent Emergency Contact";
                emrerrorlbl.ForeColor = Color.Red;
                emrerrorlbl.Visible = true;
                hasError = true;
            }
            else if (!Regex.IsMatch(EmrPhone, @"^\d{11}$"))
            {
                emrerrorlbl.Text = "Invalid Contact";
                emrerrorlbl.ForeColor = Color.Red;
                emrerrorlbl.Visible = true;
                hasError = true;
            }
            else
            {
                emrerrorlbl.Text = "Emergency is Optional";
                emrerrorlbl.ForeColor = Color.Lime;
                emrerrorlbl.Visible = true;

            }

            if (!int.TryParse(Weight, out _))
            {
                weighterrorlbl.Text = "Weight Must be Numeric";
                weighterrorlbl.ForeColor = Color.Red;
                weighterrorlbl.Visible = true;
                hasError = true;
            }
            else
            {
                weighterrorlbl.Visible = false;
            }

            if (!int.TryParse(GoalWeight, out _))
            {
                gweighterrorlbl.Text = "Weight Must be Numaric";
                gweighterrorlbl.ForeColor = Color.Red;
                gweighterrorlbl.Visible = true;

            }
            else
            {
                gweighterrorlbl.Text = "Goal Weight Optional";
                gweighterrorlbl.ForeColor = Color.Lime;
                gweighterrorlbl.Visible = true;
            }



            SqlCommand Usercmd = dataAccess.GetCommand(@"
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

            Usercmd.Parameters.AddWithValue("@id", userid);
            Usercmd.Parameters.AddWithValue("@username", UserName);
            Usercmd.Parameters.AddWithValue("@userfname", FirstName);
            Usercmd.Parameters.AddWithValue("@userlname", string.IsNullOrWhiteSpace(LastName) ? DBNull.Value : LastName);
            Usercmd.Parameters.AddWithValue("@pass", Pass);
            Usercmd.Parameters.AddWithValue("@conpass", Pass);
            Usercmd.Parameters.AddWithValue("@usertype", "Member");
            Usercmd.Parameters.AddWithValue("@phone", Phone);
            Usercmd.Parameters.AddWithValue("@email", Email);
            Usercmd.Parameters.AddWithValue("@address", Address);
            Usercmd.Parameters.AddWithValue("@gender", Gender);
            Usercmd.Parameters.Add("@age", SqlDbType.Int).Value = int.Parse(Age);
            Usercmd.Parameters.Add("@height", SqlDbType.Float).Value = float.Parse(Height);
            Usercmd.Parameters.Add("@weight", SqlDbType.Int).Value = int.Parse(Weight);
            Usercmd.Parameters.Add("@goalweight", SqlDbType.Int).Value = string.IsNullOrWhiteSpace(GoalWeight) ? DBNull.Value : int.Parse(GoalWeight);
            Usercmd.Parameters.AddWithValue("@trainer", UserTrainer);
            Usercmd.Parameters.AddWithValue("@emrphone", string.IsNullOrWhiteSpace(EmrPhone) ? DBNull.Value : EmrPhone);
            Usercmd.Parameters.AddWithValue("@membership", memberShip);
            Usercmd.Parameters.Add("@join", SqlDbType.Date).Value =joindate == null ? DBNull.Value : joindate;
            Usercmd.Parameters.Add("@leave", SqlDbType.Date).Value = leavedate==null? DBNull.Value:leavedate;
            try
            {
                var rows = dataAccess.ExecuteNonQuery(Usercmd);
                if (rows > 0)
                {
                    MessageBox.Show($"{UserName}s User Information Updated");

                }
                else
                {
                    MessageBox.Show($"{UserName}s User Information Update Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DataBase Error");
            }
            LoadUser();
            ResetForm();

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (userid == 0)
            {
                MessageBox.Show("Please Select An User First");
                return;
            }
            var reesult = MessageBox.Show("Are You Sure Want to Delete This User?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (reesult == DialogResult.Yes)
            {
                var UserName = UserNametxt.Text;
                SqlCommand Usercmd = dataAccess.GetCommand("DELETE FROM UserInfo WHERE UserId=@id");
                Usercmd.Parameters.AddWithValue("@id", userid);
                try
                {
                    var rows = dataAccess.ExecuteNonQuery(Usercmd);
                    if (rows > 0)
                    {
                        MessageBox.Show($"{UserName}s User Information Deleted");
                    }
                    else
                    {
                        MessageBox.Show($"{UserName}s User Information Deletion Failed");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "DataBase Error");
                }
                LoadUser();
                ResetForm();
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            SqlCommand usercmd = dataAccess.GetCommand(@"SELECT * FROM UserInfo WHERE UserName LIKE @name OR CAST(UserId AS VARCHAR) LIKE @id");
            string search = "%" + textBox9.Text.Trim() + "%";
            usercmd.Parameters.AddWithValue("@name", search);
            usercmd.Parameters.AddWithValue("@id", search);
            DataTable dt = dataAccess.Execute(usercmd);
            UserDataGridView.DataSource = dt; 
        }
    }
}

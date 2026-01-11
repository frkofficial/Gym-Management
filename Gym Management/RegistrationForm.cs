using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic.ApplicationServices;



namespace Gym_Management
{
    public partial class RegistrationForm : Form
    {
        //public LoginForm login { private get; set; }
        //public LoginForm login;
        private Form previousform;
        DataAccess DataAccess;
        public RegistrationForm(Form previousform)
        {

            InitializeComponent();
            DataAccess = new DataAccess();
            this.previousform = previousform;
            this.FormClosing += RegistrationFormClosing;

        }
        public void RegistrationFormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserAddresstextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserFirstNametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegiPnl_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void ProceedBtn_Click(object sender, EventArgs e)
        {
            var FirstName = UserFirstNametextBox.Text;
            var LastName = UserLastNametextBox.Text;
            var UserName = UserNametextBox.Text;
            var Age = UserAgetextBox.Text;
            var Pass = UserPasstextBox.Text;
            var ConPass = UserConfirmPasstextBox.Text;
            var Weight = UserWeighttextBox.Text;
            var GoalWeight = UserWeightGoaltextBox.Text;
            var Height = UserHeighttextBox.Text;
            var Email = UserEmailtextBox.Text;
            var Phone = UserPhonetextBox.Text;
            var EmrPhone = UserEmerPhonetextBox.Text;
            var Address = UserAddresstextBox.Text;
            var Gender = GendercomboBox.SelectedItem.ToString();
            string UserTrainer = UseTrainercomboBox2.SelectedItem.ToString();
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            string passPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";

            bool hasError = false;

            if (UserFirstNametextBox.Text == " Your First Name" || string.IsNullOrWhiteSpace(FirstName))
            {
                FirstNamePnl.Visible = true;
                hasError = true;
            }
            else
            {
                 Fnamelbl.Visible = false;
            }
            if (UserLastNametextBox.Text == " Your Last Name" || string.IsNullOrWhiteSpace(LastName))
            {

            }
            else
            {

            }
            if (UserNametextBox.Text == " Your User Name" || string.IsNullOrWhiteSpace(UserName))
            {
                UserNamelbl.Visible = true;
                hasError=true;

            }
            else
            {
                UserNamelbl.Visible = false;
            }
            if (UserPasstextBox.Text == " Password(Strong)" || string.IsNullOrWhiteSpace(Pass))
            {
                passlbl.Visible = true;
                hasError = true;
            }
            else
            {
                passlbl.Visible = false;
            }
            if (!Regex.IsMatch(Pass, passPattern))
            {
                passlbl.Text = "Weak Password";
                passlbl.ForeColor = Color.Red;
                passlbl.Visible = true;
                hasError = true;
            }
            else
            {
                passlbl.Visible = false;
            }
            

                if (UserConfirmPasstextBox.Text == " Confirm Password" || string.IsNullOrWhiteSpace(ConPass))
            {
                ConPasslbl.Visible = true;
                hasError = true;
            }
            else
            {
                ConPasslbl.Visible = false;
            }
            if(Pass!=ConPass)
            {
                ConPasslbl.Visible = true;
                hasError = true;
            }
            else
            {
                ConPasslbl.Visible = false;
            }
            if (UserAgetextBox.Text == " Your Age" || string.IsNullOrWhiteSpace(Age))
            {
                Agelbl.Visible = true;
                hasError = true;
            }

            else
            {
                Agelbl.Visible = false;

            }
            
            if (!int.TryParse(Age, out _))
            {
                Agelbl.Text = "Age Must be Numeric";
                Agelbl.ForeColor = Color.Red;
                Agelbl.Visible = true;

                hasError = true;
            }
            if (UserHeighttextBox.Text == " Your Current Height" || string.IsNullOrWhiteSpace(Height))
            {
                Heightlbl.Visible = true;
                hasError = true;
            }
            else
            {
                Heightlbl.Visible = false;
            }

            if(!float.TryParse(Height, out _))
            {
                Heightlbl.Text = "Height Must be Numeric";
                Heightlbl.ForeColor = Color.Red;
                Heightlbl.Visible = true;
                hasError = true;
            }

            if (UserPhonetextBox.Text == " Contact Number" || string.IsNullOrWhiteSpace(Phone))
            {
                Contactlbl.Visible = true;
                hasError = true;
            }
            else
            {
                Contactlbl.Visible = false;
            }
            if (UserEmailtextBox.Text == " Email ID" || string.IsNullOrWhiteSpace(Email))
            {
                Emaillbl.Visible = true;
                hasError = true;
            }
            else
            {
                Emaillbl.Visible = false;
            }
            if(!Regex.IsMatch(Email,emailPattern))
            {
                Emaillbl.Text = "Invalid Email Address";

                Emaillbl.ForeColor = Color.Red;
                Emaillbl.Visible = true;
                hasError = true;
            }
            else
            {
                Emaillbl.Visible = false;
            }
            if (UserEmerPhonetextBox.Text == " Emergency Contact" || string.IsNullOrWhiteSpace(EmrPhone))
            {

            }
            else
            {

            }
            if (EmrPhone == Phone)
            {
                EmrPhonelbl.Text = "Emergency contact must be different";
                EmrPhonelbl.Visible = true;
                hasError = true;
            }
           
            if (UserWeighttextBox.Text == " You Current Weight" || string.IsNullOrWhiteSpace(Weight))
            {
                Weightlbl.Visible = true;
                hasError = true;
            }
            else
            {
                Weightlbl.Visible = false;
            }
            if(!int.TryParse(Weight, out _))
            {
                Weightlbl.Text = "Weight Must be Numeric";
                Weightlbl.ForeColor = Color.Red;
                Weightlbl.Visible = true;
                hasError = true;
            }

            if (UserWeightGoaltextBox.Text == " Goal Weight" || string.IsNullOrWhiteSpace(GoalWeight))
            {

            }
            else
            {

            }

            if(UserAddresstextBox.Text == " Your Address" || string.IsNullOrWhiteSpace(Address))
            {
                Addresslbl.Visible = true;
                hasError = true;
            }
            else
            {
                Addresslbl.Visible = false;
            }
            

            if (GendercomboBox.SelectedIndex == 0)
            {
                Genderlbl.Visible = true;
                //GendercomboBox.Focus();
                hasError = true;
                
            }
            else
            {
                Genderlbl.Visible = false;
            }
            if (UseTrainercomboBox2.SelectedIndex == 0)
            {
                Trainerlbl.Visible = true;
               // UseTrainercomboBox2.Focus();
                hasError=true;
            }
            else
            {
                Trainerlbl.Visible = false;

            }

            if (hasError) return;

            SqlCommand Usercmd = DataAccess.GetCommand(@"INSERT INTO UserInfo(UserName,UserFirstName,UserLastName,UserPass,UserConPass,UserType,UserPhone,UserEmail,UserAddress,UserGender,UserAge,UserHeight,UserWeight,UserWeightGoal,UserTrainer,UserEmrPhone) VALUES (@username,@userfname,@userlname,@pass,@conpass,@usertype,@phone,@email,@address,@gender,@age,@height,@weight,@goalweight,@trainer,@emrphone);"); 
            Usercmd.Parameters.AddWithValue("@userfname", FirstName);
            Usercmd.Parameters.AddWithValue("@userlname", LastName);
            Usercmd.Parameters.AddWithValue("@username", UserName);
            Usercmd.Parameters.AddWithValue("@pass", Pass);
            Usercmd.Parameters.AddWithValue("@conpass", ConPass);
            Usercmd.Parameters.AddWithValue("@usertype", "Member");
            Usercmd.Parameters.AddWithValue("@phone", Phone);
            Usercmd.Parameters.AddWithValue("@email", Email);
            Usercmd.Parameters.AddWithValue("@address",Address);
            Usercmd.Parameters.AddWithValue("@gender", Gender);
            Usercmd.Parameters.Add("@age", SqlDbType.Int).Value=int.Parse(Age);
            Usercmd.Parameters.Add("@height", SqlDbType.Float).Value= float.Parse(Height);
            Usercmd.Parameters.Add("@weight", SqlDbType.Int).Value=int.Parse(Weight);
            Usercmd.Parameters.Add("@goalweight", SqlDbType.Int).Value=int.Parse(GoalWeight);
            Usercmd.Parameters.AddWithValue("@trainer", UserTrainer);
            Usercmd.Parameters.AddWithValue("@emrphone", EmrPhone);

            try
            {
                if(!string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(Pass) && !string.IsNullOrEmpty(ConPass)&& !string.IsNullOrEmpty(Phone) && !string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(Address) && !string.IsNullOrEmpty(Gender) && !string.IsNullOrEmpty(Age) && !string.IsNullOrEmpty(Height) && !string.IsNullOrEmpty(Weight)  && !string.IsNullOrEmpty(UserTrainer) )
                {
                    var rows = DataAccess.ExecuteNonQuery(Usercmd);
                    if(rows==1)
                    {
                        MessageBox.Show($"Congratulations!!! {UserName}, Your Refgistration Has Completed");
                       
                        //this.Hide();
                        previousform.Show();
                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show($"Sorry!!! {UserName}, Your Registration Has failed, Try Again");
                    }
                }
                else
                {
                    FirstNamePnl.Visible = true;
                    passlbl.Visible = true;
                    UserNamelbl.Visible = true;
                    Addresslbl.Visible = true;
                    Agelbl.Visible = true;
                    ConPasslbl.Visible = true;
                    Contactlbl.Visible = true;
                    Emaillbl.Visible = true;
                    Genderlbl.Visible = true;
                    Heightlbl.Visible = true;
                    Weightlbl.Visible = true;
                    Trainerlbl.Visible = true;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show( ex.Message,"Registration Error");

            }









        }

        private void UserLastNametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            FirstNamePnl.Visible = false;
            passlbl.Visible = false;
            UserNamelbl.Visible = false;
            Addresslbl.Visible = false;
            Agelbl.Visible = false;
            ConPasslbl.Visible = false;
            Contactlbl.Visible = false;
            Emaillbl.Visible = false;
            Genderlbl.Visible = false;
            Heightlbl.Visible = false;
            Weightlbl.Visible = false;
            Trainerlbl.Visible = false;
            GoalWeightlbl.Visible = true;
            EmrPhonelbl.Visible = true;
            LastNamelbl.Visible = true;



            GendercomboBox.SelectedIndex = 0;
            UseTrainercomboBox2.SelectedIndex = 0;
        }
    }
}

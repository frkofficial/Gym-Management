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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
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
            bool hasError = false;

            if (UserFirstNametextBox.Text == "Your First Name")
            {

            }
            if (UserLastNametextBox.Text == "Your Last Name")
            {

            }
            else
            {

            }
            if (UserNametextBox.Text == "User Name")
            {

            }
            else
            {

            }
            if (UserPasstextBox.Text == "Password(Strong)")
            {

            }
            else
            {

            }
            if (UserConfirmPasstextBox.Text == "Confirm Password")
            {

            }
            else
            {

            }
            if (UserAgetextBox.Text == " Your Age")
            {

            }
            else
            {

            }
            if (UserHeighttextBox.Text == " Your Height")
            {

            }
            else
            {

            }
            if (UserPhonetextBox.Text == " Contact Number")
            {

            }
            else
            {

            }
            if (UserEmailtextBox.Text == " Email ID")
            {

            }
            else
            {

            }
            if (UserEmerPhonetextBox.Text == " Emergency Contact")
            {

            }
            else
            {

            }

            if (UserWeightGoaltextBox.Text == " Goal Weight")
            {

            }

            if (GendercomboBox.SelectedIndex == 0)
            {
                Genderlbl.Visible = true;
                //GendercomboBox.Focus();
                return;
            }
            string gender = GendercomboBox.SelectedItem.ToString();
            if (UseTrainercomboBox2.SelectedIndex == 0)
            {
                Trainerlbl.Visible = true;
                UseTrainercomboBox2.Focus();
                return;
            }
            string useTrainer = GendercomboBox.SelectedItem.ToString();

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



            GendercomboBox.SelectedIndex = 0;
            UseTrainercomboBox2.SelectedIndex = 0;
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gym_Management
{
    public partial class EditMembershipCardForm : Form
    {
        public string CardName { get; private set; }
        public decimal CardPrice { get; private set; }
        public decimal AdmissionFee { get; private set; }
        public string CardDescription { get; private set; }
        public bool IsStudentPlan { get; private set; }
        public int Duration { get; private set; }

        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtAdmission;
        private TextBox txtDescription;
        private NumericUpDown numDuration;
        private CheckBox chkStudent;
        private MembershipPackage originalCard;

        public EditMembershipCardForm(MembershipPackage card)
        {
            this.originalCard = card;
            InitializeComponent();
            SetupUI();
            LoadCardData();
        }

        private void LoadCardData()
        {
            // Pre-fill the form with existing card data
            txtName.Text = originalCard.Name;
            txtPrice.Text = originalCard.Price.ToString();
            txtAdmission.Text = originalCard.AdmissionFee.ToString();
            txtDescription.Text = originalCard.Description;
            numDuration.Value = originalCard.Duration;
            chkStudent.Checked = originalCard.IsStudentPlan;
        }

        private void SetupUI()
        {
            this.Text = "Edit Membership Card";
            this.Size = new Size(500, 650);
            this.BackColor = ColorTranslator.FromHtml("#2a2a2a");
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Title
            Label titleLabel = new Label
            {
                Text = "Edit Membership Card",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(30, 20)
            };
            this.Controls.Add(titleLabel);

            // Plan Name
            Label lblName = new Label
            {
                Text = "Plan Name *",
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(30, 80)
            };
            this.Controls.Add(lblName);

            txtName = new TextBox
            {
                Size = new Size(420, 30),
                Location = new Point(30, 105),
                Font = new Font("Segoe UI", 11),
                BackColor = ColorTranslator.FromHtml("#1a1a1a"),
                ForeColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };
            this.Controls.Add(txtName);

            // Price
            Label lblPrice = new Label
            {
                Text = "Price (BDT/month) *",
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(30, 150)
            };
            this.Controls.Add(lblPrice);

            txtPrice = new TextBox
            {
                Size = new Size(420, 30),
                Location = new Point(30, 175),
                Font = new Font("Segoe UI", 11),
                BackColor = ColorTranslator.FromHtml("#1a1a1a"),
                ForeColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };
            this.Controls.Add(txtPrice);

            // Admission Fee
            Label lblAdmission = new Label
            {
                Text = "Admission Fee (BDT) - Optional",
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(30, 220)
            };
            this.Controls.Add(lblAdmission);

            txtAdmission = new TextBox
            {
                Size = new Size(420, 30),
                Location = new Point(30, 245),
                Font = new Font("Segoe UI", 11),
                BackColor = ColorTranslator.FromHtml("#1a1a1a"),
                ForeColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };
            this.Controls.Add(txtAdmission);

            // Duration in Months
            Label lblDuration = new Label
            {
                Text = "Duration (Months) *",
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(30, 290)
            };
            this.Controls.Add(lblDuration);

            numDuration = new NumericUpDown
            {
                Size = new Size(420, 30),
                Location = new Point(30, 315),
                Font = new Font("Segoe UI", 11),
                BackColor = ColorTranslator.FromHtml("#1a1a1a"),
                ForeColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Minimum = 1,
                Maximum = 120,
                Value = 1
            };
            this.Controls.Add(numDuration);

            // Description
            Label lblDescription = new Label
            {
                Text = "Description",
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(30, 360)
            };
            this.Controls.Add(lblDescription);

            txtDescription = new TextBox
            {
                Size = new Size(420, 80),
                Location = new Point(30, 385),
                Font = new Font("Segoe UI", 10),
                BackColor = ColorTranslator.FromHtml("#1a1a1a"),
                ForeColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Multiline = true
            };
            this.Controls.Add(txtDescription);

            // Student Plan Checkbox
            chkStudent = new CheckBox
            {
                Text = "Student Plan",
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(30, 480),
                Cursor = Cursors.Hand
            };
            this.Controls.Add(chkStudent);

            // Save Button
            Button btnSave = new Button
            {
                Text = "Save Changes",
                Size = new Size(200, 45),
                Location = new Point(30, 520),
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = ColorTranslator.FromHtml("#4CAF50"),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Click += BtnSave_Click;
            btnSave.MouseEnter += (s, e) => btnSave.BackColor = ColorTranslator.FromHtml("#45a049");
            btnSave.MouseLeave += (s, e) => btnSave.BackColor = ColorTranslator.FromHtml("#4CAF50");
            this.Controls.Add(btnSave);

            // Cancel Button
            Button btnCancel = new Button
            {
                Text = "Cancel",
                Size = new Size(200, 45),
                Location = new Point(250, 520),
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = ColorTranslator.FromHtml("#2a2a2a"),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnCancel.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#444444");
            btnCancel.FlatAppearance.BorderSize = 2;
            btnCancel.Click += (s, e) => this.DialogResult = DialogResult.Cancel;
            btnCancel.MouseEnter += (s, e) => btnCancel.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#666666");
            btnCancel.MouseLeave += (s, e) => btnCancel.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#444444");
            this.Controls.Add(btnCancel);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a plan name.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid price.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return;
            }

            decimal admission = 0;
            if (!string.IsNullOrWhiteSpace(txtAdmission.Text))
            {
                if (!decimal.TryParse(txtAdmission.Text, out admission) || admission < 0)
                {
                    MessageBox.Show("Please enter a valid admission fee.", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAdmission.Focus();
                    return;
                }
            }

            // Set properties
            CardName = txtName.Text.Trim();
            CardPrice = price;
            AdmissionFee = admission;
            CardDescription = txtDescription.Text.Trim();
            IsStudentPlan = chkStudent.Checked;
            Duration = (int)numDuration.Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Name = "EditMembershipCardForm";
            this.ResumeLayout(false);
        }
    }
}

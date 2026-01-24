using Gym_Management.Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym_Management.Entities;

namespace Gym_Management
{
    public partial class AssignedControl : UserControl
    {
        TrainerRepo trainerRepo;
        UserRepo userRepo;
        int assignid = 0;
        int trainerid = 0;
        string currentMode = "assignment";
        public AssignedControl()
        {
            trainerRepo = new TrainerRepo();
            userRepo = new UserRepo();

            InitializeComponent();
        }
        private void AssignedControl_Load(object sender, EventArgs e)
        {
            LoadAssigning();
            LoadTrainer();
            bookdatedtp.Value = DateTime.Now;
            expiredatedtp.Value = DateTime.Now;
            updatebtn.Enabled = false;
            deletebtn.Enabled = false;
        }
        private void UpdateButtonStates()
        {

            if (currentMode == "assignment")
            {
                updatebtn.Enabled = assignid > 0;
                deletebtn.Enabled = assignid > 0;
            }
            else if (currentMode == "trainer")
            {
                updatebtn.Enabled = trainerid > 0;
                deletebtn.Enabled = trainerid > 0;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoadAssigning()
        {
            DataTable dt = userRepo.Assignments();
            AssignGridView.DataSource = dt;
        }

        private void LoadTrainer()
        {
            DataTable dt = trainerRepo.Trainers();
            TrainerGridView.DataSource = dt;
        }

        private void AssignGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || AssignGridView.Rows[e.RowIndex].IsNewRow)
            {
                return;
            }

            try
            {
                currentMode = "assignment";
                TrainerGridView.ClearSelection();
                var rows = AssignGridView.Rows[e.RowIndex];
                assignid = Convert.ToInt32(rows.Cells["AssignmentId"].Value);
                trainerid = 0;
                useridtxt.Text = rows.Cells["UserId"].Value?.ToString() ?? "";
                usernametxt.Text = rows.Cells["UserName"].Value?.ToString() ?? "";
                traineridtxt.Text = rows.Cells["TrainerId"].Value?.ToString() ?? "";
                trainernametxt.Text = rows.Cells["TrainerName"].Value?.ToString() ?? "";
                Trainerprice.Text = rows.Cells["TrainerPrice"].Value?.ToString() ?? "";

                TrainerNamet.Text = rows.Cells["TrainerName"].Value?.ToString() ?? "";
                Trainerprice.Text = rows.Cells["TrainerPrice"].Value?.ToString() ?? "";

                if (rows.Cells["BookingDate"].Value != DBNull.Value)
                    bookdatedtp.Value = Convert.ToDateTime(rows.Cells["BookingDate"].Value);
                if (rows.Cells["ExpireDate"].Value != DBNull.Value)
                    expiredatedtp.Value = Convert.ToDateTime(rows.Cells["ExpireDate"].Value);

                UpdateButtonStates();
            }


            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }
        private void ResetForms()
        {
            assignid = 0;
            trainerid = 0;
            currentMode = "assignment";

            useridtxt.Clear();
            usernametxt.Clear();
            traineridtxt.Clear();
            trainernametxt.Clear();
            Trainerprice.Clear();
            TrainerNamet.Clear();
            trainerpricetxt.Clear();

            bookdatedtp.Value = DateTime.Now;
            expiredatedtp.Value = DateTime.Now;

            AssignGridView.ClearSelection();
            TrainerGridView.ClearSelection();

            UpdateButtonStates();
        }

        private void InsertAssignment()
        {
            var uname = usernametxt.Text;
            var uid = useridtxt.Text;
            var tid = traineridtxt.Text;
            var tname = trainernametxt.Text;
            var tprice = Trainerprice.Text;

            if (string.IsNullOrWhiteSpace(uid))
            {
                MessageBox.Show("Please enter User ID", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                useridtxt.Focus();
                return;
            }

            if (!int.TryParse(uid, out _))
            {
                MessageBox.Show("User ID must be a number", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                useridtxt.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(uname))
            {
                MessageBox.Show("Please enter User Name", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usernametxt.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tid))
            {
                MessageBox.Show("Please enter Trainer ID", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                traineridtxt.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tname))
            {
                MessageBox.Show("Please enter Trainer Name", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                trainernametxt.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tprice))
            {
                MessageBox.Show("Please enter Trainer Price", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Trainerprice.Focus();
                return;
            }

            try
            {
                TrainerAssignment assignment = new TrainerAssignment();
                assignment.UserId = int.Parse(uid);
                assignment.UserName = uname;
                assignment.TrainerId = tid;
                assignment.TrainerName = tname;
                assignment.TrainerPrice = tprice;
                assignment.BookingDate = bookdatedtp.Value.ToString("yyyy-MM-dd");
                assignment.ExpireDate = expiredatedtp.Value.ToString("yyyy-MM-dd");

                int result = userRepo.InsertAssignment(assignment);

                if (result > 0)
                {
                    MessageBox.Show("Trainer assigned successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAssigning();
                    ResetForms();
                }
                else
                {
                    MessageBox.Show("Failed to assign trainer. Please try again.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void UpdateAssignment()
        {
            var uname = usernametxt.Text;
            var uid = useridtxt.Text;
            var tid = traineridtxt.Text;
            var tname = trainernametxt.Text;
            var tprice = Trainerprice.Text;

            if (string.IsNullOrWhiteSpace(uid))
            {
                MessageBox.Show("Please enter User ID", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                useridtxt.Focus();
                return;
            }

            if (!int.TryParse(uid, out _))
            {
                MessageBox.Show("User ID must be a number", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                useridtxt.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(uname))
            {
                MessageBox.Show("Please enter User Name", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usernametxt.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tid))
            {
                MessageBox.Show("Please enter Trainer ID", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                traineridtxt.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tname))
            {
                MessageBox.Show("Please enter Trainer Name", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                trainernametxt.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tprice))
            {
                MessageBox.Show("Please enter Trainer Price", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Trainerprice.Focus();
                return;
            }
            try
            {
                TrainerAssignment assignment = new TrainerAssignment();
                assignment.AssignmentId = assignid;
                assignment.UserId = int.Parse(uid);
                assignment.UserName = uname;
                assignment.TrainerId = tid;
                assignment.TrainerName = tname;
                assignment.TrainerPrice = tprice;
                assignment.BookingDate = bookdatedtp.Value.ToString("yyyy-MM-dd");
                assignment.ExpireDate = expiredatedtp.Value.ToString("yyyy-MM-dd");

                int result = userRepo.UpdateAssignment(assignment);

                if (result > 0)
                {
                    MessageBox.Show("Assignment updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAssigning();
                    ResetForms();
                }
                else
                {
                    MessageBox.Show("Failed to update assignment. Please try again.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteAssignment()
        {
            var result = MessageBox.Show(
                $"Are you sure you want to delete this assignment?\n" +
                $"User: {usernametxt.Text}\n" +
                $"Trainer: {trainernametxt.Text}\n" +
                $"This action cannot be undone.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    int deleteResult = userRepo.DeleteAssignment(assignid);

                    if (deleteResult > 0)
                    {
                        MessageBox.Show("Assignment deleted successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAssigning();
                        ResetForms();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete assignment. Please try again.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TrainerGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || TrainerGridView.Rows[e.RowIndex].IsNewRow)
            {
                return;
            }

            try
            {
                currentMode = "trainer";
                AssignGridView.ClearSelection();

                var row = TrainerGridView.Rows[e.RowIndex];
                trainerid = Convert.ToInt32(row.Cells["TrainerId"].Value);
                assignid = 0;

                TrainerNamet.Text = row.Cells["TrainerName"].Value?.ToString() ?? "";
                trainerpricetxt.Text = row.Cells["TrainerPrice"].Value?.ToString() ?? "";

                // Also fill assignment trainer fields
                trainernametxt.Text = row.Cells["TrainerName"].Value?.ToString() ?? "";
                Trainerprice.Text = row.Cells["TrainerPrice"].Value?.ToString() ?? "";
                traineridtxt.Text = row.Cells["TrainerId"].Value?.ToString() ?? "";

                UpdateButtonStates();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }


        private void InsertTrainer()
        {
            var trainername = TrainerNamet.Text;
            var price = trainerpricetxt.Text;
            if (string.IsNullOrWhiteSpace(trainername))
            {
                MessageBox.Show("Please enter Trainer Name", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TrainerNamet.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(price))
            {
                MessageBox.Show("Please enter Trainer Price", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                trainerpricetxt.Focus();
                return;
            }

            try
            {
                Trainer trainer = new Trainer();
                trainer.TrainerName = trainername;
                trainer.TrainerPrice = price;

                int result = trainerRepo.InsertTrainer(trainer);

                if (result > 0)
                {
                    MessageBox.Show("Trainer added successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTrainer();
                    ResetForms();
                }
                else
                {
                    MessageBox.Show("Failed to add trainer. Please try again.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTrainer()
        {
            var trainername = TrainerNamet.Text;
            var price = trainerpricetxt.Text;
            if (string.IsNullOrWhiteSpace(trainername))
            {
                MessageBox.Show("Please enter Trainer Name", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                trainernametxt.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(price))
            {
                MessageBox.Show("Please enter Trainer Price", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                trainerpricetxt.Focus();
                return;
            }

            try
            {
                Trainer trainer = new Trainer();
                trainer.TrainerId = trainerid;
                trainer.TrainerName = trainername;
                trainer.TrainerPrice = price;

                int result = trainerRepo.UpdateTrainer(trainer);

                if (result > 0)
                {
                    MessageBox.Show("Trainer updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTrainer();
                    ResetForms();
                }
                else
                {
                    MessageBox.Show("Failed to update trainer. Please try again.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteTrainer()
        {
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete trainer '{trainernametxt.Text}'?\n" +
                $"This action cannot be undone.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    int deleteResult = trainerRepo.DeleteTrainer(trainerid);

                    if (deleteResult > 0)
                    {
                        MessageBox.Show("Trainer deleted successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTrainer();
                        ResetForms();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete trainer. Please try again.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            bool hasAssignmentData = !string.IsNullOrWhiteSpace(useridtxt.Text);
            bool hasTrainerData = !string.IsNullOrWhiteSpace(TrainerNamet.Text) && !string.IsNullOrWhiteSpace(trainerpricetxt.Text);

            if (hasAssignmentData && hasTrainerData)
            {
                
                InsertTrainer();
                InsertAssignment();
            }
            else if (hasAssignmentData)
            {
                
                InsertAssignment();
            }
            else if (hasTrainerData)
            {
                
                InsertTrainer();
            }
            else
            {
                MessageBox.Show("Please fill in trainer information or assignment information", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void updatebtn_Click(object sender, EventArgs e)
        {
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

        }

        private void deletebtn_Click_1(object sender, EventArgs e)
        {
            if (currentMode == "assignment" && assignid > 0)
            {
                DeleteAssignment();
            }
            else if (currentMode == "trainer" && trainerid > 0)
            {
                DeleteTrainer();
            }
            else
            {
                MessageBox.Show("Please select a record from the grid to delete", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            ResetForms();
        }

        private void updatebtn_Click_1(object sender, EventArgs e)
        {
            bool hasAssignmentSelected = assignid > 0;
            bool hasTrainerSelected = trainerid > 0;
            bool hasAssignmentData = !string.IsNullOrWhiteSpace(useridtxt.Text);
            bool hasTrainerData = !string.IsNullOrWhiteSpace(TrainerNamet.Text) && !string.IsNullOrWhiteSpace(trainerpricetxt.Text);


            if (hasAssignmentSelected && hasTrainerSelected && hasAssignmentData && hasTrainerData)
            {
                UpdateAssignment();
                UpdateTrainer();
            }
            
            else if (hasAssignmentSelected && hasAssignmentData)
            {
                UpdateAssignment();
            }
            
            else if (hasTrainerSelected && hasTrainerData)
            {
                UpdateTrainer();
            }
            else
            {
                MessageBox.Show("Please select a record from the grid to update", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

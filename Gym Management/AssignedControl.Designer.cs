namespace Gym_Management
{
    partial class AssignedControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            TrainerGridView = new DataGridView();
            AssignGridView = new DataGridView();
            panel1 = new Panel();
            insertbtn = new Button();
            trainerpricetxt = new TextBox();
            label9 = new Label();
            label10 = new Label();
            TrainerNamet = new TextBox();
            Trainerprice = new TextBox();
            label8 = new Label();
            resetbtn = new Button();
            updatebtn = new Button();
            deletebtn = new Button();
            usernametxt = new TextBox();
            traineridtxt = new TextBox();
            label1 = new Label();
            trainernametxt = new TextBox();
            label3 = new Label();
            label5 = new Label();
            usernamelbl = new Label();
            label6 = new Label();
            label2 = new Label();
            label7 = new Label();
            useridtxt = new TextBox();
            expiredatedtp = new DateTimePicker();
            bookdatedtp = new DateTimePicker();
            label4 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TrainerGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AssignGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(20, 20, 20);
            panel2.Controls.Add(TrainerGridView);
            panel2.Controls.Add(AssignGridView);
            panel2.Location = new Point(83, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(1393, 320);
            panel2.TabIndex = 40;
            // 
            // TrainerGridView
            // 
            TrainerGridView.BackgroundColor = Color.FromArgb(20, 20, 20);
            TrainerGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TrainerGridView.Location = new Point(832, 17);
            TrainerGridView.Name = "TrainerGridView";
            TrainerGridView.RowHeadersWidth = 62;
            TrainerGridView.Size = new Size(538, 282);
            TrainerGridView.TabIndex = 1;
            TrainerGridView.CellClick += TrainerGridView_CellClick;
            // 
            // AssignGridView
            // 
            AssignGridView.BackgroundColor = Color.FromArgb(20, 20, 20);
            AssignGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AssignGridView.Location = new Point(38, 17);
            AssignGridView.Name = "AssignGridView";
            AssignGridView.RowHeadersWidth = 62;
            AssignGridView.Size = new Size(723, 282);
            AssignGridView.TabIndex = 0;
            AssignGridView.CellClick += AssignGridView_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(20, 20, 20);
            panel1.Controls.Add(insertbtn);
            panel1.Controls.Add(trainerpricetxt);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(TrainerNamet);
            panel1.Controls.Add(Trainerprice);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(resetbtn);
            panel1.Controls.Add(updatebtn);
            panel1.Controls.Add(deletebtn);
            panel1.Controls.Add(usernametxt);
            panel1.Controls.Add(traineridtxt);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(trainernametxt);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(usernamelbl);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(useridtxt);
            panel1.Controls.Add(expiredatedtp);
            panel1.Controls.Add(bookdatedtp);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(83, 428);
            panel1.Name = "panel1";
            panel1.Size = new Size(1416, 483);
            panel1.TabIndex = 39;
            // 
            // insertbtn
            // 
            insertbtn.BackColor = Color.Transparent;
            insertbtn.FlatAppearance.BorderColor = Color.FromArgb(255, 87, 34);
            insertbtn.FlatAppearance.BorderSize = 2;
            insertbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 87, 34);
            insertbtn.FlatStyle = FlatStyle.Flat;
            insertbtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            insertbtn.ForeColor = SystemColors.ButtonHighlight;
            insertbtn.Location = new Point(886, 194);
            insertbtn.Name = "insertbtn";
            insertbtn.Size = new Size(189, 43);
            insertbtn.TabIndex = 46;
            insertbtn.Text = "Insert";
            insertbtn.UseVisualStyleBackColor = false;
            insertbtn.Click += insertbtn_Click;
            // 
            // trainerpricetxt
            // 
            trainerpricetxt.Location = new Point(1019, 141);
            trainerpricetxt.Multiline = true;
            trainerpricetxt.Name = "trainerpricetxt";
            trainerpricetxt.Size = new Size(351, 31);
            trainerpricetxt.TabIndex = 42;
            trainerpricetxt.TextChanged += textBox2_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(886, 52);
            label9.Name = "label9";
            label9.Size = new Size(127, 25);
            label9.TabIndex = 45;
            label9.Text = "Trainer Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(886, 144);
            label10.Name = "label10";
            label10.Size = new Size(119, 25);
            label10.TabIndex = 44;
            label10.Text = "Trainer Price";
            // 
            // TrainerNamet
            // 
            TrainerNamet.Location = new Point(1019, 46);
            TrainerNamet.Name = "TrainerNamet";
            TrainerNamet.Size = new Size(351, 31);
            TrainerNamet.TabIndex = 43;
            // 
            // Trainerprice
            // 
            Trainerprice.Location = new Point(216, 259);
            Trainerprice.Name = "Trainerprice";
            Trainerprice.Size = new Size(545, 31);
            Trainerprice.TabIndex = 40;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(31, 262);
            label8.Name = "label8";
            label8.Size = new Size(158, 25);
            label8.TabIndex = 41;
            label8.Text = "Trainer Price";
            // 
            // resetbtn
            // 
            resetbtn.BackColor = Color.Transparent;
            resetbtn.FlatAppearance.BorderColor = Color.FromArgb(255, 87, 34);
            resetbtn.FlatAppearance.BorderSize = 2;
            resetbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 87, 34);
            resetbtn.FlatStyle = FlatStyle.Flat;
            resetbtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resetbtn.ForeColor = SystemColors.ButtonHighlight;
            resetbtn.Location = new Point(1101, 262);
            resetbtn.Name = "resetbtn";
            resetbtn.Size = new Size(189, 43);
            resetbtn.TabIndex = 39;
            resetbtn.Text = "Reset";
            resetbtn.UseVisualStyleBackColor = false;
            resetbtn.Click += resetbtn_Click;
            // 
            // updatebtn
            // 
            updatebtn.BackColor = Color.Transparent;
            updatebtn.FlatAppearance.BorderColor = Color.FromArgb(255, 87, 34);
            updatebtn.FlatAppearance.BorderSize = 2;
            updatebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 87, 34);
            updatebtn.FlatStyle = FlatStyle.Flat;
            updatebtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updatebtn.ForeColor = SystemColors.ButtonHighlight;
            updatebtn.Location = new Point(886, 262);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(189, 43);
            updatebtn.TabIndex = 37;
            updatebtn.Text = "Update";
            updatebtn.UseVisualStyleBackColor = false;
            updatebtn.Click += updatebtn_Click_1;
            // 
            // deletebtn
            // 
            deletebtn.BackColor = Color.Transparent;
            deletebtn.FlatAppearance.BorderColor = Color.FromArgb(255, 87, 34);
            deletebtn.FlatAppearance.BorderSize = 2;
            deletebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 87, 34);
            deletebtn.FlatStyle = FlatStyle.Flat;
            deletebtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deletebtn.ForeColor = SystemColors.ButtonHighlight;
            deletebtn.Location = new Point(1101, 194);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(189, 43);
            deletebtn.TabIndex = 38;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = false;
            deletebtn.Click += deletebtn_Click_1;
            // 
            // usernametxt
            // 
            usernametxt.Location = new Point(216, 98);
            usernametxt.Multiline = true;
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new Size(545, 31);
            usernametxt.TabIndex = 23;
            // 
            // traineridtxt
            // 
            traineridtxt.Location = new Point(216, 154);
            traineridtxt.Multiline = true;
            traineridtxt.Name = "traineridtxt";
            traineridtxt.Size = new Size(545, 31);
            traineridtxt.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(31, 46);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 26;
            label1.Text = "User Id";
            // 
            // trainernametxt
            // 
            trainernametxt.Location = new Point(216, 209);
            trainernametxt.Name = "trainernametxt";
            trainernametxt.Size = new Size(545, 31);
            trainernametxt.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(311, 43);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 27;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(31, 212);
            label5.Name = "label5";
            label5.Size = new Size(158, 25);
            label5.TabIndex = 34;
            label5.Text = "Assign To Trainer";
            // 
            // usernamelbl
            // 
            usernamelbl.AutoSize = true;
            usernamelbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernamelbl.ForeColor = SystemColors.ButtonHighlight;
            usernamelbl.Location = new Point(31, 101);
            usernamelbl.Name = "usernamelbl";
            usernamelbl.Size = new Size(105, 25);
            usernamelbl.TabIndex = 25;
            usernamelbl.Text = "User Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(311, 173);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(31, 318);
            label2.Name = "label2";
            label2.Size = new Size(128, 25);
            label2.TabIndex = 28;
            label2.Text = "Booking Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(31, 154);
            label7.Name = "label7";
            label7.Size = new Size(94, 25);
            label7.TabIndex = 35;
            label7.Text = "Trainer Id";
            // 
            // useridtxt
            // 
            useridtxt.Location = new Point(216, 43);
            useridtxt.Name = "useridtxt";
            useridtxt.Size = new Size(545, 31);
            useridtxt.TabIndex = 24;
            // 
            // expiredatedtp
            // 
            expiredatedtp.Format = DateTimePickerFormat.Short;
            expiredatedtp.Location = new Point(216, 374);
            expiredatedtp.Name = "expiredatedtp";
            expiredatedtp.Size = new Size(545, 31);
            expiredatedtp.TabIndex = 31;
            // 
            // bookdatedtp
            // 
            bookdatedtp.Format = DateTimePickerFormat.Short;
            bookdatedtp.Location = new Point(216, 313);
            bookdatedtp.Name = "bookdatedtp";
            bookdatedtp.Size = new Size(545, 31);
            bookdatedtp.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(31, 379);
            label4.Name = "label4";
            label4.Size = new Size(110, 25);
            label4.TabIndex = 30;
            label4.Text = "Expire Date";
            // 
            // AssignedControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AssignedControl";
            Size = new Size(1476, 936);
            Load += AssignedControl_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TrainerGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)AssignGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Button resetbtn;
        private Button updatebtn;
        private Button deletebtn;
        private TextBox usernametxt;
        private TextBox traineridtxt;
        private Label label1;
        private TextBox trainernametxt;
        private Label label3;
        private Label label5;
        private Label usernamelbl;
        private Label label6;
        private Label label2;
        private Label label7;
        private TextBox useridtxt;
        private DateTimePicker expiredatedtp;
        private DateTimePicker bookdatedtp;
        private Label label4;
        private DataGridView TrainerGridView;
        private TextBox Trainerprice;
        private Label label8;
        private TextBox trainerpricetxt;
        private Label label9;
        private Label label10;
        private TextBox TrainerNamet;
        private Button insertbtn;
        private DataGridView AssignGridView;
    }
}

namespace Gym_Management
{
    partial class EmployeeForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            DashBoardBtn = new Button();
            SliderDrawerpnl = new Panel();
            FeedbackBtn = new Button();
            MessageBtn = new Button();
            PaymentBtn = new Button();
            WorkoutBtn = new Button();
            ClassSchedulingBtn = new Button();
            ActivityBtn = new Button();
            GroupBtn = new Button();
            StaffBtn = new Button();
            MembershipBtn = new Button();
            NameInfolbl = new Label();
            pictureBox1 = new PictureBox();
            MemberBtn = new Button();
            HeaderPnl = new Panel();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            CenterPnl = new Panel();
            SliderDrawerpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            HeaderPnl.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            CenterPnl.SuspendLayout();
            SuspendLayout();
            // 
            // DashBoardBtn
            // 
            DashBoardBtn.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 20);
            DashBoardBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 87, 34);
            DashBoardBtn.FlatStyle = FlatStyle.Flat;
            DashBoardBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DashBoardBtn.ForeColor = SystemColors.HighlightText;
            DashBoardBtn.Image = (Image)resources.GetObject("DashBoardBtn.Image");
            DashBoardBtn.ImageAlign = ContentAlignment.MiddleLeft;
            DashBoardBtn.Location = new Point(3, 262);
            DashBoardBtn.Name = "DashBoardBtn";
            DashBoardBtn.Size = new Size(270, 52);
            DashBoardBtn.TabIndex = 0;
            DashBoardBtn.Text = "Dashboard";
            DashBoardBtn.UseVisualStyleBackColor = true;
            DashBoardBtn.Click += button1_Click;
            // 
            // SliderDrawerpnl
            // 
            SliderDrawerpnl.BackColor = Color.FromArgb(20, 20, 20);
            SliderDrawerpnl.Controls.Add(FeedbackBtn);
            SliderDrawerpnl.Controls.Add(MessageBtn);
            SliderDrawerpnl.Controls.Add(PaymentBtn);
            SliderDrawerpnl.Controls.Add(WorkoutBtn);
            SliderDrawerpnl.Controls.Add(ClassSchedulingBtn);
            SliderDrawerpnl.Controls.Add(ActivityBtn);
            SliderDrawerpnl.Controls.Add(StaffBtn);
            SliderDrawerpnl.Controls.Add(DashBoardBtn);
            SliderDrawerpnl.Controls.Add(MembershipBtn);
            SliderDrawerpnl.Controls.Add(NameInfolbl);
            SliderDrawerpnl.Controls.Add(pictureBox1);
            SliderDrawerpnl.Controls.Add(MemberBtn);
            SliderDrawerpnl.Dock = DockStyle.Left;
            SliderDrawerpnl.ForeColor = SystemColors.HighlightText;
            SliderDrawerpnl.Location = new Point(0, 0);
            SliderDrawerpnl.Name = "SliderDrawerpnl";
            SliderDrawerpnl.Size = new Size(276, 1050);
            SliderDrawerpnl.TabIndex = 1;
            // 
            // FeedbackBtn
            // 
            FeedbackBtn.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 20);
            FeedbackBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 87, 34);
            FeedbackBtn.FlatStyle = FlatStyle.Flat;
            FeedbackBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FeedbackBtn.Location = new Point(0, 842);
            FeedbackBtn.Name = "FeedbackBtn";
            FeedbackBtn.Size = new Size(273, 52);
            FeedbackBtn.TabIndex = 2;
            FeedbackBtn.Text = "Feedback List";
            FeedbackBtn.UseVisualStyleBackColor = true;
            // 
            // MessageBtn
            // 
            MessageBtn.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 20);
            MessageBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 87, 34);
            MessageBtn.FlatStyle = FlatStyle.Flat;
            MessageBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MessageBtn.Location = new Point(0, 784);
            MessageBtn.Name = "MessageBtn";
            MessageBtn.Size = new Size(273, 52);
            MessageBtn.TabIndex = 2;
            MessageBtn.Text = "Message";
            MessageBtn.UseVisualStyleBackColor = true;
            // 
            // PaymentBtn
            // 
            PaymentBtn.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 20);
            PaymentBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 87, 34);
            PaymentBtn.FlatStyle = FlatStyle.Flat;
            PaymentBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PaymentBtn.Location = new Point(0, 726);
            PaymentBtn.Name = "PaymentBtn";
            PaymentBtn.Size = new Size(273, 52);
            PaymentBtn.TabIndex = 4;
            PaymentBtn.Text = "Payment List";
            PaymentBtn.UseVisualStyleBackColor = true;
            // 
            // WorkoutBtn
            // 
            WorkoutBtn.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 20);
            WorkoutBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 87, 34);
            WorkoutBtn.FlatStyle = FlatStyle.Flat;
            WorkoutBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WorkoutBtn.Location = new Point(0, 668);
            WorkoutBtn.Name = "WorkoutBtn";
            WorkoutBtn.Size = new Size(273, 52);
            WorkoutBtn.TabIndex = 2;
            WorkoutBtn.Text = "Assigned Workout";
            WorkoutBtn.UseVisualStyleBackColor = true;
            // 
            // ClassSchedulingBtn
            // 
            ClassSchedulingBtn.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 20);
            ClassSchedulingBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 87, 34);
            ClassSchedulingBtn.FlatStyle = FlatStyle.Flat;
            ClassSchedulingBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClassSchedulingBtn.Location = new Point(0, 610);
            ClassSchedulingBtn.Name = "ClassSchedulingBtn";
            ClassSchedulingBtn.Size = new Size(273, 52);
            ClassSchedulingBtn.TabIndex = 1;
            ClassSchedulingBtn.Text = "Class Schedule";
            ClassSchedulingBtn.UseVisualStyleBackColor = true;
            // 
            // ActivityBtn
            // 
            ActivityBtn.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 20);
            ActivityBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 87, 34);
            ActivityBtn.FlatStyle = FlatStyle.Flat;
            ActivityBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ActivityBtn.Location = new Point(0, 552);
            ActivityBtn.Name = "ActivityBtn";
            ActivityBtn.Size = new Size(273, 52);
            ActivityBtn.TabIndex = 6;
            ActivityBtn.Text = "Activity";
            ActivityBtn.UseVisualStyleBackColor = true;
            // 
            // GroupBtn
            // 
            GroupBtn.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 20);
            GroupBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 87, 34);
            GroupBtn.FlatStyle = FlatStyle.Flat;
            GroupBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GroupBtn.Location = new Point(149, 115);
            GroupBtn.Name = "GroupBtn";
            GroupBtn.Size = new Size(273, 52);
            GroupBtn.TabIndex = 3;
            GroupBtn.Text = "Group";
            GroupBtn.UseVisualStyleBackColor = true;
            // 
            // StaffBtn
            // 
            StaffBtn.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 20);
            StaffBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 87, 34);
            StaffBtn.FlatStyle = FlatStyle.Flat;
            StaffBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StaffBtn.Location = new Point(0, 485);
            StaffBtn.Name = "StaffBtn";
            StaffBtn.Size = new Size(273, 52);
            StaffBtn.TabIndex = 5;
            StaffBtn.Text = "Staff Member";
            StaffBtn.UseVisualStyleBackColor = true;
            StaffBtn.Click += StaffBtn_Click;
            // 
            // MembershipBtn
            // 
            MembershipBtn.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 20);
            MembershipBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 87, 34);
            MembershipBtn.FlatStyle = FlatStyle.Flat;
            MembershipBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MembershipBtn.Image = (Image)resources.GetObject("MembershipBtn.Image");
            MembershipBtn.ImageAlign = ContentAlignment.MiddleLeft;
            MembershipBtn.Location = new Point(3, 409);
            MembershipBtn.Name = "MembershipBtn";
            MembershipBtn.Size = new Size(270, 53);
            MembershipBtn.TabIndex = 2;
            MembershipBtn.Text = "    Membership Type";
            MembershipBtn.UseVisualStyleBackColor = true;
            MembershipBtn.Click += MembershipBtn_Click;
            // 
            // NameInfolbl
            // 
            NameInfolbl.Font = new Font("Sitka Banner", 14.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameInfolbl.Location = new Point(60, 159);
            NameInfolbl.Name = "NameInfolbl";
            NameInfolbl.Size = new Size(157, 41);
            NameInfolbl.TabIndex = 1;
            NameInfolbl.TextAlign = ContentAlignment.MiddleCenter;
            NameInfolbl.Click += NameInfolbl_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(60, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // MemberBtn
            // 
            MemberBtn.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 20);
            MemberBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 87, 34);
            MemberBtn.FlatStyle = FlatStyle.Flat;
            MemberBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MemberBtn.Image = (Image)resources.GetObject("MemberBtn.Image");
            MemberBtn.ImageAlign = ContentAlignment.MiddleLeft;
            MemberBtn.Location = new Point(6, 337);
            MemberBtn.Name = "MemberBtn";
            MemberBtn.Size = new Size(270, 53);
            MemberBtn.TabIndex = 4;
            MemberBtn.Text = "Member";
            MemberBtn.UseVisualStyleBackColor = false;
            MemberBtn.Click += MemberBtn_Click;
            // 
            // HeaderPnl
            // 
            HeaderPnl.BackColor = Color.FromArgb(20, 20, 20);
            HeaderPnl.Controls.Add(panel1);
            HeaderPnl.Controls.Add(label1);
            HeaderPnl.Controls.Add(pictureBox2);
            HeaderPnl.Dock = DockStyle.Top;
            HeaderPnl.Location = new Point(276, 0);
            HeaderPnl.Name = "HeaderPnl";
            HeaderPnl.Size = new Size(972, 156);
            HeaderPnl.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(422, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 156);
            panel1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(550, 156);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.InactiveBorder;
            label1.Location = new Point(207, -8);
            label1.Name = "label1";
            label1.Size = new Size(215, 164);
            label1.TabIndex = 1;
            label1.Text = "STAMINA\r\nFITNESS";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Black;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(228, 156);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // CenterPnl
            // 
            CenterPnl.BackColor = Color.FromArgb(35, 35, 35);
            CenterPnl.Controls.Add(GroupBtn);
            CenterPnl.Dock = DockStyle.Fill;
            CenterPnl.Location = new Point(276, 156);
            CenterPnl.Name = "CenterPnl";
            CenterPnl.Size = new Size(972, 894);
            CenterPnl.TabIndex = 3;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 1050);
            Controls.Add(CenterPnl);
            Controls.Add(HeaderPnl);
            Controls.Add(SliderDrawerpnl);
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            WindowState = FormWindowState.Maximized;
            Load += EmployeeForm_Load;
            SliderDrawerpnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            HeaderPnl.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            CenterPnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button DashBoardBtn;
        private Panel SliderDrawerpnl;
        private Panel HeaderPnl;
        private Panel CenterPnl;
        private PictureBox pictureBox1;
        private Label NameInfolbl;
        private Label label1;
        private PictureBox pictureBox2;
        private Button StaffBtn;
        private Button MemberBtn;
        private Button GroupBtn;
        private Button MembershipBtn;
        private Button ClassSchedulingBtn;
        private Button ActivityBtn;
        private Button PaymentBtn;
        private Button WorkoutBtn;
        private Button FeedbackBtn;
        private Button MessageBtn;
        private Panel panel1;
        private PictureBox pictureBox3;
    }
}
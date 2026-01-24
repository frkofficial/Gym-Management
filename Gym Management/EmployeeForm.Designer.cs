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
            Logoutbtn = new Button();
            PaymentBtn = new Button();
            WorkoutBtn = new Button();
            MembershipListBtn = new Button();
            MembershipBtn = new Button();
            NameInfolbl = new Label();
            pictureBox1 = new PictureBox();
            MemberBtn = new Button();
            GroupBtn = new Button();
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
            DashBoardBtn.Size = new Size(305, 52);
            DashBoardBtn.TabIndex = 0;
            DashBoardBtn.Text = "     Dashboard";
            DashBoardBtn.UseVisualStyleBackColor = true;
            DashBoardBtn.Click += DashBoardBtn_Click;
            // 
            // SliderDrawerpnl
            // 
            SliderDrawerpnl.BackColor = Color.FromArgb(20, 20, 20);
            SliderDrawerpnl.Controls.Add(Logoutbtn);
            SliderDrawerpnl.Controls.Add(PaymentBtn);
            SliderDrawerpnl.Controls.Add(WorkoutBtn);
            SliderDrawerpnl.Controls.Add(MembershipListBtn);
            SliderDrawerpnl.Controls.Add(DashBoardBtn);
            SliderDrawerpnl.Controls.Add(MembershipBtn);
            SliderDrawerpnl.Controls.Add(NameInfolbl);
            SliderDrawerpnl.Controls.Add(pictureBox1);
            SliderDrawerpnl.Controls.Add(MemberBtn);
            SliderDrawerpnl.Dock = DockStyle.Left;
            SliderDrawerpnl.ForeColor = SystemColors.HighlightText;
            SliderDrawerpnl.Location = new Point(0, 0);
            SliderDrawerpnl.Name = "SliderDrawerpnl";
            SliderDrawerpnl.Size = new Size(314, 1050);
            SliderDrawerpnl.TabIndex = 1;
            // 
            // Logoutbtn
            // 
            Logoutbtn.ForeColor = SystemColors.ActiveCaptionText;
            Logoutbtn.Location = new Point(82, 936);
            Logoutbtn.Name = "Logoutbtn";
            Logoutbtn.Size = new Size(112, 34);
            Logoutbtn.TabIndex = 5;
            Logoutbtn.Text = "Logout";
            Logoutbtn.UseVisualStyleBackColor = true;
            Logoutbtn.Click += Logoutbtn_Click;
            // 
            // PaymentBtn
            // 
            PaymentBtn.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 20);
            PaymentBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 87, 34);
            PaymentBtn.FlatStyle = FlatStyle.Flat;
            PaymentBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PaymentBtn.Image = (Image)resources.GetObject("PaymentBtn.Image");
            PaymentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            PaymentBtn.Location = new Point(3, 645);
            PaymentBtn.Name = "PaymentBtn";
            PaymentBtn.Size = new Size(311, 52);
            PaymentBtn.TabIndex = 4;
            PaymentBtn.Text = "    Payment List";
            PaymentBtn.UseVisualStyleBackColor = true;
            PaymentBtn.Click += PaymentBtn_Click;
            // 
            // WorkoutBtn
            // 
            WorkoutBtn.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 20);
            WorkoutBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 87, 34);
            WorkoutBtn.FlatStyle = FlatStyle.Flat;
            WorkoutBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WorkoutBtn.Image = (Image)resources.GetObject("WorkoutBtn.Image");
            WorkoutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            WorkoutBtn.Location = new Point(6, 564);
            WorkoutBtn.Name = "WorkoutBtn";
            WorkoutBtn.Size = new Size(311, 52);
            WorkoutBtn.TabIndex = 2;
            WorkoutBtn.Text = "     Assigned Workout";
            WorkoutBtn.UseVisualStyleBackColor = true;
            WorkoutBtn.Click += WorkoutBtn_Click;
            // 
            // MembershipListBtn
            // 
            MembershipListBtn.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 20);
            MembershipListBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 87, 34);
            MembershipListBtn.FlatStyle = FlatStyle.Flat;
            MembershipListBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MembershipListBtn.Image = (Image)resources.GetObject("MembershipListBtn.Image");
            MembershipListBtn.ImageAlign = ContentAlignment.MiddleLeft;
            MembershipListBtn.Location = new Point(6, 483);
            MembershipListBtn.Name = "MembershipListBtn";
            MembershipListBtn.Size = new Size(308, 52);
            MembershipListBtn.TabIndex = 1;
            MembershipListBtn.Text = "    Membership List";
            MembershipListBtn.UseVisualStyleBackColor = true;
            MembershipListBtn.Click += MembershipListBtn_Click;
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
            MembershipBtn.Size = new Size(311, 53);
            MembershipBtn.TabIndex = 2;
            MembershipBtn.Text = "     Membership Type";
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
            pictureBox1.Location = new Point(73, 30);
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
            MemberBtn.Size = new Size(305, 53);
            MemberBtn.TabIndex = 4;
            MemberBtn.Text = "   Member";
            MemberBtn.UseVisualStyleBackColor = false;
            MemberBtn.Click += MemberBtn_Click;
            // 
            // GroupBtn
            // 
            GroupBtn.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 20);
            GroupBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 87, 34);
            GroupBtn.FlatStyle = FlatStyle.Flat;
            GroupBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GroupBtn.Location = new Point(6, 58);
            GroupBtn.Name = "GroupBtn";
            GroupBtn.Size = new Size(273, 53);
            GroupBtn.TabIndex = 3;
            GroupBtn.Text = "Group";
            GroupBtn.UseVisualStyleBackColor = true;
            GroupBtn.Click += GroupBtn_Click;
            // 
            // HeaderPnl
            // 
            HeaderPnl.BackColor = Color.FromArgb(20, 20, 20);
            HeaderPnl.Controls.Add(panel1);
            HeaderPnl.Controls.Add(label1);
            HeaderPnl.Controls.Add(pictureBox2);
            HeaderPnl.Dock = DockStyle.Top;
            HeaderPnl.Location = new Point(314, 0);
            HeaderPnl.Name = "HeaderPnl";
            HeaderPnl.Size = new Size(1610, 120);
            HeaderPnl.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(422, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1188, 119);
            panel1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1205, 120);
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
            label1.Size = new Size(215, 128);
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
            pictureBox2.Size = new Size(228, 120);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // CenterPnl
            // 
            CenterPnl.BackColor = Color.FromArgb(35, 35, 35);
            CenterPnl.Controls.Add(GroupBtn);
            CenterPnl.Dock = DockStyle.Fill;
            CenterPnl.Location = new Point(314, 120);
            CenterPnl.Name = "CenterPnl";
            CenterPnl.Size = new Size(1610, 930);
            CenterPnl.TabIndex = 3;
            CenterPnl.Paint += CenterPnl_Paint;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1050);
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
        private Button MemberBtn;
        private Button GroupBtn;
        private Button MembershipBtn;
        private Button MembershipListBtn;
        private Button PaymentBtn;
        private Button WorkoutBtn;
        private Panel panel1;
        private PictureBox pictureBox3;
        private Button Logoutbtn;
    }
}
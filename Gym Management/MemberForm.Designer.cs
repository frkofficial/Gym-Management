namespace Gym_Management
{
    partial class MemberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberForm));
            panel1 = new Panel();
            panelMain = new Panel();
            btnMyProfile = new Button();
            btnmembershipPrice = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel2 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Location = new Point(59, 40);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(192, 228);
            panel1.TabIndex = 0;
            // 
            // panelMain
            // 
            panelMain.Location = new Point(310, 4);
            panelMain.Margin = new Padding(3, 4, 3, 4);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1239, 969);
            panelMain.TabIndex = 1;
            panelMain.Paint += panelMain_Paint;
            // 
            // btnMyProfile
            // 
            btnMyProfile.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMyProfile.Location = new Point(19, 336);
            btnMyProfile.Margin = new Padding(3, 4, 3, 4);
            btnMyProfile.Name = "btnMyProfile";
            btnMyProfile.Size = new Size(283, 49);
            btnMyProfile.TabIndex = 2;
            btnMyProfile.Text = "My Profile";
            btnMyProfile.UseVisualStyleBackColor = true;
            btnMyProfile.Click += button1_Click;
            // 
            // btnmembershipPrice
            // 
            btnmembershipPrice.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnmembershipPrice.Location = new Point(19, 420);
            btnmembershipPrice.Margin = new Padding(3, 4, 3, 4);
            btnmembershipPrice.Name = "btnmembershipPrice";
            btnmembershipPrice.Size = new Size(283, 48);
            btnmembershipPrice.TabIndex = 3;
            btnmembershipPrice.Text = "Membership Pricing";
            btnmembershipPrice.UseVisualStyleBackColor = true;
            btnmembershipPrice.Click += btnmembershipPrice_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(19, 501);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(283, 48);
            button3.TabIndex = 4;
            button3.Text = "Payment";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(19, 595);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(283, 45);
            button4.TabIndex = 5;
            button4.Text = "Print";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(103, 733);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(86, 44);
            button5.TabIndex = 6;
            button5.Text = "Logout";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(button5);
            panel2.Controls.Add(panelMain);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(btnMyProfile);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(btnmembershipPrice);
            panel2.Location = new Point(5, 5);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1549, 977);
            panel2.TabIndex = 7;
            // 
            // MemberForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1567, 999);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "MemberForm";
            Text = "MemberForm";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelMain;
        private Button btnMyProfile;
        private Button btnmembershipPrice;
        private Button button3;
        private Button button4;
        private Button button5;
        private Panel panel2;
    }
}
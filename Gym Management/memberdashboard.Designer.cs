namespace Gym_Management
{
    partial class memberdashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(memberdashboard));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(327, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 563);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 3);
            label1.Name = "label1";
            label1.Size = new Size(321, 38);
            label1.TabIndex = 1;
            label1.Text = "MEMBER DASHBOARD";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Location = new Point(64, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(170, 170);
            panel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(0, 265);
            button1.Name = "button1";
            button1.Size = new Size(328, 41);
            button1.TabIndex = 3;
            button1.Text = "My Profile";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(0, 312);
            button2.Name = "button2";
            button2.Size = new Size(328, 41);
            button2.TabIndex = 4;
            button2.Text = "Membership Pricing";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(0, 359);
            button3.Name = "button3";
            button3.Size = new Size(328, 36);
            button3.TabIndex = 5;
            button3.Text = "Slot Booking";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(0, 401);
            button4.Name = "button4";
            button4.Size = new Size(328, 39);
            button4.TabIndex = 6;
            button4.Text = "Payment";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(0, 446);
            button5.Name = "button5";
            button5.Size = new Size(328, 37);
            button5.TabIndex = 7;
            button5.Text = "Print";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(115, 498);
            button6.Name = "button6";
            button6.Size = new Size(89, 41);
            button6.TabIndex = 8;
            button6.Text = "Logout";
            button6.UseVisualStyleBackColor = true;
            // 
            // memberdashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "memberdashboard";
            Text = "Member Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
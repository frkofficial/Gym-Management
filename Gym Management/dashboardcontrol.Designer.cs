namespace Gym_Management
{
    partial class dashboardcontrol
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
            button1 = new Button();
            lblTotalCustomers = new Label();
            button2 = new Button();
            button3 = new Button();
            lblTotalEmployee = new Label();
            lblTotalAdmin = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(93, 76);
            button1.Name = "button1";
            button1.Size = new Size(203, 100);
            button1.TabIndex = 0;
            button1.Text = "Total Customer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblTotalCustomers
            // 
            lblTotalCustomers.BackColor = SystemColors.ActiveCaption;
            lblTotalCustomers.ForeColor = SystemColors.Control;
            lblTotalCustomers.Location = new Point(322, 76);
            lblTotalCustomers.Name = "lblTotalCustomers";
            lblTotalCustomers.Size = new Size(156, 100);
            lblTotalCustomers.TabIndex = 1;
            lblTotalCustomers.Text = "0";
            lblTotalCustomers.TextAlign = ContentAlignment.MiddleCenter;
            lblTotalCustomers.Click += label1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(93, 215);
            button2.Name = "button2";
            button2.Size = new Size(203, 100);
            button2.TabIndex = 2;
            button2.Text = "Total Employee";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(93, 365);
            button3.Name = "button3";
            button3.Size = new Size(203, 100);
            button3.TabIndex = 3;
            button3.Text = "Total Admin";
            button3.UseVisualStyleBackColor = true;
            // 
            // lblTotalEmployee
            // 
            lblTotalEmployee.BackColor = SystemColors.ActiveCaption;
            lblTotalEmployee.ForeColor = SystemColors.Control;
            lblTotalEmployee.Location = new Point(322, 218);
            lblTotalEmployee.Name = "lblTotalEmployee";
            lblTotalEmployee.Size = new Size(156, 100);
            lblTotalEmployee.TabIndex = 4;
            lblTotalEmployee.Text = "0";
            lblTotalEmployee.TextAlign = ContentAlignment.MiddleCenter;
            lblTotalEmployee.Click += label1_Click_1;
            // 
            // lblTotalAdmin
            // 
            lblTotalAdmin.BackColor = SystemColors.ActiveCaption;
            lblTotalAdmin.ForeColor = SystemColors.Control;
            lblTotalAdmin.Location = new Point(322, 368);
            lblTotalAdmin.Name = "lblTotalAdmin";
            lblTotalAdmin.Size = new Size(156, 100);
            lblTotalAdmin.TabIndex = 5;
            lblTotalAdmin.Text = "0";
            lblTotalAdmin.TextAlign = ContentAlignment.MiddleCenter;
            lblTotalAdmin.Click += lblTotalAdmin_Click;
            // 
            // dashboardcontrol
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTotalAdmin);
            Controls.Add(lblTotalEmployee);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(lblTotalCustomers);
            Controls.Add(button1);
            Name = "dashboardcontrol";
            Size = new Size(766, 549);
            Load += dashboardcontrol_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label lblTotalCustomers;
        private Button button2;
        private Button button3;
        private Label lblTotalEmployee;
        private Label lblTotalAdmin;
    }
}

namespace Gym_Management
{
    partial class AdminForm
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
            dashboardbutton = new Button();
            EmployeeListbutton = new Button();
            Packagesbutton = new Button();
            CustomerListbutton = new Button();
            Logoutbutton = new Button();
            adminListbutton = new Button();
            contentpannel = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dashboardbutton
            // 
            dashboardbutton.BackColor = SystemColors.Control;
            dashboardbutton.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboardbutton.Location = new Point(2, 85);
            dashboardbutton.Margin = new Padding(2);
            dashboardbutton.Name = "dashboardbutton";
            dashboardbutton.Size = new Size(173, 43);
            dashboardbutton.TabIndex = 0;
            dashboardbutton.Text = "DashBoard";
            dashboardbutton.UseVisualStyleBackColor = false;
            dashboardbutton.Click += dashboardbutton_Click;
            // 
            // EmployeeListbutton
            // 
            EmployeeListbutton.BackColor = SystemColors.Control;
            EmployeeListbutton.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmployeeListbutton.Location = new Point(2, 224);
            EmployeeListbutton.Margin = new Padding(2);
            EmployeeListbutton.Name = "EmployeeListbutton";
            EmployeeListbutton.Size = new Size(173, 43);
            EmployeeListbutton.TabIndex = 1;
            EmployeeListbutton.Text = "Employee List";
            EmployeeListbutton.UseVisualStyleBackColor = false;
            EmployeeListbutton.Click += EmployeeListbutton_Click;
            // 
            // Packagesbutton
            // 
            Packagesbutton.BackColor = SystemColors.Control;
            Packagesbutton.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Packagesbutton.Location = new Point(2, 454);
            Packagesbutton.Margin = new Padding(2);
            Packagesbutton.Name = "Packagesbutton";
            Packagesbutton.Size = new Size(173, 43);
            Packagesbutton.TabIndex = 2;
            Packagesbutton.Text = "Packages ";
            Packagesbutton.UseVisualStyleBackColor = false;
            Packagesbutton.Click += Packagesbutton_Click;
            // 
            // CustomerListbutton
            // 
            CustomerListbutton.BackColor = SystemColors.Control;
            CustomerListbutton.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomerListbutton.Location = new Point(2, 379);
            CustomerListbutton.Margin = new Padding(2);
            CustomerListbutton.Name = "CustomerListbutton";
            CustomerListbutton.Size = new Size(173, 43);
            CustomerListbutton.TabIndex = 3;
            CustomerListbutton.Text = "Customer List";
            CustomerListbutton.UseVisualStyleBackColor = false;
            CustomerListbutton.Click += CustomerListbutton_Click_1;
            // 
            // Logoutbutton
            // 
            Logoutbutton.BackColor = SystemColors.Control;
            Logoutbutton.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Logoutbutton.Location = new Point(0, 520);
            Logoutbutton.Margin = new Padding(2);
            Logoutbutton.Name = "Logoutbutton";
            Logoutbutton.Size = new Size(173, 43);
            Logoutbutton.TabIndex = 5;
            Logoutbutton.Text = "Logout";
            Logoutbutton.UseVisualStyleBackColor = false;
            Logoutbutton.Click += Logoutbutton_Click;
            // 
            // adminListbutton
            // 
            adminListbutton.BackColor = SystemColors.Control;
            adminListbutton.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminListbutton.Location = new Point(2, 149);
            adminListbutton.Margin = new Padding(2);
            adminListbutton.Name = "adminListbutton";
            adminListbutton.Size = new Size(173, 43);
            adminListbutton.TabIndex = 6;
            adminListbutton.Text = "Admin List";
            adminListbutton.UseVisualStyleBackColor = false;
            adminListbutton.Click += adminListbutton_Click;
            // 
            // contentpannel
            // 
            contentpannel.BackColor = Color.White;
            contentpannel.ForeColor = SystemColors.ControlLight;
            contentpannel.Location = new Point(189, 7);
            contentpannel.Name = "contentpannel";
            contentpannel.Size = new Size(983, 668);
            contentpannel.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(Logoutbutton);
            panel2.Controls.Add(dashboardbutton);
            panel2.Controls.Add(EmployeeListbutton);
            panel2.Controls.Add(Packagesbutton);
            panel2.Controls.Add(CustomerListbutton);
            panel2.Controls.Add(adminListbutton);
            panel2.Location = new Point(3, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(181, 668);
            panel2.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(2, 310);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(173, 43);
            button1.TabIndex = 7;
            button1.Text = "Trainer List";
            button1.UseVisualStyleBackColor = false;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 687);
            Controls.Add(panel2);
            Controls.Add(contentpannel);
            Margin = new Padding(2);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button dashboardbutton;
        private Button EmployeeListbutton;
        private Button Packagesbutton;
        private Button CustomerListbutton;
        private Button Logoutbutton;
        private Button adminListbutton;
        private Panel contentpannel;
        private Panel panel2;
        private Button button1;
    }
}
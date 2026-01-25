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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            dashboardbutton = new Button();
            EmployeeListbutton = new Button();
            Packagesbutton = new Button();
            CustomerListbutton = new Button();
            Logoutbutton = new Button();
            adminListbutton = new Button();
            contentpannel = new Panel();
            panel2 = new Panel();
            btntrainerlist = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dashboardbutton
            // 
            dashboardbutton.BackColor = SystemColors.Control;
            dashboardbutton.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboardbutton.Location = new Point(2, 106);
            dashboardbutton.Margin = new Padding(2);
            dashboardbutton.Name = "dashboardbutton";
            dashboardbutton.Size = new Size(216, 54);
            dashboardbutton.TabIndex = 0;
            dashboardbutton.Text = "DashBoard";
            dashboardbutton.UseVisualStyleBackColor = false;
            dashboardbutton.Click += dashboardbutton_Click;
            // 
            // EmployeeListbutton
            // 
            EmployeeListbutton.BackColor = SystemColors.Control;
            EmployeeListbutton.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmployeeListbutton.Location = new Point(2, 280);
            EmployeeListbutton.Margin = new Padding(2);
            EmployeeListbutton.Name = "EmployeeListbutton";
            EmployeeListbutton.Size = new Size(216, 54);
            EmployeeListbutton.TabIndex = 1;
            EmployeeListbutton.Text = "Employee List";
            EmployeeListbutton.UseVisualStyleBackColor = false;
            EmployeeListbutton.Click += EmployeeListbutton_Click;
            // 
            // Packagesbutton
            // 
            Packagesbutton.BackColor = SystemColors.Control;
            Packagesbutton.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Packagesbutton.Location = new Point(2, 568);
            Packagesbutton.Margin = new Padding(2);
            Packagesbutton.Name = "Packagesbutton";
            Packagesbutton.Size = new Size(216, 54);
            Packagesbutton.TabIndex = 2;
            Packagesbutton.Text = "Packages ";
            Packagesbutton.UseVisualStyleBackColor = false;
            Packagesbutton.Click += Packagesbutton_Click;
            // 
            // CustomerListbutton
            // 
            CustomerListbutton.BackColor = SystemColors.Control;
            CustomerListbutton.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomerListbutton.Location = new Point(2, 474);
            CustomerListbutton.Margin = new Padding(2);
            CustomerListbutton.Name = "CustomerListbutton";
            CustomerListbutton.Size = new Size(216, 54);
            CustomerListbutton.TabIndex = 3;
            CustomerListbutton.Text = "Customer List";
            CustomerListbutton.UseVisualStyleBackColor = false;
            CustomerListbutton.Click += CustomerListbutton_Click_1;
            // 
            // Logoutbutton
            // 
            Logoutbutton.BackColor = SystemColors.Control;
            Logoutbutton.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Logoutbutton.Location = new Point(0, 650);
            Logoutbutton.Margin = new Padding(2);
            Logoutbutton.Name = "Logoutbutton";
            Logoutbutton.Size = new Size(216, 54);
            Logoutbutton.TabIndex = 5;
            Logoutbutton.Text = "Logout";
            Logoutbutton.UseVisualStyleBackColor = false;
            Logoutbutton.Click += Logoutbutton_Click;
            // 
            // adminListbutton
            // 
            adminListbutton.BackColor = SystemColors.Control;
            adminListbutton.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminListbutton.Location = new Point(2, 186);
            adminListbutton.Margin = new Padding(2);
            adminListbutton.Name = "adminListbutton";
            adminListbutton.Size = new Size(216, 54);
            adminListbutton.TabIndex = 6;
            adminListbutton.Text = "Admin List";
            adminListbutton.UseVisualStyleBackColor = false;
            adminListbutton.Click += adminListbutton_Click;
            // 
            // contentpannel
            // 
            contentpannel.BackColor = Color.White;
            contentpannel.ForeColor = SystemColors.ControlLight;
            contentpannel.Location = new Point(236, 9);
            contentpannel.Margin = new Padding(4, 4, 4, 4);
            contentpannel.Name = "contentpannel";
            contentpannel.Size = new Size(1229, 835);
            contentpannel.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(btntrainerlist);
            panel2.Controls.Add(Logoutbutton);
            panel2.Controls.Add(dashboardbutton);
            panel2.Controls.Add(EmployeeListbutton);
            panel2.Controls.Add(Packagesbutton);
            panel2.Controls.Add(CustomerListbutton);
            panel2.Controls.Add(adminListbutton);
            panel2.Location = new Point(4, 9);
            panel2.Margin = new Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(226, 835);
            panel2.TabIndex = 8;
            // 
            // btntrainerlist
            // 
            btntrainerlist.BackColor = SystemColors.Control;
            btntrainerlist.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btntrainerlist.Location = new Point(2, 388);
            btntrainerlist.Margin = new Padding(2);
            btntrainerlist.Name = "btntrainerlist";
            btntrainerlist.Size = new Size(216, 54);
            btntrainerlist.TabIndex = 7;
            btntrainerlist.Text = "Trainer List";
            btntrainerlist.UseVisualStyleBackColor = false;
            btntrainerlist.Click += button1_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1480, 859);
            Controls.Add(panel2);
            Controls.Add(contentpannel);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private Button btntrainerlist;
    }
}
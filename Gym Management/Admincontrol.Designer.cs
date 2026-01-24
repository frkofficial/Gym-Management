namespace Gym_Management
{
    partial class Admincontrol
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnInsertAdmin1_Click = new Button();
            dataGridViewadmin = new DataGridView();
            panel1 = new Panel();
            label5 = new Label();
            txtLastName = new TextBox();
            adminFirstName = new TextBox();
            label4 = new Label();
            btnDeleteAdmin = new Button();
            txtPhone = new TextBox();
            txtAdminName = new TextBox();
            txtRank = new TextBox();
            AdminUserName = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxId = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewadmin).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnInsertAdmin1_Click
            // 
            btnInsertAdmin1_Click.BackColor = SystemColors.ActiveCaption;
            btnInsertAdmin1_Click.ForeColor = SystemColors.InfoText;
            btnInsertAdmin1_Click.Location = new Point(19, 236);
            btnInsertAdmin1_Click.Name = "btnInsertAdmin1_Click";
            btnInsertAdmin1_Click.Size = new Size(163, 48);
            btnInsertAdmin1_Click.TabIndex = 0;
            btnInsertAdmin1_Click.Text = "Insert";
            btnInsertAdmin1_Click.UseVisualStyleBackColor = false;
            btnInsertAdmin1_Click.Click += btnInsertAdmin1_Click_Click;
            // 
            // dataGridViewadmin
            // 
            dataGridViewadmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewadmin.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewadmin.Location = new Point(85, 15);
            dataGridViewadmin.Name = "dataGridViewadmin";
            dataGridViewadmin.RowHeadersWidth = 51;
            dataGridViewadmin.Size = new Size(856, 257);
            dataGridViewadmin.TabIndex = 1;
            dataGridViewadmin.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(adminFirstName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnDeleteAdmin);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(txtAdminName);
            panel1.Controls.Add(txtRank);
            panel1.Controls.Add(AdminUserName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxId);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnInsertAdmin1_Click);
            panel1.Location = new Point(84, 288);
            panel1.Name = "panel1";
            panel1.Size = new Size(857, 299);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(273, 101);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 13;
            label5.Text = "Last Name :";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(375, 94);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(119, 27);
            txtLastName.TabIndex = 12;
            // 
            // adminFirstName
            // 
            adminFirstName.Location = new Point(141, 175);
            adminFirstName.Name = "adminFirstName";
            adminFirstName.Size = new Size(119, 27);
            adminFirstName.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 178);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 10;
            label4.Text = "First Name :";
            // 
            // btnDeleteAdmin
            // 
            btnDeleteAdmin.BackColor = SystemColors.ActiveCaption;
            btnDeleteAdmin.ForeColor = SystemColors.InfoText;
            btnDeleteAdmin.Location = new Point(341, 236);
            btnDeleteAdmin.Name = "btnDeleteAdmin";
            btnDeleteAdmin.Size = new Size(163, 48);
            btnDeleteAdmin.TabIndex = 9;
            btnDeleteAdmin.Text = "Delete";
            btnDeleteAdmin.UseVisualStyleBackColor = false;
            btnDeleteAdmin.Click += btnDeleteAdmin_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(597, 41);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(119, 27);
            txtPhone.TabIndex = 8;
            // 
            // txtAdminName
            // 
            txtAdminName.Location = new Point(129, 98);
            txtAdminName.Name = "txtAdminName";
            txtAdminName.Size = new Size(119, 27);
            txtAdminName.TabIndex = 7;
            // 
            // txtRank
            // 
            txtRank.Location = new Point(375, 41);
            txtRank.Name = "txtRank";
            txtRank.Size = new Size(119, 27);
            txtRank.TabIndex = 6;
            // 
            // AdminUserName
            // 
            AdminUserName.AutoSize = true;
            AdminUserName.Location = new Point(19, 101);
            AdminUserName.Name = "AdminUserName";
            AdminUserName.Size = new Size(104, 20);
            AdminUserName.TabIndex = 5;
            AdminUserName.Text = "Admin Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(530, 48);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 4;
            label3.Text = "Phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(297, 41);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 3;
            label2.Text = "Rank";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(98, 34);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(100, 27);
            textBoxId.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 33);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 1;
            label1.Text = "AdminId";
            // 
            // Admincontrol
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(dataGridViewadmin);
            Name = "Admincontrol";
            Size = new Size(1230, 624);
            Load += Admincontrol_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewadmin).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnInsertAdmin1_Click;
        private DataGridView dataGridViewadmin;
        private Panel panel1;
        private TextBox txtPhone;
        private TextBox txtAdminName;
        private TextBox txtRank;
        private Label AdminUserName;
        private Label label3;
        private Label label2;
        private TextBox textBoxId;
        private Label label1;
        private Button btnDeleteAdmin;
        private TextBox adminFirstName;
        private Label label4;
        private Label label5;
        private TextBox txtLastName;
    }
}

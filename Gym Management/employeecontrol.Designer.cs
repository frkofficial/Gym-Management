namespace Gym_Management
{
    partial class employeecontrol
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            buttonInsertbtnInsertEmployee_Click = new Button();
            dataGridViewemployee = new DataGridView();
            employeepannel2 = new Panel();
            textBoxUserT = new TextBox();
            label8 = new Label();
            textBoxLname = new TextBox();
            label7 = new Label();
            textBoxEpass = new TextBox();
            label6 = new Label();
            textBoxfname = new TextBox();
            label5 = new Label();
            btnemployeedlt = new Button();
            txtEmpPhone = new TextBox();
            txtEmpJob = new TextBox();
            txtEmpName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtEmpId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewemployee).BeginInit();
            employeepannel2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonInsertbtnInsertEmployee_Click
            // 
            buttonInsertbtnInsertEmployee_Click.Location = new Point(45, 330);
            buttonInsertbtnInsertEmployee_Click.Name = "buttonInsertbtnInsertEmployee_Click";
            buttonInsertbtnInsertEmployee_Click.Size = new Size(138, 53);
            buttonInsertbtnInsertEmployee_Click.TabIndex = 0;
            buttonInsertbtnInsertEmployee_Click.Text = "Insert";
            buttonInsertbtnInsertEmployee_Click.UseVisualStyleBackColor = true;
            buttonInsertbtnInsertEmployee_Click.Click += btnInsertEmployee_Click;
            // 
            // dataGridViewemployee
            // 
            dataGridViewemployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewemployee.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewemployee.BackgroundColor = Color.DimGray;
            dataGridViewemployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewemployee.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewemployee.GridColor = SystemColors.ControlLightLight;
            dataGridViewemployee.Location = new Point(34, 11);
            dataGridViewemployee.Name = "dataGridViewemployee";
            dataGridViewemployee.ReadOnly = true;
            dataGridViewemployee.RowHeadersWidth = 51;
            dataGridViewemployee.Size = new Size(1028, 230);
            dataGridViewemployee.TabIndex = 1;
            // 
            // employeepannel2
            // 
            employeepannel2.BackColor = Color.FromArgb(20, 20, 20);
            employeepannel2.Controls.Add(textBoxUserT);
            employeepannel2.Controls.Add(label8);
            employeepannel2.Controls.Add(textBoxLname);
            employeepannel2.Controls.Add(label7);
            employeepannel2.Controls.Add(textBoxEpass);
            employeepannel2.Controls.Add(label6);
            employeepannel2.Controls.Add(textBoxfname);
            employeepannel2.Controls.Add(label5);
            employeepannel2.Controls.Add(btnemployeedlt);
            employeepannel2.Controls.Add(txtEmpPhone);
            employeepannel2.Controls.Add(txtEmpJob);
            employeepannel2.Controls.Add(buttonInsertbtnInsertEmployee_Click);
            employeepannel2.Controls.Add(txtEmpName);
            employeepannel2.Controls.Add(label4);
            employeepannel2.Controls.Add(label3);
            employeepannel2.Controls.Add(label2);
            employeepannel2.Controls.Add(label1);
            employeepannel2.Controls.Add(txtEmpId);
            employeepannel2.Location = new Point(23, 247);
            employeepannel2.Name = "employeepannel2";
            employeepannel2.Size = new Size(1039, 448);
            employeepannel2.TabIndex = 2;
            // 
            // textBoxUserT
            // 
            textBoxUserT.Location = new Point(395, 223);
            textBoxUserT.Name = "textBoxUserT";
            textBoxUserT.Size = new Size(140, 27);
            textBoxUserT.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(288, 223);
            label8.Name = "label8";
            label8.Size = new Size(110, 28);
            label8.TabIndex = 15;
            label8.Text = "UserType :";
            // 
            // textBoxLname
            // 
            textBoxLname.Location = new Point(117, 223);
            textBoxLname.Name = "textBoxLname";
            textBoxLname.Size = new Size(140, 27);
            textBoxLname.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(15, 223);
            label7.Name = "label7";
            label7.Size = new Size(89, 28);
            label7.TabIndex = 13;
            label7.Text = "LName :";
            // 
            // textBoxEpass
            // 
            textBoxEpass.Location = new Point(395, 165);
            textBoxEpass.Name = "textBoxEpass";
            textBoxEpass.Size = new Size(140, 27);
            textBoxEpass.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(288, 161);
            label6.Name = "label6";
            label6.Size = new Size(93, 28);
            label6.TabIndex = 11;
            label6.Text = "EmPass :";
            // 
            // textBoxfname
            // 
            textBoxfname.Location = new Point(118, 165);
            textBoxfname.Name = "textBoxfname";
            textBoxfname.Size = new Size(140, 27);
            textBoxfname.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(15, 165);
            label5.Name = "label5";
            label5.Size = new Size(85, 28);
            label5.TabIndex = 9;
            label5.Text = "Fname :";
            // 
            // btnemployeedlt
            // 
            btnemployeedlt.Location = new Point(375, 330);
            btnemployeedlt.Name = "btnemployeedlt";
            btnemployeedlt.Size = new Size(138, 53);
            btnemployeedlt.TabIndex = 8;
            btnemployeedlt.Text = "Delete";
            btnemployeedlt.UseVisualStyleBackColor = true;
            btnemployeedlt.Click += btnemployeedlt_Click;
            // 
            // txtEmpPhone
            // 
            txtEmpPhone.Location = new Point(393, 110);
            txtEmpPhone.Name = "txtEmpPhone";
            txtEmpPhone.Size = new Size(140, 27);
            txtEmpPhone.TabIndex = 7;
            // 
            // txtEmpJob
            // 
            txtEmpJob.Location = new Point(117, 107);
            txtEmpJob.Name = "txtEmpJob";
            txtEmpJob.Size = new Size(140, 27);
            txtEmpJob.TabIndex = 6;
            // 
            // txtEmpName
            // 
            txtEmpName.Location = new Point(393, 38);
            txtEmpName.Name = "txtEmpName";
            txtEmpName.Size = new Size(140, 27);
            txtEmpName.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(288, 106);
            label4.Name = "label4";
            label4.Size = new Size(82, 28);
            label4.TabIndex = 4;
            label4.Text = "Phone :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(14, 103);
            label3.Name = "label3";
            label3.Size = new Size(97, 28);
            label3.TabIndex = 3;
            label3.Text = "EmpJob :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(267, 34);
            label2.Name = "label2";
            label2.Size = new Size(120, 28);
            label2.TabIndex = 2;
            label2.Text = "EmpName :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(15, 34);
            label1.Name = "label1";
            label1.Size = new Size(82, 28);
            label1.TabIndex = 1;
            label1.Text = "EmpId :";
            // 
            // txtEmpId
            // 
            txtEmpId.Location = new Point(103, 34);
            txtEmpId.Name = "txtEmpId";
            txtEmpId.Size = new Size(140, 27);
            txtEmpId.TabIndex = 0;
            // 
            // employeecontrol
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(employeepannel2);
            Controls.Add(dataGridViewemployee);
            Name = "employeecontrol";
            Size = new Size(1227, 682);
            Load += employeecontrol_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewemployee).EndInit();
            employeepannel2.ResumeLayout(false);
            employeepannel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonInsertbtnInsertEmployee_Click;
        private DataGridView dataGridViewemployee;
        private Panel employeepannel2;
        private Label label1;
        private TextBox txtEmpId;
        private TextBox txtEmpPhone;
        private TextBox txtEmpJob;
        private TextBox txtEmpName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnemployeedlt;
        private TextBox textBoxUserT;
        private Label label8;
        private TextBox textBoxLname;
        private Label label7;
        private TextBox textBoxEpass;
        private Label label6;
        private TextBox textBoxfname;
        private Label label5;
    }
}

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
            button1 = new Button();
            dataGridViewadmin = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            textBoxId = new TextBox();
            label2 = new Label();
            label3 = new Label();
            AdminUserName = new Label();
            textBoxRank = new TextBox();
            textBoxName = new TextBox();
            textBoxPhone = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewadmin).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.ForeColor = SystemColors.InfoText;
            button1.Location = new Point(58, 155);
            button1.Name = "button1";
            button1.Size = new Size(163, 48);
            button1.TabIndex = 0;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridViewadmin
            // 
            dataGridViewadmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewadmin.Location = new Point(85, 15);
            dataGridViewadmin.Name = "dataGridViewadmin";
            dataGridViewadmin.RowHeadersWidth = 51;
            dataGridViewadmin.Size = new Size(856, 257);
            dataGridViewadmin.TabIndex = 1;
            dataGridViewadmin.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(textBoxPhone);
            panel1.Controls.Add(textBoxName);
            panel1.Controls.Add(textBoxRank);
            panel1.Controls.Add(AdminUserName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxId);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(84, 288);
            panel1.Name = "panel1";
            panel1.Size = new Size(857, 222);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
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
            // textBoxId
            // 
            textBoxId.Location = new Point(98, 34);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(100, 27);
            textBoxId.TabIndex = 2;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(297, 101);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 4;
            label3.Text = "Phone";
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
            // textBoxRank
            // 
            textBoxRank.Location = new Point(375, 41);
            textBoxRank.Name = "textBoxRank";
            textBoxRank.Size = new Size(119, 27);
            textBoxRank.TabIndex = 6;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(129, 98);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(119, 27);
            textBoxName.TabIndex = 7;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(375, 98);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(119, 27);
            textBoxPhone.TabIndex = 8;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.ForeColor = SystemColors.InfoText;
            button2.Location = new Point(331, 155);
            button2.Name = "button2";
            button2.Size = new Size(163, 48);
            button2.TabIndex = 9;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            // 
            // Admincontrol
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(dataGridViewadmin);
            Name = "Admincontrol";
            Size = new Size(1230, 534);
            Load += Admincontrol_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewadmin).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dataGridViewadmin;
        private Panel panel1;
        private TextBox textBoxPhone;
        private TextBox textBoxName;
        private TextBox textBoxRank;
        private Label AdminUserName;
        private Label label3;
        private Label label2;
        private TextBox textBoxId;
        private Label label1;
        private Button button2;
    }
}

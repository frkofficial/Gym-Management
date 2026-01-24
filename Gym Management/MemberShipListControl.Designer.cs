namespace Gym_Management
{
    partial class MemberShipListControl
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
            MembershipGridView = new DataGridView();
            expiredatedtp = new DateTimePicker();
            label4 = new Label();
            usernametxt = new TextBox();
            bookdatedtp = new DateTimePicker();
            useridtxt = new TextBox();
            label2 = new Label();
            userlbl = new Label();
            label3 = new Label();
            label1 = new Label();
            pcknametxt = new TextBox();
            pricetxt = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            resetbtn = new Button();
            updatebtn = new Button();
            deletebtn = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)MembershipGridView).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // MembershipGridView
            // 
            MembershipGridView.BackgroundColor = Color.FromArgb(20, 20, 20);
            MembershipGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MembershipGridView.Location = new Point(38, 17);
            MembershipGridView.Name = "MembershipGridView";
            MembershipGridView.RowHeadersWidth = 62;
            MembershipGridView.Size = new Size(1085, 282);
            MembershipGridView.TabIndex = 0;
            MembershipGridView.CellClick += MembershipGridView_CellClick;
            MembershipGridView.CellContentClick += MembershipGridView_CellContentClick;
            // 
            // expiredatedtp
            // 
            expiredatedtp.Format = DateTimePickerFormat.Short;
            expiredatedtp.Location = new Point(344, 322);
            expiredatedtp.Name = "expiredatedtp";
            expiredatedtp.Size = new Size(545, 31);
            expiredatedtp.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(159, 327);
            label4.Name = "label4";
            label4.Size = new Size(110, 25);
            label4.TabIndex = 30;
            label4.Text = "Expire Date";
            // 
            // usernametxt
            // 
            usernametxt.Location = new Point(344, 40);
            usernametxt.Multiline = true;
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new Size(545, 31);
            usernametxt.TabIndex = 23;
            // 
            // bookdatedtp
            // 
            bookdatedtp.Format = DateTimePickerFormat.Short;
            bookdatedtp.Location = new Point(344, 261);
            bookdatedtp.Name = "bookdatedtp";
            bookdatedtp.Size = new Size(545, 31);
            bookdatedtp.TabIndex = 29;
            // 
            // useridtxt
            // 
            useridtxt.Location = new Point(344, 95);
            useridtxt.Name = "useridtxt";
            useridtxt.Size = new Size(545, 31);
            useridtxt.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(159, 266);
            label2.Name = "label2";
            label2.Size = new Size(128, 25);
            label2.TabIndex = 28;
            label2.Text = "Booking Date";
            // 
            // userlbl
            // 
            userlbl.AutoSize = true;
            userlbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userlbl.ForeColor = SystemColors.ButtonHighlight;
            userlbl.Location = new Point(159, 37);
            userlbl.Name = "userlbl";
            userlbl.Size = new Size(105, 25);
            userlbl.TabIndex = 25;
            userlbl.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(439, 40);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(159, 95);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 26;
            label1.Text = "User Id";
            // 
            // pcknametxt
            // 
            pcknametxt.Location = new Point(344, 151);
            pcknametxt.Multiline = true;
            pcknametxt.Name = "pcknametxt";
            pcknametxt.Size = new Size(545, 31);
            pcknametxt.TabIndex = 32;
            // 
            // pricetxt
            // 
            pricetxt.Location = new Point(344, 206);
            pricetxt.Name = "pricetxt";
            pricetxt.Size = new Size(545, 31);
            pricetxt.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(159, 148);
            label5.Name = "label5";
            label5.Size = new Size(138, 25);
            label5.TabIndex = 34;
            label5.Text = "Package Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(439, 170);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(159, 206);
            label7.Name = "label7";
            label7.Size = new Size(54, 25);
            label7.TabIndex = 35;
            label7.Text = "Price";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(20, 20, 20);
            panel1.Controls.Add(resetbtn);
            panel1.Controls.Add(updatebtn);
            panel1.Controls.Add(deletebtn);
            panel1.Controls.Add(usernametxt);
            panel1.Controls.Add(pcknametxt);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pricetxt);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(userlbl);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(useridtxt);
            panel1.Controls.Add(expiredatedtp);
            panel1.Controls.Add(bookdatedtp);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(179, 414);
            panel1.Name = "panel1";
            panel1.Size = new Size(1281, 389);
            panel1.TabIndex = 37;
            // 
            // resetbtn
            // 
            resetbtn.BackColor = Color.Transparent;
            resetbtn.FlatAppearance.BorderColor = Color.FromArgb(255, 87, 34);
            resetbtn.FlatAppearance.BorderSize = 2;
            resetbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 87, 34);
            resetbtn.FlatStyle = FlatStyle.Flat;
            resetbtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resetbtn.ForeColor = SystemColors.ButtonHighlight;
            resetbtn.Location = new Point(936, 266);
            resetbtn.Name = "resetbtn";
            resetbtn.Size = new Size(189, 43);
            resetbtn.TabIndex = 39;
            resetbtn.Text = "Reset";
            resetbtn.UseVisualStyleBackColor = false;
            resetbtn.Click += resetbtn_Click;
            // 
            // updatebtn
            // 
            updatebtn.BackColor = Color.Transparent;
            updatebtn.FlatAppearance.BorderColor = Color.FromArgb(255, 87, 34);
            updatebtn.FlatAppearance.BorderSize = 2;
            updatebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 87, 34);
            updatebtn.FlatStyle = FlatStyle.Flat;
            updatebtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updatebtn.ForeColor = SystemColors.ButtonHighlight;
            updatebtn.Location = new Point(936, 95);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(189, 43);
            updatebtn.TabIndex = 37;
            updatebtn.Text = "Update";
            updatebtn.UseVisualStyleBackColor = false;
            updatebtn.Click += updatebtn_Click;
            // 
            // deletebtn
            // 
            deletebtn.BackColor = Color.Transparent;
            deletebtn.FlatAppearance.BorderColor = Color.FromArgb(255, 87, 34);
            deletebtn.FlatAppearance.BorderSize = 2;
            deletebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 87, 34);
            deletebtn.FlatStyle = FlatStyle.Flat;
            deletebtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deletebtn.ForeColor = SystemColors.ButtonHighlight;
            deletebtn.Location = new Point(936, 179);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(189, 43);
            deletebtn.TabIndex = 38;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = false;
            deletebtn.Click += deletebtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(20, 20, 20);
            panel2.Controls.Add(MembershipGridView);
            panel2.Location = new Point(243, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(1157, 320);
            panel2.TabIndex = 38;
            // 
            // MemberShipListControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MemberShipListControl";
            Size = new Size(1532, 870);
            Load += MemberShipListControl_Load;
            ((System.ComponentModel.ISupportInitialize)MembershipGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView MembershipGridView;
        private DateTimePicker expiredatedtp;
        private Label label4;
        private TextBox usernametxt;
        private DateTimePicker bookdatedtp;
        private TextBox useridtxt;
        private Label label2;
        private Label userlbl;
        private Label label3;
        private Label label1;
        private TextBox pcknametxt;
        private TextBox pricetxt;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private Button resetbtn;
        private Button updatebtn;
        private Button deletebtn;
        private Panel panel2;
    }
}

namespace Gym_Management
{
    partial class MemberShipInquiry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberShipInquiry));
            Bookbtn = new Button();
            cancelbtn = new Button();
            usernametxt = new TextBox();
            useridtxt = new TextBox();
            userlbl = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            bookdatedtp = new DateTimePicker();
            expiredatedtp = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Bookbtn
            // 
            Bookbtn.BackColor = Color.Transparent;
            Bookbtn.FlatAppearance.BorderColor = Color.FromArgb(255, 87, 34);
            Bookbtn.FlatAppearance.BorderSize = 2;
            Bookbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 87, 34);
            Bookbtn.FlatStyle = FlatStyle.Flat;
            Bookbtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bookbtn.ForeColor = SystemColors.ButtonHighlight;
            Bookbtn.Location = new Point(100, 446);
            Bookbtn.Name = "Bookbtn";
            Bookbtn.Size = new Size(102, 43);
            Bookbtn.TabIndex = 12;
            Bookbtn.Text = "Book";
            Bookbtn.UseVisualStyleBackColor = false;
            Bookbtn.Click += Bookbtn_Click_1;
            // 
            // cancelbtn
            // 
            cancelbtn.BackColor = Color.Transparent;
            cancelbtn.FlatAppearance.BorderColor = Color.FromArgb(255, 87, 34);
            cancelbtn.FlatAppearance.BorderSize = 2;
            cancelbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 87, 34);
            cancelbtn.FlatStyle = FlatStyle.Flat;
            cancelbtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelbtn.ForeColor = SystemColors.ButtonHighlight;
            cancelbtn.Location = new Point(271, 446);
            cancelbtn.Name = "cancelbtn";
            cancelbtn.Size = new Size(102, 43);
            cancelbtn.TabIndex = 13;
            cancelbtn.Text = "Cancel";
            cancelbtn.UseVisualStyleBackColor = false;
            cancelbtn.Click += cancelbtn_Click;
            // 
            // usernametxt
            // 
            usernametxt.Location = new Point(254, 139);
            usernametxt.Multiline = true;
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new Size(155, 31);
            usernametxt.TabIndex = 14;
            // 
            // useridtxt
            // 
            useridtxt.Location = new Point(254, 194);
            useridtxt.Name = "useridtxt";
            useridtxt.Size = new Size(155, 31);
            useridtxt.TabIndex = 15;
            // 
            // userlbl
            // 
            userlbl.AutoSize = true;
            userlbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userlbl.ForeColor = SystemColors.ButtonHighlight;
            userlbl.Location = new Point(69, 136);
            userlbl.Name = "userlbl";
            userlbl.Size = new Size(105, 25);
            userlbl.TabIndex = 16;
            userlbl.Text = "User Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(69, 194);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 17;
            label1.Text = "User Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(69, 253);
            label2.Name = "label2";
            label2.Size = new Size(128, 25);
            label2.TabIndex = 19;
            label2.Text = "Booking Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(349, 139);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 18;
            // 
            // bookdatedtp
            // 
            bookdatedtp.Format = DateTimePickerFormat.Short;
            bookdatedtp.Location = new Point(254, 248);
            bookdatedtp.Name = "bookdatedtp";
            bookdatedtp.Size = new Size(155, 31);
            bookdatedtp.TabIndex = 20;
            // 
            // expiredatedtp
            // 
            expiredatedtp.Format = DateTimePickerFormat.Short;
            expiredatedtp.Location = new Point(254, 309);
            expiredatedtp.Name = "expiredatedtp";
            expiredatedtp.Size = new Size(155, 31);
            expiredatedtp.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(69, 314);
            label4.Name = "label4";
            label4.Size = new Size(128, 25);
            label4.TabIndex = 21;
            label4.Text = "Booking Date";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(61, 38);
            label5.Name = "label5";
            label5.Size = new Size(362, 57);
            label5.TabIndex = 23;
            label5.Text = "Membership Booking";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(Bookbtn);
            panel1.Controls.Add(expiredatedtp);
            panel1.Controls.Add(cancelbtn);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(usernametxt);
            panel1.Controls.Add(bookdatedtp);
            panel1.Controls.Add(useridtxt);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(userlbl);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(485, 566);
            panel1.TabIndex = 24;
            // 
            // MemberShipInquiry
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(484, 561);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MemberShipInquiry";
            Text = "MemberShipInquiry";
            Load += MemberShipInquiry_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Bookbtn;
        private Button cancelbtn;
        private TextBox usernametxt;
        private TextBox useridtxt;
        private Label userlbl;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker bookdatedtp;
        private DateTimePicker expiredatedtp;
        private Label label4;
        private Label label5;
        private Panel panel1;
    }
}
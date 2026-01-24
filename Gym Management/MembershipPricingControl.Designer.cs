namespace Gym_Management
{
    partial class MembershipPricingControl
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
            label1 = new Label();
            packageBox = new ComboBox();
            lblBasic = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            lblstuPrice = new Label();
            lblstudentmonthly = new Label();
            panel3 = new Panel();
            label4 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            lblPrice1year = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(99, 41);
            label1.Name = "label1";
            label1.Size = new Size(255, 32);
            label1.TabIndex = 3;
            label1.Text = " Membership Type";
            // 
            // packageBox
            // 
            packageBox.FormattingEnabled = true;
            packageBox.Items.AddRange(new object[] { "No membership", "Regular Monthly", "Student Monthly", "6 Month Package", "1 Year Package" });
            packageBox.Location = new Point(49, 474);
            packageBox.Name = "packageBox";
            packageBox.Size = new Size(121, 23);
            packageBox.TabIndex = 4;
            packageBox.Text = "No Membership";
            // 
            // lblBasic
            // 
            lblBasic.AutoSize = true;
            lblBasic.BackColor = SystemColors.ActiveCaption;
            lblBasic.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBasic.ForeColor = SystemColors.ActiveCaptionText;
            lblBasic.Location = new Point(10, 18);
            lblBasic.Name = "lblBasic";
            lblBasic.Size = new Size(160, 25);
            lblBasic.TabIndex = 5;
            lblBasic.Text = "Regular Monthly ";
            lblBasic.Click += lblBasic_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(152, 25);
            label2.TabIndex = 6;
            label2.Text = "Price : BDT 2000";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblBasic);
            panel1.Location = new Point(49, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(178, 117);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(lblstuPrice);
            panel2.Controls.Add(lblstudentmonthly);
            panel2.Location = new Point(256, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(170, 117);
            panel2.TabIndex = 8;
            // 
            // lblstuPrice
            // 
            lblstuPrice.AutoSize = true;
            lblstuPrice.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblstuPrice.Location = new Point(10, 66);
            lblstuPrice.Name = "lblstuPrice";
            lblstuPrice.Size = new Size(149, 25);
            lblstuPrice.TabIndex = 1;
            lblstuPrice.Text = "Price : BDT 1500";
            // 
            // lblstudentmonthly
            // 
            lblstudentmonthly.AutoSize = true;
            lblstudentmonthly.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblstudentmonthly.Location = new Point(10, 18);
            lblstudentmonthly.Name = "lblstudentmonthly";
            lblstudentmonthly.Size = new Size(156, 25);
            lblstudentmonthly.TabIndex = 0;
            lblstudentmonthly.Text = "Student Monthly";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(49, 259);
            panel3.Name = "panel3";
            panel3.Size = new Size(178, 120);
            panel3.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 70);
            label4.Name = "label4";
            label4.Size = new Size(160, 25);
            label4.TabIndex = 1;
            label4.Text = "Price : BDT 10000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 18);
            label3.Name = "label3";
            label3.Size = new Size(161, 25);
            label3.TabIndex = 0;
            label3.Text = "6 Month Package";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(lblPrice1year);
            panel4.Controls.Add(label5);
            panel4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel4.Location = new Point(256, 259);
            panel4.Name = "panel4";
            panel4.Size = new Size(170, 120);
            panel4.TabIndex = 10;
            // 
            // lblPrice1year
            // 
            lblPrice1year.AutoSize = true;
            lblPrice1year.Location = new Point(10, 70);
            lblPrice1year.Name = "lblPrice1year";
            lblPrice1year.Size = new Size(163, 25);
            lblPrice1year.TabIndex = 1;
            lblPrice1year.Text = "Price : BDT 20000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 18);
            label5.Name = "label5";
            label5.Size = new Size(136, 25);
            label5.TabIndex = 0;
            label5.Text = "1 Year Package";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlLightLight;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(49, 435);
            label6.Name = "label6";
            label6.Size = new Size(237, 25);
            label6.TabIndex = 11;
            label6.Text = "Select Membership Type :";
            // 
            // MembershipPricingControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(label6);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(packageBox);
            Controls.Add(label1);
            Name = "MembershipPricingControl";
            Size = new Size(470, 596);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ComboBox packageBox;
        private Label lblBasic;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Label lblstuPrice;
        private Label lblstudentmonthly;
        private Panel panel3;
        private Label label4;
        private Label label3;
        private Panel panel4;
        private Label lblPrice1year;
        private Label label5;
        private Label label6;
    }
}

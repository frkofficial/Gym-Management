namespace Gym_Management
{
    partial class PaymrntControl
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
            cidtxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cnametxt = new TextBox();
            label3 = new Label();
            packtxt = new TextBox();
            label4 = new Label();
            trainertxt = new TextBox();
            label5 = new Label();
            totalamount = new TextBox();
            paydtp = new DateTimePicker();
            methodcmb = new ComboBox();
            changeamounttxt = new TextBox();
            payamounttxt = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            Process = new Button();
            Clearbtn = new Button();
            label6 = new Label();
            amountlbl = new Label();
            changelbl = new Label();
            SuspendLayout();
            // 
            // cidtxt
            // 
            cidtxt.Location = new Point(372, 136);
            cidtxt.Name = "cidtxt";
            cidtxt.Size = new Size(285, 31);
            cidtxt.TabIndex = 0;
            cidtxt.TextChanged += cidtxt_TextChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(98, 136);
            label1.Name = "label1";
            label1.Size = new Size(147, 38);
            label1.TabIndex = 1;
            label1.Text = "Customer Id";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(98, 202);
            label2.Name = "label2";
            label2.Size = new Size(164, 38);
            label2.TabIndex = 3;
            label2.Text = "Customer Name";
            // 
            // cnametxt
            // 
            cnametxt.Location = new Point(372, 203);
            cnametxt.Name = "cnametxt";
            cnametxt.Size = new Size(285, 31);
            cnametxt.TabIndex = 2;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(98, 264);
            label3.Name = "label3";
            label3.Size = new Size(164, 38);
            label3.TabIndex = 5;
            label3.Text = "Package Amount";
            label3.Click += label3_Click;
            // 
            // packtxt
            // 
            packtxt.Location = new Point(372, 265);
            packtxt.Name = "packtxt";
            packtxt.Size = new Size(285, 31);
            packtxt.TabIndex = 4;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(98, 329);
            label4.Name = "label4";
            label4.Size = new Size(147, 38);
            label4.TabIndex = 7;
            label4.Text = "Trainer Price";
            // 
            // trainertxt
            // 
            trainertxt.Location = new Point(372, 330);
            trainertxt.Name = "trainertxt";
            trainertxt.Size = new Size(285, 31);
            trainertxt.TabIndex = 6;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(98, 393);
            label5.Name = "label5";
            label5.Size = new Size(147, 38);
            label5.TabIndex = 9;
            label5.Text = "Total Amount";
            // 
            // totalamount
            // 
            totalamount.Location = new Point(372, 394);
            totalamount.Name = "totalamount";
            totalamount.Size = new Size(285, 31);
            totalamount.TabIndex = 8;
            // 
            // paydtp
            // 
            paydtp.Format = DateTimePickerFormat.Short;
            paydtp.Location = new Point(981, 136);
            paydtp.Name = "paydtp";
            paydtp.Size = new Size(285, 31);
            paydtp.TabIndex = 10;
            // 
            // methodcmb
            // 
            methodcmb.FormattingEnabled = true;
            methodcmb.Location = new Point(981, 198);
            methodcmb.Name = "methodcmb";
            methodcmb.Size = new Size(285, 33);
            methodcmb.TabIndex = 11;
            // 
            // changeamounttxt
            // 
            changeamounttxt.Location = new Point(981, 323);
            changeamounttxt.Name = "changeamounttxt";
            changeamounttxt.Size = new Size(285, 31);
            changeamounttxt.TabIndex = 13;
            // 
            // payamounttxt
            // 
            payamounttxt.Location = new Point(981, 259);
            payamounttxt.Name = "payamounttxt";
            payamounttxt.Size = new Size(285, 31);
            payamounttxt.TabIndex = 12;
            payamounttxt.TextChanged += payamounttxt_TextChanged;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(746, 323);
            label7.Name = "label7";
            label7.Size = new Size(151, 38);
            label7.TabIndex = 17;
            label7.Text = "Change Amount";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(746, 258);
            label8.Name = "label8";
            label8.Size = new Size(151, 38);
            label8.TabIndex = 16;
            label8.Text = "Paying Amount";
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(746, 196);
            label9.Name = "label9";
            label9.Size = new Size(151, 38);
            label9.TabIndex = 15;
            label9.Text = "Method";
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(746, 129);
            label10.Name = "label10";
            label10.Size = new Size(151, 38);
            label10.TabIndex = 14;
            label10.Text = "Payment Date";
            // 
            // Process
            // 
            Process.Location = new Point(880, 388);
            Process.Name = "Process";
            Process.Size = new Size(126, 34);
            Process.TabIndex = 18;
            Process.Text = "Process";
            Process.UseVisualStyleBackColor = true;
            Process.Click += Process_Click;
            // 
            // Clearbtn
            // 
            Clearbtn.Location = new Point(1078, 391);
            Clearbtn.Name = "Clearbtn";
            Clearbtn.Size = new Size(119, 34);
            Clearbtn.TabIndex = 19;
            Clearbtn.Text = "Clear";
            Clearbtn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(169, 13);
            label6.Name = "label6";
            label6.Size = new Size(931, 73);
            label6.TabIndex = 20;
            label6.Text = "PAYMENT";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Click += label6_Click;
            // 
            // amountlbl
            // 
            amountlbl.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            amountlbl.ForeColor = SystemColors.Control;
            amountlbl.Location = new Point(98, 454);
            amountlbl.Name = "amountlbl";
            amountlbl.Size = new Size(559, 73);
            amountlbl.TabIndex = 21;
            amountlbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // changelbl
            // 
            changelbl.ForeColor = SystemColors.ControlLightLight;
            changelbl.Location = new Point(1335, 311);
            changelbl.Name = "changelbl";
            changelbl.Size = new Size(232, 56);
            changelbl.TabIndex = 22;
            changelbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PaymrntControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(changelbl);
            Controls.Add(amountlbl);
            Controls.Add(label6);
            Controls.Add(Clearbtn);
            Controls.Add(Process);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(changeamounttxt);
            Controls.Add(payamounttxt);
            Controls.Add(methodcmb);
            Controls.Add(paydtp);
            Controls.Add(label5);
            Controls.Add(totalamount);
            Controls.Add(label4);
            Controls.Add(trainertxt);
            Controls.Add(label3);
            Controls.Add(packtxt);
            Controls.Add(label2);
            Controls.Add(cnametxt);
            Controls.Add(label1);
            Controls.Add(cidtxt);
            Name = "PaymrntControl";
            Size = new Size(1567, 890);
            Load += PaymrntControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox cidtxt;
        private Label label1;
        private Label label2;
        private TextBox cnametxt;
        private Label label3;
        private TextBox packtxt;
        private Label label4;
        private TextBox trainertxt;
        private Label label5;
        private TextBox totalamount;
        private DateTimePicker paydtp;
        private ComboBox methodcmb;
        private TextBox changeamounttxt;
        private TextBox payamounttxt;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button Process;
        private Button Clearbtn;
        private Label label6;
        private Label amountlbl;
        private Label changelbl;
    }
}

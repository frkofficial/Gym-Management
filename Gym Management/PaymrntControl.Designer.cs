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
            label11 = new Label();
            button1 = new Button();
            label12 = new Label();
            label13 = new Label();
            pckgname = new Label();
            pckamount = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cardbtn = new Button();
            mobilebankbtn = new Button();
            netbankbtn = new Button();
            webViewpayment = new Microsoft.Web.WebView2.WinForms.WebView2();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)webViewpayment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // paydtp
            // 
            paydtp.Format = DateTimePickerFormat.Short;
            paydtp.Location = new Point(1265, 67);
            paydtp.Name = "paydtp";
            paydtp.Size = new Size(285, 31);
            paydtp.TabIndex = 10;
            // 
            // methodcmb
            // 
            methodcmb.FormattingEnabled = true;
            methodcmb.Location = new Point(1265, 129);
            methodcmb.Name = "methodcmb";
            methodcmb.Size = new Size(285, 33);
            methodcmb.TabIndex = 11;
            // 
            // changeamounttxt
            // 
            changeamounttxt.Location = new Point(1265, 254);
            changeamounttxt.Name = "changeamounttxt";
            changeamounttxt.Size = new Size(285, 31);
            changeamounttxt.TabIndex = 13;
            // 
            // payamounttxt
            // 
            payamounttxt.Location = new Point(1265, 190);
            payamounttxt.Name = "payamounttxt";
            payamounttxt.Size = new Size(285, 31);
            payamounttxt.TabIndex = 12;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(1108, 254);
            label7.Name = "label7";
            label7.Size = new Size(151, 38);
            label7.TabIndex = 17;
            label7.Text = "Change Amount";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(1108, 189);
            label8.Name = "label8";
            label8.Size = new Size(151, 38);
            label8.TabIndex = 16;
            label8.Text = "Paying Amount";
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(1108, 127);
            label9.Name = "label9";
            label9.Size = new Size(151, 38);
            label9.TabIndex = 15;
            label9.Text = "Method";
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(1108, 60);
            label10.Name = "label10";
            label10.Size = new Size(151, 38);
            label10.TabIndex = 14;
            label10.Text = "Payment Date";
            // 
            // Process
            // 
            Process.Location = new Point(1164, 319);
            Process.Name = "Process";
            Process.Size = new Size(126, 34);
            Process.TabIndex = 18;
            Process.Text = "Process";
            Process.UseVisualStyleBackColor = true;
            // 
            // Clearbtn
            // 
            Clearbtn.Location = new Point(1362, 322);
            Clearbtn.Name = "Clearbtn";
            Clearbtn.Size = new Size(119, 34);
            Clearbtn.TabIndex = 19;
            Clearbtn.Text = "Clear";
            Clearbtn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(20, 20, 20);
            label6.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(26, 25);
            label6.Name = "label6";
            label6.Size = new Size(931, 73);
            label6.TabIndex = 20;
            label6.Text = "Make Payment";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            label6.Click += label6_Click;
            // 
            // amountlbl
            // 
            amountlbl.BackColor = Color.FromArgb(35, 35, 35);
            amountlbl.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            amountlbl.ForeColor = SystemColors.Control;
            amountlbl.Location = new Point(33, 257);
            amountlbl.Name = "amountlbl";
            amountlbl.Size = new Size(1049, 720);
            amountlbl.TabIndex = 21;
            amountlbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // changelbl
            // 
            changelbl.ForeColor = SystemColors.ControlLightLight;
            changelbl.Location = new Point(1397, -32);
            changelbl.Name = "changelbl";
            changelbl.Size = new Size(232, 56);
            changelbl.TabIndex = 22;
            changelbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.BackColor = Color.FromArgb(20, 20, 20);
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Gainsboro;
            label11.Location = new Point(35, 98);
            label11.Name = "label11";
            label11.Size = new Size(940, 45);
            label11.TabIndex = 23;
            label11.Text = "Complete Your Payment For The Selected Membership Package.";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(35, 35, 35);
            button1.FlatAppearance.BorderColor = Color.FromArgb(255, 87, 34);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(33, 146);
            button1.Name = "button1";
            button1.Size = new Size(1049, 96);
            button1.TabIndex = 25;
            button1.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            label12.BackColor = Color.FromArgb(35, 35, 35);
            label12.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ScrollBar;
            label12.Location = new Point(135, 180);
            label12.Name = "label12";
            label12.Size = new Size(191, 41);
            label12.TabIndex = 26;
            label12.Text = "Current Package:";
            // 
            // label13
            // 
            label13.BackColor = Color.FromArgb(35, 35, 35);
            label13.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.LightGray;
            label13.Location = new Point(780, 162);
            label13.Name = "label13";
            label13.Size = new Size(76, 65);
            label13.TabIndex = 27;
            label13.Text = "Total:";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pckgname
            // 
            pckgname.BackColor = Color.FromArgb(35, 35, 35);
            pckgname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pckgname.ForeColor = SystemColors.Window;
            pckgname.Location = new Point(322, 162);
            pckgname.Name = "pckgname";
            pckgname.Size = new Size(443, 65);
            pckgname.TabIndex = 28;
            pckgname.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pckamount
            // 
            pckamount.BackColor = Color.FromArgb(35, 35, 35);
            pckamount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pckamount.ForeColor = SystemColors.Window;
            pckamount.Location = new Point(852, 162);
            pckamount.Name = "pckamount";
            pckamount.Size = new Size(209, 65);
            pckamount.TabIndex = 29;
            pckamount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(255, 87, 34);
            label1.Location = new Point(33, 255);
            label1.Name = "label1";
            label1.Size = new Size(1049, 2);
            label1.TabIndex = 30;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(255, 87, 34);
            label2.Location = new Point(33, 257);
            label2.Name = "label2";
            label2.Size = new Size(2, 716);
            label2.TabIndex = 31;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(255, 87, 34);
            label3.Location = new Point(33, 973);
            label3.Name = "label3";
            label3.Size = new Size(1049, 2);
            label3.TabIndex = 32;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(255, 87, 34);
            label4.Location = new Point(1080, 255);
            label4.Name = "label4";
            label4.Size = new Size(2, 720);
            label4.TabIndex = 33;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(35, 35, 35);
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(41, 265);
            label5.Name = "label5";
            label5.Size = new Size(1033, 56);
            label5.TabIndex = 34;
            label5.Text = "Select Payment Method";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cardbtn
            // 
            cardbtn.BackColor = Color.Transparent;
            cardbtn.FlatAppearance.BorderColor = Color.FromArgb(255, 87, 34);
            cardbtn.FlatAppearance.BorderSize = 2;
            cardbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 87, 34);
            cardbtn.FlatStyle = FlatStyle.Flat;
            cardbtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cardbtn.ForeColor = SystemColors.ButtonHighlight;
            cardbtn.Location = new Point(81, 324);
            cardbtn.Name = "cardbtn";
            cardbtn.Size = new Size(319, 43);
            cardbtn.TabIndex = 47;
            cardbtn.Text = "Card";
            cardbtn.UseVisualStyleBackColor = false;
            cardbtn.Click += cardbtn_Click;
            // 
            // mobilebankbtn
            // 
            mobilebankbtn.BackColor = Color.Transparent;
            mobilebankbtn.FlatAppearance.BorderColor = Color.FromArgb(255, 87, 34);
            mobilebankbtn.FlatAppearance.BorderSize = 2;
            mobilebankbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 87, 34);
            mobilebankbtn.FlatStyle = FlatStyle.Flat;
            mobilebankbtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mobilebankbtn.ForeColor = SystemColors.ButtonHighlight;
            mobilebankbtn.Location = new Point(397, 324);
            mobilebankbtn.Name = "mobilebankbtn";
            mobilebankbtn.Size = new Size(319, 43);
            mobilebankbtn.TabIndex = 48;
            mobilebankbtn.Text = "Mobile Bank";
            mobilebankbtn.UseVisualStyleBackColor = false;
            mobilebankbtn.Click += mobilebankbtn_Click;
            // 
            // netbankbtn
            // 
            netbankbtn.BackColor = Color.Transparent;
            netbankbtn.FlatAppearance.BorderColor = Color.FromArgb(255, 87, 34);
            netbankbtn.FlatAppearance.BorderSize = 2;
            netbankbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 87, 34);
            netbankbtn.FlatStyle = FlatStyle.Flat;
            netbankbtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            netbankbtn.ForeColor = SystemColors.ButtonHighlight;
            netbankbtn.Location = new Point(713, 324);
            netbankbtn.Name = "netbankbtn";
            netbankbtn.Size = new Size(319, 43);
            netbankbtn.TabIndex = 49;
            netbankbtn.Text = "Net Bank";
            netbankbtn.UseVisualStyleBackColor = false;
            netbankbtn.Click += netbankbtn_Click;
            // 
            // webViewpayment
            // 
            webViewpayment.AllowExternalDrop = true;
            webViewpayment.CreationProperties = null;
            webViewpayment.DefaultBackgroundColor = Color.White;
            webViewpayment.Location = new Point(58, 394);
            webViewpayment.Name = "webViewpayment";
            webViewpayment.Size = new Size(1003, 557);
            webViewpayment.TabIndex = 50;
            webViewpayment.ZoomFactor = 1D;
            webViewpayment.Click += webViewpayment_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(35, 35, 35);
            pictureBox1.Image = Properties.Resources.icons8_wallet_502;
            pictureBox1.Location = new Point(41, 160);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 51;
            pictureBox1.TabStop = false;
            // 
            // PaymrntControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            Controls.Add(pictureBox1);
            Controls.Add(webViewpayment);
            Controls.Add(netbankbtn);
            Controls.Add(mobilebankbtn);
            Controls.Add(cardbtn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pckamount);
            Controls.Add(pckgname);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(button1);
            Controls.Add(label11);
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
            Name = "PaymrntControl";
            Size = new Size(1567, 1045);
            Load += PaymrntControl_Load;
            ((System.ComponentModel.ISupportInitialize)webViewpayment).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Label label11;
        private Button button1;
        private Label label12;
        private Label label13;
        private Label pckgname;
        private Label pckamount;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button cardbtn;
        private Button mobilebankbtn;
        private Button netbankbtn;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewpayment;
        private PictureBox pictureBox1;
    }
}

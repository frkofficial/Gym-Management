namespace Gym_Management
{
    partial class IntroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroForm));
            IntroPicBox = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            GetStartedBtn = new Button();
            LoginBtn = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)IntroPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // IntroPicBox
            // 
            IntroPicBox.BackColor = SystemColors.ActiveCaptionText;
            IntroPicBox.Image = (Image)resources.GetObject("IntroPicBox.Image");
            IntroPicBox.Location = new Point(2, 99);
            IntroPicBox.Margin = new Padding(2, 2, 2, 2);
            IntroPicBox.Name = "IntroPicBox";
            IntroPicBox.Size = new Size(532, 575);
            IntroPicBox.SizeMode = PictureBoxSizeMode.Zoom;
            IntroPicBox.TabIndex = 0;
            IntroPicBox.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(113, 442);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(233, 64);
            label1.TabIndex = 1;
            label1.Text = "Transform Your";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 147);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(105, 506);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(160, 57);
            label3.TabIndex = 3;
            label3.Text = "Empower";
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(336, 442);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(105, 64);
            label4.TabIndex = 4;
            label4.Text = "Body";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(270, 496);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(171, 64);
            label5.TabIndex = 5;
            label5.Text = "Your Mind";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // GetStartedBtn
            // 
            GetStartedBtn.BackColor = Color.Orange;
            GetStartedBtn.FlatAppearance.BorderColor = Color.Black;
            GetStartedBtn.FlatAppearance.BorderSize = 3;
            GetStartedBtn.FlatStyle = FlatStyle.Flat;
            GetStartedBtn.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GetStartedBtn.Location = new Point(105, 566);
            GetStartedBtn.Margin = new Padding(2, 2, 2, 2);
            GetStartedBtn.Name = "GetStartedBtn";
            GetStartedBtn.Size = new Size(317, 57);
            GetStartedBtn.TabIndex = 6;
            GetStartedBtn.Text = "Get Started";
            GetStartedBtn.UseVisualStyleBackColor = false;
            GetStartedBtn.Click += GetStartedBtn_Click;
            GetStartedBtn.MouseEnter += GetStarted_MouseEnter;
            GetStartedBtn.MouseLeave += GetStarted_MouseLeave;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.Black;
            LoginBtn.Cursor = Cursors.IBeam;
            LoginBtn.FlatAppearance.BorderColor = Color.White;
            LoginBtn.FlatAppearance.BorderSize = 3;
            LoginBtn.FlatAppearance.MouseOverBackColor = Color.Orange;
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = SystemColors.HighlightText;
            LoginBtn.Location = new Point(105, 647);
            LoginBtn.Margin = new Padding(2, 2, 2, 2);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(317, 57);
            LoginBtn.TabIndex = 7;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            LoginBtn.MouseEnter += LoginBtn_MouseEnter;
            LoginBtn.MouseLeave += LoginBtn_MouseLeave;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(153, 10);
            pictureBox2.Margin = new Padding(2, 2, 2, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(219, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // IntroForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(530, 791);
            Controls.Add(pictureBox2);
            Controls.Add(LoginBtn);
            Controls.Add(GetStartedBtn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(IntroPicBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "IntroForm";
            Text = "IntroForm";
            ((System.ComponentModel.ISupportInitialize)IntroPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox IntroPicBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button GetStartedBtn;
        private Button LoginBtn;
        private PictureBox pictureBox2;
    }
}
namespace Gym_Management
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            textBox1 = new TextBox();
            EmailLabel = new Label();
            textBox2 = new TextBox();
            lab = new Label();
            label2 = new Label();
            checkBox1 = new CheckBox();
            label1 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(265, 165);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(290, 31);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmailLabel.ForeColor = SystemColors.HotTrack;
            EmailLabel.Location = new Point(265, 126);
            EmailLabel.Margin = new Padding(4, 0, 4, 0);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(87, 32);
            EmailLabel.TabIndex = 1;
            EmailLabel.Text = "Email*";
            EmailLabel.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(261, 246);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(290, 31);
            textBox2.TabIndex = 2;
            // 
            // lab
            // 
            lab.AutoSize = true;
            lab.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lab.ForeColor = SystemColors.HotTrack;
            lab.Location = new Point(265, 214);
            lab.Margin = new Padding(4, 0, 4, 0);
            lab.Name = "lab";
            lab.Size = new Size(115, 30);
            lab.TabIndex = 3;
            lab.Text = "Password*";
            lab.Click += lab_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(265, 68);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 38);
            label2.TabIndex = 7;
            label2.Text = "Sign-In";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.ForeColor = SystemColors.AppWorkspace;
            checkBox1.Location = new Point(261, 320);
            checkBox1.Margin = new Padding(4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(154, 29);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Remember Me";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(440, 319);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(186, 30);
            label1.TabIndex = 9;
            label1.Text = "Forgot Password?";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.HotTrack;
            button1.Location = new Point(106, 385);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(288, 52);
            button1.TabIndex = 10;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Location = new Point(731, 126);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(239, 311);
            panel1.TabIndex = 11;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.HotTrack;
            button2.Location = new Point(401, 385);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(288, 52);
            button2.TabIndex = 12;
            button2.Text = "Sign Up";
            button2.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(lab);
            Controls.Add(textBox2);
            Controls.Add(EmailLabel);
            Controls.Add(textBox1);
            Margin = new Padding(4);
            Name = "LoginForm";
            Text = "Gym Management";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label EmailLabel;
        private TextBox textBox2;
        private Label lab;
        private Label label2;
        private CheckBox checkBox1;
        private Label label1;
        private Button button1;
        private Panel panel1;
        private Button button2;
    }
}

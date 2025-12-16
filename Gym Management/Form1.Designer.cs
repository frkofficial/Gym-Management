namespace Gym_Management
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            Name = new Label();
            textBox2 = new TextBox();
            lab = new Label();
            label2 = new Label();
            checkBox1 = new CheckBox();
            label1 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(212, 132);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name.ForeColor = SystemColors.HotTrack;
            Name.Location = new Point(212, 101);
            Name.Name = "Name";
            Name.Size = new Size(73, 28);
            Name.TabIndex = 1;
            Name.Text = "Email*";
            Name.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(209, 197);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(233, 27);
            textBox2.TabIndex = 2;
            // 
            // lab
            // 
            lab.AutoSize = true;
            lab.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lab.ForeColor = SystemColors.HotTrack;
            lab.Location = new Point(212, 171);
            lab.Name = "lab";
            lab.Size = new Size(93, 23);
            lab.TabIndex = 3;
            lab.Text = "Password*";
            lab.Click += lab_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(212, 54);
            label2.Name = "label2";
            label2.Size = new Size(92, 31);
            label2.TabIndex = 7;
            label2.Text = "Sign-In";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.ForeColor = SystemColors.AppWorkspace;
            checkBox1.Location = new Point(209, 256);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(129, 24);
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
            label1.Location = new Point(352, 255);
            label1.Name = "label1";
            label1.Size = new Size(151, 23);
            label1.TabIndex = 9;
            label1.Text = "Forgot Password?";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.HotTrack;
            button1.Location = new Point(85, 308);
            button1.Name = "button1";
            button1.Size = new Size(230, 42);
            button1.TabIndex = 10;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Location = new Point(585, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(191, 249);
            panel1.TabIndex = 11;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.HotTrack;
            button2.Location = new Point(321, 308);
            button2.Name = "button2";
            button2.Size = new Size(230, 42);
            button2.TabIndex = 12;
            button2.Text = "Sign Up";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(277, 356);
            button3.Name = "button3";
            button3.Size = new Size(132, 51);
            button3.TabIndex = 13;
            button3.Text = "Click";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(lab);
            Controls.Add(textBox2);
            Controls.Add(Name);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Gym Management";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label Name;
        private TextBox textBox2;
        private Label lab;
        private Label label2;
        private CheckBox checkBox1;
        private Label label1;
        private Button button1;
        private Panel panel1;
        private Button button2;
        private Button button3;
    }
}

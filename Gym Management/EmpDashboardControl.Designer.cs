namespace Gym_Management
{
    partial class EmpDashboardControl
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Emplbl = new Label();
            Rmemlbl = new Label();
            ActMemlbl = new Label();
            inactmemlbl = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(219, 195);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(144, 148);
            label1.Name = "label1";
            label1.Size = new Size(535, 115);
            label1.TabIndex = 1;
            label1.Text = "Number Of Employees";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(144, 294);
            label2.Name = "label2";
            label2.Size = new Size(535, 115);
            label2.TabIndex = 2;
            label2.Text = "Number Of Registered Members";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(144, 442);
            label3.Name = "label3";
            label3.Size = new Size(535, 115);
            label3.TabIndex = 3;
            label3.Text = "Number Of Active Members";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Emplbl
            // 
            Emplbl.BorderStyle = BorderStyle.Fixed3D;
            Emplbl.FlatStyle = FlatStyle.Flat;
            Emplbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Emplbl.ForeColor = SystemColors.ButtonHighlight;
            Emplbl.Location = new Point(858, 148);
            Emplbl.Name = "Emplbl";
            Emplbl.Size = new Size(273, 115);
            Emplbl.TabIndex = 4;
            Emplbl.TextAlign = ContentAlignment.MiddleCenter;
            Emplbl.Click += Emplbl_Click;
            // 
            // Rmemlbl
            // 
            Rmemlbl.BorderStyle = BorderStyle.Fixed3D;
            Rmemlbl.FlatStyle = FlatStyle.Flat;
            Rmemlbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Rmemlbl.ForeColor = SystemColors.ButtonHighlight;
            Rmemlbl.Location = new Point(858, 294);
            Rmemlbl.Name = "Rmemlbl";
            Rmemlbl.Size = new Size(273, 115);
            Rmemlbl.TabIndex = 5;
            Rmemlbl.TextAlign = ContentAlignment.MiddleCenter;
            Rmemlbl.Click += Rmemlbl_Click;
            // 
            // ActMemlbl
            // 
            ActMemlbl.BorderStyle = BorderStyle.Fixed3D;
            ActMemlbl.FlatStyle = FlatStyle.Flat;
            ActMemlbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ActMemlbl.ForeColor = SystemColors.ButtonHighlight;
            ActMemlbl.Location = new Point(858, 442);
            ActMemlbl.Name = "ActMemlbl";
            ActMemlbl.Size = new Size(273, 115);
            ActMemlbl.TabIndex = 6;
            ActMemlbl.TextAlign = ContentAlignment.MiddleCenter;
            ActMemlbl.Click += ActMemlbl_Click;
            // 
            // inactmemlbl
            // 
            inactmemlbl.BorderStyle = BorderStyle.Fixed3D;
            inactmemlbl.FlatStyle = FlatStyle.Flat;
            inactmemlbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inactmemlbl.ForeColor = SystemColors.ButtonHighlight;
            inactmemlbl.Location = new Point(858, 598);
            inactmemlbl.Name = "inactmemlbl";
            inactmemlbl.Size = new Size(273, 115);
            inactmemlbl.TabIndex = 8;
            inactmemlbl.TextAlign = ContentAlignment.MiddleCenter;
            inactmemlbl.Click += inactmemlbl_Click;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(144, 598);
            label5.Name = "label5";
            label5.Size = new Size(535, 115);
            label5.TabIndex = 7;
            label5.Text = "Number Of Inactive Members";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EmpDashboardControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(inactmemlbl);
            Controls.Add(label5);
            Controls.Add(ActMemlbl);
            Controls.Add(Rmemlbl);
            Controls.Add(Emplbl);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "EmpDashboardControl";
            Size = new Size(1308, 835);
            Load += EmpDashboardControl_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label Emplbl;
        private Label Rmemlbl;
        private Label ActMemlbl;
        private Label inactmemlbl;
        private Label label5;
    }
}

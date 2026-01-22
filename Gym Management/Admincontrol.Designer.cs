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
            ((System.ComponentModel.ISupportInitialize)dataGridViewadmin).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.ForeColor = SystemColors.InfoText;
            button1.Location = new Point(85, 417);
            button1.Name = "button1";
            button1.Size = new Size(163, 48);
            button1.TabIndex = 0;
            button1.Text = "admin";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridViewadmin
            // 
            dataGridViewadmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewadmin.Location = new Point(85, 15);
            dataGridViewadmin.Name = "dataGridViewadmin";
            dataGridViewadmin.RowHeadersWidth = 51;
            dataGridViewadmin.Size = new Size(536, 381);
            dataGridViewadmin.TabIndex = 1;
            dataGridViewadmin.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Admincontrol
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridViewadmin);
            Controls.Add(button1);
            Name = "Admincontrol";
            Size = new Size(735, 534);
            Load += Admincontrol_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewadmin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dataGridViewadmin;
    }
}

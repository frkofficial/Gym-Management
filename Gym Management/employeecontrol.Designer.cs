namespace Gym_Management
{
    partial class employeecontrol
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
            dataGridViewemployee = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewemployee).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(142, 401);
            button1.Name = "button1";
            button1.Size = new Size(138, 53);
            button1.TabIndex = 0;
            button1.Text = "employee";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewemployee
            // 
            dataGridViewemployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewemployee.Location = new Point(123, 59);
            dataGridViewemployee.Name = "dataGridViewemployee";
            dataGridViewemployee.RowHeadersWidth = 51;
            dataGridViewemployee.Size = new Size(549, 326);
            dataGridViewemployee.TabIndex = 1;
            // 
            // employeecontrol
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridViewemployee);
            Controls.Add(button1);
            Name = "employeecontrol";
            Size = new Size(789, 557);
            Load += employeecontrol_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewemployee).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dataGridViewemployee;
    }
}

namespace Gym_Management
{
    partial class package
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridViewPackage = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPackage).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPackage
            // 
            dataGridViewPackage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewPackage.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPackage.Location = new Point(278, 113);
            dataGridViewPackage.Name = "dataGridViewPackage";
            dataGridViewPackage.RowHeadersWidth = 51;
            dataGridViewPackage.Size = new Size(546, 208);
            dataGridViewPackage.TabIndex = 0;
            dataGridViewPackage.CellContentClick += dataGridViewPackage_CellContentClick;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(378, 51);
            label1.Name = "label1";
            label1.Size = new Size(322, 47);
            label1.TabIndex = 1;
            label1.Text = "Current Packages";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // package
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(dataGridViewPackage);
            Name = "package";
            Size = new Size(1379, 610);
            Load += package_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPackage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewPackage;
        private Label label1;
    }
}

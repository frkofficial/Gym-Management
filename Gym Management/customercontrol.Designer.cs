namespace Gym_Management
{
    partial class customercontrol
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
            dataGridViewCustomer = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCustomer
            // 
            dataGridViewCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewCustomer.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCustomer.Location = new Point(118, 87);
            dataGridViewCustomer.Name = "dataGridViewCustomer";
            dataGridViewCustomer.RowHeadersWidth = 51;
            dataGridViewCustomer.Size = new Size(905, 375);
            dataGridViewCustomer.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Elephant", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Firebrick;
            label1.ImageAlign = ContentAlignment.BottomCenter;
            label1.Location = new Point(337, 20);
            label1.Name = "label1";
            label1.Size = new Size(421, 53);
            label1.TabIndex = 2;
            label1.Text = "Customer List ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // customercontrol
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(dataGridViewCustomer);
            Name = "customercontrol";
            Size = new Size(1236, 481);
            Load += customercontrol_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridViewCustomer;
        private Label label1;
    }
}

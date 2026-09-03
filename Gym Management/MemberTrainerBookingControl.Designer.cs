//namespace Gym_Management
//{
//    partial class MemberTrainerControl
//    {
//        /// <summary> 
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary> 
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Component Designer generated code

//        /// <summary> 
//        /// Required method for Designer support - do not modify 
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            headinglbl = new Label();
//            label1 = new Label();
//            label2 = new Label();
//            SuspendLayout();
//            // 
//            // headinglbl
//            // 
//            headinglbl.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
//            headinglbl.ForeColor = SystemColors.ButtonHighlight;
//            headinglbl.Location = new Point(34, 31);
//            headinglbl.Name = "headinglbl";
//            headinglbl.Size = new Size(302, 56);
//            headinglbl.TabIndex = 0;
//            headinglbl.Text = "Book a Trainer\r\n";
//            // 
//            // label1
//            // 
//            label1.Font = new Font("Segoe UI Light", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            label1.ForeColor = SystemColors.WindowFrame;
//            label1.Location = new Point(43, 87);
//            label1.Name = "label1";
//            label1.Size = new Size(411, 34);
//            label1.TabIndex = 1;
//            label1.Text = "Select a trainer, preferred day and available time slot.";
//            // 
//            // label2
//            // 
//            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
//            label2.ForeColor = Color.FromArgb(255, 87, 34);
//            label2.Location = new Point(43, 138);
//            label2.Name = "label2";
//            label2.Size = new Size(217, 49);
//            label2.TabIndex = 2;
//            label2.Text = "Choose trainer";
//            // 
//            // MemberTrainerControl
//            // 
//            AutoScaleDimensions = new SizeF(10F, 25F);
//            AutoScaleMode = AutoScaleMode.Font;
//            AutoScroll = true;
//            AutoScrollMinSize = new Size(0, 1180);
//            BackColor = Color.FromArgb(20, 20, 20);
//            Controls.Add(label2);
//            Controls.Add(label1);
//            Controls.Add(headinglbl);
//            Name = "MemberTrainerControl";
//            Size = new Size(1567, 1713);
//            Load += MemberTrainerControl_Load;
//            ResumeLayout(false);
//        }

//        #endregion

//        private Label headinglbl;
//        private Label label1;
//        private Label label2;
//    }
//}
namespace Gym_Management
{
    partial class MemberTrainerBookingControl : System.Windows.Forms.UserControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            lblSectionTrainer = new System.Windows.Forms.Label();
            flowTrainerCards = new System.Windows.Forms.FlowLayoutPanel();
            lblSectionDay = new System.Windows.Forms.Label();
            flowDayPills = new System.Windows.Forms.FlowLayoutPanel();
            lblSectionSlots = new System.Windows.Forms.Label();
            flowSlots = new System.Windows.Forms.FlowLayoutPanel();

            SuspendLayout();

            System.Drawing.Color bgPage = System.Drawing.Color.FromArgb(20, 20, 20);
            System.Drawing.Color orange = System.Drawing.Color.FromArgb(232, 119, 34);
            System.Drawing.Color muted = System.Drawing.Color.FromArgb(140, 140, 140);

            // ── CHOOSE TRAINER label ─────────────────────────────────────────
            lblSectionTrainer.Name = "lblSectionTrainer";
            lblSectionTrainer.Text = "CHOOSE TRAINER";
            lblSectionTrainer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblSectionTrainer.ForeColor = orange;
            lblSectionTrainer.Location = new System.Drawing.Point(20, 20);
            lblSectionTrainer.Size = new System.Drawing.Size(300, 22);

            // ── Trainer cards FlowLayoutPanel ────────────────────────────────
            flowTrainerCards.Name = "flowTrainerCards";
            flowTrainerCards.Location = new System.Drawing.Point(20, 48);
            flowTrainerCards.Size = new System.Drawing.Size(1100, 580);
            flowTrainerCards.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            flowTrainerCards.WrapContents = true;
            flowTrainerCards.AutoScroll = false;
            flowTrainerCards.BackColor = bgPage;
            flowTrainerCards.Padding = new System.Windows.Forms.Padding(0);

            // ── SELECT DAY label ─────────────────────────────────────────────
            lblSectionDay.Name = "lblSectionDay";
            lblSectionDay.Text = "SELECT DAY";
            lblSectionDay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblSectionDay.ForeColor = orange;
            lblSectionDay.Location = new System.Drawing.Point(20, 648);
            lblSectionDay.Size = new System.Drawing.Size(300, 22);

            // ── Day pills FlowLayoutPanel ────────────────────────────────────
            flowDayPills.Name = "flowDayPills";
            flowDayPills.Location = new System.Drawing.Point(20, 676);
            flowDayPills.Size = new System.Drawing.Size(1100, 60);
            flowDayPills.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            flowDayPills.WrapContents = false;
            flowDayPills.AutoScroll = false;
            flowDayPills.BackColor = bgPage;
            flowDayPills.Padding = new System.Windows.Forms.Padding(0);

            // ── AVAILABLE SLOTS label ────────────────────────────────────────
            lblSectionSlots.Name = "lblSectionSlots";
            lblSectionSlots.Text = "AVAILABLE SLOTS";
            lblSectionSlots.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblSectionSlots.ForeColor = orange;
            lblSectionSlots.Location = new System.Drawing.Point(20, 754);
            lblSectionSlots.Size = new System.Drawing.Size(600, 22);

            // ── Slots FlowLayoutPanel ────────────────────────────────────────
            flowSlots.Name = "flowSlots";
            flowSlots.Location = new System.Drawing.Point(20, 782);
            flowSlots.Size = new System.Drawing.Size(1100, 200);
            flowSlots.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            flowSlots.WrapContents = true;
            flowSlots.AutoScroll = false;
            flowSlots.BackColor = bgPage;
            flowSlots.Padding = new System.Windows.Forms.Padding(0);

            // ── Root UserControl ─────────────────────────────────────────────
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new System.Drawing.Size(0, 1020);
            BackColor = bgPage;
            Name = "MemberTrainerBookingControl";
            Size = new System.Drawing.Size(1160, 1020);

            Controls.Add(lblSectionTrainer);
            Controls.Add(flowTrainerCards);
            Controls.Add(lblSectionDay);
            Controls.Add(flowDayPills);
            Controls.Add(lblSectionSlots);
            Controls.Add(flowSlots);

            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblSectionTrainer;
        private System.Windows.Forms.FlowLayoutPanel flowTrainerCards;
        private System.Windows.Forms.Label lblSectionDay;
        private System.Windows.Forms.FlowLayoutPanel flowDayPills;
        private System.Windows.Forms.Label lblSectionSlots;
        private System.Windows.Forms.FlowLayoutPanel flowSlots;
    }
}
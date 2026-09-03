//namespace Gym_Management
//{
//    partial class EmpTrainerControl
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
//            label2 = new Label();
//            label1 = new Label();
//            headinglbl = new Label();
//            SuspendLayout();
//            // 
//            // label2
//            // 
//            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
//            label2.ForeColor = Color.FromArgb(255, 87, 34);
//            label2.Location = new Point(39, 136);
//            label2.Name = "label2";
//            label2.Size = new Size(217, 49);
//            label2.TabIndex = 5;
//            label2.Text = "Operate trainer";
//            // 
//            // label1
//            // 
//            label1.Font = new Font("Segoe UI Light", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            label1.ForeColor = SystemColors.WindowFrame;
//            label1.Location = new Point(39, 85);
//            label1.Name = "label1";
//            label1.Size = new Size(411, 34);
//            label1.TabIndex = 4;
//            label1.Text = "Select a trainer, add, delete or modify.";
//            // 
//            // headinglbl
//            // 
//            headinglbl.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
//            headinglbl.ForeColor = SystemColors.ButtonHighlight;
//            headinglbl.Location = new Point(30, 29);
//            headinglbl.Name = "headinglbl";
//            headinglbl.Size = new Size(281, 56);
//            headinglbl.TabIndex = 3;
//            headinglbl.Text = "Trainer List";
//            // 
//            // EmpTrainerControl
//            // 
//            AutoScaleDimensions = new SizeF(10F, 25F);
//            AutoScaleMode = AutoScaleMode.Font;
//            AutoScroll = true;
//            AutoScrollMinSize = new Size(0, 1180);
//            BackColor = Color.FromArgb(20, 20, 20);
//            Controls.Add(label2);
//            Controls.Add(label1);
//            Controls.Add(headinglbl);
//            Name = "EmpTrainerControl";
//            Size = new Size(1567, 1713);
//            ResumeLayout(false);
//        }

//        #endregion

//        private Label label2;
//        private Label label1;
//        private Label headinglbl;
//    }
//}

namespace Gym_Management
{
    partial class EmpTrainerControl
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
            // ── Labels ──────────────────────────────────────────────────────
            headinglbl = new Label();
            lblSubtitle = new Label();
            lblSectionTrainer = new Label();
            lblSectionForm = new Label();
            lblSectionShift = new Label();
            lblSectionSlot = new Label();

            // ── Trainer list panel ───────────────────────────────────────────
            panelTrainerList = new Panel();
            flowTrainerCards = new FlowLayoutPanel();
            btnAddTrainer = new Button();
            btnEditTrainer = new Button();
            btnDeleteTrainer = new Button();

            // ── Add / Edit form panel ────────────────────────────────────────
            panelForm = new Panel();
            lblFormFullName = new Label();
            txtFullName = new TextBox();
            lblFormSpec = new Label();
            txtSpecialization = new TextBox();
            lblFormPhone = new Label();
            txtPhone = new TextBox();
            lblFormEmail = new Label();
            txtEmail = new TextBox();
            lblFormRate = new Label();
            numHourlyRate = new NumericUpDown();
            btnSaveTrainer = new Button();
            btnCancelForm = new Button();

            // ── Shift panel ──────────────────────────────────────────────────
            panelShift = new Panel();
            lblFormShiftName = new Label();
            txtShiftName = new TextBox();
            lblFormShiftStart = new Label();
            dtpShiftStart = new DateTimePicker();
            lblFormShiftEnd = new Label();
            dtpShiftEnd = new DateTimePicker();
            btnAddShift = new Button();
            btnDeleteShift = new Button();
            dgvShifts = new DataGridView();

            // ── Slot panel ───────────────────────────────────────────────────
            panelSlot = new Panel();
            lblFormDay = new Label();
            cmbDayOfWeek = new ComboBox();
            lblFormSlotTime = new Label();
            dtpSlotTime = new DateTimePicker();
            lblFormSlotShift = new Label();
            cmbSlotShift = new ComboBox();
            btnAddSlot = new Button();
            btnDeleteSlot = new Button();
            dgvSlots = new DataGridView();

            // ────────────────────────────────────────────────────────────────
            SuspendLayout();

            // ═══ COLORS (shared) ════════════════════════════════════════════
            Color bgPage = Color.FromArgb(20, 20, 20);
            Color bgPanel = Color.FromArgb(30, 30, 30);
            Color bgInput = Color.FromArgb(40, 40, 40);
            Color bgBtn = Color.FromArgb(40, 40, 40);
            Color orange = Color.FromArgb(232, 119, 34);
            Color textPrimary = Color.FromArgb(220, 220, 220);
            Color textMuted = Color.FromArgb(140, 140, 140);
            Color border = Color.FromArgb(55, 55, 55);
            Font fontLabel = new Font("Segoe UI", 9F, FontStyle.Regular);
            Font fontInput = new Font("Segoe UI", 10F, FontStyle.Regular);
            Font fontBtn = new Font("Segoe UI", 9F, FontStyle.Bold);

            // ═══ HEADING ════════════════════════════════════════════════════
            headinglbl.Text = "Trainer Management";
            headinglbl.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            headinglbl.ForeColor = Color.FromArgb(255, 255, 255);
            headinglbl.Location = new Point(30, 28);
            headinglbl.Size = new Size(420, 52);
            headinglbl.Name = "headinglbl";

            lblSubtitle.Text = "Add, edit or remove trainers, manage their shifts and time slots.";
            lblSubtitle.Font = new Font("Segoe UI Light", 10F);
            lblSubtitle.ForeColor = textMuted;
            lblSubtitle.Location = new Point(33, 84);
            lblSubtitle.Size = new Size(600, 28);
            lblSubtitle.Name = "lblSubtitle";

            // ═══ SECTION — TRAINER LIST ══════════════════════════════════════
            lblSectionTrainer.Text = "Trainer List";
            lblSectionTrainer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSectionTrainer.ForeColor = orange;
            lblSectionTrainer.Location = new Point(30, 130);
            lblSectionTrainer.Size = new Size(200, 28);
            lblSectionTrainer.Name = "lblSectionTrainer";

            // Trainer list panel
            panelTrainerList.Name = "panelTrainerList";
            panelTrainerList.Location = new Point(30, 165);
            panelTrainerList.Size = new Size(1510, 260);
            panelTrainerList.BackColor = bgPanel;
            panelTrainerList.BorderStyle = BorderStyle.FixedSingle;

            // FlowLayoutPanel — trainer cards rendered dynamically from DB
            flowTrainerCards.Name = "flowTrainerCards";
            flowTrainerCards.Location = new Point(8, 8);
            flowTrainerCards.Size = new Size(1390, 244);
            flowTrainerCards.FlowDirection = FlowDirection.LeftToRight;
            flowTrainerCards.WrapContents = true;
            flowTrainerCards.AutoScroll = true;
            flowTrainerCards.BackColor = bgPanel;
            flowTrainerCards.Padding = new Padding(6);

            // Add / Edit / Delete buttons (stacked on right of list)
            btnAddTrainer.Name = "btnAddTrainer";
            btnAddTrainer.Text = "+ Add";
            btnAddTrainer.Font = fontBtn;
            btnAddTrainer.ForeColor = Color.White;
            btnAddTrainer.BackColor = orange;
            btnAddTrainer.FlatStyle = FlatStyle.Flat;
            btnAddTrainer.FlatAppearance.BorderSize = 0;
            btnAddTrainer.Size = new Size(100, 36);
            btnAddTrainer.Location = new Point(1404, 16);
            btnAddTrainer.Cursor = Cursors.Hand;
            btnAddTrainer.Name = "btnAddTrainer";

            btnEditTrainer.Name = "btnEditTrainer";
            btnEditTrainer.Text = "✎ Edit";
            btnEditTrainer.Font = fontBtn;
            btnEditTrainer.ForeColor = textPrimary;
            btnEditTrainer.BackColor = bgBtn;
            btnEditTrainer.FlatStyle = FlatStyle.Flat;
            btnEditTrainer.FlatAppearance.BorderColor = border;
            btnEditTrainer.FlatAppearance.BorderSize = 1;
            btnEditTrainer.Size = new Size(100, 36);
            btnEditTrainer.Location = new Point(1404, 62);
            btnEditTrainer.Cursor = Cursors.Hand;
            btnEditTrainer.Enabled = false;

            btnDeleteTrainer.Name = "btnDeleteTrainer";
            btnDeleteTrainer.Text = "🗑 Delete";
            btnDeleteTrainer.Font = fontBtn;
            btnDeleteTrainer.ForeColor = Color.FromArgb(231, 76, 60);
            btnDeleteTrainer.BackColor = bgBtn;
            btnDeleteTrainer.FlatStyle = FlatStyle.Flat;
            btnDeleteTrainer.FlatAppearance.BorderColor = Color.FromArgb(231, 76, 60);
            btnDeleteTrainer.FlatAppearance.BorderSize = 1;
            btnDeleteTrainer.Size = new Size(100, 36);
            btnDeleteTrainer.Location = new Point(1404, 108);
            btnDeleteTrainer.Cursor = Cursors.Hand;
            btnDeleteTrainer.Enabled = false;

            panelTrainerList.Controls.Add(flowTrainerCards);
            panelTrainerList.Controls.Add(btnAddTrainer);
            panelTrainerList.Controls.Add(btnEditTrainer);
            panelTrainerList.Controls.Add(btnDeleteTrainer);

            // ═══ SECTION — ADD / EDIT FORM ═══════════════════════════════════
            lblSectionForm.Text = "Trainer Details";
            lblSectionForm.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSectionForm.ForeColor = orange;
            lblSectionForm.Location = new Point(30, 448);
            lblSectionForm.Size = new Size(200, 28);
            lblSectionForm.Name = "lblSectionForm";

            panelForm.Name = "panelForm";
            panelForm.Location = new Point(30, 483);
            panelForm.Size = new Size(1510, 160);
            panelForm.BackColor = bgPanel;
            panelForm.BorderStyle = BorderStyle.FixedSingle;

            // Row 1: FullName | Specialization | Phone | Email
            int col1 = 16, col2 = 386, col3 = 756, col4 = 1126;
            int row1y = 16, row1inp = 40;

            lblFormFullName.Text = "Full Name"; lblFormFullName.ForeColor = textMuted;
            lblFormFullName.Font = fontLabel; lblFormFullName.Location = new Point(col1, row1y);
            lblFormFullName.Size = new Size(340, 20); lblFormFullName.Name = "lblFormFullName";

            txtFullName.Name = "txtFullName";
            txtFullName.Location = new Point(col1, row1inp);
            txtFullName.Size = new Size(350, 34);
            txtFullName.Font = fontInput;
            txtFullName.BackColor = bgInput;
            txtFullName.ForeColor = textPrimary;
            txtFullName.BorderStyle = BorderStyle.FixedSingle;

            lblFormSpec.Text = "Specialization"; lblFormSpec.ForeColor = textMuted;
            lblFormSpec.Font = fontLabel; lblFormSpec.Location = new Point(col2, row1y);
            lblFormSpec.Size = new Size(340, 20); lblFormSpec.Name = "lblFormSpec";

            txtSpecialization.Name = "txtSpecialization";
            txtSpecialization.Location = new Point(col2, row1inp);
            txtSpecialization.Size = new Size(350, 34);
            txtSpecialization.Font = fontInput;
            txtSpecialization.BackColor = bgInput;
            txtSpecialization.ForeColor = textPrimary;
            txtSpecialization.BorderStyle = BorderStyle.FixedSingle;

            lblFormPhone.Text = "Phone"; lblFormPhone.ForeColor = textMuted;
            lblFormPhone.Font = fontLabel; lblFormPhone.Location = new Point(col3, row1y);
            lblFormPhone.Size = new Size(340, 20); lblFormPhone.Name = "lblFormPhone";

            txtPhone.Name = "txtPhone";
            txtPhone.Location = new Point(col3, row1inp);
            txtPhone.Size = new Size(350, 34);
            txtPhone.Font = fontInput;
            txtPhone.BackColor = bgInput;
            txtPhone.ForeColor = textPrimary;
            txtPhone.BorderStyle = BorderStyle.FixedSingle;

            lblFormEmail.Text = "Email"; lblFormEmail.ForeColor = textMuted;
            lblFormEmail.Font = fontLabel; lblFormEmail.Location = new Point(col4, row1y);
            lblFormEmail.Size = new Size(200, 20); lblFormEmail.Name = "lblFormEmail";

            txtEmail.Name = "txtEmail";
            txtEmail.Location = new Point(col4, row1inp);
            txtEmail.Size = new Size(220, 34);
            txtEmail.Font = fontInput;
            txtEmail.BackColor = bgInput;
            txtEmail.ForeColor = textPrimary;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;

            // Row 2: HourlyRate | Save | Cancel
            int row2y = 90, row2inp = 112;

            lblFormRate.Text = "Hourly Rate (BDT)"; lblFormRate.ForeColor = textMuted;
            lblFormRate.Font = fontLabel; lblFormRate.Location = new Point(col1, row2y);
            lblFormRate.Size = new Size(220, 20); lblFormRate.Name = "lblFormRate";

            numHourlyRate.Name = "numHourlyRate";
            numHourlyRate.Location = new Point(col1, row2inp);
            numHourlyRate.Size = new Size(200, 34);
            numHourlyRate.Font = fontInput;
            numHourlyRate.BackColor = bgInput;
            numHourlyRate.ForeColor = textPrimary;
            numHourlyRate.Minimum = 0;
            numHourlyRate.Maximum = 99999;
            numHourlyRate.DecimalPlaces = 2;
            numHourlyRate.BorderStyle = BorderStyle.FixedSingle;

            btnSaveTrainer.Name = "btnSaveTrainer";
            btnSaveTrainer.Text = "Save Trainer";
            btnSaveTrainer.Font = fontBtn;
            btnSaveTrainer.ForeColor = Color.White;
            btnSaveTrainer.BackColor = orange;
            btnSaveTrainer.FlatStyle = FlatStyle.Flat;
            btnSaveTrainer.FlatAppearance.BorderSize = 0;
            btnSaveTrainer.Size = new Size(140, 36);
            btnSaveTrainer.Location = new Point(col2, row2inp);
            btnSaveTrainer.Cursor = Cursors.Hand;

            btnCancelForm.Name = "btnCancelForm";
            btnCancelForm.Text = "Cancel";
            btnCancelForm.Font = fontBtn;
            btnCancelForm.ForeColor = textMuted;
            btnCancelForm.BackColor = bgBtn;
            btnCancelForm.FlatStyle = FlatStyle.Flat;
            btnCancelForm.FlatAppearance.BorderColor = border;
            btnCancelForm.FlatAppearance.BorderSize = 1;
            btnCancelForm.Size = new Size(100, 36);
            btnCancelForm.Location = new Point(col2 + 152, row2inp);
            btnCancelForm.Cursor = Cursors.Hand;

            panelForm.Controls.AddRange(new Control[] {
                lblFormFullName, txtFullName,
                lblFormSpec,     txtSpecialization,
                lblFormPhone,    txtPhone,
                lblFormEmail,    txtEmail,
                lblFormRate,     numHourlyRate,
                btnSaveTrainer,  btnCancelForm
            });

            // ═══ SECTION — SHIFT MANAGEMENT ══════════════════════════════════
            lblSectionShift.Text = "Shift Management";
            lblSectionShift.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSectionShift.ForeColor = orange;
            lblSectionShift.Location = new Point(30, 666);
            lblSectionShift.Size = new Size(220, 28);
            lblSectionShift.Name = "lblSectionShift";

            panelShift.Name = "panelShift";
            panelShift.Location = new Point(30, 700);
            panelShift.Size = new Size(1510, 320);
            panelShift.BackColor = bgPanel;
            panelShift.BorderStyle = BorderStyle.FixedSingle;

            // Shift form controls
            lblFormShiftName.Text = "Shift Name"; lblFormShiftName.ForeColor = textMuted;
            lblFormShiftName.Font = fontLabel; lblFormShiftName.Location = new Point(16, 16);
            lblFormShiftName.Size = new Size(220, 20); lblFormShiftName.Name = "lblFormShiftName";

            txtShiftName.Name = "txtShiftName";
            txtShiftName.Location = new Point(16, 40);
            txtShiftName.Size = new Size(220, 34);
            txtShiftName.Font = fontInput;
            txtShiftName.BackColor = bgInput;
            txtShiftName.ForeColor = textPrimary;
            txtShiftName.BorderStyle = BorderStyle.FixedSingle;
            txtShiftName.PlaceholderText = "e.g. Morning";

            lblFormShiftStart.Text = "Start Time"; lblFormShiftStart.ForeColor = textMuted;
            lblFormShiftStart.Font = fontLabel; lblFormShiftStart.Location = new Point(256, 16);
            lblFormShiftStart.Size = new Size(180, 20); lblFormShiftStart.Name = "lblFormShiftStart";

            dtpShiftStart.Name = "dtpShiftStart";
            dtpShiftStart.Location = new Point(256, 40);
            dtpShiftStart.Size = new Size(180, 34);
            dtpShiftStart.Font = fontInput;
            dtpShiftStart.Format = DateTimePickerFormat.Time;
            dtpShiftStart.ShowUpDown = true;
            dtpShiftStart.CalendarForeColor = textPrimary;

            lblFormShiftEnd.Text = "End Time"; lblFormShiftEnd.ForeColor = textMuted;
            lblFormShiftEnd.Font = fontLabel; lblFormShiftEnd.Location = new Point(456, 16);
            lblFormShiftEnd.Size = new Size(180, 20); lblFormShiftEnd.Name = "lblFormShiftEnd";

            dtpShiftEnd.Name = "dtpShiftEnd";
            dtpShiftEnd.Location = new Point(456, 40);
            dtpShiftEnd.Size = new Size(180, 34);
            dtpShiftEnd.Font = fontInput;
            dtpShiftEnd.Format = DateTimePickerFormat.Time;
            dtpShiftEnd.ShowUpDown = true;

            btnAddShift.Name = "btnAddShift";
            btnAddShift.Text = "+ Add Shift";
            btnAddShift.Font = fontBtn;
            btnAddShift.ForeColor = Color.White;
            btnAddShift.BackColor = orange;
            btnAddShift.FlatStyle = FlatStyle.Flat;
            btnAddShift.FlatAppearance.BorderSize = 0;
            btnAddShift.Size = new Size(120, 36);
            btnAddShift.Location = new Point(656, 40);
            btnAddShift.Cursor = Cursors.Hand;

            btnDeleteShift.Name = "btnDeleteShift";
            btnDeleteShift.Text = "Delete Shift";
            btnDeleteShift.Font = fontBtn;
            btnDeleteShift.ForeColor = Color.FromArgb(231, 76, 60);
            btnDeleteShift.BackColor = bgBtn;
            btnDeleteShift.FlatStyle = FlatStyle.Flat;
            btnDeleteShift.FlatAppearance.BorderColor = Color.FromArgb(231, 76, 60);
            btnDeleteShift.FlatAppearance.BorderSize = 1;
            btnDeleteShift.Size = new Size(120, 36);
            btnDeleteShift.Location = new Point(786, 40);
            btnDeleteShift.Cursor = Cursors.Hand;
            btnDeleteShift.Enabled = false;

            // Shift DataGridView
            dgvShifts.Name = "dgvShifts";
            dgvShifts.Location = new Point(16, 96);
            dgvShifts.Size = new Size(1476, 210);
            dgvShifts.BackgroundColor = bgPanel;
            dgvShifts.GridColor = border;
            dgvShifts.BorderStyle = BorderStyle.None;
            dgvShifts.DefaultCellStyle.BackColor = bgPanel;
            dgvShifts.DefaultCellStyle.ForeColor = textPrimary;
            dgvShifts.DefaultCellStyle.Font = fontInput;
            dgvShifts.DefaultCellStyle.SelectionBackColor = Color.FromArgb(232, 119, 34, 60);
            dgvShifts.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvShifts.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            dgvShifts.ColumnHeadersDefaultCellStyle.ForeColor = orange;
            dgvShifts.ColumnHeadersDefaultCellStyle.Font = fontBtn;
            dgvShifts.ColumnHeadersHeight = 36;
            dgvShifts.RowTemplate.Height = 34;
            dgvShifts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvShifts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvShifts.MultiSelect = false;
            dgvShifts.ReadOnly = true;
            dgvShifts.AllowUserToAddRows = false;
            dgvShifts.AllowUserToDeleteRows = false;
            dgvShifts.RowHeadersVisible = false;
            dgvShifts.EnableHeadersVisualStyles = false;
            dgvShifts.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(35, 35, 35);

            panelShift.Controls.AddRange(new Control[] {
                lblFormShiftName, txtShiftName,
                lblFormShiftStart, dtpShiftStart,
                lblFormShiftEnd,   dtpShiftEnd,
                btnAddShift, btnDeleteShift,
                dgvShifts
            });

            // ═══ SECTION — SLOT MANAGEMENT ═══════════════════════════════════
            lblSectionSlot.Text = "Slot Management";
            lblSectionSlot.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSectionSlot.ForeColor = orange;
            lblSectionSlot.Location = new Point(30, 1044);
            lblSectionSlot.Size = new Size(220, 28);
            lblSectionSlot.Name = "lblSectionSlot";

            panelSlot.Name = "panelSlot";
            panelSlot.Location = new Point(30, 1078);
            panelSlot.Size = new Size(1510, 340);
            panelSlot.BackColor = bgPanel;
            panelSlot.BorderStyle = BorderStyle.FixedSingle;

            // Slot form controls
            lblFormSlotShift.Text = "Shift"; lblFormSlotShift.ForeColor = textMuted;
            lblFormSlotShift.Font = fontLabel; lblFormSlotShift.Location = new Point(16, 16);
            lblFormSlotShift.Size = new Size(200, 20); lblFormSlotShift.Name = "lblFormSlotShift";

            cmbSlotShift.Name = "cmbSlotShift";
            cmbSlotShift.Location = new Point(16, 40);
            cmbSlotShift.Size = new Size(200, 34);
            cmbSlotShift.Font = fontInput;
            cmbSlotShift.BackColor = bgInput;
            cmbSlotShift.ForeColor = textPrimary;
            cmbSlotShift.FlatStyle = FlatStyle.Flat;
            cmbSlotShift.DropDownStyle = ComboBoxStyle.DropDownList;

            lblFormDay.Text = "Day of Week"; lblFormDay.ForeColor = textMuted;
            lblFormDay.Font = fontLabel; lblFormDay.Location = new Point(236, 16);
            lblFormDay.Size = new Size(200, 20); lblFormDay.Name = "lblFormDay";

            cmbDayOfWeek.Name = "cmbDayOfWeek";
            cmbDayOfWeek.Location = new Point(236, 40);
            cmbDayOfWeek.Size = new Size(200, 34);
            cmbDayOfWeek.Font = fontInput;
            cmbDayOfWeek.BackColor = bgInput;
            cmbDayOfWeek.ForeColor = textPrimary;
            cmbDayOfWeek.FlatStyle = FlatStyle.Flat;
            cmbDayOfWeek.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDayOfWeek.Items.AddRange(new object[] {
                "Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday"
            });

            lblFormSlotTime.Text = "Slot Time"; lblFormSlotTime.ForeColor = textMuted;
            lblFormSlotTime.Font = fontLabel; lblFormSlotTime.Location = new Point(456, 16);
            lblFormSlotTime.Size = new Size(180, 20); lblFormSlotTime.Name = "lblFormSlotTime";

            dtpSlotTime.Name = "dtpSlotTime";
            dtpSlotTime.Location = new Point(456, 40);
            dtpSlotTime.Size = new Size(180, 34);
            dtpSlotTime.Font = fontInput;
            dtpSlotTime.Format = DateTimePickerFormat.Time;
            dtpSlotTime.ShowUpDown = true;

            btnAddSlot.Name = "btnAddSlot";
            btnAddSlot.Text = "+ Add Slot";
            btnAddSlot.Font = fontBtn;
            btnAddSlot.ForeColor = Color.White;
            btnAddSlot.BackColor = orange;
            btnAddSlot.FlatStyle = FlatStyle.Flat;
            btnAddSlot.FlatAppearance.BorderSize = 0;
            btnAddSlot.Size = new Size(120, 36);
            btnAddSlot.Location = new Point(656, 40);
            btnAddSlot.Cursor = Cursors.Hand;

            btnDeleteSlot.Name = "btnDeleteSlot";
            btnDeleteSlot.Text = "Delete Slot";
            btnDeleteSlot.Font = fontBtn;
            btnDeleteSlot.ForeColor = Color.FromArgb(231, 76, 60);
            btnDeleteSlot.BackColor = bgBtn;
            btnDeleteSlot.FlatStyle = FlatStyle.Flat;
            btnDeleteSlot.FlatAppearance.BorderColor = Color.FromArgb(231, 76, 60);
            btnDeleteSlot.FlatAppearance.BorderSize = 1;
            btnDeleteSlot.Size = new Size(120, 36);
            btnDeleteSlot.Location = new Point(786, 40);
            btnDeleteSlot.Cursor = Cursors.Hand;
            btnDeleteSlot.Enabled = false;

            // Slot DataGridView
            dgvSlots.Name = "dgvSlots";
            dgvSlots.Location = new Point(16, 96);
            dgvSlots.Size = new Size(1476, 230);
            dgvSlots.BackgroundColor = bgPanel;
            dgvSlots.GridColor = border;
            dgvSlots.BorderStyle = BorderStyle.None;
            dgvSlots.DefaultCellStyle.BackColor = bgPanel;
            dgvSlots.DefaultCellStyle.ForeColor = textPrimary;
            dgvSlots.DefaultCellStyle.Font = fontInput;
            dgvSlots.DefaultCellStyle.SelectionBackColor = Color.FromArgb(232, 119, 34, 60);
            dgvSlots.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvSlots.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            dgvSlots.ColumnHeadersDefaultCellStyle.ForeColor = orange;
            dgvSlots.ColumnHeadersDefaultCellStyle.Font = fontBtn;
            dgvSlots.ColumnHeadersHeight = 36;
            dgvSlots.RowTemplate.Height = 34;
            dgvSlots.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSlots.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSlots.MultiSelect = false;
            dgvSlots.ReadOnly = true;
            dgvSlots.AllowUserToAddRows = false;
            dgvSlots.AllowUserToDeleteRows = false;
            dgvSlots.RowHeadersVisible = false;
            dgvSlots.EnableHeadersVisualStyles = false;
            dgvSlots.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(35, 35, 35);

            panelSlot.Controls.AddRange(new Control[] {
                lblFormSlotShift, cmbSlotShift,
                lblFormDay,       cmbDayOfWeek,
                lblFormSlotTime,  dtpSlotTime,
                btnAddSlot, btnDeleteSlot,
                dgvSlots
            });

            // ═══ ROOT CONTROL ════════════════════════════════════════════════
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(0, 1450);
            BackColor = bgPage;
            Name = "EmpTrainerControl";
            Size = new Size(1567, 1713);

            Controls.AddRange(new Control[] {
                headinglbl,
                lblSubtitle,
                lblSectionTrainer,
                panelTrainerList,
                lblSectionForm,
                panelForm,
                lblSectionShift,
                panelShift,
                lblSectionSlot,
                panelSlot
            });

            ResumeLayout(false);
        }

        #endregion

        // ── Control declarations ─────────────────────────────────────────────
        private Label headinglbl;
        private Label lblSubtitle;
        private Label lblSectionTrainer;
        private Label lblSectionForm;
        private Label lblSectionShift;
        private Label lblSectionSlot;

        private Panel panelTrainerList;
        private FlowLayoutPanel flowTrainerCards;
        private Button btnAddTrainer;
        private Button btnEditTrainer;
        private Button btnDeleteTrainer;

        private Panel panelForm;
        private Label lblFormFullName;
        private TextBox txtFullName;
        private Label lblFormSpec;
        private TextBox txtSpecialization;
        private Label lblFormPhone;
        private TextBox txtPhone;
        private Label lblFormEmail;
        private TextBox txtEmail;
        private Label lblFormRate;
        private NumericUpDown numHourlyRate;
        private Button btnSaveTrainer;
        private Button btnCancelForm;

        private Panel panelShift;
        private Label lblFormShiftName;
        private TextBox txtShiftName;
        private Label lblFormShiftStart;
        private DateTimePicker dtpShiftStart;
        private Label lblFormShiftEnd;
        private DateTimePicker dtpShiftEnd;
        private Button btnAddShift;
        private Button btnDeleteShift;
        private DataGridView dgvShifts;

        private Panel panelSlot;
        private Label lblFormDay;
        private ComboBox cmbDayOfWeek;
        private Label lblFormSlotTime;
        private DateTimePicker dtpSlotTime;
        private Label lblFormSlotShift;
        private ComboBox cmbSlotShift;
        private Button btnAddSlot;
        private Button btnDeleteSlot;
        private DataGridView dgvSlots;
    }
}

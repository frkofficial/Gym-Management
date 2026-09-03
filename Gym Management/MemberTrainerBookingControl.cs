//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Gym_Management
//{
//    public partial class MemberTrainerControl : UserControl
//    {
//        Form previousform;
//        int Mid;
//        public MemberTrainerControl(Form previousform,int mid)
//        {
//            InitializeComponent();
//            this.previousform=previousform;
//            this.Mid = mid;
//        }

//        private void MemberTrainerControl_Load(object sender, EventArgs e)
//        {

//        }
//    }
//}
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Gym_Management.Entities;
using Gym_Management.Repo;

namespace Gym_Management
{
    public partial class MemberTrainerBookingControl : UserControl
    {
        // ── Dependencies & state ─────────────────────────────────────────────
        // private readonly UserRepository _repo;
        private readonly TrainerRepo _repo = new TrainerRepo();
        private readonly int _customerId;
        Form previousform;
        private int _selectedTrainerId = -1;
        private string _selectedDay = "";
        private int _selectedSlotId = -1;

        private Panel _selectedTrainerCard = null;
        private Button _selectedDayBtn = null;
        private Button _selectedSlotBtn = null;

        // ── Colours (reused across all builders) ─────────────────────────────
        private static readonly Color BgPage = Color.FromArgb(20, 20, 20);
        private static readonly Color BgCard = Color.FromArgb(35, 35, 35);
        private static readonly Color BgCardSel = Color.FromArgb(42, 28, 12);
        private static readonly Color BgInput = Color.FromArgb(40, 40, 40);
        private static readonly Color Orange = Color.FromArgb(232, 119, 34);
        private static readonly Color TextPri = Color.FromArgb(220, 220, 220);
        private static readonly Color TextMuted = Color.FromArgb(140, 140, 140);
        private static readonly Color SlotTaken = Color.FromArgb(28, 28, 28);
        private static readonly Color SlotText = Color.FromArgb(70, 70, 70);

        // ── Constructor ──────────────────────────────────────────────────────
        public MemberTrainerBookingControl(Form previousform, int customerId)
        {
            this.previousform = previousform;
            //            this.Mid = mid;
            _customerId = customerId;
            InitializeComponent();
            LoadTrainers();
        }

        // ════════════════════════════════════════════════════════════════════
        // STEP 1 — TRAINER CARDS
        // ════════════════════════════════════════════════════════════════════

        private void LoadTrainers()
        {
            flowTrainerCards.Controls.Clear();
            _selectedTrainerId = -1;
            _selectedTrainerCard = null;

            var trainers = _repo.GetActiveTrainers();
            foreach (var t in trainers)
                flowTrainerCards.Controls.Add(BuildTrainerCard(t));

            ClearDays();
            ClearSlots();
        }

        /// <summary>
        /// Builds one trainer card that exactly matches the screenshot style:
        /// avatar circle → name → specialization → stars → shift/rate tags.
        /// </summary>
        private Panel BuildTrainerCard(TrainerDto t)
        {
            // Outer card
            var card = new Panel();
            card.Size = new Size(520, 280);
            card.Margin = new Padding(0, 0, 16, 16);
            card.BackColor = BgCard;
            card.Cursor = Cursors.Hand;
            card.Tag = t.Id;
            card.Paint += CardPaint;          // rounded corners + border
            card.Click += TrainerCard_Click;

            // Avatar circle
            var avatar = new Panel();
            avatar.Size = new Size(64, 64);
            avatar.Location = new Point(20, 20);
            avatar.BackColor = AvatarColor(t.FullName);
            avatar.Cursor = Cursors.Hand;
            avatar.Tag = t.Id;
            avatar.Paint += AvatarPaint;        // circle clip
            avatar.Click += TrainerCard_Click;

            var lblInitials = new Label();
            lblInitials.Text = Initials(t.FullName);
            lblInitials.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblInitials.ForeColor = Color.White;
            lblInitials.TextAlign = ContentAlignment.MiddleCenter;
            lblInitials.Dock = DockStyle.Fill;
            lblInitials.Cursor = Cursors.Hand;
            lblInitials.Tag = t.Id;
            lblInitials.Click += TrainerCard_Click;
            avatar.Controls.Add(lblInitials);

            // Checkmark badge (hidden until selected)
            var check = new Panel();
            check.Size = new Size(28, 28);
            check.Location = new Point(card.Width - 44, 16);
            check.BackColor = Orange;
            check.Visible = false;
            check.Name = "check";
            check.Paint += CheckPaint;

            // Name
            var lblName = new Label();
            lblName.Text = t.FullName;
            lblName.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblName.ForeColor = TextPri;
            lblName.AutoSize = true;
            lblName.Location = new Point(20, 100);
            lblName.Cursor = Cursors.Hand;
            lblName.Tag = t.Id;
            lblName.Click += TrainerCard_Click;

            // Specialization
            var lblSpec = new Label();
            lblSpec.Text = t.Specialization;
            lblSpec.Font = new Font("Segoe UI", 9F);
            lblSpec.ForeColor = TextMuted;
            lblSpec.AutoSize = true;
            lblSpec.Location = new Point(20, 130);
            lblSpec.Cursor = Cursors.Hand;
            lblSpec.Tag = t.Id;
            lblSpec.Click += TrainerCard_Click;

            // Stars
            var lblStars = new Label();
            lblStars.Text = BuildStars(t.Rating) + $"  {t.Rating:F1}";
            lblStars.Font = new Font("Segoe UI", 9F);
            lblStars.ForeColor = Orange;
            lblStars.AutoSize = true;
            lblStars.Location = new Point(20, 158);
            lblStars.Cursor = Cursors.Hand;
            lblStars.Tag = t.Id;
            lblStars.Click += TrainerCard_Click;

            // Tag strip: shifts + rate
            var tagFlow = new FlowLayoutPanel();
            tagFlow.Location = new Point(16, 200);
            tagFlow.Size = new Size(480, 50);
            tagFlow.BackColor = BgCard;
            tagFlow.FlowDirection = FlowDirection.LeftToRight;
            tagFlow.WrapContents = true;
            tagFlow.Cursor = Cursors.Hand;
            tagFlow.Tag = t.Id;
            tagFlow.Click += TrainerCard_Click;

            foreach (var shiftName in t.ShiftNames)
                tagFlow.Controls.Add(BuildTag(shiftName, isOrange: shiftName == "Morning"));

            tagFlow.Controls.Add(BuildTag($"{t.HourlyRate:N0} BDT/hr", isOrange: false));

            card.Controls.Add(avatar);
            card.Controls.Add(check);
            card.Controls.Add(lblName);
            card.Controls.Add(lblSpec);
            card.Controls.Add(lblStars);
            card.Controls.Add(tagFlow);
            return card;
        }

        private void TrainerCard_Click(object sender, EventArgs e)
        {
            // Find root card panel regardless of which child was clicked
            Control c = sender as Control;
            while (c != null && !(c is Panel p && p.Tag is int))
                c = c.Parent;
            if (c == null) return;

            int trainerId = (int)c.Tag;

            // De-select previous card
            if (_selectedTrainerCard != null)
            {
                _selectedTrainerCard.BackColor = BgCard;
                _selectedTrainerCard.Controls["check"].Visible = false;
                _selectedTrainerCard.Invalidate();
            }

            // Select new card
            _selectedTrainerId = trainerId;
            _selectedTrainerCard = FindCardById(trainerId);
            if (_selectedTrainerCard != null)
            {
                _selectedTrainerCard.BackColor = BgCardSel;
                _selectedTrainerCard.Controls["check"].Visible = true;
                _selectedTrainerCard.Invalidate();
            }

            // Update slots label to show trainer name
            //var trainer = _repo.GetTrainerById(trainerId);
            lblSectionSlots.Text = "AVAILABLE SLOTS";

            LoadDays(trainerId);
            ClearSlots();
        }

        // ════════════════════════════════════════════════════════════════════
        // STEP 2 — DAY PILLS
        // ════════════════════════════════════════════════════════════════════

        private void LoadDays(int trainerId)
        {
            flowDayPills.Controls.Clear();
            _selectedDay = "";
            _selectedDayBtn = null;

            var days = _repo.GetAvailableDaysForTrainer(trainerId);
            foreach (var day in days)
            {
                var btn = new Button();
                btn.Text = day.Substring(0, 3);   // "Monday" → "Mon"
                btn.Tag = day;
                btn.Size = new Size(80, 44);
                btn.Margin = new Padding(0, 0, 10, 0);
                btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
                btn.ForeColor = TextMuted;
                btn.BackColor = Color.FromArgb(40, 40, 40);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
                btn.FlatAppearance.BorderSize = 1;
                btn.Cursor = Cursors.Hand;
                btn.Click += DayPill_Click;
                StyleAsRoundBtn(btn, radius: 22);
                flowDayPills.Controls.Add(btn);
            }
        }

        private void DayPill_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn == null) return;

            // De-select previous pill
            if (_selectedDayBtn != null)
            {
                _selectedDayBtn.BackColor = Color.FromArgb(40, 40, 40);
                _selectedDayBtn.ForeColor = TextMuted;
                _selectedDayBtn.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            }

            // Select new pill
            _selectedDay = btn.Tag.ToString();
            _selectedDayBtn = btn;
            btn.BackColor = Orange;
            btn.ForeColor = Color.White;
            btn.FlatAppearance.BorderColor = Orange;

            // Update slots label
            lblSectionSlots.Text = $"AVAILABLE SLOTS — {_selectedDay.ToUpper()}";

            LoadSlots(_selectedTrainerId, _selectedDay);
        }

        private void ClearDays()
        {
            flowDayPills.Controls.Clear();
            _selectedDay = "";
            _selectedDayBtn = null;
        }

        // ════════════════════════════════════════════════════════════════════
        // STEP 3 — SLOT BUTTONS
        // ════════════════════════════════════════════════════════════════════

        private void LoadSlots(int trainerId, string day)
        {
            flowSlots.Controls.Clear();
            _selectedSlotId = -1;
            _selectedSlotBtn = null;

            var slots = _repo.GetSlotsForTrainerAndDay(trainerId, day);

            if (slots.Count == 0)
            {
                var lbl = new Label();
                lbl.Text = "No slots available for this day.";
                lbl.ForeColor = TextMuted;
                lbl.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
                lbl.AutoSize = true;
                lbl.Margin = new Padding(4, 12, 0, 0);
                flowSlots.Controls.Add(lbl);
                return;
            }

            foreach (var slot in slots)
            {
                var btn = new Button();
                btn.Text = slot.SlotTime.ToString(@"h\:mm tt");
                btn.Tag = slot.Id;
                btn.Size = new Size(250, 56);
                btn.Margin = new Padding(0, 0, 12, 12);
                btn.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
                btn.FlatStyle = FlatStyle.Flat;
                btn.Cursor = Cursors.Hand;

                if (slot.IsBooked)
                {
                    // Taken — greyed out, strikethrough text, not clickable
                    btn.Text = slot.SlotTime.ToString(@"h\:mm tt");
                    btn.Font = new Font("Segoe UI", 11F, FontStyle.Strikeout);
                    btn.BackColor = SlotTaken;
                    btn.ForeColor = SlotText;
                    btn.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
                    btn.FlatAppearance.BorderSize = 1;
                    btn.Enabled = false;
                }
                else
                {
                    // Available
                    btn.BackColor = Color.FromArgb(40, 40, 40);
                    btn.ForeColor = TextPri;
                    btn.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 70);
                    btn.FlatAppearance.BorderSize = 1;
                    btn.Click += SlotBtn_Click;
                }

                flowSlots.Controls.Add(btn);
            }
        }

        private void SlotBtn_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn == null) return;

            // De-select previous slot
            if (_selectedSlotBtn != null)
            {
                _selectedSlotBtn.BackColor = Color.FromArgb(40, 40, 40);
                _selectedSlotBtn.ForeColor = TextPri;
                _selectedSlotBtn.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 70);
            }

            // Select new slot
            _selectedSlotId = (int)btn.Tag;
            _selectedSlotBtn = btn;
            btn.BackColor = Orange;
            btn.ForeColor = Color.White;
            btn.FlatAppearance.BorderColor = Orange;
        }

        private void ClearSlots()
        {
            flowSlots.Controls.Clear();
            _selectedSlotId = -1;
            _selectedSlotBtn = null;
            lblSectionSlots.Text = "AVAILABLE SLOTS";
        }

        // ════════════════════════════════════════════════════════════════════
        // PUBLIC — called by parent form's Confirm button
        // ════════════════════════════════════════════════════════════════════

        /// <summary>Returns true when trainer + day + slot are all chosen.</summary>
        public bool IsSelectionComplete() =>
            _selectedTrainerId != -1 &&
            !string.IsNullOrEmpty(_selectedDay) &&
            _selectedSlotId != -1;

        public (int TrainerId, string Day, int SlotId) GetSelection() =>
            (_selectedTrainerId, _selectedDay, _selectedSlotId);

        // ════════════════════════════════════════════════════════════════════
        // PAINT HELPERS — rounded corners, avatar circle, checkmark
        // ════════════════════════════════════════════════════════════════════

        private void CardPaint(object sender, PaintEventArgs e)
        {
            var p = sender as Panel;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            bool selected = p.BackColor == BgCardSel;
            using var pen = new Pen(selected ? Orange : Color.FromArgb(55, 55, 55), selected ? 2f : 1f);
            var rect = new Rectangle(1, 1, p.Width - 2, p.Height - 2);
            using var path = RoundedRect(rect, 12);
            e.Graphics.DrawPath(pen, path);
        }

        private void AvatarPaint(object sender, PaintEventArgs e)
        {
            var p = sender as Panel;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using var brush = new SolidBrush(p.BackColor);
            e.Graphics.FillEllipse(brush, 0, 0, p.Width, p.Height);
        }

        private void CheckPaint(object sender, PaintEventArgs e)
        {
            var p = sender as Panel;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using var brush = new SolidBrush(Orange);
            e.Graphics.FillEllipse(brush, 0, 0, p.Width, p.Height);
            using var pen = new Pen(Color.White, 2.5f);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            e.Graphics.DrawLines(pen, new PointF[] {
                new PointF(7, 14), new PointF(12, 20), new PointF(21, 9)
            });
        }

        // ════════════════════════════════════════════════════════════════════
        // SMALL UI HELPERS
        // ════════════════════════════════════════════════════════════════════

        private Label BuildTag(string text, bool isOrange)
        {
            var lbl = new Label();
            lbl.Text = text;
            lbl.Font = new Font("Segoe UI", 8.5F);
            lbl.ForeColor = isOrange ? Orange : TextMuted;
            lbl.BackColor = Color.FromArgb(50, 50, 50);
            lbl.AutoSize = false;
            lbl.Size = new Size(TextRenderer.MeasureText(text, lbl.Font).Width + 20, 28);
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Margin = new Padding(0, 0, 8, 0);
            lbl.Cursor = Cursors.Hand;
            return lbl;
        }

        private void StyleAsRoundBtn(Button btn, int radius)
        {
            var rect = new Rectangle(0, 0, btn.Width, btn.Height);
            var path = RoundedRect(rect, radius);
            btn.Region = new Region(path);
        }

        private static GraphicsPath RoundedRect(Rectangle r, int radius)
        {
            var path = new GraphicsPath();
            path.AddArc(r.X, r.Y, radius * 2, radius * 2, 180, 90);
            path.AddArc(r.Right - radius * 2, r.Y, radius * 2, radius * 2, 270, 90);
            path.AddArc(r.Right - radius * 2, r.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(r.X, r.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
            path.CloseFigure();
            return path;
        }

        private Panel FindCardById(int trainerId)
        {
            foreach (Control c in flowTrainerCards.Controls)
                if (c is Panel p && p.Tag is int id && id == trainerId)
                    return p;
            return null;
        }

        private static string Initials(string fullName)
        {
            var parts = fullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 0) return "?";
            if (parts.Length == 1) return parts[0].Substring(0, 1).ToUpper();
            return $"{parts[0][0]}{parts[^1][0]}".ToUpper();
        }

        private static string BuildStars(decimal rating)
        {
            int full = (int)Math.Floor((double)rating);
            bool half = (rating - full) >= 0.5m;
            return new string('★', full) + (half ? "☆" : "") + new string('☆', 5 - full - (half ? 1 : 0));
        }

        private static readonly Color[] AvatarPalette = {
            Color.FromArgb(70, 90, 110),
            Color.FromArgb(60, 100, 90),
            Color.FromArgb(100, 70, 110),
            Color.FromArgb(110, 75, 60),
            Color.FromArgb(70, 100, 60),
        };

        private static Color AvatarColor(string name) =>
            AvatarPalette[Math.Abs(name.GetHashCode()) % AvatarPalette.Length];
    }

    // ════════════════════════════════════════════════════════════════════════
    // DTOs — simple data carriers returned by UserRepository
    // ════════════════════════════════════════════════════════════════════════

    //public class TrainerDto
    //{
    //    public int Id { get; set; }
    //    public string FullName { get; set; }
    //    public string Specialization { get; set; }
    //    public decimal HourlyRate { get; set; }
    //    public decimal Rating { get; set; }   // e.g. 4.9
    //    public List<string> ShiftNames { get; set; }   // ["Morning","Evening"]
    //}

    //public class SlotDto
    //{
    //    public int Id { get; set; }
    //    public TimeSpan SlotTime { get; set; }
    //    public bool IsBooked { get; set; }
    //}
}
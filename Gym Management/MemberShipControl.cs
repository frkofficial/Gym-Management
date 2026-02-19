
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym_Management.Entities;
using Gym_Management.Repo;

namespace Gym_Management
{
    public partial class MemberShipControl : UserControl
    {
        MembershipRepo membershiprepo;
        DataAccess access;
        private List<MembershipPackage> membershipCards;
        private FlowLayoutPanel cardsPanel;
        private const int CARD_WIDTH = 323;
        private const int CARD_HEIGHT = 425;

        public MemberShipControl()
        {
            InitializeComponent();
            
            access = new DataAccess();
            membershiprepo = new MembershipRepo();
        }

        private void InitializeMembershipCards()
        {

            membershipCards = membershiprepo.GetAll();
        //    membershipCards = new List<MembershipPackage>
        //    {
        //        new MembershipCard(1, "Regular Monthly", 2000, 2000,
        //            "One-time admission fee of 2000 BDT applies for each month.", false, 1),
        //        new MembershipCard(2, "Student Monthly", 1500, 1500,
        //            "For students with valid ID. One-time admission fee of 1500 BDT applies.", true, 1),
        //        new MembershipCard(3, "6 Month Package", 10000, 0,
        //            "Includes admission fee. Get 6 months of full access for a one-time payment.", false, 6),
        //        new MembershipCard(4, "1 Year Package", 20000, 0,
        //            "Includes admission fee. Lock in a full year of fitness and save big!", false, 12)
        //    };
        }

        private void MemberShipControl_Load(object sender, EventArgs e)
        {
            SetupDynamicCardsPanel();
            InitializeMembershipCards();
            DisplayCards();
        }

        private void SetupDynamicCardsPanel()
        {
            // Create FlowLayoutPanel for dynamic cards
            cardsPanel = new FlowLayoutPanel
            {
                Location = new Point(10, 10),
                Size = new Size(this.Width - 20, this.Height - 20),
                AutoScroll = true,
                BackColor = ColorTranslator.FromHtml("#1a1a1a"),
                Padding = new Padding(0),
                WrapContents = true
            };
            this.Controls.Add(cardsPanel);
            cardsPanel.BringToFront();

            // Handle resize
            this.Resize += (s, e) =>
            {
                if (cardsPanel != null)
                {
                    cardsPanel.Size = new Size(this.Width - 20, this.Height - 20);
                }
            };
        }

        private void DisplayCards()
        {
            cardsPanel.Controls.Clear();

            // Display existing cards
            foreach (var card in membershipCards)
            {
                Panel cardPanel = CreateCardPanel(card);
                cardsPanel.Controls.Add(cardPanel);
            }

            // Add "+" button card
            Panel addCard = CreateAddCardPanel();
            cardsPanel.Controls.Add(addCard);
        }

        private Panel CreateCardPanel(MembershipPackage card)
        {
            Panel cardPanel = new Panel
            {
                Size = new Size(CARD_WIDTH, CARD_HEIGHT),
                BackColor = ColorTranslator.FromHtml("#2a2a2a"),
                Margin = new Padding(33),
                Cursor = Cursors.Hand,
                Tag = card
            };

            // Border paint
            cardPanel.Paint += (s, e) =>
            {
                using (Pen pen = new Pen(ColorTranslator.FromHtml("#ff4d00"), 2))
                {
                    e.Graphics.DrawRectangle(pen, 0, 0, cardPanel.Width - 1, cardPanel.Height - 1);
                }
            };

            // Card name
            Label nameLabel = new Label
            {
                Text = card.Name,
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = false,
                Size = new Size(CARD_WIDTH - 40, 60),
                Location = new Point(20, 20),
                TextAlign = ContentAlignment.TopLeft
            };
            cardPanel.Controls.Add(nameLabel);

            // Price
            Label priceLabel = new Label
            {
                Text = card.Price.ToString("N0"),
                Font = new Font("Segoe UI", 32, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(20, 70)
            };
            cardPanel.Controls.Add(priceLabel);

            Label currencyLabel = new Label
            {
                Text = "BDT/month",
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.LightGray,
                AutoSize = true,
                Location = new Point(190, 150)
            };
            cardPanel.Controls.Add(currencyLabel);


            // Admission Fee Label
            Label admissionLabel = new Label
            {
                Text = card.AdmissionFee > 0
                    ? $"Admission: {card.AdmissionFee:N0} BDT"+"\n(one-time)"
                    : "No admission fee",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = card.AdmissionFee > 0
                    ? ColorTranslator.FromHtml("#ff4d00")
                    : ColorTranslator.FromHtml("#4CAF50"),
                AutoSize = true,
                Location = new Point(20, 180)
            };
            cardPanel.Controls.Add(admissionLabel);


            // Description
            Label descLabel = new Label
            {
                Text = card.Description,
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.LightGray,
                AutoSize = false,
                Size = new Size(CARD_WIDTH - 40, 100),
                Location = new Point(20, 240)
            };
            cardPanel.Controls.Add(descLabel);

            // Inquiry Button
            Button inquiryBtn = new Button
            {
                Text = "Inquiry",
                Size = new Size(CARD_WIDTH - 40, 45),
                Location = new Point(20, CARD_HEIGHT - 70),
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = ColorTranslator.FromHtml("#2a2a2a"),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                Tag = card
            };
            inquiryBtn.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#ff4d00");
            inquiryBtn.FlatAppearance.BorderSize = 2;
            inquiryBtn.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#ff4d00");

            inquiryBtn.MouseEnter += (s, e) =>
            {
                inquiryBtn.ForeColor = Color.Black;
            };
            inquiryBtn.MouseLeave += (s, e) =>
            {
                inquiryBtn.ForeColor = Color.White;
            };
            inquiryBtn.Click += InquiryBtn_Click;

            cardPanel.Controls.Add(inquiryBtn);


            // Edit Button
            Button editBtn = new Button
            {
                Text = "✎",
                Size = new Size(30, 30),
                Location = new Point(CARD_WIDTH - 80, 10),
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = ColorTranslator.FromHtml("#4CAF50"),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                Tag = card
            };
            editBtn.FlatAppearance.BorderSize = 0;
            editBtn.Click += EditBtn_Click;
            cardPanel.Controls.Add(editBtn);

            // Delete Button
            Button deleteBtn = new Button
            {
                Text = "×",
                Size = new Size(30, 30),
                Location = new Point(CARD_WIDTH - 40, 10),
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = ColorTranslator.FromHtml("#ff4d00"),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                Tag = card
            };
            deleteBtn.FlatAppearance.BorderSize = 0;
            deleteBtn.Click += DeleteBtn_Click;
            cardPanel.Controls.Add(deleteBtn);

            // Hover effect
            cardPanel.MouseEnter += (s, e) =>
            {
                cardPanel.BackColor = ColorTranslator.FromHtml("#333333");
            };
            cardPanel.MouseLeave += (s, e) =>
            {
                cardPanel.BackColor = ColorTranslator.FromHtml("#2a2a2a");
            };

            return cardPanel;
        }

        private Panel CreateAddCardPanel()
        {
            Panel addPanel = new Panel
            {
                Size = new Size(CARD_WIDTH, CARD_HEIGHT),
                BackColor = ColorTranslator.FromHtml("#2a2a2a"),
                Margin = new Padding(33),
                Cursor = Cursors.Hand
            };

            // Dashed border
            addPanel.Paint += (s, e) =>
            {
                using (Pen pen = new Pen(ColorTranslator.FromHtml("#ff4d00"), 2))
                {
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    e.Graphics.DrawRectangle(pen, 0, 0, addPanel.Width - 1, addPanel.Height - 1);
                }
            };

            // Plus sign
            Label plusLabel = new Label
            {
                Text = "+",
                Font = new Font("Segoe UI", 60, FontStyle.Bold),
                ForeColor = ColorTranslator.FromHtml("#ff4d00"),
                AutoSize = true,
                Location = new Point(CARD_WIDTH / 2 - 65, CARD_HEIGHT / 2 - 80),
                Cursor = Cursors.Hand
            };
            addPanel.Controls.Add(plusLabel);

            // Text
            Label addText = new Label
            {
                Text = "Add New Card",
                Font = new Font("Segoe UI", 14),
                ForeColor = Color.LightGray,
                AutoSize = true,
                Location = new Point(CARD_WIDTH / 2 - 100, CARD_HEIGHT / 2 - 113),
                Cursor = Cursors.Hand
            };
            addPanel.Controls.Add(addText);

            // Click event
            addPanel.Click += (s, e) => ShowAddCardForm();
            plusLabel.Click += (s, e) => ShowAddCardForm();
            addText.Click += (s, e) => ShowAddCardForm();

            // Hover effect
            addPanel.MouseEnter += (s, e) =>
            {
                addPanel.BackColor = ColorTranslator.FromHtml("#333333");
                addPanel.Invalidate();
            };
            addPanel.MouseLeave += (s, e) =>
            {
                addPanel.BackColor = ColorTranslator.FromHtml("#2a2a2a");
                addPanel.Invalidate();
            };

            return addPanel;
        }

        private void InquiryBtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn?.Tag is MembershipPackage card)
            {
                MemberShipInquiry mi = new MemberShipInquiry(this, card.Name, card.Price, card.Duration);
                mi.ShowDialog();
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is MembershipPackage card)
            {
                EditMembershipCardForm form = new EditMembershipCardForm(card);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    card.Name = form.CardName;
                    card.Price = form.CardPrice;
                    card.AdmissionFee = form.AdmissionFee;
                    card.Description = form.CardDescription;
                    card.IsStudentPlan = form.IsStudentPlan;
                    card.Duration= form.Duration;

                    membershiprepo.Update(card);
                    InitializeMembershipCards();
                    DisplayCards();
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is MembershipPackage card)
            {
                var confirm = MessageBox.Show(
                    $"Delete {card.Name} ?",
                    "Confirm",
                    MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    membershiprepo.Delete(card.Id);
                    InitializeMembershipCards();
                    DisplayCards();
                }
            }
        }

        private void ShowAddCardForm()
        {
            AddMembershipCardForm addForm = new AddMembershipCardForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                MembershipPackage newPackage = new MembershipPackage
                {
                    Name = addForm.CardName,
                    Price = addForm.CardPrice,
                    AdmissionFee = addForm.AdmissionFee,
                    Description = addForm.CardDescription,
                    IsStudentPlan = addForm.IsStudentPlan,
                    Duration = addForm.DurationMonths
                };

                membershiprepo.Insert(newPackage);
                InitializeMembershipCards();
                DisplayCards();

            }
        }

        // Keep your original event handlers for backwards compatibility
        private void Inquirybtn1_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button btn)
                btn.ForeColor = Color.Black;
        }

        private void Inquirybtn1_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button btn)
                btn.ForeColor = Color.White;
        }

        private void Inquirybtn1_Click(object sender, EventArgs e)
        {
            MemberShipInquiry mi = new MemberShipInquiry(this, "Regular Monthly", 2000, 1);
            mi.ShowDialog();
        }

        private void Inquirybtn2_Click(object sender, EventArgs e)
        {
            MemberShipInquiry mi = new MemberShipInquiry(this, "Student Monthly", 1500, 1);
            mi.ShowDialog();
        }

        private void Inquirybtn3_Click(object sender, EventArgs e)
        {
            MemberShipInquiry mi = new MemberShipInquiry(this, "6 Month Package", 10000, 6);
            mi.ShowDialog();
        }

        private void Inquirybtn4_Click(object sender, EventArgs e)
        {
            MemberShipInquiry mi = new MemberShipInquiry(this, "1 Year Package", 20000, 12);
            mi.ShowDialog();
        }

        // Public method to refresh cards from outside
        public void RefreshCards()
        {
            DisplayCards();
        }

        // Public method to add a card programmatically
        public void AddCard(MembershipPackage card)
        {
            membershipCards.Add(card);
            DisplayCards();
        }

        // Public method to get all cards
        public List<MembershipPackage> GetAllCards()
        {
            return new List<MembershipPackage>(membershipCards);
        }
    }

    // MembershipCard class
    public class MembershipPackage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal AdmissionFee { get; set; }
        public string Description { get; set; }
        public bool IsStudentPlan { get; set; }
        public int Duration { get; set; }

        public MembershipPackage()
        {
        }

        public MembershipPackage(int id, string name, decimal price, decimal admissionFee,
            string description, bool isStudentPlan, int duration)
        {
            Id = id;
            Name = name;
            Price = price;
            AdmissionFee = admissionFee;
            Description = description;
            IsStudentPlan = isStudentPlan;
            Duration = duration;
        }

        public override string ToString()
        {
            return $"{Name} - {Price:N0} BDT/month";
        }
    }
}
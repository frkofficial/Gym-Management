using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management
{
    public partial class MemberShipControl : UserControl
    {
        public MemberShipControl()
        {
            InitializeComponent();
        }
        private void Inquirybtn1_MouseEnter(object sender, EventArgs e)
        {
            Inquirybtn1.ForeColor = Color.Black;
        }

        private void Inquirybtn1_MouseLeave(object sender, EventArgs e)
        {
            Inquirybtn1.ForeColor = Color.White;
        }
        private void Inquirybtn1_Click(object sender, EventArgs e)
        {
            MemberShipInquiry mi = new MemberShipInquiry(this,"Regular Monthly", 2000, 1);
            mi.ShowDialog();
        }

        private void MemberShipControl_Load(object sender, EventArgs e)
        {
            
        }

        private void Inquirybtn2_Click(object sender, EventArgs e)
        {
            MemberShipInquiry mi = new MemberShipInquiry(this,"Student Monthly", 1500, 1);
            mi.ShowDialog();
        }

        private void Inquirybtn3_Click(object sender, EventArgs e)
        {
            MemberShipInquiry mi = new MemberShipInquiry(this,"6 Month Package", 10000, 6);
            mi.ShowDialog();
        }

        private void Inquirybtn4_Click(object sender, EventArgs e)
        {
            MemberShipInquiry mi= new MemberShipInquiry(this,"1 Year Package",20000, 12);
            mi.ShowDialog();
        }
    }
}

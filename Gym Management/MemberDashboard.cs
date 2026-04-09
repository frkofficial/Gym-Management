using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Data.SqlClient;
using Gym_Management.Entities;
using Gym_Management.Repo;


namespace Gym_Management
{
    public partial class MemberDashboard : UserControl
    {
        DataAccess dataaccess;
        int Mid;
        private Form previousform;
        UserRepo userrepo;

        public MemberDashboard(Form previousform, int Mid)
        {
            InitializeComponent();
            userrepo = new UserRepo();
            this.previousform = previousform;
            this.Mid = Mid;

            dataaccess = new DataAccess();

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MemberDashboard_Load(object sender, EventArgs e)
        {
            string name = userrepo.GetMemberName(Mid);
            MmbrNamelbl.Text = name + "!";

            string packagename = userrepo.GetPackage(Mid);
            pckgelbl.Text = packagename;

            DateTime? expiredate = userrepo.GetExpireDate(Mid);
            if (expiredate.HasValue)
            {
                expirelbl.Text = expiredate.Value.ToString("MMM dd, yyyy");
            }
            else
            {
                expirelbl.Text = "-------";
            }



            string paystatus = userrepo.GetPaymentStatus(Mid);
            paymentlbl.Text = paystatus;

            if (paystatus == "Paid")
            {
                paymentlbl.ForeColor = Color.Green;
            }
            else if (paystatus == "Due")
            {
                //paymentlbl.ForeColor= Color.Red;
                paymentlbl.ForeColor = ColorTranslator.FromHtml("#ff0000");
            }
            else
            {
                //paymentlbl.ForeColor=Color.White;
                paymentlbl.ForeColor = ColorTranslator.FromHtml("#ffffff");
            }

            string trainer = userrepo.GetTrainer(Mid);
            trainerlbl.Text = trainer;



            string status = userrepo.GetStatus(Mid);
            statuslbl.Text = status;

            if (status == "Paid")
            {
                statuslbl.ForeColor = Color.Green;
                statuslbl.Text = "✅Active";
            }
            else
            {
                statuslbl.ForeColor = Color.Red;
                statuslbl.Text = "❌Inactive";
            }



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pckgelbl_Click(object sender, EventArgs e)
        {

        }
    }

}

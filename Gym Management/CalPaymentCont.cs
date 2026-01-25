using Gym_Management.Repo;
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
    public partial class CalPaymentCont : UserControl
    {
        UserRepo userrepo;
        public CalPaymentCont()
        {
            userrepo = new UserRepo();
             
            InitializeComponent();
        }

        private void CalPaymentCont_Load(object sender, EventArgs e)
        {
            LoadPayment();
            LoadEarning();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadPayment()
        {
            try
            {
                DataTable dt = userrepo.AllPayments();
                dataGridView1.DataSource = dt;

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.ReadOnly = true;
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load payment data\n" + ex.Message);
            }
        }

        private void LoadEarning()
        {
            try
            {
                DataTable dt = userrepo.TotalEarningPerCustomer();
                dataGridView2.DataSource = dt;

                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView2.ReadOnly = true;
                dataGridView2.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load earning summary\n" + ex.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using Microsoft.Data.SqlClient;


namespace Gym_Management
{
    public partial class AdminForm : Form
    {
        LoginForm login;
        int adminId;
        SqlConnection con;
        DataAccess access;
        private Form previousform;
        public AdminForm(Form previousform, int adminId)
        {
            InitializeComponent();
            //this.login = login;
            this.adminId = adminId;
            this.previousform = previousform;
            access = new DataAccess();
            this.FormClosing += AdminFormClosing;
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["GymsDB"].ConnectionString;
                con = new SqlConnection(cs);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection init error: " + ex.Message);
            }

        }

        private void LoadControl(UserControl control)
        {
            contentpannel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            contentpannel.Controls.Add(control);
        }
        //private void button1_Click(object sender, EventArgs e) { LoadControl(new MyProfileControl1()); }
        //private void btnmembershipPrice_Click(object sender, EventArgs e) { LoadControl(new MembershipPricingControl()); }
        public void AdminFormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{

        //}

        private void AdminForm_Load(object sender, EventArgs e)
        {
            //HideAllPanels();
            //loaduser();

        }

        //private void loaduser()
        //{
        //    SqlCommand cmd = access.GetCommand(@"SELECT * FROM AdminInfo");
        //    DataTable dt = access.Execute(cmd);
        //    //dgvAdmins.DataSource = dt;


        //}
        //DataAccess base connet
        private void TestDb()
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["GymsDB"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    MessageBox.Show("Database connected successfully");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //void LoadDashboardData()
        //{
        //    LoadTotalCustomers();
        //    //LoadActiveMembers();
        //    //LoadExpiredMembers();
        //    //LoadTotalTrainers();
        //    LoadTotalEmployees();
        //    //LoadMonthlyRevenue();
        //    //LoadTodayJoins();
        //    //LoadExpiringSoon();
        //    LoadAdminList();
        //}

        //to get total customer
        //void LoadTotalCustomers()
        //{
        //    try
        //    {
        //        if (con.State != ConnectionState.Open)
        //            con.Open(); // connection open

        //        SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM UserInfo", con);
        //        int total = (int)cmd.ExecuteScalar();

        //        //lblTotalCustomers.Text = total.ToString();  // Label update 
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error loading total customers: " + ex.Message);
        //    }
        //    finally
        //    {
        //        con.Close(); // connection close
        //    }
        //}

        //void LoadAdminList()
        //{
        //    try
        //    {
        //        if (con.State != ConnectionState.Open)
        //            con.Open(); // connection open

        //        SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM EmpInfo", con);
        //        int total = (int)cmd.ExecuteScalar();

        //        //lblTotalAdmin.Text = total.ToString();  // Label update
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error loading total customers: " + ex.Message);
        //    }
        //    finally
        //    {
        //        con.Close(); // connection close
        //    }
        //}

        //void LoadActiveMembers() { }
        //void LoadExpiredMembers() { }
        //void LoadTotalTrainers() { }
        //void LoadTotalEmployees()
        //{
        //    try
        //    {
        //        if (con.State != ConnectionState.Open)
        //            con.Open(); // connection open

        //        SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM AdminInfo", con);
        //        int total = (int)cmd.ExecuteScalar();

        //        //lblTotalEmployee.Text = total.ToString();  // Label update
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error loading total customers: " + ex.Message);
        //    }
        //    finally
        //    {
        //        con.Close(); // connection close
        //    }
        //}
        //void LoadMonthlyRevenue() { }
        //void LoadTodayJoins() { }
        //void LoadExpiringSoon() { }

        //View admin
        //void LoadAdminTable()
        //{
        //    try
        //    {
        //        if (con.State != ConnectionState.Open)
        //            con.Open();

        //        SqlDataAdapter da = new SqlDataAdapter(
        //            "SELECT AdminId, AdminUserName, Rank, AdminPhone FROM AdminInfo",
        //            con
        //        );

        //        DataTable dt = new DataTable();
        //        da.Fill(dt);

        //        //dgvAdmins.DataSource = dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Admin load error: " + ex.Message);
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}
        //hide pannel
        //void HideAllPanels()
        //{
        //    panelDashboard.Visible = false;
        //    //panelAdminList.Visible = false;
        //    //panelCustomerList.Visible = false;
        //    //panelEmployeeList.Visible = false;
        //}


        //void ClearDashboard()
        //{
        //    lblTotalCustomers.Text = "";
        //    lblTotalAdmin.Text = "";
        //    lblTotalEmployee.Text = "";
        //}


        ////dashboard click
        //private void dashboardbutton_Click(object sender, EventArgs e)
        //{

        //    MessageBox.Show("Dashboard clicked"); // Debug: check click works
        //    HideAllPanels();
        //    panelDashboard.Visible = true;
        //    panelDashboard.BringToFront();  // ensure panel is on top
        //    //ClearDashboard();

        //    try
        //    {
        //        LoadDashboardData();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error loading dashboard: " + ex.Message);
        //    }

        //}


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalCustomers_Click(object sender, EventArgs e)
        {

        }

        private void adminListbutton_Click(object sender, EventArgs e)
        {
            LoadControl(new Admincontrol());
            //HideAllPanels();
            ////panelAdminList.Visible = true;
            //LoadAdminTable();
        }

        private void CustomerListbutton_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeListbutton_Click(object sender, EventArgs e)
        {
            LoadControl(new employeecontrol());
            //panelDashboard.Visible = true;
            //LoadDashboardData();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomerListbutton_Click_1(object sender, EventArgs e)
        {
            LoadControl(new customercontrol());
            //LoadControl(new dashboard());
        }

        private void dashboardbutton_Click(object sender, EventArgs e)
        {
            //panelDashboard.Visible = true;
            LoadControl(new dashboardcontrol());
        }

        private void Packagesbutton_Click(object sender, EventArgs e)
        {
            LoadControl(new packagescontrol());
        }

        private void Logoutbutton_Click(object sender, EventArgs e)
        {
            previousform.Show();
            this.Hide();
        }
    }
}




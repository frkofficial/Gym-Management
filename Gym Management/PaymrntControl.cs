using Azure;
using Gym_Management.Entities;
using Gym_Management.Repo;
using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Microsoft.Data.SqlClient;


namespace Gym_Management
{
    public partial class PaymrntControl : UserControl
    {
        UserRepo userrepo;
        DataAccess dataaccess;
        private Form previousform;
        int customerId;
        decimal totalAmount;
        string cusname;
        string transactionid;
        decimal packageAmount;
        decimal trainerPrice;
        string selectedPaymentMethod;
        decimal subtotal,vat;
        FlowLayoutPanel flowSummary;
        public PaymrntControl(Form previousform,int Mid)
        {
            InitializeComponent();
            userrepo = new UserRepo();
            dataaccess = new DataAccess();
            this.previousform=previousform;
            this.customerId = Mid;

            flowSummary = new FlowLayoutPanel();
            flowSummary.Location = new Point(1108, 333);
            flowSummary.Size = new Size(350, 400);
            flowSummary.AutoScroll = true;
            flowSummary.FlowDirection = FlowDirection.TopDown;
            flowSummary.WrapContents = false;

            this.Controls.Add(flowSummary);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private async void PaymrntControl_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            //paydtp.Value = DateTime.Now;

            LoadCustomerDetails(customerId);
            LoadSummary(customerId);

            webViewpayment.EnsureCoreWebView2Async(null);
            if (webViewpayment.CoreWebView2 != null)
            {

                webViewpayment.CoreWebView2.NavigationStarting += CoreWebView2_NavigationStarting;
            }

            // Make fields readonly
            //cnametxt.ReadOnly = true;
            //packtxt.ReadOnly = true;
            //trainertxt.ReadOnly = true;
            //totalamount.ReadOnly = true;
            //changeamounttxt.ReadOnly = true;

            // Clear initial values
            //  ClearForm();
        }

        private void LoadComboBoxes()
        {
            // Payment Method ComboBox
            //methodcmb.Items.Clear();
            //methodcmb.Items.Add("Cash");
            //methodcmb.Items.Add("Card");
            //methodcmb.Items.Add("Bank Transfer");
            //methodcmb.Items.Add("bKash");
            //methodcmb.Items.Add("Nagad");
            //methodcmb.Items.Add("Rocket");
            //methodcmb.SelectedIndex = 0;
        }

        private void webViewpayment_Click(object sender, EventArgs e)
        {

        }
        private void LoadCustomerDetails(int customerId)
        {
            try
            {
                // Get Customer Name
                var data = userrepo.GetCustomerName(customerId);
                 cusname= data.CusName;
                string packname = data.PackName;

                if (string.IsNullOrEmpty(packname))
                {
                    MessageBox.Show("Customer not found!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                pckgname.Text = packname.ToUpper();

                // Get Package Amount
                 packageAmount = userrepo.GetPackageAmountByCustomer(customerId);
                //pckamount.Text = packageAmount.ToString("N2");

                // Get Trainer Price
                 trainerPrice = userrepo.GetTrainerPriceByCustomer(customerId);
                //trainertxt.Text = trainerPrice.ToString("N2");

                // Calculate Total
                 totalAmount = packageAmount + trainerPrice;
                pckamount.Text = totalAmount.ToString("N2");

                // Show breakdown
                amountlbl.Text = $"Package: {packageAmount:N2} BDT + Trainer: {trainerPrice:N2} BDT";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customer details: {ex.Message}", "Error");
            }
            //subtotal=userrepo.GetVat(customerId);
            //vat=subtotal * 0.10m;
            //userrepo.InsertFee(customerId, "Vat(10%)", vat);
            // ✅ Delete old VAT row first to prevent duplicates
            userrepo.DeleteFeeByType(customerId, "Vat(10%)");

            // ✅ GetVat now sums only package + trainer rows (not previous VAT)
            subtotal = userrepo.GetVat(customerId);
            vat = subtotal * 0.10m;

            if (vat > 0)
                userrepo.InsertFee(customerId, "Vat(10%)", vat);

        }
        private Panel CreateRow(string title, string amount, bool isBold = false)
        {
            Panel row = new Panel();
            row.Width = 320;
            row.Height = 30;
            row.Margin = new Padding(0, 5, 0, 5);

            Label lblTitle = new Label();
            lblTitle.Text = title;
            lblTitle.ForeColor = Color.White;
            lblTitle.AutoSize = false;
            lblTitle.Width = 200;
            lblTitle.Height = 25;
            lblTitle.Location = new Point(0, 5);

            Label lblAmount = new Label();
            lblAmount.Text = amount;
            lblAmount.ForeColor = Color.White;
            lblAmount.AutoSize = false;
            lblAmount.Width = 100;
            lblAmount.Height = 25;
            lblAmount.TextAlign = ContentAlignment.MiddleRight;
            lblAmount.Location = new Point(210, 5);

            if (isBold)
            {
                lblTitle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                lblAmount.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            }

            row.Controls.Add(lblTitle);
            row.Controls.Add(lblAmount);

            return row;
        }

        private Panel CreateDivider()
        {
            Panel line = new Panel();
            line.Height = 2;
            line.Width = 320;
            line.BackColor = Color.Gray;
            line.Margin = new Padding(0, 10, 0, 10);
            return line;
        }
        decimal SummaryTotal = 0;
        private void LoadSummary(int customerId)
        {
            decimal summaryTotal = 0;
            flowSummary.Controls.Clear();
            var items = userrepo.GetPaymentBreakdown(customerId);
            foreach( var item in items)
            {
                flowSummary.Controls.Add(CreateRow(item.Name, item.Amount.ToString()));
                summaryTotal += item.Amount;
            }
            flowSummary.Controls.Add(CreateDivider() );
            flowSummary.Controls.Add(CreateRow("Total", summaryTotal.ToString()));
            SummaryTotal = summaryTotal;
        }
        private async void cardbtn_Click(object sender, EventArgs e)
        {
            selectedPaymentMethod="Card";
            await StartPayment("card",totalAmount,cusname);

        }

        private async void  mobilebankbtn_Click(object sender, EventArgs e)
        {
            selectedPaymentMethod= "Mobile Banking";
            await StartPayment("mobilebanking",totalAmount,cusname);
        }

        private async void netbankbtn_Click(object sender, EventArgs e)
        {
            selectedPaymentMethod= "Net Banking";
           await StartPayment("netbanking",totalAmount,cusname);
        }
        private async Task StartPayment(string paymentType,decimal totalAmount,string cusname)
        {
            transactionid = Guid.NewGuid().ToString();
            var client = new HttpClient();

            var values = new Dictionary<string, string>()
    {
        {"store_id", "testbox"},
        {"store_passwd", "qwerty"},
        {"total_amount", totalAmount.ToString()},
        {"currency", "BDT"},
        {"tran_id", transactionid},
        {"success_url", "https://sandbox.sslcommerz.com/demo/success.php"},
        {"fail_url", "https://sandbox.sslcommerz.com/demo/fail.php"},
        {"cancel_url", "https://sandbox.sslcommerz.com/demo/cancel.php"},
        {"cus_name",cusname },
        {"cus_email", "test@email.com"},
        {"cus_add1", "Dhaka"},
        {"cus_phone", "01700000000"},
        {"product_name", "Gym Membership"},
        {"product_category", "Fitness"},
        {"product_profile", "general"},
        
         {"allowed_payment_methods", paymentType}
    };

            var content = new FormUrlEncodedContent(values);

            var response = await client.PostAsync(
                "https://sandbox.sslcommerz.com/gwprocess/v4/api.php",
                content);

            var json = await response.Content.ReadAsStringAsync();

            dynamic result = Newtonsoft.Json.JsonConvert.DeserializeObject(json);

            if (result.status == "SUCCESS")
            {
                string paymentUrl = result.GatewayPageURL;
                webViewpayment.CoreWebView2.Navigate(paymentUrl);

            }
            else
            {
                MessageBox.Show("Payment failed: " + result.failedreason);
            }
        }

        private void CoreWebView2_NavigationStarting(object sender,
    Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs e)
        {
            string url = e.Uri.ToLower();

            if (url.Contains("success"))
            {
                MessageBox.Show("✅ Payment Successful");
                Payment p = new Payment()
                {
                    CustomerID = customerId,
                    CustomerName = cusname,
                    PackageName = pckgname.Text,
                    PackageAmount =  packageAmount,
                       TrainerPriceAmount =  trainerPrice,
                       TotalAmount= totalAmount,
                       TransactionID=transactionid,
                       PayingDate = DateTime.Now,
                    Status = "Paid",
                       PaymentMethod = selectedPaymentMethod


                };
                var result=userrepo.InsertPayment(p);

            }
            else if (url.Contains("fail"))
            {
                MessageBox.Show("❌ Payment Failed");
            }
            else if (url.Contains("cancel"))
            {
                MessageBox.Show("⚠️ Payment Cancelled");
            }
        }


        //private void cidtxt_TextChanged(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(cidtxt.Text))
        //    {
        //        ClearCustomerFields();
        //        return;
        //    }

        //    if (int.TryParse(cidtxt.Text, out int customerId))
        //    {
        //        LoadCustomerDetails(customerId);
        //    }
        //}

        
        //private void CalculateChange()
        //{
        //    if (string.IsNullOrWhiteSpace(totalamount.Text) ||
        //        string.IsNullOrWhiteSpace(payamounttxt.Text))
        //    {
        //        changeamounttxt.Clear();
        //        return;
        //    }

        //    if (decimal.TryParse(totalamount.Text.Replace(",", ""), out decimal total) &&
        //        decimal.TryParse(payamounttxt.Text, out decimal paid))
        //    {
        //        decimal change = paid - total;
        //        changeamounttxt.Text = change.ToString("N2");

        //        if (change < 0)
        //        {
        //            changeamounttxt.ForeColor = Color.Red;
        //            changelbl.Text = "Insufficient Amount!";
        //            changelbl.ForeColor = Color.Red;
        //        }
        //        else
        //        {
        //            changeamounttxt.ForeColor = Color.Lime;
        //            changelbl.Text = "Change to Return";
        //            changelbl.ForeColor = Color.Lime;
        //        }
        //    }
        //}

        //private void payamounttxt_TextChanged(object sender, EventArgs e)
        //{
        //    CalculateChange();
        //}

        //private void Process_Click(object sender, EventArgs e)
        //{
        //    if (!ValidatePayment()) return;

        //    try
        //    {
        //        decimal totalAmount = decimal.Parse(totalamount.Text.Replace(",", ""));
        //        decimal amountPaid = decimal.Parse(payamounttxt.Text);

        //        if (amountPaid < totalAmount)
        //        {
        //            MessageBox.Show("Amount paid is less than total amount!", "Error",
        //                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }

        //Payment payment = new Payment();
        //payment.CustomerID = int.Parse(cidtxt.Text.Trim());
        //payment.CustomerName = cnametxt.Text.Trim();
        //payment.PackageAmount = decimal.Parse(packtxt.Text.Replace(",", ""));
        //payment.TrainerPriceAmount = decimal.Parse(trainertxt.Text.Replace(",", ""));
        //payment.TotalAmount = totalAmount;
        //payment.PayingDate = paydtp.Value;
        //payment.Status = "Paid";
        //payment.PaymentMethod = methodcmb.SelectedItem.ToString();

        //int result = userrepo.InsertPayment(payment);

        //if (result > 0)
        //{
        //    // Show success message with details
        //    string message = $"Payment Successful!\n\n" +
        //                   $"Customer: {payment.CustomerName}\n" +
        //                   $"Total Amount: {totalAmount:N2} BDT\n" +
        //                   $"Amount Paid: {amountPaid:N2} BDT\n" +
        //                   $"Change: {(amountPaid - totalAmount):N2} BDT\n" +
        //                   $"Payment Method: {payment.PaymentMethod}\n" +
        //                   $"Date: {payment.PayingDate.ToShortDateString()}";

        //            MessageBox.Show(message, "Payment Successful",
        //                MessageBoxButtons.OK, MessageBoxIcon.Information);

        //            // Ask if want to print receipt
        //            DialogResult printResult = MessageBox.Show(
        //                "Do you want to print receipt?",
        //                "Print Receipt",
        //                MessageBoxButtons.YesNo,
        //                MessageBoxIcon.Question
        //            );

        //            if (printResult == DialogResult.Yes)
        //            {
        //                PrintReceipt(payment, amountPaid);
        //            }

        //            ClearForm();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Payment failed. Please try again.", "Error",
        //                MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error processing payment: {ex.Message}", "Error",
        //            MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void PrintReceipt(Payment payment, decimal amountPaid)
        //{
        //    // Simple receipt display - you can enhance this with actual printing
        //    string receipt = "========================================\n" +
        //                   "      STAMINA FITNESS CENTER\n" +
        //                   "           PAYMENT RECEIPT\n" +
        //                   "========================================\n\n" +
        //                   $"Date: {payment.PayingDate.ToShortDateString()}\n" +
        //                   $"Receipt No: {DateTime.Now.ToString("yyyyMMddHHmmss")}\n\n" +
        //                   $"Customer ID: {payment.CustomerID}\n" +
        //                   $"Customer Name: {payment.CustomerName}\n\n" +
        //                   "----------------------------------------\n" +
        //                   $"Package Amount:        {payment.PackageAmount,10:N2}\n" +
        //                   $"Trainer Amount:        {payment.TrainerPriceAmount,10:N2}\n" +
        //                   "----------------------------------------\n" +
        //                   $"Total Amount:          {payment.TotalAmount,10:N2}\n" +
        //                   $"Amount Paid:           {amountPaid,10:N2}\n" +
        //                   $"Change:                {(amountPaid - payment.TotalAmount),10:N2}\n\n" +
        //                   $"Payment Method: {payment.PaymentMethod}\n\n" +
        //                   "========================================\n" +
        //                   "      Thank you for your payment!\n" +
        //                   "========================================";

        //    MessageBox.Show(receipt, "Payment Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

        //private bool ValidatePayment()
        //{
        //    if (string.IsNullOrWhiteSpace(cidtxt.Text))
        //    {
        //        MessageBox.Show("Please enter Customer ID", "Validation Error",
        //            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        cidtxt.Focus();
        //        return false;
        //    }

        //    if (string.IsNullOrWhiteSpace(cnametxt.Text))
        //    {
        //        MessageBox.Show("Customer not found", "Validation Error",
        //            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        cidtxt.Focus();
        //        return false;
        //    }

        //    if (string.IsNullOrWhiteSpace(totalamount.Text) ||
        //        decimal.Parse(totalamount.Text.Replace(",", "")) == 0)
        //    {
        //        MessageBox.Show("No payment amount found for this customer", "Validation Error",
        //            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return false;
        //    }

        //    if (string.IsNullOrWhiteSpace(payamounttxt.Text))
        //    {
        //        MessageBox.Show("Please enter amount paid", "Validation Error",
        //            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        payamounttxt.Focus();
        //        return false;
        //    }

        //    if (!decimal.TryParse(payamounttxt.Text, out _))
        //    {
        //        MessageBox.Show("Amount paid must be a valid number", "Validation Error",
        //            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        payamounttxt.Focus();
        //        return false;
        //    }

        //    return true;
        //}

        //private void ClearForm()
        //{
        //    cidtxt.Clear();
        //    ClearCustomerFields();
        //    payamounttxt.Clear();
        //    changeamounttxt.Clear();
        //    amountlbl.Text = "";
        //    changelbl.Text = "";
        //    paydtp.Value = DateTime.Now;
        //    methodcmb.SelectedIndex = 0;
        //    cidtxt.Focus();
        //}
        //private void ClearCustomerFields()
        //{
        //    cnametxt.Clear();
        //    packtxt.Clear();
        //    trainertxt.Clear();
        //    totalamount.Clear();
        //    amountlbl.Text = "";
        //}

        //private void label11_Click(object sender, EventArgs e)
        //{

        //}

        //private void label12_Click(object sender, EventArgs e)
        //{

        //}

        //private void button2_Click(object sender, EventArgs e)
        //{

        //}
    }
}

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
    public partial class PaymrntControl : UserControl
    {
        UserRepo userrepo;
        public PaymrntControl()
        {
            InitializeComponent();
            userrepo = new UserRepo();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void PaymrntControl_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            paydtp.Value = DateTime.Now;

            // Make fields readonly
            cnametxt.ReadOnly = true;
            packtxt.ReadOnly = true;
            trainertxt.ReadOnly = true;
            totalamount.ReadOnly = true;
            changeamounttxt.ReadOnly = true;

            // Clear initial values
            ClearForm();
        }

        private void LoadComboBoxes()
        {
            // Payment Method ComboBox
            methodcmb.Items.Clear();
            methodcmb.Items.Add("Cash");
            methodcmb.Items.Add("Card");
            methodcmb.Items.Add("Bank Transfer");
            methodcmb.Items.Add("bKash");
            methodcmb.Items.Add("Nagad");
            methodcmb.Items.Add("Rocket");
            methodcmb.SelectedIndex = 0;
        }

        private void cidtxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cidtxt.Text))
            {
                ClearCustomerFields();
                return;
            }

            if (int.TryParse(cidtxt.Text, out int customerId))
            {
                LoadCustomerDetails(customerId);
            }
        }

        private void LoadCustomerDetails(int customerId)
        {
            try
            {
                // Get Customer Name
                string customerName = userrepo.GetCustomerName(customerId);

                if (string.IsNullOrEmpty(customerName))
                {
                    MessageBox.Show("Customer not found!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearCustomerFields();
                    return;
                }

                cnametxt.Text = customerName;

                // Get Package Amount
                decimal packageAmount = userrepo.GetPackageAmountByCustomer(customerId);
                packtxt.Text = packageAmount.ToString("N2");

                // Get Trainer Price
                decimal trainerPrice = userrepo.GetTrainerPriceByCustomer(customerId);
                trainertxt.Text = trainerPrice.ToString("N2");

                // Calculate Total
                decimal totalAmount = packageAmount + trainerPrice;
                totalamount.Text = totalAmount.ToString("N2");

                // Show breakdown
                amountlbl.Text = $"Package: {packageAmount:N2} BDT + Trainer: {trainerPrice:N2} BDT";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customer details: {ex.Message}", "Error");
            }
        }
        private void CalculateChange()
        {
            if (string.IsNullOrWhiteSpace(totalamount.Text) ||
                string.IsNullOrWhiteSpace(payamounttxt.Text))
            {
                changeamounttxt.Clear();
                return;
            }

            if (decimal.TryParse(totalamount.Text.Replace(",", ""), out decimal total) &&
                decimal.TryParse(payamounttxt.Text, out decimal paid))
            {
                decimal change = paid - total;
                changeamounttxt.Text = change.ToString("N2");

                if (change < 0)
                {
                    changeamounttxt.ForeColor = Color.Red;
                    changelbl.Text = "Insufficient Amount!";
                    changelbl.ForeColor = Color.Red;
                }
                else
                {
                    changeamounttxt.ForeColor = Color.Lime;
                    changelbl.Text = "Change to Return";
                    changelbl.ForeColor = Color.Lime;
                }
            }
        }

        private void payamounttxt_TextChanged(object sender, EventArgs e)
        {
            CalculateChange();
        }

        private void Process_Click(object sender, EventArgs e)
        {
            if (!ValidatePayment()) return;

            try
            {
                decimal totalAmount = decimal.Parse(totalamount.Text.Replace(",", ""));
                decimal amountPaid = decimal.Parse(payamounttxt.Text);

                if (amountPaid < totalAmount)
                {
                    MessageBox.Show("Amount paid is less than total amount!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Payment payment = new Payment();
                payment.CustomerID = int.Parse(cidtxt.Text.Trim());
                payment.CustomerName = cnametxt.Text.Trim();
                payment.PackageAmount = decimal.Parse(packtxt.Text.Replace(",", ""));
                payment.TrainerPriceAmount = decimal.Parse(trainertxt.Text.Replace(",", ""));
                payment.TotalAmount = totalAmount;
                payment.PayingDate = paydtp.Value;
                payment.Status = "Paid";
                payment.PaymentMethod = methodcmb.SelectedItem.ToString();

                int result = userrepo.InsertPayment(payment);

                if (result > 0)
                {
                    // Show success message with details
                    string message = $"Payment Successful!\n\n" +
                                   $"Customer: {payment.CustomerName}\n" +
                                   $"Total Amount: {totalAmount:N2} BDT\n" +
                                   $"Amount Paid: {amountPaid:N2} BDT\n" +
                                   $"Change: {(amountPaid - totalAmount):N2} BDT\n" +
                                   $"Payment Method: {payment.PaymentMethod}\n" +
                                   $"Date: {payment.PayingDate.ToShortDateString()}";

                    MessageBox.Show(message, "Payment Successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Ask if want to print receipt
                    DialogResult printResult = MessageBox.Show(
                        "Do you want to print receipt?",
                        "Print Receipt",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (printResult == DialogResult.Yes)
                    {
                        PrintReceipt(payment, amountPaid);
                    }

                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Payment failed. Please try again.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing payment: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintReceipt(Payment payment, decimal amountPaid)
        {
            // Simple receipt display - you can enhance this with actual printing
            string receipt = "========================================\n" +
                           "      STAMINA FITNESS CENTER\n" +
                           "           PAYMENT RECEIPT\n" +
                           "========================================\n\n" +
                           $"Date: {payment.PayingDate.ToShortDateString()}\n" +
                           $"Receipt No: {DateTime.Now.ToString("yyyyMMddHHmmss")}\n\n" +
                           $"Customer ID: {payment.CustomerID}\n" +
                           $"Customer Name: {payment.CustomerName}\n\n" +
                           "----------------------------------------\n" +
                           $"Package Amount:        {payment.PackageAmount,10:N2}\n" +
                           $"Trainer Amount:        {payment.TrainerPriceAmount,10:N2}\n" +
                           "----------------------------------------\n" +
                           $"Total Amount:          {payment.TotalAmount,10:N2}\n" +
                           $"Amount Paid:           {amountPaid,10:N2}\n" +
                           $"Change:                {(amountPaid - payment.TotalAmount),10:N2}\n\n" +
                           $"Payment Method: {payment.PaymentMethod}\n\n" +
                           "========================================\n" +
                           "      Thank you for your payment!\n" +
                           "========================================";

            MessageBox.Show(receipt, "Payment Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ValidatePayment()
        {
            if (string.IsNullOrWhiteSpace(cidtxt.Text))
            {
                MessageBox.Show("Please enter Customer ID", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cidtxt.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cnametxt.Text))
            {
                MessageBox.Show("Customer not found", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cidtxt.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(totalamount.Text) ||
                decimal.Parse(totalamount.Text.Replace(",", "")) == 0)
            {
                MessageBox.Show("No payment amount found for this customer", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(payamounttxt.Text))
            {
                MessageBox.Show("Please enter amount paid", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                payamounttxt.Focus();
                return false;
            }

            if (!decimal.TryParse(payamounttxt.Text, out _))
            {
                MessageBox.Show("Amount paid must be a valid number", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                payamounttxt.Focus();
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            cidtxt.Clear();
            ClearCustomerFields();
            payamounttxt.Clear();
            changeamounttxt.Clear();
            amountlbl.Text = "";
            changelbl.Text = "";
            paydtp.Value = DateTime.Now;
            methodcmb.SelectedIndex = 0;
            cidtxt.Focus();
        }
        private void ClearCustomerFields()
        {
            cnametxt.Clear();
            packtxt.Clear();
            trainertxt.Clear();
            totalamount.Clear();
            amountlbl.Text = "";
        }

    }
}

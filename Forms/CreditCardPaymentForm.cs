using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Webshop.Classes;

namespace Webshop.Forms
{
    public partial class CreditCardPaymentForm : Form
    {
        private Cart _cart;
        public CreditCardPaymentForm(Cart cart)
        {
            InitializeComponent();
            _cart = cart;
            PopulateComboBoxes();
        }

        private void btnSubmitPayment_Click(object sender, EventArgs e)
        {
            // Collect credit card information
            string cardNumber = txtCardNumber.Text;
            string cardholderName = txtCardholderName.Text;
            string expirationMonth = cmbExpirationMonth.SelectedItem.ToString();
            string expirationYear = cmbExpirationYear.SelectedItem.ToString();
            string cvv = txtCVV.Text;

            // Validate and process payment (this is a placeholder, implement actual payment processing)
            if (ValidatePaymentDetails(cardNumber, cardholderName, expirationMonth, expirationYear, cvv))
            {
                MessageBox.Show("Betalningen gick igenom!");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Invalid payment details. Please try again.");
            }
        }

        private void PopulateComboBoxes()
        {
            for (int month = 1; month <= 12; month++)
            {
                cmbExpirationMonth.Items.Add(month.ToString("D2"));
            }

            int currenYear = DateTime.Now.Year;
            for (int year = currenYear; year <= currenYear + 10; year++)
            {
                cmbExpirationYear.Items.Add(year.ToString());
            }
        }

        private bool ValidatePaymentDetails(string cardNumber, string cardholderName, string expirationMonth, string expirationYear, string cvv)
        {
            if (string.IsNullOrWhiteSpace(cardholderName) || !System.Text.RegularExpressions.Regex.IsMatch(cardholderName, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Ogiltligt kortinnehavarens namn. Vänligen ange kortinnehavarens namn.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(cardNumber) || cardNumber.Length != 16 || !cardNumber.All(char.IsDigit))
            {
                MessageBox.Show("Ogiltligt kortnummer. Vänligen ange ett 16-siffrigt kortnummer.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(expirationMonth))
            {
                MessageBox.Show("Ogiltligt utgångsdatum för månad. Vänligen välj en månad.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(expirationYear))
            {
                MessageBox.Show("Ogiltligt utgångsdatum för år. Vänligen välj ett år.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(cvv) || cvv.Length != 3 || !cvv.All(char.IsDigit))
            {
                MessageBox.Show("Ogiltligt CVV. Vänligen ange ett 3-siffrigt CVV.");
                return false;
            }

            return true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

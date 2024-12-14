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
    public partial class PaymentForm : Form
    {
        private Cart _cart;
        public PaymentForm(Cart cart)
        {
            InitializeComponent();
            _cart = cart;
            lblTotalAmount.Text = _cart.GetTotalPrice().ToString("C");
            LoadInvoiceItems();
        }

        private void LoadInvoiceItems()
        {
            tableLayoutPanelInvoice.Controls.Clear();

            // Configure TableLayoutPanel
            tableLayoutPanelInvoice.RowCount = _cart.GetItems().Count + 1; // Add one for the header row
            tableLayoutPanelInvoice.ColumnCount = 4; // Quantity, Image, Name, Cost
            tableLayoutPanelInvoice.RowStyles.Clear();
            tableLayoutPanelInvoice.ColumnStyles.Clear();

            // Define proportions for columns
            tableLayoutPanelInvoice.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F)); // Quantity
            tableLayoutPanelInvoice.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F)); // Image
            tableLayoutPanelInvoice.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F)); // Name
            tableLayoutPanelInvoice.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F)); // Cost

            // Add header row
            tableLayoutPanelInvoice.Controls.Add(new Label() { Text = "Quantity", Font = new Font("Arial", 10, FontStyle.Bold) }, 0, 0);
            tableLayoutPanelInvoice.Controls.Add(new Label() { Text = "Image", Font = new Font("Arial", 10, FontStyle.Bold) }, 1, 0);
            tableLayoutPanelInvoice.Controls.Add(new Label() { Text = "Name", Font = new Font("Arial", 10, FontStyle.Bold) }, 2, 0);
            tableLayoutPanelInvoice.Controls.Add(new Label() { Text = "Cost", Font = new Font("Arial", 10, FontStyle.Bold) }, 3, 0);

            // Add cart items
            int row = 1;
            foreach (var cartItem in _cart.GetItems())
            {
                // Quantity
                tableLayoutPanelInvoice.Controls.Add(new Label() { Text = cartItem.Quantity.ToString() }, 0, row);

                // Image
                var pictureBox = new PictureBox
                {
                    Image = Image.FromFile(cartItem.Product.ImagePath),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Width = 50,
                    Height = 50
                };
                tableLayoutPanelInvoice.Controls.Add(pictureBox, 1, row);

                // Name
                tableLayoutPanelInvoice.Controls.Add(new Label() { Text = cartItem.Product.Name }, 2, row);

                // Cost
                tableLayoutPanelInvoice.Controls.Add(new Label() { Text = (cartItem.Product.Price * cartItem.Quantity).ToString("C") }, 3, row);

                row++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreditCardPaymentForm creditCardPaymentForm = new CreditCardPaymentForm(_cart);
            creditCardPaymentForm.ShowDialog();
        }
    }
}

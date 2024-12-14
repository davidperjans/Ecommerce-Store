using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Webshop.Cards;
using Webshop.Classes;
using Webshop.Forms;

namespace Webshop.Pages
{
    public partial class CartUC : UserControl
    {
        private Cart _cart;
        public CartUC()
        {
            InitializeComponent();
        }

        public void InitializeData(Cart cart)
        {
            this._cart = cart;
            _cart.CartChanged += _cart_CartChanged;
            LoadCartItems();
        }

        private void _cart_CartChanged(object sender, EventArgs e)
        {
            LoadCartItems();
        }

        private void LoadCartItems()
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                return;
            }

            try
            {
                tableLayoutPanelCartItems.Controls.Clear();

                // Configure TableLayoutPanel
                tableLayoutPanelCartItems.RowCount = 2; // Two rows
                tableLayoutPanelCartItems.ColumnCount = 6; // Six columns
                tableLayoutPanelCartItems.RowStyles.Clear();
                tableLayoutPanelCartItems.ColumnStyles.Clear();

                // Define proportions for rows and columns
                for (int i = 0; i < tableLayoutPanelCartItems.RowCount; i++)
                {
                    tableLayoutPanelCartItems.RowStyles.Add(new RowStyle(SizeType.Percent, 50F)); // 50% per row
                }

                for (int i = 0; i < tableLayoutPanelCartItems.ColumnCount; i++)
                {
                    tableLayoutPanelCartItems.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.67F)); // 16.67% per column
                }

                // Add cart items
                int row = 0;
                int column = 0;
                foreach (var cartItem in _cart.GetItems())
                {
                    var itemCard = new CartItemCard()
                    {
                        Width = 164,
                        Height = 221
                    };

                    itemCard.InitializeData(_cart, cartItem);
                    tableLayoutPanelCartItems.Controls.Add(itemCard, column, row);

                    column++;
                    if (column >= tableLayoutPanelCartItems.ColumnCount)
                    {
                        column = 0;
                        row++;
                    }
                }

                lblTotalPrice.Text = $"Totalpris: {_cart.GetTotalPrice():C}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ett fel uppstod: {ex.Message}");
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (_cart.GetItems().Count == 0)
            {
                MessageBox.Show("Varukorgen är tom. Lägg till produkter för att fortsätta.");
                return;
            }

            PaymentForm paymentForm = new PaymentForm(_cart);
            paymentForm.Show();
        }
    }
}

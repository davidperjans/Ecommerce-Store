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
using Newtonsoft.Json;
using System.IO;

namespace Webshop.Cards
{
    public partial class ItemCard : UserControl
    {
        private Cart _cart;
        private Product _currentProduct;
        public ItemCard(Cart cart)
        {
            InitializeComponent();
            _cart = cart;
        }

        public void SetProduct(Product product)
        {
            _currentProduct = product;

            lblItemName.Text = product.Name;
            lblItemPrice.Text = $"${product.Price}";

            // Ladda bilden från sökvägen
            if (!string.IsNullOrEmpty(product.ImagePath) && File.Exists(product.ImagePath))
            {
                pbItem.Image = Image.FromFile(product.ImagePath);
            }
            else
            {
                pbItem.Image = null; // Hantera fall där bilden inte finns
            }

            nudItem.Value = 1;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            var quantity = (int)nudItem.Value;

            if (_currentProduct != null)
            {
                if (quantity > 0)
                {
                    _cart.AddToCart(_currentProduct, quantity);
                    MessageBox.Show($"Lade till {quantity} x {_currentProduct.Name} i din kassa för ${quantity * _currentProduct.Price}");
                }
                else
                {
                    MessageBox.Show("Vänligen ange en giltig kvantitet.");
                }
            }
        }
    }
}

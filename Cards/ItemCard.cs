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
        public ItemCard()
        {
            InitializeComponent();
        }

        public void SetProduct(Product product)
        {
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
            var name = lblItemName.Text;
            var price = decimal.Parse(lblItemPrice.Text.Trim('$'));

            if (quantity > 0)
            {
                MessageBox.Show($"Lade till {quantity} x {name} i din kassa för ${quantity * price}");
            }
            else
            {
                MessageBox.Show("Vänligen ange en giltig kvantitet.");
            }
        }
    }
}

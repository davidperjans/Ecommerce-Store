using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Webshop.Cards;
using Webshop.Classes;

namespace Webshop.Pages
{
    public partial class ElectronicsUC : UserControl
    {
        private Cart _cart;
        public ElectronicsUC()
        {
            InitializeComponent();
        }

        public void InitializeData(Cart cart)
        {
            _cart = cart;
            if (!DesignMode)
            {
                LoadProducts();
            }
        }

        private void LoadProducts()
        {

            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                return;
            }


            try
            {
                var jsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "products.json");

                //Ladda produkter från json
                var products = JSONHelper.LoadProductsFromJson(jsonPath);

                //Filtrera produkter för elektronik kategorin
                var electronicsProducts = products.Where(product => product.Category == "Electronics");



                // Anpassa TableLayoutPanel
                tableLayoutPanel.RowCount = 2; // Två rader
                tableLayoutPanel.ColumnCount = 4; // Fyra kolumner
                tableLayoutPanel.RowStyles.Clear();
                tableLayoutPanel.ColumnStyles.Clear();

                // Definiera proportioner för rader och kolumner
                for (int i = 0; i < tableLayoutPanel.RowCount; i++)
                {
                    tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F)); // 50% per rad
                }

                for (int i = 0; i < tableLayoutPanel.ColumnCount; i++)
                {
                    tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F)); // 25% per kolumn
                }

                // Lägg till produkter
                foreach (var product in electronicsProducts)
                {
                    var itemCard = new ItemCard(_cart)
                    {
                        Width = 164,
                        Height = 221
                    };
                    itemCard.SetProduct(product);
                    tableLayoutPanel.Controls.Add(itemCard);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ett fel uppstod när produkterna laddades: {ex.Message}");
            }
        }
    }
}

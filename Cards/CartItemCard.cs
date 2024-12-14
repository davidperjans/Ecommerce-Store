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
using Webshop.Classes;

namespace Webshop.Cards
{
    public partial class CartItemCard : UserControl
    {
        private Cart _cart;
        private CartItem _cartItem;
        public CartItemCard()
        {
            InitializeComponent();
        }

        public void InitializeData(Cart cart, CartItem cartItem)
        {
            this._cart = cart;
            this._cartItem = cartItem;
            SetProduct(cartItem.Product);
            lblName.Text = cartItem.Product.Name;
            nudQuantity.Value = cartItem.Quantity;
            lblPrice.Text = (cartItem.Product.Price * cartItem.Quantity).ToString("C");
        }

        public void SetProduct(Product product)
        {
            lblPrice.Text = $"${product.Price}";
            //lblQuantity.Text = product.Quantity;

            // Load image from path
            if (!string.IsNullOrEmpty(product.ImagePath) && File.Exists(product.ImagePath))
            {
                pbImage.Image = Image.FromFile(product.ImagePath);
            }
            else
            {
                pbImage.Image = null; // Handle case where image does not exist
            }
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            int newQuantity = (int)nudQuantity.Value;

            if (newQuantity > _cartItem.Quantity)
            {
                _cart.AddToCart(_cartItem.Product, newQuantity - _cartItem.Quantity);
            }
            else if (newQuantity < _cartItem.Quantity && newQuantity > 0)
            {
                _cart.RemoveFromCart(_cartItem.Product, _cartItem.Quantity - newQuantity);
            }

            if (newQuantity == 0)
            {
                var result = MessageBox.Show("Are you sure you want to remove this item from the cart?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    _cart.RemoveFromCart(_cartItem.Product, _cartItem.Quantity);
                }
                else
                {
                    nudQuantity.Value = _cartItem.Quantity; // Reset to the previous quantity
                }
            }
        }
    }
}

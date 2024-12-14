using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Classes
{
    public class Cart
    {
        private List<CartItem> Items { get; set; } = new List<CartItem>();

        public event EventHandler CartChanged;

        // Lägg till produkt i varukorgen
        public void AddToCart(Product product, int quantity)
        {
            var existingItem = Items.FirstOrDefault(i => i.Product.Name == product.Name);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                Items.Add(new CartItem(product, quantity));
            }
            CartChanged?.Invoke(this, EventArgs.Empty);
        }

        public void RemoveFromCart(Product product, int quantity)
        {
            var item = Items.FirstOrDefault(i => i.Product.Name == product.Name);
            if (item != null)
            {
                item.Quantity -= quantity;
                if (item.Quantity <= 0)
                {
                    Items.Remove(item);
                }
                CartChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public decimal GetTotalPrice()
        {
            return Items.Sum(item => item.Product.Price * item.Quantity);
        }
        public List<CartItem> GetItems()
        {
            return Items;
        }
    }
}

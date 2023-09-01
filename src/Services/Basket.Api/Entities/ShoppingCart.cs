using System.Collections.Generic;

namespace Basket.Api.Entities
{
    public class ShoppingCart
    {
        public string UserName { get; set; }
        public List<ShoppingCartItem> items { get; set; } = new List<ShoppingCartItem>();

        public ShoppingCart() { }
        public ShoppingCart(string userName)
        {
            this.UserName = userName;
        }

        public decimal totalPrice
        {
            get
            {
                decimal totalprice = 0;
                foreach (var item in items)
                {
                    totalprice += item.Price * item.Quantity;
                }
                return totalprice;
            }
        }
    }
}

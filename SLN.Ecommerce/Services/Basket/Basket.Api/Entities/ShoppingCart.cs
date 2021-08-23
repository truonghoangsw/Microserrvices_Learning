using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.Api.Entities
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
            
        }
        public ShoppingCart(string userName)
        {
            UserNamne = userName;
        }
        public List<ShoppingCartItem> Items { get; set; } = new List<ShoppingCartItem>();
        public string UserNamne { get; set; }

        public decimal TotalPrice
        {
            get
            {
                decimal totalprice = 0;
                foreach (var item in Items)
                {
                    totalprice = item.Price * item.Quantity;
                }
                return totalprice;
            }
        }
    }
}

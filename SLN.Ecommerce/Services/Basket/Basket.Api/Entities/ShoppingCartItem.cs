namespace Basket.Api.Entities
{
    public class ShoppingCartItem
    {
        public string ProductName { get; set; }
        public string ProductId { get; set; }
        public decimal Price { get; set; }
        public string Colorr { get; set; }
        public int Quantity { get; set; }
    }
}
namespace FoodCore.Contracts.Product
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set;}
        public int Quantity { get; set; }
        public long UnitPrice { get; set; }
        public int RestaurantId { get; set; }
        public ProductRestaurantSettings Settings { get; set; }
    }
}

using System;
namespace FoodCore.Contracts
{
    public class Restaurant
    {
        public int RestaurantId { get; set; }
        public string RestaurantName { get; set; }
        public Address RestaurantAddress { get; set; }
        public bool IsOpen { get; set; }
    }
}

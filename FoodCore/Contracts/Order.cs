using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ProtoBuf;

namespace FoodCore.Contracts
{
    [ProtoContract]
    [Serializable]
    public class Order
    {
        
        [ProtoMember(1)]
        public string OrderId { get; set; }

        [ProtoMember(2)]
        public string CheckinCode { get; set; }

        [Required]
        [ProtoMember(3)]
        public string CustomerId { get; set; }

        [ProtoMember(4)]
        public long Total { get; set; }

        [Required]
        [ProtoMember(5)]
        public int RestaurantId { get; set; }

        [ProtoMember(6)]
        public List<FoodCore.Contracts.Product.Product> Items { get; set; }

        [Required]
        [ProtoMember(7)]
        public FoodCore.Contracts.Payment.Payment Payment { get; set; }

        [Required]
        [ProtoMember(8)]
        public FoodCore.Enums.OrderType OrderType { get; set; }

        [ProtoMember(9)]
        public FoodCore.Enums.OrderStatus OrderStatus { get; set; }

    }
}

using System;
using ProtoBuf;
using FoodCore.Contracts.Product;

namespace FoodCore.Messages
{
    [ProtoContract]
    [Serializable]
    public class ProductRequest
    {
        [ProtoMember(1)]
        public Product product { get; set; }
    }
}

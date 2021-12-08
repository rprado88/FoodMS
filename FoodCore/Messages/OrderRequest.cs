using System;
using ProtoBuf;
using FoodCore.Contracts;
namespace FoodCore.Messages
{
    [ProtoContract]
    [Serializable]
    public class OrderRequest
    {
        [ProtoMember(1)]
        public Order order { get; set; }
    }
}

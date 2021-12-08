using System;
using ProtoBuf;
namespace FoodCore.Messages
{
    [ProtoContract]
    [Serializable]
    public class OrderResponse
    {
        [ProtoMember(1)]
        public FoodCore.Contracts.Order Order { get; set; }

        [ProtoMember(2)]
        public string ErrorCode { get; set; }
    }
}

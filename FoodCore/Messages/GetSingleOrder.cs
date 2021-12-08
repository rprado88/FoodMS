using System;
using ProtoBuf;

namespace FoodCore.Messages
{
    [ProtoContract]
    [Serializable]
    public class GetSingleOrder
    {
        [ProtoMember(1)]
        public FoodCore.Contracts.Order Order { get; set; }
    }
}

using System;
using ProtoBuf;

namespace FoodCore.Messages
{
    [ProtoContract]
    [Serializable]
    public class GetRecentOrdersResponse
    {
        [ProtoMember(1)]
        public FoodCore.Contracts.Order RecentOrder { get; set; }
    }
}

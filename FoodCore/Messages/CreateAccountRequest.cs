using System;
using ProtoBuf;
using FoodCore.Contracts;
using System.ComponentModel.DataAnnotations;

namespace FoodCore.Messages
{
    [ProtoContract]
    [Serializable]
    public class AccountRequest
    {
        [Required]
        [ProtoMember(1)]
        public Account Account { get; set; }
    }
}

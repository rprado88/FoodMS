using System;
using System.ComponentModel.DataAnnotations;
using ProtoBuf;

namespace FoodCore.Contracts.Payment
{
    [ProtoContract]
    [Serializable]
    public class Payment
    {
        [Required]
        [ProtoMember(1)]
        public string CustomerId { get; set; }

        [Required]
        [ProtoMember(2)]
        public string WalletId { get; set; }

        [Required]
        [ProtoMember(3)]
        public FoodCore.Enums.PaymentOption PaymentOption { get; set; }

        [Required]
        [ProtoMember(4)]
        public FoodCore.Enums.PaymentProvider PaymentProvider { get; set; }
    }
}

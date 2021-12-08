using System;
using System.ComponentModel.DataAnnotations;
using ProtoBuf;

namespace FoodCore.Contracts
{
    [ProtoContract]
    [Serializable]
    public class Address
    {
        [Required]
        [ProtoMember(1)]
        public string Street { get; set; }
        
        [Required]
        [ProtoMember(2)]
        public string City { get; set; }
        
        [Required]
        [ProtoMember(3)]
        public string ZipCode { get; set; }
        
        [Required]
        [ProtoMember(4)]
        public string State { get; set; }
    }
}

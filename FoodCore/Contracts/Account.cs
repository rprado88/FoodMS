using System;
using System.ComponentModel.DataAnnotations;
using ProtoBuf;

namespace FoodCore.Contracts
{
    [ProtoContract]
    [Serializable]
    public class Account
    {
        [ProtoMember(1)]
        public string CustomerId { get; set; }
        
        [Required]
        [ProtoMember(2)]
        public string FirstName { get; set; }
        
        [Required]
        [ProtoMember(3)]
        public string LastName { get; set; }
        
        [Required]
        [ProtoMember(3)]
        public string Email { get; set; }
        
        [Required]
        [ProtoMember(4)]
        public Address AccountAddress { get; set; }
    }
}

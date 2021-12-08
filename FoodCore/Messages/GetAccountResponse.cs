using System;
using FoodCore.Contracts;

namespace FoodCore.Messages
{
    public class GetAccountResponse
    {
        public Account Customer { get; set; }
        
    }
}

using System;
using System.Threading.Tasks;
using FoodCore.Contracts;
using FoodCore.Messages;

namespace FoodCore.Business.Steps
{
    public interface IAccountStep
    {
        Task<string> Create(AccountRequest account);
        Task<GetAccountResponse> Get(string customerId);
        Task<bool> Delete(string customerId);
        
        Task<bool> Update(AccountRequest account);
    }
}

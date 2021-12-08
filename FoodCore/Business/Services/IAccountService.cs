using System;
using System.Threading.Tasks;
using FoodCore.Messages;

namespace FoodCore.Business.Services
{
    public interface IAccountService
    {
        Task<CreateAccountResponse> Create(AccountRequest createAccountRequest);
        Task<GetAccountResponse> Get(string customerId);
        Task<bool> Delete(string customerId);

        Task<bool> Update(string customerId, AccountRequest accountRequest);
    }
}

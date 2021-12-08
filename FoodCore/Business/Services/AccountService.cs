using System;
using System.Threading.Tasks;
using FoodCore.Business.Steps;
using FoodCore.Messages;

namespace FoodCore.Business.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountStep _accountStep;

        public AccountService(IAccountStep iaccountStep)
        {
            _accountStep = iaccountStep;
        }

        public async Task<CreateAccountResponse> Create(AccountRequest createAccountRequest)
        {
            var createAccount = _accountStep.Create(createAccountRequest);

            return new CreateAccountResponse()
            {
                Result = createAccount.Result
            };
        }

        public async Task<GetAccountResponse> Get(string customerId)
        {
            var response = await _accountStep.Get(customerId);

            if (response != null)
            {
                return response;
            }

            return null;
        }

        public async Task<bool> Delete(string customerId)
        {
            var response = await _accountStep.Delete(customerId);
            
            return response;
        }

        public async Task<bool> Update(string customerId ,AccountRequest accountRequest)
        {
            bool response = false;
            if (!String.IsNullOrEmpty(customerId) && accountRequest != null)
            {
                accountRequest.Account.CustomerId = customerId;
                response = await _accountStep.Update(accountRequest);
            }
            
            return response;
        }
    }
}

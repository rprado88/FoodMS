using System;
using System.Threading.Tasks;
using FoodCore.Contracts;
using FoodCore.Data.DataManagement;
using FoodCore.Messages;

namespace FoodCore.Business.Steps
{
    public class AccountStep : IAccountStep
    {
        public readonly ICustomerDataManager customerDataManager;

        public AccountStep(ICustomerDataManager icustomerDataManager)
        {
            customerDataManager = icustomerDataManager;
        }

        public Task<string> Create(AccountRequest accountRequest)
        {
            var customerId = Guid.NewGuid();
            accountRequest.Account.CustomerId = customerId.ToString();

            return customerDataManager.Create(accountRequest.Account);
        }

        public async Task<GetAccountResponse> Get(string customerId)
        {
            var customerData = await customerDataManager.Get(customerId);

            if (customerData != null)
            {
                return new GetAccountResponse()
                {
                    Customer = customerData
                };
            }

            return null;
        }

        public async Task<bool> Delete(string customerId)
        {
            var customerData = await customerDataManager.Delete(customerId);

            return customerData;
            
        }

        public async Task<bool> Update(AccountRequest account)
        {
            var customerData = await customerDataManager.Update(account.Account);

            return customerData;
        }
    }
}

using System;
using System.Threading.Tasks;
using FoodCore.Contracts;

namespace FoodCore.Data.DataManagement
{
    public interface ICustomerDataManager
    {
        Task<string> Create(Account account);

        Task<Account> Get(string customerId);

        Task<bool> Delete(string customerId);

        Task<bool> Update(Account account);
    }
}

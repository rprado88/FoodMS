using System.Collections.Generic;
using System.Threading.Tasks;
using FoodCore.Contracts;
namespace FoodCore.Data.DataManagement
{
    public interface IOrderDataManager
    {
        Task Create(Order order);
        Task<bool> Update(Order order);
        Task<Order> Get(string orderId);
        Task<List<Order>> GetOrdersList(string customerId);
    }
}

using System;
using System.Threading.Tasks;
using FoodCore.Messages;

namespace FoodCore.Business.Services
{
    public interface IOrderService
    {
        Task<OrderResponse> CreateOrder(OrderRequest orderRequest);
    }
}

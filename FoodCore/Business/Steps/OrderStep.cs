using System;
using System.Threading.Tasks;
using FoodCore.Data.DataManagement;
using FoodCore.Messages;

namespace FoodCore.Business.Steps
{
    public class OrderStep : IOrderStep
    {
        public readonly IOrderDataManager orderDataManager;

        public OrderStep(IOrderDataManager iOrderDataManager)
        {
            orderDataManager = iOrderDataManager;
        }

        public async Task Create(OrderRequest order)
        {
            await orderDataManager.Create(order.order);
        }
    }
}

using System;
using System.Threading.Tasks;
using FoodCore.Business.Steps;
using FoodCore.Messages;

namespace FoodCore.Business.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderStep createOrderStep;

        public OrderService(IOrderStep iCreateOrderStep)
        {
            createOrderStep = iCreateOrderStep;
        }

        public async Task<OrderResponse> CreateOrder(OrderRequest orderRequest)
        {

            var response = createOrderStep.Create(orderRequest);

            return new OrderResponse();
        }
    }
}

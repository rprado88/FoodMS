using System.Collections.Generic;
using FoodCore.Contracts;
using Microsoft.AspNetCore.Mvc;
using FoodCore.Messages;
using FoodCore.Business.Services;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoodMS.Controllers
{
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        private readonly IOrderService orderService;

        public OrderController(IOrderService iOrderService)
        {
            orderService = iOrderService;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<GetSingleOrder> Get(string OrderId)
        {
            return new GetSingleOrder();
        }

        
        [HttpGet("recenteorders")]
        public ActionResult<IEnumerable<GetRecentOrdersResponse>> GetRecentOrders([FromHeader]string customerId)
        {
            return new List<GetRecentOrdersResponse>();
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult<OrderResponse>> PostAsync(OrderRequest request)
        {
            var result = await orderService.CreateOrder(request);

            return result;
        }

        // PUT api/values/5
        [HttpPut]
        public void Put([FromBody] OrderRequest request)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(string orderId)
        {
        }
    }
}

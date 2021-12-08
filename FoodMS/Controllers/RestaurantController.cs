using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoodCore.Contracts;
using FoodCore.Contracts.Product;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoodMS.Controllers
{
    [Route("api/[controller]")]
    public class RestaurantController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<Restaurant> Get()
        {
            return new List<Restaurant>();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Restaurant Get(int id)
        {
            return new Restaurant();
        }

        // GET api/values/5
        [HttpGet("{id}/products")]
        public List<Product> GetAllProducts(int id)
        {
            return new List<Product>();
        }

        // GET api/values/5
        [HttpGet("{id}/product/{idProduct}")]
        public Product GetProductById(int id, int idProduct)
        {
            return new Product();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Restaurant value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Restaurant value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

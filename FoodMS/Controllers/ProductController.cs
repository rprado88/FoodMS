using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoodCore.Contracts.Product;
using Swashbuckle.AspNetCore.SwaggerUI;
using FoodCore.Messages;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoodMS.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        // GET: api/values
        [HttpGet]
        public ActionResult<IEnumerable<ProductResponse>> Get()
        {
            return new List<ProductResponse>();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<ProductResponse> Get(int id)
        {
            return new ProductResponse();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] ProductRequest value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] ProductRequest value)
        {
            return Ok();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok();
        }
    }
}

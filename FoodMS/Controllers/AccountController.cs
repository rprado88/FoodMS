using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using FoodCore.Business.Services;
using FoodCore.Contracts;
using FoodCore.Messages;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoodMS.Controllers
{
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService iaccountService)
        {
            _accountService = iaccountService;
        }
        
        [HttpGet]
        public async Task<ActionResult<GetAccountResponse>> Get([FromHeader] string customerId)
        {
            try
            {
                var response = await _accountService.Get(customerId);
            
                if (response.Customer.CustomerId == null)
                {
                    return NotFound();
                }
                
                return response;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPost]
        public async Task<HttpResponseMessage> Post([FromBody] AccountRequest createAccountRequest)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var response = await _accountService.Create(createAccountRequest);
                    
                    return new HttpResponseMessage(HttpStatusCode.OK);
                }
                else
                {
                    return new HttpResponseMessage(HttpStatusCode.BadRequest);
                }
            }
            catch (Exception e)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
        }
        
        [HttpPut()]
        public async Task<HttpResponseMessage> Put([FromHeader] string customerId, [FromBody] AccountRequest value)
        {
            try
            {
                var response = await _accountService.Update(customerId, value);

                if (response)
                {
                    return new HttpResponseMessage(HttpStatusCode.OK);
                }
                else
                {
                    return new HttpResponseMessage(HttpStatusCode.NotFound);
                }
            }
            catch (Exception e)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
        }

        [HttpDelete()]
        public async Task<HttpResponseMessage> Delete([FromHeader] string customerId)
        {
            try
            {
                var response = await _accountService.Delete(customerId);
                if (response)
                {
                    return new HttpResponseMessage(HttpStatusCode.OK);
                }
                else
                {
                    return new HttpResponseMessage(HttpStatusCode.NotFound);
                }
            }
            catch (Exception e)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
        }
    }
}

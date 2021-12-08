using System;
using Microsoft.AspNetCore.Mvc;

namespace FoodMS.Controllers
{
    [Route("api/[controller]")]
    public class WalletController : Controller
    {
        // GET
        [HttpGet]
        public string Index()
        {
            return "";
        }
    }
}
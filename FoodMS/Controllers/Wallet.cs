using Microsoft.AspNetCore.Mvc;

namespace FoodMS.Controllers
{
    public class Wallet : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}
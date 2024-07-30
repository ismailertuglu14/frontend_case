using Microsoft.AspNetCore.Mvc;

namespace Shop.Web.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

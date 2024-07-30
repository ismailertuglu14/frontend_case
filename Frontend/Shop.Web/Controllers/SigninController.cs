using Microsoft.AspNetCore.Mvc;

namespace Shop.Web.Controllers
{
    public class SigninController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

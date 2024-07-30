using Microsoft.AspNetCore.Mvc;

namespace Shop.Web.Controllers
{
    public class SignupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

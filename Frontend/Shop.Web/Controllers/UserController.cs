﻿using Microsoft.AspNetCore.Mvc;

namespace Shop.Web.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

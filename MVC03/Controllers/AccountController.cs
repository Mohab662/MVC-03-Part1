﻿using Microsoft.AspNetCore.Mvc;

namespace MVC03.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

    }
}

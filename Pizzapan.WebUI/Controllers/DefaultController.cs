﻿using Microsoft.AspNetCore.Mvc;

namespace Pizzapan.WebUI.Controllers
{
    public class DefaultController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
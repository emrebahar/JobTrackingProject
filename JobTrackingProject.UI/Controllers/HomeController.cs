﻿using Microsoft.AspNetCore.Mvc;

namespace JobTrackingProject.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

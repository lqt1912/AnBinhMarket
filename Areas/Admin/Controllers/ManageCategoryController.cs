﻿using Microsoft.AspNetCore.Mvc;

namespace AgriShop.Areas.Admin.Controllers
{
    public class ManageCategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

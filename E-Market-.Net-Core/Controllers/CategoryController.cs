﻿using Microsoft.AspNetCore.Mvc;
using E_Market_.Net_Core.Models.DB_Classes;

namespace E_Market_.Net_Core.Controllers
{
    public class CategoryController : Controller
    {
        MarketContext marketContext = new MarketContext();
        public IActionResult Index()
        {
            var values=marketContext.Categories.ToList();
            return View(values);
        }
    }
}

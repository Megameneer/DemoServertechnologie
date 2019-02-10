using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Demo_MVC.Models;
using Microsoft.AspNetCore.Http;

namespace Demo_MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [ValidateAntiForgeryToken]
        public IActionResult Page1(int amountOfKibbeling)
        {
            HttpContext.Session.SetInt32("amountOfKibbeling", amountOfKibbeling);
            var page1Model = new Page1Model {AmountOfKibbeling = amountOfKibbeling};
            page1Model.TotalPrice = amountOfKibbeling * page1Model.PricePerUnit;
            return View(page1Model);
        }
    }
}

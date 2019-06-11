using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CGarage.Models;

namespace CGarage.Controllers
{
    public class HomeController :Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Car()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
    }
}

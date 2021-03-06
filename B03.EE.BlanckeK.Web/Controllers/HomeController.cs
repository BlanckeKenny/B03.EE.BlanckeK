﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using B03.EE.BlanckeK.Lib.Models;
using Microsoft.AspNetCore.Mvc;
using B03.EE.BlanckeK.Web.Models;
using Microsoft.AspNetCore.Identity;

namespace B03.EE.BlanckeK.Web.Controllers
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
    }
}

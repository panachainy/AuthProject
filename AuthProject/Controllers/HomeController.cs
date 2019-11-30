﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AuthProject.Models;
using Microsoft.AspNetCore.Authorization;

namespace AuthProject.Controllers
{
    [Route("prefix/[controller]")]
    public class HomeController : Controller
    {
        //https://localhost:5001/prefix/Home/index

        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }

        //(Roles = "s")
        [Authorize]
        [Route("Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [Route("Error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
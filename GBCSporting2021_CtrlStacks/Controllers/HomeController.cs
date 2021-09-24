using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using GBCSporting2021_CtrlStacks.DbRepository;
using GBCSporting2021_CtrlStacks.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace GBCSporting2021_CtrlStacks.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("about-us")]
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}

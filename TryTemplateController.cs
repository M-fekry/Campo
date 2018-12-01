using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Camping.Controllers
{
    public class TryTemplateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult Features()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Shop()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Sale()
        {
            return View();
        }
        public IActionResult Home()
        {
            return View();
        }
    }
}
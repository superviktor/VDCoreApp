using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VD.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Home/Index");
        }
        public IActionResult Edit()
        {
            return Content("Home/Edit");
        }
    }
}
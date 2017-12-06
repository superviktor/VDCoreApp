using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace VD.Controllers
{
    public class HomeController : Controller
    {
        [Authorize(Roles = "admin, user")]
        public IActionResult Index()
        {
            return Content("Home/Index");
        }
        [Authorize(Roles = "admin")]
        public IActionResult Edit()
        {
            return Content("Home/Edit");
        }
    }
}
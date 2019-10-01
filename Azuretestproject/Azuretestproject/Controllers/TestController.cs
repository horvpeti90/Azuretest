using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Azuretestproject.Controllers
{
    public class TestController : Controller
    {
        [HttpGet("/hello")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
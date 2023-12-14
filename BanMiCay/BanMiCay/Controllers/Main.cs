using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BanMiCay.Controllers
{
    public class Main : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

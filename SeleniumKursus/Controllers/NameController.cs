using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SeleniumKursus.Controllers
{
    public class NameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
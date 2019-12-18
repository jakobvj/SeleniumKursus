using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SeleniumKursus.Controllers
{
    public class ExerciseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult IDSelectorTraining()
        {
            return View();
        }
        public IActionResult NameSelectorTraining()
        {
            return View();
        }
        public IActionResult CheckboxTraining()
        {
            return View();
        }
        public IActionResult RadiobuttonTraining()
        {
            return View();
        }
        public IActionResult TextTraining()
        {
            return View();
        }
        public IActionResult DropdownMenuTraining()
        {
            return View();
        }
        public IActionResult AlertBoxTraining()
        {
            return View();
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filipas_Denisa_Lab1.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Bine ai venit!");
        }

        public string Salut()
        {
            return "Salutare!";
        }

        public IActionResult Actual(string nume, int ani)
        {
            return Content("Salutare " +nume +". Ai varsta de "+ani +" ani.");
        }
    }
}

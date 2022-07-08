using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vakarkrasti.Controllers
{
    public class OurServicesController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GuestHouses()
        {
            return View("GuestHouses/Index");
        }

        public IActionResult GuestHousePaula()
        {
            return View("GuestHouses/Paula/Index");
        }

        public IActionResult GuestHouseAmelija()
        {
            return View("GuestHouses/Amelija/Index");
        }

        public IActionResult Activities()
        {
            return View("Activities/Index");
        }

        public IActionResult Fishing()
        {
            return View();
        }

        public IActionResult SUPRent()
        {
            return View();
        }

        public IActionResult RowingBoat()
        {
            return View();
        }
    }
}


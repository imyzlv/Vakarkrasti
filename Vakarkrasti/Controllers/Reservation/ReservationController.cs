using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Vakarkrasti.Models;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vakarkrasti.Controllers.Reservation
{
    public class ReservationController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<SelectListItem> guestHouses = new List<SelectListItem>
            {
                new SelectListItem() { Text = "Izvēlēties...", Value = "Guest house" },
                new SelectListItem() { Text = "Paula", Value = "Paula" },
                new SelectListItem() { Text = "Amēlija", Value = "Amēlija" },
                new SelectListItem() { Text= "Abas", Value = "Abas"}
            };
            ViewBag.GuestHouses = guestHouses;
            return View("Index");
        }
        [HttpGet]
        public IActionResult CreateReservation()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateReservation(Reservations reservation)
        {
            List<SelectListItem> guestHouses = new List<SelectListItem>
            {
                new SelectListItem() { Text = "Izvēlēties...", Value = "Guest house" },
                new SelectListItem() { Text = "Paula", Value = "Paula" },
                new SelectListItem() { Text = "Amēlija", Value = "Amēlija" }
            };
            ViewBag.GuestHouses = guestHouses;
            return View("Index");
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Vakarkrasti.Models;
using Vakarkrasti.Data;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vakarkrasti.Controllers.Reservation
{
    public class ReservationController : Controller
    {
        private readonly VKContext _db;
        public ReservationController(VKContext db)
        {
            _db = db;
        }
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
            ViewBag.GuestHouse = guestHouses;
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
                new SelectListItem() { Text = "Amēlija", Value = "Amēlija" },
                new SelectListItem() {Text="Abas", Value="Abas"}
            };
            ViewBag.GuestHouse = guestHouses;
            if (ModelState != null)
            {
                //var bookedDates = from c in _db.Reservation
                //                  where (c.ArrivalDateTime <= reservation.ArrivalDateTime && c.DepartureDateTime >= reservation.DepartureDateTime)||
                //                  (c.ArrivalDateTime < reservation.DepartureDateTime && c.DepartureDateTime >= reservation.DepartureDateTime) ||
                //                  (reservation.ArrivalDateTime <= c.ArrivalDateTime && reservation.DepartureDateTime >= c.ArrivalDateTime)
                //                  select c;

                var bookedDates = from c in _db.Reservation
                                  where (c.CheckOut > reservation.CheckIn && c.CheckIn < reservation.CheckOut)
                                  select c;
                if (!bookedDates.Any())
                {
                    Console.WriteLine("Datumi pieejami. Rezervācija veiksmīga");
                    //_db.Reservation.Add(reservation);
                    //_db.SaveChanges();

                }
                else
                {

                    //ModelState.Clear();
                    //TempData["Success"] = "Ieraksts veiksmīgi pievienots";
                    Console.WriteLine("Datumi nav pieejami. Rezervācija neveiksmīga.");
                }
            }
            return View("Index");
        }

        public bool CheckReservationAvailability(DateTime checkIn, DateTime checkOut, int houseId)
        {
            bool datesAvailable = false;
            if (checkIn >= checkOut)
            {

            }
            return datesAvailable;
        }
    }
}


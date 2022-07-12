using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vakarkrasti.Models;
using Vakarkrasti.Data;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vakarkrasti.Controllers.Admin
{
    public class AdminController : Controller
    {
        private readonly VKContext _db;

        public AdminController(VKContext db)
        {
            _db = db;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddHouse(Houses house)
        {
            if (ModelState != null)
            {
                try
                {
                    _db.House.Add(house);
                    _db.SaveChanges();
                    ModelState.Clear();
                    ViewBag.Message = "Ieraksts veiksmīgi pievienots";
                    TempData["Success"] = "Ieraksts veiksmīgi pievienots";
                }
                catch (DbUpdateException)
                {
                    ViewBag.Message = "Neatstājiet tukšus laukus.";
                }
            }
            return View("Index");
        }
    }
}


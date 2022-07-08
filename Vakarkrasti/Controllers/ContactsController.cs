using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vakarkrasti.Models;
using Vakarkrasti.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vakarkrasti.Controllers
{
    public class ContactsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ContactFormMessage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ContactFormMessage(Contact contact)
        {
            if (ModelState.IsValid)
            {
                TempData["Success"] = "Ziņa veiksmīgi nosūtīta";
                ModelState.Clear();
                //EmailSender.SendEmail("imants.treidis@gmail.com", contact.Name.ToString(), contact.Message.ToString(), contact.Phone.ToString());
            }
            
            return View("Index");
        }
    }
}


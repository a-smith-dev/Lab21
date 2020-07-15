using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab21.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab21.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddUser(Register register)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            return View(register);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sklep_internetowy_DD_DP.Models;

namespace Sklep_internetowy_DD_DP.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public IActionResult Index()
        {
            return View();
        }


        
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = user.Name + ", " + user.Surname + ", " + user.Email + ", " + user.Password;
            }
            else
            {
                ViewBag.Message = "Błędne dane!";
            }
            return View();
        }


    }
}

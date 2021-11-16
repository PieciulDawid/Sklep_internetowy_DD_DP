using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Sklep_internetowy_DD_DP.Models;

namespace Sklep_internetowy_DD_DP.Controllers
{
    public class UserController : Controller
    {


        [HttpPost]
        public ActionResult Create(User user)
        {
            Console.WriteLine();
            if (ModelState.IsValid)
            {
                //  TODO dodaj użytkownika
            }
            else
            {
                //  TODO nie dodawaj użytkownika
            }
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            Console.WriteLine();
            if (ModelState.IsValid)
            {
                //  TODO zaloguj użytkownika
            }
            else
            {
                //  TODO nie zaloguj użytkownika
            }
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

    }
}

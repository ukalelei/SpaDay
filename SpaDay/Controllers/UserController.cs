using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController: Controller
    {
      
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/user")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            ViewBag.userName = newUser.UserName;
            ViewBag.email = newUser.Email;
            ViewBag.password = newUser.Password;
            ViewBag.verify = verify;
            ViewBag.dateJoined = newUser.DateJoined;

            if (newUser.Password == verify)
            {
                ViewBag.isError = false;
                return View("Index");
            }
            else
            {
                ViewBag.isError = true;
                ViewBag.ErrorMessage = "Your password do not match. Try again";
                return View("Add");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using SpaDay.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            //pass an instance of AddUserViewModel
            AddUserViewModel addUserViewModel = new AddUserViewModel();
            return View(addUserViewModel);
        }

        [HttpPost]
        [Route("/user")]
        public IActionResult SubmitAddUserForm(AddUserViewModel addUserViewModel) //Take in the instance of AddUserViewModel as a parameter.
        {
            if (ModelState.IsValid) // make sure conditions outlined using validation attributes have been met
            {
                User newUser = new User
                {
                    //check that the value of Password is equal to VerifyPassword
                    Username = addUserViewModel.Username,
                    Email = addUserViewModel.Email,
                    Password = addUserViewModel.VerifyPassword,
                };

                //create an instance of User and pass it to the User / Index.cshtml view
                return View("Index", newUser);
            }
                return View("Add", addUserViewModel); // reload the form if passwords do not match
        }

    }
}

using LoginPage.Data;
using LoginPage.Models;
using LoginPage.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LoginPage.Controllers
{
    public class UserController : Controller
    {
            private UserDbContext _userDbContext;

            public UserController(UserDbContext userDbContext)
            {
                _userDbContext = userDbContext;
        }


        [HttpGet]
        public IActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        [ActionName("AddUser")]
        public IActionResult AddUser(Login login)
        {
            var user = new User
            {
                Name = login.Name,
                Surname = login.Surname,
                Mail=login.Mail,
                Password=login.Password,
            };

            _userDbContext.Users.Add(user);
            _userDbContext.SaveChanges();
            return View("AddUser");
        }

    }
       
    }


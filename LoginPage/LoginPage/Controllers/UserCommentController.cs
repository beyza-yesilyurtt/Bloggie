using LoginPage.Data;
using LoginPage.Models.ViewModels;
using LoginPage.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoginPage.Controllers
{
    public class UserCommentController : Controller
    {

        private UserDbContext _userDbContext;

        public UserCommentController(UserDbContext userDbContext)
        {
            _userDbContext = userDbContext;
        }

        [HttpGet]
        public IActionResult AddUserComment()
        {
            return View();
        }

        [HttpPost]
        [ActionName("AddUserComment")]
        public IActionResult AddUser(Comments comments)
        {
            var userComments = new UserComment
            {
                Name = comments.Name,
                Surname = comments.Surname,
                Comment = comments.Comment,
            
            };

            _userDbContext.UserComments.Add(userComments);
            _userDbContext.SaveChanges();
            return View("AddUserComment");
        }



    }
}

using Lab3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab3.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(UserModel model)
        {
            if (!ModelState.IsValid)
            {
                // To DO:
            }
            else
            {
                ViewBag.Message = "User Registered!";
            }

            return View();
        }
    }
}

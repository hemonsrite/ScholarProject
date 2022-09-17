using Microsoft.AspNetCore.Mvc;

namespace Lab1.Areas.User.Controllers
{
    [Area("User")]
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string UserName, string Password)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}

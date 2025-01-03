using Microsoft.AspNetCore.Mvc;
using practice_C_.Areas.Admin.Models;
using practice_C_.Models;
using Model;
using practice_C_.Areas.code;


namespace practice_C_.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        private readonly SessionHelper _sessionHelper;

        public LoginController(SessionHelper sessionHelper)
        {
            _sessionHelper = sessionHelper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var result = new AccountModel().Login(model.UserName, model.Password);
                if (result)
                {
                    _sessionHelper.SetSession(new UserSession() { UserName = model.UserName });
                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                }
                ModelState.AddModelError("", "Invalid username or password.");
            }
            return View(model);
        }

    }
}

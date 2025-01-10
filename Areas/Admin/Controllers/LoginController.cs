using Microsoft.AspNetCore.Mvc;
using Model.DAO;
using OnlineShop.Areas.Admin.Models;
using OnlineShop.Common;

namespace OnlineShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                var result = dao.Login(model.UserName, Encryptor.MD5Hash(model.Password));

                if (result == 1)
                {
                    var user = dao.GetById(model.UserName);
                    var userSession = new UserLogin();
                    userSession.UserName = user.UserName;
                    userSession.UserID = user.Id;

                    HttpContext.Session.SetString("USER_SESSION", Newtonsoft.Json.JsonConvert.SerializeObject(userSession));
                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                }
                else if (result == 0)
                {
                    ModelState.AddModelError("", "Username does not exist");
                }
                else if (result == -1)
                {
                    ModelState.AddModelError("", "Account is disabled");
                }
                else if (result == -2)
                {
                    ModelState.AddModelError("", "password is incorrect");
                }
                else
                {
                    ModelState.AddModelError("", "Login failed");
                }
            }
            return View(model   );

        }
    }
}

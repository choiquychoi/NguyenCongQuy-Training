using Microsoft.AspNetCore.Mvc;
using Model.DAO;
using Model.EF;
using OnlineShop.Common;

namespace OnlineShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        public IActionResult Index(int page = 1, int pageSize = 10)
        {
            var dao = new UserDao();
            var model = dao.ListAllPaging(page, pageSize);
            return View(model);
        }

        public IActionResult Edit(int id)
        { 
            var user = new UserDao().ViewDetail(id);
            return View(user);
        } 

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(User user)
        {
            var dao = new UserDao();

            var encryptedMd5Pas = Encryptor.MD5Hash(user.Password);
            user.Password = encryptedMd5Pas;

            long id = dao.Insert(user);
            if (ModelState.IsValid)
            {
                if (id > 0)
                {
                    return RedirectToAction("Create", "User");
                }
                else
                {
                    ModelState.AddModelError("", "create a User successfully");
                }
            }
            return View("Index");
        }

    }
}

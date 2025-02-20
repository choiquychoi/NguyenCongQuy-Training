﻿using Microsoft.AspNetCore.Mvc;
using Model.DAO;
using Model.EF;
using OnlineShop.Common;

namespace OnlineShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : BaseController
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

        [HttpPost]
        public IActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();

                if (!string.IsNullOrEmpty(user.Password))
                {
                    user.Password = Encryptor.MD5Hash(user.Password);
                }

                var result = dao.Update(user);
                if (result)
                {
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    ModelState.AddModelError("", " Update a User unsuccessfully");
                }
            }

            return View(user);
        }

        public IActionResult Delete(int id)
        {
            var dao = new UserDao();
            var user = dao.ViewDetail(id);
            if (user == null)
            {
                return RedirectToAction("Index", "User");
            }
            dao.Delete(user);
            return RedirectToAction("Index", "User");
        }

    }
}

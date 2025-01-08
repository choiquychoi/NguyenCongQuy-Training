    using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace practice_C_.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        // GET: CategoryController
        public IActionResult Index()
        {
            var IplCate = new Model.CategoryModel();
            var model = IplCate.ListAll();
            return View(model);
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoryController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        public ActionResult Create(Category collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // Thêm logic lưu dữ liệu ở đây
                    return RedirectToAction("Index");
                }
                return View(collection);
            }
            catch
            {
                return View();
            }

        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

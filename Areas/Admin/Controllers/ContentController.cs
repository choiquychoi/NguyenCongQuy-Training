using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Model.DAO;
using Model.EF;

namespace OnlineShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            SetViewBag();
            var model = new Content(); // Khởi tạo model
            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(long id)
        {
            var dao = new ContentDao();
            var content = dao.GetById(id);
            SetViewBag(content.CategoryId);
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Content Model)
        {
            if (ModelState.IsValid)
            {

            }
            SetViewBag(Model.CategoryId);
            return View();
        }


        [HttpPost]
        public IActionResult Create(Content Model) 
        {
            if (ModelState.IsValid)
            {
                
            }
            SetViewBag();
            var model = new Content(); // Khởi tạo model
            return View();
        }

        public void SetViewBag(long? selectedId = null)
        {
            var dao = new CategoryDao();
            ViewBag.CategoryId = new SelectList(dao.ListAll(), "Id", "Name", selectedId);
        }

    }
}

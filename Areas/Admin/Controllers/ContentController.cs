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
            var model = new Content();
            SetViewBag();
            return View(model);
        }



        public void SetViewBag(long? selectedId = null)
        {
            var dao = new CategoryDao();
            var categories = dao.ListAll();
            if (categories == null || !categories.Any())
            {
                throw new Exception("Không tìm thấy danh mục nào trong cơ sở dữ liệu!");
            }
            ViewBag.CategoryId = new SelectList(categories, "ID", "Name", selectedId);
        }
    }
}

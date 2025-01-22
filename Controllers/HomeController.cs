using Microsoft.AspNetCore.Mvc;
using Model.DAO;

namespace OnlineShop.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult MainMenu()
        {
            var model = new MenuDao().ListByTypeId(1);
            return PartialView(model);
        }
    }
}

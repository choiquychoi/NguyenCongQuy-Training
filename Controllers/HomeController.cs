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
		public IActionResult MainMenu()
		{
			var model = new MenuDao().ListByGroupId(1);
			return PartialView();
		}
	}
}

using Microsoft.AspNetCore.Mvc;

namespace practice_C_.Areas.Admin.Controllers  

{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

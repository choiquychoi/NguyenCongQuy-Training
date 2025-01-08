using Microsoft.AspNetCore.Mvc;

namespace practice_C_.Areas.Admin.Controllers  

{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

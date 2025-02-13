using Microsoft.AspNetCore.Mvc;

namespace DiaryApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

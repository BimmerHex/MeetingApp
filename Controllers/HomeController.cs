using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        // localhost
        // localhost/home
        // localhost/home/index
        public IActionResult Index()
        {
            return View();
        }
    }
}
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
            int hour = DateTime.Now.Hour;

            // ViewBag.WelcomeMessage = hour > 12 ? "İyi Günler" : "Günaydın";
            // ViewBag.Username = "Gökhan";

            ViewData["WelcomeMessage"] = hour > 12 ? "İyi Günler" : "Günaydın";
            ViewData["Username"] = "Gökhan";

            return View();
        }
    }
}
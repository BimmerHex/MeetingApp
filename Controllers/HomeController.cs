using MeetingApp.Models;
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
            // ViewData["Username"] = "Gökhan";

            var meetingInfo = new MeetingInfo() {
                Id = 1,
                Location = "ABC Kongre Merkezi / İstanbul",
                Date = new DateTime(2024, 02, 20, 20, 0, 0),
                NumberOfPeople = 100
            };

            return View(meetingInfo);
        }
    }
}
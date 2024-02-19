using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {
        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(UserInfo userInfo)
        {
            Repository.AddUser(userInfo);
            ViewBag.UserCount = Repository.Users.Where(info => info.WillAttend == true).Count();
            return View("Thanks", userInfo);
        }

        [HttpGet]
        public IActionResult List()
        {
            return View(Repository.Users);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(Repository.GetUserById(id));
        }
    }
}
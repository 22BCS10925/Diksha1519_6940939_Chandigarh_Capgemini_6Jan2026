using Microsoft.AspNetCore.Mvc;
using StudentManagementProject.Filters;
using StudentManagementProject.Models;


namespace StudentManagementProject.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "123")
            {
                HttpContext.Session.SetString("username", username);
                return RedirectToAction("Dashboard");
            }

            ViewBag.Error = "Invalid credentials";
            return View();
        }

        public IActionResult Dashboard()
        {
            var username = HttpContext.Session.GetString("username");

            if (username == null)
            {
                return RedirectToAction("Login");
            }

            ViewBag.Username = username;
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
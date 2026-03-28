using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;

        public AccountController(AppDbContext context)
        {
            _context = context;
        }

        // ✅ LOGIN PAGE
        public IActionResult Login()
        {
            return View();
        }

        // ✅ LOGIN POST
        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            var user = _context.Users
                .FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Username),
                    new Claim(ClaimTypes.Role, user.Role)
                };

                var identity = new ClaimsIdentity(claims, "CookieAuth");
                var principal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync("CookieAuth", principal);

                return RedirectToAction("Index", "Product");
            }

            ViewBag.Error = "Invalid login";
            return View();
        }

        // ✅ LOGOUT
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync("CookieAuth");
            return RedirectToAction("Login");
        }

        // ✅ REGISTER PAGE
        public IActionResult Register()
        {
            return View();
        }

        // ✅ REGISTER POST
        [HttpPost]
        public IActionResult Register(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                ViewBag.Error = "Username and Password required";
                return View();
            }

            var existingUser = _context.Users
                .FirstOrDefault(u => u.Username == username);

            if (existingUser != null)
            {
                ViewBag.Error = "User already exists";
                return View();
            }

            // ✅ Step 1: Create Customer
            var customer = new Customer
            {
                Name = username,
                Email = username + "@gmail.com" // ✅ temporary fix

            };

            _context.Customers.Add(customer);
            _context.SaveChanges();

            // ✅ Step 2: Create User
            var user = new User
            {
                Username = username,
                Password = password, // ⚠️ Should hash in real apps
                Role = "User",
                CustomerId = customer.Id
            };

            _context.Users.Add(user);
            _context.SaveChanges();

            return RedirectToAction("Login");
        }
    }
}
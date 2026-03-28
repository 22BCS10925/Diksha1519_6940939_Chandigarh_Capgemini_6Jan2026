using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using SecureEmployee.Data;
using SecureEmployee.Models;

namespace SecureEmployee.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // View Employees (Admin + Employee)
        public IActionResult Index()
        {
            return View(_context.Employees.ToList());
        }

        // Admin only
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Create(Employee emp)
        {
            _context.Add(emp);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Edit(int id)
        {
            var emp = _context.Employees.Find(id);
            return View(emp);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Edit(Employee emp)
        {
            _context.Update(emp);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
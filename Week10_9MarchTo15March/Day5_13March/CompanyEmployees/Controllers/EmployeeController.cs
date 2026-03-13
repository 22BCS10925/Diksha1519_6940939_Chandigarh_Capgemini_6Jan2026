using CompanyEmployees.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CompanyEmployees.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly CompanyDbContext _context;

        public EmployeesController(CompanyDbContext context)
        {
            _context = context;
        }

        // INDEX (LIST EMPLOYEES)
        public IActionResult Index()
        {
            var employees = _context.Employees
                            .Include(e => e.Company)
                            .ToList();

            return View(employees);
        }

        // CREATE EMPLOYEE (GET)
        public IActionResult Create()
        {
            ViewBag.CompanyId = new SelectList(_context.Companies, "CompanyId", "CompanyName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(EmployeeModel emp)
        {
            if (ModelState.IsValid)
            {
                _context.Employees.Add(emp);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            ViewBag.CompanyId = new SelectList(_context.Companies, "CompanyId", "CompanyName", emp.CompanyId);
            return View(emp);
        }
    }
}
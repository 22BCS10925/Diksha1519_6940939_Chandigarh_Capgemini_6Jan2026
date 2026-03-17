using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using WeeklyTestEmployee.Models;

public class EmployeesController : Controller
{
    private readonly TestDbContext _context;

    public EmployeesController(TestDbContext context)
    {
        _context = context;
    }

    // READ
    public IActionResult Index()
    {
        var employees = _context.Employees
            .Include(e => e.Department)
            .Include(e => e.EmployeeProjects)
            .ThenInclude(ep => ep.Project)
            .ToList();

        return View(employees);
    }

    // CREATE
    public IActionResult Create()
    {
        ViewBag.Departments = _context.Departments.ToList();
        ViewBag.Projects = _context.Projects.ToList();
        return View();
    }

    [HttpPost]
    public IActionResult Create(Employee emp, int[] projectIds)
    {
        _context.Employees.Add(emp);
        _context.SaveChanges();

        foreach (var pid in projectIds)
        {
            EmployeeProject ep = new EmployeeProject()
            {
                EmployeeId = emp.EmployeeId,
                ProjectId = pid,
                AssignedDate = DateTime.Now
            };

            _context.EmployeeProjects.Add(ep);
        }

        _context.SaveChanges();

        return RedirectToAction("Index");
    }
}
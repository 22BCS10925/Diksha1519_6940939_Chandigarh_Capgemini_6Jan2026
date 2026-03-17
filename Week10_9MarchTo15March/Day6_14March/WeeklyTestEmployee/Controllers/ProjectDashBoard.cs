using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeeklyTestEmployee.Models;


public class DashboardController : Controller
{
    private readonly TestDbContext _context;

    public DashboardController(TestDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var data = _context.Projects
            .Include(p => p.EmployeeProjects)
            .ThenInclude(ep => ep.Employee)
            .ThenInclude(e => e.Department)
            .ToList();

        return View(data);
    }
}
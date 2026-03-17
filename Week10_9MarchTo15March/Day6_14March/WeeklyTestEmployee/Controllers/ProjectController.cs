using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using WeeklyTestEmployee.Models;

public class ProjectsController : Controller
{
    private readonly TestDbContext _context;

    public ProjectsController(TestDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var projects = _context.Projects
            .Include(p => p.EmployeeProjects)
            .ThenInclude(ep => ep.Employee)
            .ToList();

        return View(projects);
    }

    public IActionResult Create()
    {
        ViewBag.Employees = _context.Employees.ToList();
        return View();
    }

    [HttpPost]
    public IActionResult Create(Project project, int[] employeeIds)
    {
        _context.Projects.Add(project);
        _context.SaveChanges();

        foreach (var id in employeeIds)
        {
            EmployeeProject ep = new EmployeeProject()
            {
                EmployeeId = id,
                ProjectId = project.ProjectId,
                AssignedDate = DateTime.Now
            };

            _context.EmployeeProjects.Add(ep);
        }

        _context.SaveChanges();

        return RedirectToAction("Index");
    }
}
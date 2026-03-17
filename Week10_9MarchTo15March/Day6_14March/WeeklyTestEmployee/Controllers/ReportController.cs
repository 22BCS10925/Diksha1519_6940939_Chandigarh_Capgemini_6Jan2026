using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeeklyTestEmployee.Models;


public class ReportsController : Controller
{
    private readonly TestDbContext _context;

    public ReportsController(TestDbContext context)
    {
        _context = context;
    }
    public IActionResult EmployeesByProject(int projectId)
    {
        var employees = _context.EmployeeProjects
            .Where(ep => ep.ProjectId == projectId)
            .Select(ep => ep.Employee)
            .Include(e => e.Department)
            .ToList();

        return View(employees);
    }
    public IActionResult ProjectsByEmployee(int employeeId)
    {
        var projects = _context.EmployeeProjects
            .Where(ep => ep.EmployeeId == employeeId)
            .Select(ep => ep.Project)
            .ToList();

        return View(projects);
    }
    public IActionResult EmployeesPerDepartment()
    {
        var result = _context.Departments
            .Select(d => new
            {
                DepartmentName = d.DepartmentName,
                EmployeeCount = d.Employees.Count()
            })
            .ToList();

        return View(result);
    }
}
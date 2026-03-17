using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    private static List<Employee> employees = new List<Employee>();

    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(Employee emp)
    {
        if (ModelState.IsValid)
        {
            emp.Id = employees.Count + 1;
            employees.Add(emp);

            TempData["Success"] = "Employee registered successfully!";
            return RedirectToAction("Details", new { id = emp.Id });
        }

        return View(emp);
    }

    public IActionResult Details(int id)
    {
        var emp = employees.FirstOrDefault(e => e.Id == id);
        return View(emp);
    }
}
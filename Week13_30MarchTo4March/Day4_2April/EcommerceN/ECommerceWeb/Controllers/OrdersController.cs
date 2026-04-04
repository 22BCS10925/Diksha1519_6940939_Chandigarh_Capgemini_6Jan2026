using Microsoft.AspNetCore.Mvc;
public class OrdersController : Controller
{
    private readonly HttpClient _client;

    public OrdersController(HttpClient client)
    {
        _client = client;
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Order order)
    {
        await _client.PostAsJsonAsync("http://localhost:5211/api/orders", order);
        return RedirectToAction("Success");
    }
}

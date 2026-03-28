using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly AppDbContext _context;

        public AdminController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Dashboard()
        {
            var topProducts = _context.OrderItems
                .GroupBy(o => o.ProductId)
                .Select(g => new
                {
                    ProductId = g.Key,
                    Count = g.Sum(x => x.Quantity)
                })
                .OrderByDescending(x => x.Count)
                .Take(5)
                .ToList();

            var pendingOrders = _context.ShippingDetails
                .Where(s => s.Status != "Delivered")
                .ToList();

            ViewBag.TopProducts = topProducts;
            ViewBag.PendingOrders = pendingOrders;

            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace WebApplication1.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly AppDbContext _context;

        public OrderController(AppDbContext context)
        {
            _context = context;
        }

        // ✅ GET: /Order/Create?productId=2
        [HttpGet]
        public IActionResult Create(int? productId)
        {
            if (productId == null)
                return BadRequest("ProductId is required");

            var product = _context.Products
                .AsNoTracking()
                .FirstOrDefault(p => p.Id == productId);

            if (product == null)
                return NotFound();

            return View(product);
        }

        // ✅ POST: Save Order
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(int productId)
        {
            var username = User.Identity?.Name;

            if (string.IsNullOrEmpty(username))
                return RedirectToAction("Login", "Account");

            var user = _context.Users
                .AsNoTracking()
                .FirstOrDefault(u => u.Username == username);

            if (user == null)
                return RedirectToAction("Login", "Account");

            // ✅ Check product exists
            var productExists = _context.Products.Any(p => p.Id == productId);
            if (!productExists)
                return NotFound();

            var order = new Order
            {
                CustomerId = user.CustomerId,
                OrderDate = DateTime.UtcNow, // ✅ better practice
                Status = "Placed", // ✅ ADD THIS

                OrderItems = new List<OrderItem>
                {
                    new OrderItem
                    {
                        ProductId = productId,
                        Quantity = 1
                    }
                }
            };

            _context.Orders.Add(order);
            _context.SaveChanges();

            return RedirectToAction(nameof(History));
        }

        // ✅ ORDER HISTORY
        public IActionResult History()
        {
            var username = User.Identity?.Name;

            if (string.IsNullOrEmpty(username))
                return RedirectToAction("Login", "Account");

            var user = _context.Users
                .AsNoTracking()
                .FirstOrDefault(u => u.Username == username);

            if (user == null)
                return RedirectToAction("Login", "Account");

            var orders = _context.Orders
                .Where(o => o.CustomerId == user.CustomerId)
                .Include(o => o.OrderItems)
                    .ThenInclude(oi => oi.Product)
                .Include(o => o.ShippingDetail)
                .AsNoTracking()
                .ToList();

            return View(orders);
        }
    }
}
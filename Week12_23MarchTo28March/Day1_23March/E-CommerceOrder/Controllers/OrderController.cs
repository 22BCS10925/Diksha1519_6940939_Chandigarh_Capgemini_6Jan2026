using E_CommerceOrder.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System;

namespace E_CommerceOrder.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly CommerceDbContext _context;

        public OrderController(CommerceDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetOrders()
        {
            var data = _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.Product)
                .ToList();

            return Ok(data);
        }

        [HttpPost]
        public IActionResult CreateOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
            return Ok(order);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ECommerceWebApi.Services;
using ECommerceWebApi.Models;   
namespace ECommerceWebApi.Controllers;


[ApiController]
[Route("api/orders")]
public class OrdersController : ControllerBase
{
    private readonly IOrderService _service;

    public OrdersController(IOrderService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> Create(Order order)
    {
        await _service.PlaceOrder(order);
        return Ok("Order Created");
    }
}

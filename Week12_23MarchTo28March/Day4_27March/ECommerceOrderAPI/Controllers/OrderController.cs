using ECommerceOrderAPI.DTOs;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
// [Authorize]  // enable later when you add JWT
public class OrdersController : ControllerBase
{
    private readonly IOrderService _service;

    public OrdersController(IOrderService service)
    {
        _service = service;
    }

    // ✅ CREATE ORDER
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] OrderDto dto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var result = await _service.CreateOrder(dto);

        return Ok(result);
    }

    // ✅ GET ALL ORDERS
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var orders = await _service.GetAllOrders();
        return Ok(orders);
    }

    // ✅ GET ORDER BY ID
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var order = await _service.GetOrderById(id);

        if (order == null)
            return NotFound("Order not found");

        return Ok(order);
    }

    // ✅ UPDATE ORDER
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] OrderDto dto)
    {
        var result = await _service.UpdateOrder(id, dto);

        if (result == "Order not found")
            return NotFound(result);

        return Ok(result);
    }

    // ✅ DELETE ORDER
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.DeleteOrder(id);

        if (result == "Order not found")
            return NotFound(result);

        return Ok(result);
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartHealthcare.Models.Entities;
using SmartHealthcare.API.Data;

namespace SmartHealthcare.API.Controllers
{
   [ApiController]
[Route("api/Bill")]
public class BillController : ControllerBase
{
    private readonly AppDbContext _context;

    public BillController(AppDbContext context)
    {
        _context = context;
    }

    // GET: api/Bill
    [HttpGet]
    public async Task<IActionResult> GetAllBills()
    {
        var bills = await _context.Bills
            .Include(b => b.Appointment)
            .ToListAsync();

        return Ok(bills);
    }

    // other endpoints (GetBillByAppointment, CreateBill, UpdateBill)...

        // GET: api/Billing/{appointmentId}
        [HttpGet("{appointmentId}")]
        public async Task<IActionResult> GetBillByAppointment(int appointmentId)
        {
            var bill = await _context.Bills
                .Include(b => b.Appointment)
                .FirstOrDefaultAsync(b => b.AppointmentId == appointmentId);

            if (bill == null)
                return NotFound(new { Message = "Bill not found" });

            return Ok(bill);
        }

        // POST: api/Billing
        [HttpPost]
        public async Task<IActionResult> CreateBill([FromBody] Bill bill)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _context.Bills.Add(bill);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBillByAppointment),
                new { appointmentId = bill.AppointmentId }, bill);
        }
        

        // PUT: api/Billing/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBill(int id, [FromBody] Bill bill)
        {
            if (id != bill.BillId)
                return BadRequest();

            _context.Entry(bill).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return Ok(bill);
        }
    }
}
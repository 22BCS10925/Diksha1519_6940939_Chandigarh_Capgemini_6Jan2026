using HealthCareSmart.API.Data;
using HealthCareSmart.Core.Models;
using HealthCareSmart.Core.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace HealthCareSmart.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BillingsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BillingsController(AppDbContext context)
        {
            _context = context;
        }

        private int GetCurrentUserId()
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
            return userIdClaim != null ? int.Parse(userIdClaim.Value) : 0;
        }

        private string GetCurrentRole()
        {
            return User.FindFirst(ClaimTypes.Role)?.Value ?? string.Empty;
        }

        private async Task<int?> GetCurrentPatientIdAsync()
        {
            var userId = GetCurrentUserId();
            var patient = await _context.Patients.FirstOrDefaultAsync(p => p.UserId == userId);
            return patient?.Id;
        }

        private async Task<int?> GetCurrentDoctorIdAsync()
        {
            var userId = GetCurrentUserId();
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == userId);
            if (user?.Role != "Doctor") return null;
            
            // For now, find doctor by matching FullName since UserId relationship is not implemented
            var doctor = await _context.Doctors.FirstOrDefaultAsync(d => d.FullName == user.FullName);
            return doctor?.Id;
        }

        // ✅ Get all billings (filtered by role)
        [Authorize(Roles = "Admin,Doctor,Patient")]
        [HttpGet]
        public async Task<IActionResult> GetBillings()
        {
            var currentRole = GetCurrentRole();
            var currentUserId = GetCurrentUserId();
            var currentPatientId = await GetCurrentPatientIdAsync();
            var currentDoctorId = await GetCurrentDoctorIdAsync();

            // Apply role-based filtering first
            switch (currentRole)
            {
                case "Patient":
                    var billings = await _context.Billings
                        .Include(b => b.Appointment)
                            .ThenInclude(a => a.Doctor)
                        .Include(b => b.Appointment)
                            .ThenInclude(a => a.Patient)
                            .ThenInclude(p => p.User)
                        .Where(b => b.Appointment.PatientId == currentPatientId)
                        .Select(b => new
                        {
                            id = b.Id,
                            appointmentId = b.AppointmentId,
                            doctorName = b.Appointment.Doctor.FullName,
                            patientName = b.Appointment.Patient.User.FullName,
                            consultationFee = b.ConsultationFee,
                            medicineCost = b.MedicineCost,
                            totalAmount = b.ConsultationFee + b.MedicineCost,
                            isPaid = b.IsPaid,
                            paidAt = b.PaidAt
                        })
                        .ToListAsync();
                    return Ok(billings);
                case "Doctor":
                    var doctorBillings = await _context.Billings
                        .Include(b => b.Appointment)
                            .ThenInclude(a => a.Doctor)
                        .Include(b => b.Appointment)
                            .ThenInclude(a => a.Patient)
                            .ThenInclude(p => p.User)
                        .Where(b => b.Appointment.DoctorId == currentDoctorId)
                        .Select(b => new
                        {
                            id = b.Id,
                            appointmentId = b.AppointmentId,
                            doctorName = b.Appointment.Doctor.FullName,
                            patientName = b.Appointment.Patient.User.FullName,
                            consultationFee = b.ConsultationFee,
                            medicineCost = b.MedicineCost,
                            totalAmount = b.ConsultationFee + b.MedicineCost,
                            isPaid = b.IsPaid,
                            paidAt = b.PaidAt
                        })
                        .ToListAsync();
                    return Ok(doctorBillings);
                case "Admin":
                    var adminBillings = await _context.Billings
                        .Include(b => b.Appointment)
                            .ThenInclude(a => a.Doctor)
                        .Include(b => b.Appointment)
                            .ThenInclude(a => a.Patient)
                            .ThenInclude(p => p.User)
                        .Select(b => new
                        {
                            id = b.Id,
                            appointmentId = b.AppointmentId,
                            doctorName = b.Appointment.Doctor.FullName,
                            patientName = b.Appointment.Patient.User.FullName,
                            consultationFee = b.ConsultationFee,
                            medicineCost = b.MedicineCost,
                            totalAmount = b.ConsultationFee + b.MedicineCost,
                            isPaid = b.IsPaid,
                            paidAt = b.PaidAt
                        })
                        .ToListAsync();
                    return Ok(adminBillings);
            }

            // Fallback (should not reach here)
            return Ok(new List<object>());
        }

        // ✅ Get billing by ID (with role-based access control)
        [Authorize(Roles = "Admin,Doctor,Patient")]
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var currentRole = GetCurrentRole();
            var currentPatientId = await GetCurrentPatientIdAsync();
            var currentDoctorId = await GetCurrentDoctorIdAsync();

            var billing = await _context.Billings
                .Include(b => b.Appointment).ThenInclude(a => a.Doctor)
                .Include(b => b.Appointment).ThenInclude(a => a.Patient).ThenInclude(p => p.User)
                .FirstOrDefaultAsync(b => b.Id == id);

            if (billing == null)
                return NotFound(new { message = "Billing record not found" });

            // Check access permissions
            switch (currentRole)
            {
                case "Patient":
                    if (billing.Appointment.PatientId != currentPatientId)
                        return Forbid();
                    break;
                case "Doctor":
                    if (billing.Appointment.DoctorId != currentDoctorId)
                        return Forbid();
                    break;
                case "Admin":
                    // Admin can access all
                    break;
            }

            return Ok(new BillingDTO
            {
                Id = billing.Id,
                AppointmentId = billing.AppointmentId,
                DoctorName = billing.Appointment.Doctor.FullName,
                PatientName = billing.Appointment.Patient.User.FullName,
                ConsultationFee = billing.ConsultationFee,
                MedicineCost = billing.MedicineCost,
                TotalAmount = billing.TotalAmount,
                CreatedAt = billing.CreatedAt,
                IsPaid = billing.IsPaid,
                PaidAt = billing.PaidAt
            });
        }

        // ✅ Process payment (with role-based access control)
        [Authorize(Roles = "Admin,Doctor,Patient")]
        [HttpPost("pay")]
        public async Task<IActionResult> PayBill([FromBody] PaymentDTO payment)
        {
            if (payment == null || payment.BillingId <= 0)
                return BadRequest("Invalid payment data");

            var currentRole = GetCurrentRole();
            var currentPatientId = await GetCurrentPatientIdAsync();
            var currentDoctorId = await GetCurrentDoctorIdAsync();

            var billing = await _context.Billings
                .Include(b => b.Appointment)
                    .ThenInclude(a => a.Patient)
                .Include(b => b.Appointment)
                    .ThenInclude(a => a.Doctor)
                .FirstOrDefaultAsync(b => b.Id == payment.BillingId);

            if (billing == null)
                return NotFound("Billing record not found");

            // Check access permissions
            switch (currentRole)
            {
                case "Patient":
                    if (billing.Appointment.PatientId != currentPatientId)
                        return Forbid();
                    break;
                case "Doctor":
                    if (billing.Appointment.DoctorId != currentDoctorId)
                        return Forbid();
                    break;
                case "Admin":
                    // Admin can pay any bill
                    break;
            }

            if (billing.IsPaid)
                return BadRequest("Bill already paid");

            // Mark billing as paid
            billing.IsPaid = true;
            billing.PaidAt = DateTime.UtcNow;

            // Create payment record for both patient and doctor
            var paymentRecord = new Payment
            {
                BillingId = billing.Id,
                PatientId = billing.Appointment.Patient.Id,
                DoctorId = billing.Appointment.Doctor.Id,
                Amount = payment.Amount,
                PaymentMethod = payment.PaymentMethod,
                Notes = payment.Notes,
                TransactionId = payment.TransactionId,
                PaidAt = DateTime.UtcNow,
                Status = "Completed" // Payment completed
            };

            _context.Payments.Add(paymentRecord);
            await _context.SaveChangesAsync();

            return Ok(new { 
                message = "Payment completed successfully",
                paymentId = paymentRecord.Id,
                amount = paymentRecord.Amount,
                status = paymentRecord.Status,
                paidAt = paymentRecord.PaidAt
            });
        }

        // ✅ Get patient payment history (with role-based access control)
        [Authorize(Roles = "Admin,Doctor,Patient")]
        [HttpGet("patient/{patientId}/payments")]
        public async Task<IActionResult> GetPatientPayments(int patientId)
        {
            var currentRole = GetCurrentRole();
            var currentPatientId = await GetCurrentPatientIdAsync();
            var currentDoctorId = await GetCurrentDoctorIdAsync();

            // Check access permissions
            switch (currentRole)
            {
                case "Patient":
                    if (patientId != currentPatientId)
                        return Forbid();
                    break;
                case "Doctor":
                    // Doctors can view payments for their patients only if they have appointments
                    var hasAccess = await _context.Appointments
                        .AnyAsync(a => a.DoctorId == currentDoctorId && a.PatientId == patientId);
                    if (!hasAccess)
                        return Forbid();
                    break;
                case "Admin":
                    // Admin can view all patient payments
                    break;
            }

            var payments = await _context.Payments
                .Where(p => p.PatientId == patientId)
                .Include(p => p.Billing)
                    .ThenInclude(b => b.Appointment)
                        .ThenInclude(a => a.Doctor)
                .OrderByDescending(p => p.PaidAt)
                .Select(p => new PaymentRecordDTO
                {
                    Id = p.Id,
                    BillingId = p.BillingId,
                    Amount = p.Amount,
                    PaymentMethod = p.PaymentMethod,
                    Notes = p.Notes,
                    TransactionId = p.TransactionId,
                    PaidAt = p.PaidAt,
                    Status = p.Status
                })
                .ToListAsync();

            return Ok(new
            {
                patientId = patientId,
                totalPayments = payments.Count,
                totalAmount = payments.Sum(p => p.Amount),
                payments = payments
            });
        }

        // ✅ Get doctor payment history (with role-based access control)
        [Authorize(Roles = "Admin,Doctor,Patient")]
        [HttpGet("doctor/{doctorId}/payments")]
        public async Task<IActionResult> GetDoctorPayments(int doctorId)
        {
            var currentRole = GetCurrentRole();
            var currentPatientId = await GetCurrentPatientIdAsync();
            var currentDoctorId = await GetCurrentDoctorIdAsync();

            // Check access permissions
            switch (currentRole)
            {
                case "Patient":
                    // Patients can view doctor payments only for their own appointments
                    var hasAccess = await _context.Appointments
                        .AnyAsync(a => a.PatientId == currentPatientId && a.DoctorId == doctorId);
                    if (!hasAccess)
                        return Forbid();
                    break;
                case "Doctor":
                    if (doctorId != currentDoctorId)
                        return Forbid();
                    break;
                case "Admin":
                    // Admin can view all doctor payments
                    break;
            }

            var payments = await _context.Payments
                .Where(p => p.DoctorId == doctorId)
                .Include(p => p.Billing)
                    .ThenInclude(b => b.Appointment)
                        .ThenInclude(a => a.Patient)
                            .ThenInclude(p => p.User)
                .OrderByDescending(p => p.PaidAt)
                .Select(p => new PaymentRecordDTO
                {
                    Id = p.Id,
                    BillingId = p.BillingId,
                    Amount = p.Amount,
                    PaymentMethod = p.PaymentMethod,
                    Notes = p.Notes,
                    TransactionId = p.TransactionId,
                    PaidAt = p.PaidAt,
                    Status = p.Status
                })
                .ToListAsync();

            return Ok(new
            {
                doctorId = doctorId,
                totalPayments = payments.Count,
                totalAmount = payments.Sum(p => p.Amount),
                payments = payments
            });
        }
    }
}



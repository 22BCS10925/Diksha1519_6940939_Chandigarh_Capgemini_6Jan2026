namespace HealthCareSmart.Core.Models
{
    public class Billing
    {
        public int Id { get; set; }
        public int AppointmentId { get; set; }
        public Appointment Appointment { get; set; } = null!;

    public bool IsPaid { get; set; } = false;   // 🔥 NEW
    public DateTime? PaidAt { get; set; }       // 🔥 NEW

        public decimal ConsultationFee { get; set; }
        public decimal MedicineCost { get; set; }
        public decimal TotalAmount => ConsultationFee + MedicineCost;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}

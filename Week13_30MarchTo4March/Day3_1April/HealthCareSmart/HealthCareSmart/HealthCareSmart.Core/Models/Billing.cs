namespace HealthCareSmart.Core.Models
{
    public class Billing
    {
        public int Id { get; set; }
        public int AppointmentId { get; set; }
        public Appointment Appointment { get; set; } = null!;

        public bool IsPaid { get; set; } = false;
        public DateTime? PaidAt { get; set; }

        public decimal ConsultationFee { get; set; }
        public decimal MedicineCost { get; set; }
        public decimal TotalAmount => ConsultationFee + MedicineCost;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}

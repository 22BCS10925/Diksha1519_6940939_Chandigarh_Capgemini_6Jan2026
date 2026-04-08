namespace HealthCareSmart.Core.Models
{
    public class PaymentDTO
    {
        public int BillingId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; } = "Cash"; // optional default
    }
}
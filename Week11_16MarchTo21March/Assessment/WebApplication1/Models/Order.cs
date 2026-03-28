using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{

    public class Order
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;

        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }

        public ICollection<OrderItem>? OrderItems { get; set; }

        public ShippingDetail? ShippingDetail { get; set; }
        [Required]
        public string Status { get; set; } = "Pending";
    }
}

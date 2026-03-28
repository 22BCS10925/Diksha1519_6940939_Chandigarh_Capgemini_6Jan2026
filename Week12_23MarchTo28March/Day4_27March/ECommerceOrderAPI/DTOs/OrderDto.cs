namespace ECommerceOrderAPI.DTOs
{
    public class OrderDto
    {
        public string CustomerName { get; set; }

        public string ProductName { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }
    }
}

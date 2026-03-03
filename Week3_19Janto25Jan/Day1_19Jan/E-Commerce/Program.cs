namespace E_Commerce
{
    class Program
    {
        static void Main()
        {
            
            Product[] products = new Product[3];
            products[0] = new Electronics(1, "Laptop", 60000, 5, 24);
            products[1] = new Clothing(2, "T-Shirt", 799, 10, "M");
            products[2] = new Books(3, "C# Programming", 499, 7, "John");

            Console.WriteLine("PRODUCT LIST");
            for (int i = 0; i < 3; i++)
                products[i].Display();

            Cart cart = new Cart();
            cart.AddToCart(products[0]);
            cart.AddToCart(products[2]);
            cart.ViewCart();

            Customer c1 = new Customer(101, "Diksha");
            Order o1 = new Order(1001, c1, cart);
            o1.PlaceOrder();
        }
    }

}

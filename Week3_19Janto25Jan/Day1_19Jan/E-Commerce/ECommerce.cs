using System;

class Product
{
    public int productId;
    public string name;
    public double price;
    public int stock;
    public string category;

    public Product() { }

    public void Display()
    {
        Console.WriteLine(productId + "  " + name + "  " + price + "  " + stock + "  " + category);
    }
}



class Electronics : Product
{
    public int warranty;

    public Electronics(int id, string n, double p, int s, int w)
    {
        productId = id;
        name = n;
        price = p;
        stock = s;
        category = "Electronics";
        warranty = w;
    }
}

class Clothing : Product
{
    public string size;

    public Clothing(int id, string n, double p, int s, string sz)
    {
        productId = id;
        name = n;
        price = p;
        stock = s;
        category = "Clothing";
        size = sz;
    }
}

class Books : Product
{
    public string author;

    public Books(int id, string n, double p, int s, string a)
    {
        productId = id;
        name = n;
        price = p;
        stock = s;
        category = "Books";
        author = a;
    }
}


class Cart
{
    public Product[] items = new Product[5];
    public int count = 0;

    public void AddToCart(Product p)
    {
        if (p.stock > 0 && count < 5)
        {
            items[count] = p;
            count++;
            p.stock--;
            Console.WriteLine("Product added to cart!");
        }
        else
        {
            Console.WriteLine("Cannot add product!");
        }
    }

    public void ViewCart()
    {
        Console.WriteLine("CART ITEMS ");
        for (int i = 0; i < count; i++)
            items[i].Display();
    }

    public double TotalAmount()
    {
        double total = 0;
        for (int i = 0; i < count; i++)
            total += items[i].price;
        return total;
    }
}


class Customer
{
    public int cid;
    public string cname;

    public Customer(int id, string name)
    {
        cid = id;
        cname = name;
    }
}



class Order
{
    public int orderId;
    public Customer customer;
    public Cart cart;

    public Order(int id, Customer c, Cart ca)
    {
        orderId = id;
        customer = c;
        cart = ca;
    }

    public void PlaceOrder()
    {
        Console.WriteLine(" ORDER DETAILS");
        Console.WriteLine("Order ID : " + orderId);
        Console.WriteLine("Customer : " + customer.cname);
        Console.WriteLine("Total Bill : " + cart.TotalAmount());
    }
}




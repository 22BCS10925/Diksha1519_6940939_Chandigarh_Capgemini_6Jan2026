using System.Collections.Generic;

namespace ECommerceWebApi.Models;

public class Product
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public List<ProductCategory>? ProductCategories { get; set; }
}

public class Category
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public List<ProductCategory>? ProductCategories { get; set; }
}

public class ProductCategory
{
    public int ProductId { get; set; }
    public Product? Product { get; set; }

    public int CategoryId { get; set; }
    public Category? Category { get; set; }
}
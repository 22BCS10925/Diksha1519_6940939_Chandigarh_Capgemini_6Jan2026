using E_CommerceOrder.Models;

namespace E_CommerceOrder.Services
{
    public class ProductService : IProductService
    {
        private readonly CommerceDbContext _context;

        public ProductService(CommerceDbContext context)
        {
            _context = context;
        }

        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public Product Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }
        public List<Product> GetPaged(int page, int pageSize)
        {
            return _context.Products
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }
    }
}

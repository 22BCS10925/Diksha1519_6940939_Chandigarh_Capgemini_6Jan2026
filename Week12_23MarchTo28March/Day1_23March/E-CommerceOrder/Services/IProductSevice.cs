using E_CommerceOrder.Models;

namespace E_CommerceOrder.Services
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product Add(Product product);
    }
}

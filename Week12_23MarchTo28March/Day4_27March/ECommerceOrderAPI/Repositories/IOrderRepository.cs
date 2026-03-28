
using ECommerceOrderAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace ECommerceOrderAPI.Repositories
{

    public interface IOrderRepository
    {
        Task<List<Order>> GetAllAsync();
        Task<Order> GetByIdAsync(int id);
        Task AddOrderAsync(Order order);
        Task UpdateOrderAsync(Order order);
        Task DeleteOrderAsync(int id);
    }
}

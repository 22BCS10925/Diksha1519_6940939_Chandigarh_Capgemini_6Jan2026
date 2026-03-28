using ECommerceOrderAPI.DTOs;
using ECommerceOrderAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface IOrderService
{
    Task<string> CreateOrder(OrderDto dto);
    Task<List<Order>> GetAllOrders();
    Task<Order> GetOrderById(int id);
    Task<string> UpdateOrder(int id, OrderDto dto);
    Task<string> DeleteOrder(int id);
}
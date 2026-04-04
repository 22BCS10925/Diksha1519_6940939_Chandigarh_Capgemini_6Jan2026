namespace ECommerceWebApi.Services;
using ECommerceWebApi.Models;
using ECommerceWebApi.Repository;

public interface IOrderService
{
    Task PlaceOrder(Order order);
}

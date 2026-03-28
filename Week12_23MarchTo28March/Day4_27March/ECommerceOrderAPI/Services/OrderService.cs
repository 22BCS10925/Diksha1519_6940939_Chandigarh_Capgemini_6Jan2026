using AutoMapper;
using ECommerceOrderAPI.DTOs;
using ECommerceOrderAPI.Models;
using ECommerceOrderAPI.Repositories;
using log4net;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _repo;
    private readonly IMapper _mapper;

    private static readonly ILog log = LogManager.GetLogger(typeof(OrderService));

    public OrderService(IOrderRepository repo, IMapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }

    public async Task<string> CreateOrder(OrderDto dto)
    {
        log.Info("CreateOrder started");

        if (dto.Quantity <= 0)
        {
            log.Warn("Invalid quantity");
            return "Invalid quantity";
        }

        var order = _mapper.Map<Order>(dto);

        await _repo.AddOrderAsync(order);

        log.Info("Order created successfully");

        return "Order Created";
    }

    public async Task<List<Order>> GetAllOrders()
    {
        log.Info("Fetching all orders");
        return await _repo.GetAllAsync();
    }

    public async Task<Order> GetOrderById(int id)
    {
        log.Info($"Fetching order with ID {id}");

        var order = await _repo.GetByIdAsync(id);

        if (order == null)
        {
            log.Warn("Order not found");
        }

        return order;
    }

    public async Task<string> UpdateOrder(int id, OrderDto dto)
    {
        log.Info($"Updating order {id}");

        var existing = await _repo.GetByIdAsync(id);

        if (existing == null)
        {
            log.Warn("Order not found");
            return "Order not found";
        }

        // map updated values
        _mapper.Map(dto, existing);

        await _repo.UpdateOrderAsync(existing);

        log.Info("Order updated successfully");

        return "Order Updated";
    }

    public async Task<string> DeleteOrder(int id)
    {
        log.Info($"Deleting order {id}");

        var existing = await _repo.GetByIdAsync(id);

        if (existing == null)
        {
            log.Warn("Order not found");
            return "Order not found";
        }

        await _repo.DeleteOrderAsync(id);

        log.Info("Order deleted successfully");

        return "Order Deleted";
    }
}
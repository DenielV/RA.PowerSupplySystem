using RA.PowerSupplySystem.Domain;

namespace RA.PowerSupplySystem.Application.Contracts.Persistence
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Task<List<Order>> GetAllOrdersWithStatus();
        Task<Order> GetOrderWithStatus(int orderId);    
    }
}

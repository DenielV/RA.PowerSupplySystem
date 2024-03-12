using RA.PowerSupplySystem.Domain;

namespace RA.PowerSupplySystem.Application.Contracts.Persistence
{
    public interface IOrderDetailRepository : IGenericRepository<OrderDetail>
    {
        Task AddOrderDetails(List<OrderDetail> orderDetails);
        Task<List<OrderDetail>> GetOrderDetails(int orderId);
        int GetOrderProductQuantity(int orderId, int productId);
    }
}

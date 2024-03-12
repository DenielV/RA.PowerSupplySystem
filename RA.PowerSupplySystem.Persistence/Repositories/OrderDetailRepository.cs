using Microsoft.EntityFrameworkCore;
using RA.PowerSupplySystem.Application.Contracts.Persistence;
using RA.PowerSupplySystem.Domain;
using RA.PowerSupplySystem.Persistence.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.PowerSupplySystem.Persistence.Repositories
{
    public class OrderDetailRepository : GenericRepository<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(RaDatabaseContext context) : base(context)
        {
        }

        public async Task AddOrderDetails(List<OrderDetail> orderDetails)
        {
            await _context.AddRangeAsync(orderDetails);
            await _context.SaveChangesAsync();
        }

        public async Task<List<OrderDetail>> GetOrderDetails(int orderId)
        {
            return await _context.OrderDetails.AsNoTracking().Where(q => q.OrderId == orderId)
                .Include(q => q.Order).Include(q => q.Product).ToListAsync();
        }

        public int GetOrderProductQuantity(int orderId, int productId)
        {
            return _context.OrderDetails.AsNoTracking().First(q => q.OrderId == orderId && q.ProductId == productId).Quantity;
        }
    }
}

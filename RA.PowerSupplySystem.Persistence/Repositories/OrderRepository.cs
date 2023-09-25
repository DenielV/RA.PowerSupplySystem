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
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(RaDatabaseContext context) : base(context)
        {
        }

        public async Task<List<Order>> GetAllOrdersWithStatus()
        {
            return await _context.Orders.Include(o => o.OrderStatus).AsNoTracking().ToListAsync();
        }
    }
}

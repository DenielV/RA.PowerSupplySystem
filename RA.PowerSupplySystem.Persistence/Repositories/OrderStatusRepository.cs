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
    public class OrderStatusRepository : GenericRepository<OrderStatus>, IOrderStatusRepository
    {
        public OrderStatusRepository(RaDatabaseContext context) : base(context)
        {
        }

        public async Task<OrderStatus> GetOrderStatusByName(string name)
        {
            return await _context.OrderStatuses.FirstOrDefaultAsync(q => q.Name == name);
        }
    }
}

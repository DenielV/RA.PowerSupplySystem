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
    public class UnitRepository : GenericRepository<Unit>, IUnitRepository
    {
        public UnitRepository(RaDatabaseContext context) : base(context)
        {
        }

        public async Task DeleteUnitList(List<Unit> unitList)
        {
            _context.RemoveRange(unitList);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Unit>> GetAllOrderUnitsByProduct(int orderId, int productId)
        {
            return await _context.Units.AsNoTracking().Where(q => q.OrderId == orderId && q.ProductId == productId).ToListAsync();
        }
    }
}

using RA.PowerSupplySystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.PowerSupplySystem.Application.Contracts.Persistence
{
    public interface IUnitRepository : IGenericRepository<Unit>
    {
        Task<List<Unit>> GetAllOrderUnitsByProduct(int orderId, int productId);
        Task DeleteUnitList(List<Unit> unitList);
    }
}

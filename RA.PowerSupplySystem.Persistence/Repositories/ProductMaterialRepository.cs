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
    public class ProductMaterialRepository : GenericRepository<ProductMaterial>, IProductMaterialRepository
    {
        public ProductMaterialRepository(RaDatabaseContext context) : base(context)
        {
        }

        public async Task<List<ProductMaterial>> GetProductsMaterials()
        {
            return await _context.ProductMaterials.AsNoTracking()
                .Include(q => q.Material).ToListAsync();
        }
    }
}

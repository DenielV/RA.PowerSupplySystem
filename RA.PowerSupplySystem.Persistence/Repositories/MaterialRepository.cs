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
    public class MaterialRepository : GenericRepository<Material>, IMaterialRepository
    {
        public MaterialRepository(RaDatabaseContext context) : base(context)
        {
        }

        public async Task UpdateMaterials(List<Material> materials)
        {
            _context.Materials.UpdateRange(materials);
            await _context.SaveChangesAsync();
        }
    }
}

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
    public class MaterialEntryRepository : GenericRepository<MaterialEntry>, IMaterialEntryRepository
    {
        public MaterialEntryRepository(RaDatabaseContext context) : base(context)
        {
        }

        public async Task<List<MaterialEntry>> GetAllMaterialEntries(int materialId)
        {
            return await _context.MaterialEntries.AsNoTracking()
                .Where(q => q.MaterialId== materialId).Include(q => q.Material).ToListAsync();
        }

        public async Task<MaterialEntry> GetLastMaterialEntry(int materialId)
        {
            return await _context.MaterialEntries.AsNoTracking()
                .Where(q => q.MaterialId == materialId).Include(q => q.Material)
                .OrderByDescending(q => q.EntryDate).FirstOrDefaultAsync();
        }
    }
}

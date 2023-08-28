using RA.PowerSupplySystem.Domain;

namespace RA.PowerSupplySystem.Application.Contracts.Persistence
{
    public interface IMaterialEntryRepository : IGenericRepository<MaterialEntry>
    {
        Task<MaterialEntry> GetLastMaterialEntry(int materialId);
        Task<List<MaterialEntry>> GetAllMaterialEntries(int materialId);
    }
}

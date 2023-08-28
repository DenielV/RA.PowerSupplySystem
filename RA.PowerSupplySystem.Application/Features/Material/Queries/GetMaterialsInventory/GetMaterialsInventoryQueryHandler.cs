using AutoMapper;
using MediatR;
using RA.PowerSupplySystem.Application.Contracts.Persistence;

namespace RA.PowerSupplySystem.Application.Features.Material.Queries.GetMaterialsInventory
{
    public class GetMaterialsInventoryQueryHandler : IRequestHandler<GetMaterialsInventoryQuery, List<MaterialInventoryDto>>
    {
        private readonly IMaterialRepository _materialRepository;
        private readonly IMapper _mapper;
        private readonly IMaterialEntryRepository _materialEntryRepository;

        public GetMaterialsInventoryQueryHandler(IMaterialRepository materialRepository, 
            IMapper mapper, IMaterialEntryRepository materialEntryRepository)
        {
            _materialRepository = materialRepository;
            _mapper = mapper;
            _materialEntryRepository = materialEntryRepository;
        }
        public async Task<List<MaterialInventoryDto>> Handle(GetMaterialsInventoryQuery request, CancellationToken cancellationToken)
        {
            var materials = await _materialRepository.GetAllAsync();

            var materialsInventory = _mapper.Map<List<MaterialInventoryDto>>(materials);

            foreach (var mat in materialsInventory)
            {
                var lastEntry = await _materialEntryRepository.GetLastMaterialEntry(mat.Id);
                mat.LastEntryDate = lastEntry.EntryDate;
                mat.LastBatch = lastEntry.Batch;
            }

            return materialsInventory;
        }
    }
}

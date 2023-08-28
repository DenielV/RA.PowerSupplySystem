using AutoMapper;
using MediatR;
using RA.PowerSupplySystem.Application.Contracts.Persistence;

namespace RA.PowerSupplySystem.Application.Features.MaterialEntry.Queries.GetAllMaterialEntries
{
    public class GetAllMaterialEntriesQueryHandler : IRequestHandler<GetAllMaterialEntriesQuery, List<MaterialEntryListDto>>
    {
        private readonly IMaterialEntryRepository _materialEntryRepository;
        private readonly IMapper _mapper;

        public GetAllMaterialEntriesQueryHandler(IMaterialEntryRepository materialEntryRepository, IMapper mapper)
        {
            _materialEntryRepository = materialEntryRepository;
            _mapper = mapper;
        }
        public async Task<List<MaterialEntryListDto>> Handle(GetAllMaterialEntriesQuery request, CancellationToken cancellationToken)
        {
            var materialEntries = await _materialEntryRepository.GetAllMaterialEntries(request.materialId);

            return _mapper.Map<List<MaterialEntryListDto>>(materialEntries);
        }
    }
}

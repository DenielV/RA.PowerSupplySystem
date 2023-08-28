using AutoMapper;
using MediatR;
using RA.PowerSupplySystem.Application.Contracts.Persistence;

namespace RA.PowerSupplySystem.Application.Features.Material.Queries.GetAllMaterials
{
    public class GetAllMaterialsQueryHandler : IRequestHandler<GetAllMaterialsQuery, List<MaterialListDto>>
    {
        private readonly IMaterialRepository _materialRepository;
        private readonly IMapper _mapper;

        public GetAllMaterialsQueryHandler(IMaterialRepository materialRepository, IMapper mapper)
        {
            _materialRepository = materialRepository;
            _mapper = mapper;
        }
        public async Task<List<MaterialListDto>> Handle(GetAllMaterialsQuery request, CancellationToken cancellationToken)
        {
            var materials = await _materialRepository.GetAllAsync();

            return _mapper.Map<List<MaterialListDto>>(materials);
        }
    }
}

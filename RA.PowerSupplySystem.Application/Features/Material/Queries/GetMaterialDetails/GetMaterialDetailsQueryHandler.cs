using AutoMapper;
using MediatR;
using RA.PowerSupplySystem.Application.Contracts.Persistence;

namespace RA.PowerSupplySystem.Application.Features.Material.Queries.GetMaterialDetails
{
    public class GetMaterialDetailsQueryHandler : IRequestHandler<GetMaterialDetailsQuery, MaterialDetailsDto>
    {
        private readonly IMaterialRepository _materialRepository;
        private readonly IMapper _mapper;

        public GetMaterialDetailsQueryHandler(IMaterialRepository materialRepository, IMapper mapper)
        {
            _materialRepository = materialRepository;
            _mapper = mapper;
        }
        public async Task<MaterialDetailsDto> Handle(GetMaterialDetailsQuery request, CancellationToken cancellationToken)
        {
            var material = await _materialRepository.GetAsync(request.Id);

            return _mapper.Map<MaterialDetailsDto>(material);
        }
    }
}

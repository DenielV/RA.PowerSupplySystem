using AutoMapper;
using MediatR;
using RA.PowerSupplySystem.Application.Contracts.Persistence;
using RA.PowerSupplySystem.Application.Exceptions;
using RA.PowerSupplySystem.Application.Responses;
using RA.PowerSupplySystem.Domain;

namespace RA.PowerSupplySystem.Application.Features.MaterialEntry.Commands.CreateMaterialEntry
{
    public class CreateMaterialEntryCommandHandler : IRequestHandler<CreateMaterialEntryCommand, BaseCommandResponse>
    {
        private readonly IMaterialEntryRepository _materialEntryRepository;
        private readonly IMaterialRepository _materialRepository;
        private readonly IMapper _mapper;

        public CreateMaterialEntryCommandHandler(IMaterialEntryRepository materialEntryRepository, 
            IMaterialRepository materialRepository, IMapper mapper)
        {
           _materialEntryRepository = materialEntryRepository;
           _materialRepository = materialRepository;
            _mapper = mapper;
        }
        public async Task<BaseCommandResponse> Handle(CreateMaterialEntryCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateMaterialEntryCommandValidator(_materialRepository);
            var validationResult = await validator.ValidateAsync(request);

            if(validationResult.Errors.Any()) 
            {
                throw new BadRequestException("Invalid Material Entry", validationResult);
            }

            var materialEntry = _mapper.Map<Domain.MaterialEntry>(request);
            materialEntry.EntryDate = DateTime.Now;
            materialEntry.Batch = Guid.NewGuid().ToString();

            await _materialEntryRepository.CreateAsync(materialEntry);

            var material = await _materialRepository.GetAsync(request.MaterialId);
            material.Stock += request.Quantity;

            await _materialRepository.UpdateAsync(material);

            return new BaseCommandResponse
            {
                Id = materialEntry.Id,
                Message = "Material entry created successfully",
                Success = true
            };
        }
    }
}

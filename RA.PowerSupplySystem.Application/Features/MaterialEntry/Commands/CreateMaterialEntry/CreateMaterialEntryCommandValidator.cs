using FluentValidation;
using RA.PowerSupplySystem.Application.Contracts.Persistence;

namespace RA.PowerSupplySystem.Application.Features.MaterialEntry.Commands.CreateMaterialEntry
{
    public class CreateMaterialEntryCommandValidator : AbstractValidator<CreateMaterialEntryCommand>
    {
        private readonly IMaterialRepository _materialRepository;

        public CreateMaterialEntryCommandValidator(IMaterialRepository materialRepository)
        {
            this._materialRepository = materialRepository;

            RuleFor(q => q.MaterialId)
                .NotNull().WithMessage("{PropertyName} is required")
                .MustAsync(MaterialMustExist).WithMessage("Material with Id '{PropertyValue}' does not exist");

            RuleFor(q => q.Quantity)
                .NotNull().WithMessage("{PropertyName} is required")
                .GreaterThan(0).WithMessage("{PropertyName} must be greater than {ComparisonValue}");
        }

        private async Task<bool> MaterialMustExist(int materialId, CancellationToken token)
        {
            var material = await _materialRepository.GetAsync(materialId);
            return material != null;
        }
    }
}

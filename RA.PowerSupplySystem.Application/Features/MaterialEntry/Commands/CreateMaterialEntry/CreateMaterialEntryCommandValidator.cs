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
                .NotNull().WithMessage("El campo {PropertyName} is obligatorio.")
                .MustAsync(MaterialMustExist).WithMessage("El material con Id '{PropertyValue}' no existe.");

            RuleFor(q => q.Quantity)
                .NotNull().WithMessage("El campo {PropertyName} is obligatorio.")
                .GreaterThan(0).WithMessage("{PropertyName} debe ser mayor a {ComparisonValue}.");
        }

        private async Task<bool> MaterialMustExist(int materialId, CancellationToken token)
        {
            var material = await _materialRepository.GetAsync(materialId);
            return material != null;
        }
    }
}

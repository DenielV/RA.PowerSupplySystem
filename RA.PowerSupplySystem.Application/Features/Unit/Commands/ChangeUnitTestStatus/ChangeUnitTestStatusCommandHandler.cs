using MediatR;
using RA.PowerSupplySystem.Application.Contracts.Persistence;
using RA.PowerSupplySystem.Application.Exceptions;
using RA.PowerSupplySystem.Application.Responses;

namespace RA.PowerSupplySystem.Application.Features.Unit.Commands.ChangeUnitTestStatus
{
    public class ChangeUnitTestStatusCommandHandler : IRequestHandler<ChangeUnitTestStatusCommand, BaseCommandResponse>
    {
        private readonly IUnitRepository _unitRepository;

        public ChangeUnitTestStatusCommandHandler(IUnitRepository unitRepository)
        {
            _unitRepository = unitRepository;
        }

        public async Task<BaseCommandResponse> Handle(ChangeUnitTestStatusCommand request, CancellationToken cancellationToken)
        {
            var unit = await _unitRepository.GetAsync(request.UnitId);

            if (unit is null)
                throw new NotFoundException(nameof(Domain.Unit), request.UnitId);

            unit.TestPassed = request.TestPassed;

            await _unitRepository.UpdateAsync(unit);

            return new BaseCommandResponse
            {
                Id = unit.Id,
                Message = "El estado de prueba de la unidad se actualizó exitosamente",
                Success = true,
            };
        }
    }
}

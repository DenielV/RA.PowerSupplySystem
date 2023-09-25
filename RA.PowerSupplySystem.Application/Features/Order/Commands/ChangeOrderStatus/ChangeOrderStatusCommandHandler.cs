using MediatR;
using RA.PowerSupplySystem.Application.Contracts.Persistence;
using RA.PowerSupplySystem.Application.Exceptions;
using RA.PowerSupplySystem.Application.Responses;

namespace RA.PowerSupplySystem.Application.Features.Order.Commands.ChangeOrderStatus
{
    public class ChangeOrderStatusCommandHandler : IRequestHandler<ChangeOrderStatusCommand, BaseCommandResponse>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderStatusRepository _orderStatusRepository;

        public ChangeOrderStatusCommandHandler(IOrderRepository orderRepository, IOrderStatusRepository orderStatusRepository)
        {
            _orderRepository = orderRepository;
            _orderStatusRepository = orderStatusRepository;
        }
        public async Task<BaseCommandResponse> Handle(ChangeOrderStatusCommand request, CancellationToken cancellationToken)
        {
            var validator = new ChangeOrderStatusCommandValidator(_orderRepository, _orderStatusRepository);
            var validationResult = await validator.ValidateAsync(request);

            if(validationResult.Errors.Any())
            {
                throw new BadRequestException("Cambio de status invalido", validationResult);
            }

            var order = await _orderRepository.GetAsync(request.OrderId);

            order.OrderStatusId = request.OrderStatusId;

            await _orderRepository.UpdateAsync(order);

            return new BaseCommandResponse
            {
                Id = request.OrderId,
                Message = "Status de orden actualizado correctamente",
                Success = true,
            };
        }
    }
}

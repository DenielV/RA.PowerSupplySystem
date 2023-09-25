using FluentValidation;
using RA.PowerSupplySystem.Application.Contracts.Persistence;
using RA.PowerSupplySystem.Domain;

namespace RA.PowerSupplySystem.Application.Features.Order.Commands.ChangeOrderStatus
{
    public class ChangeOrderStatusCommandValidator : AbstractValidator<ChangeOrderStatusCommand>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderStatusRepository _orderStatusRepository;

        public ChangeOrderStatusCommandValidator(IOrderRepository orderRepository, IOrderStatusRepository orderStatusRepository)
        {
            _orderRepository = orderRepository;
            _orderStatusRepository = orderStatusRepository;

            RuleFor(q => q.OrderId)
                .NotNull().WithMessage("El campo {PropertyName} is obligatorio.")
                .MustAsync(OrderMustExist).WithMessage("La orden con Id '{PropertyValue}' no existe.");

            RuleFor(q => q.OrderStatusId)
                .NotNull().WithMessage("El campo {PropertyName} is obligatorio.")
                .MustAsync(StatusMustExist).WithMessage("El status con Id '{PropertyValue}' no existe.");

            RuleFor(q => q)
                .MustAsync(ValidStatus).WithMessage("Status invalido para esta orden");
        }

        private async Task<bool> ValidStatus(ChangeOrderStatusCommand orderStatusCommand, CancellationToken token)
        {
            var status = await _orderStatusRepository.GetAsync(orderStatusCommand.OrderStatusId);
            var order = await _orderRepository.GetAsync(orderStatusCommand.OrderId);

            return order.OrderStatusId == status.PreviousStatusId;
        }

        private async Task<bool> OrderMustExist(int orderId, CancellationToken token)
        {
            var order = await _orderRepository.GetAsync(orderId);
            return order != null;
        }

        private async Task<bool> StatusMustExist(int statusId, CancellationToken token)
        {
            var status = await _orderStatusRepository.GetAsync(statusId);
            return status != null;
        }
    }
}

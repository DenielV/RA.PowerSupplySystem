using MediatR;
using RA.PowerSupplySystem.Application.Contracts.Persistence;
using RA.PowerSupplySystem.Application.Exceptions;
using RA.PowerSupplySystem.Application.Responses.Orders;
using RA.PowerSupplySystem.Domain;

namespace RA.PowerSupplySystem.Application.Features.Order.Commands.CheckForOrderCompletion
{
    public class CheckForOrderCompletionCommandHandler : IRequestHandler<CheckForOrderCompletionCommand, CheckForOrderCompletionResponse>
    {
        private readonly IOrderDetailRepository _orderDetailRepository;
        private readonly IUnitRepository _unitRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderStatusRepository _orderStatusRepository;

        public CheckForOrderCompletionCommandHandler(IOrderDetailRepository orderDetailRepository,
            IUnitRepository unitRepository, IOrderRepository orderRepository, IOrderStatusRepository orderStatusRepository)
        {
            _orderDetailRepository = orderDetailRepository;
            _unitRepository = unitRepository;
            _orderRepository = orderRepository;
            _orderStatusRepository = orderStatusRepository;
        }
        public async Task<CheckForOrderCompletionResponse> Handle(CheckForOrderCompletionCommand request, CancellationToken cancellationToken)
        {
            var orderDetails = await _orderDetailRepository.GetOrderDetails(request.OrderId);

            if (orderDetails is null || orderDetails.Count < 1)
            {
                throw new NotFoundException(nameof(Domain.OrderDetail), request.OrderId);
            }

            bool completed = true;


            foreach (var detail in orderDetails)
            {
                var units = await _unitRepository.GetAllOrderUnitsByProduct(request.OrderId, detail.ProductId);
                if (units.Count < detail.Quantity)
                {
                    completed = false;
                }
            }

            if (completed)
            {
                bool reworkNeeded = false;
                foreach (var detail in orderDetails)
                {
                    var units = await _unitRepository.GetAllOrderUnitsByProduct(request.OrderId, detail.ProductId);
                    var unitsToRework = units.Where(q => !q.TestPassed).ToList();
                    
                    if (!reworkNeeded)
                    {
                        reworkNeeded = unitsToRework.Any();
                    }
                    await _unitRepository.DeleteUnitList(unitsToRework);
                }
                var order = await _orderRepository.GetOrderWithStatus(request.OrderId);
                if (reworkNeeded)
                {
                    var reworkStatus = await _orderStatusRepository.GetOrderStatusByName("En retrabajo");
                    order.OrderStatusId = reworkStatus.Id;
                }
                else
                {
                    order.OrderStatusId = (int)order.OrderStatus.NextStatusId;
                }
                await _orderRepository.UpdateAsync(order);
            }

            return new CheckForOrderCompletionResponse
            {
                OrderId = request.OrderId,
                Completed = completed,
            };
        }
    }
}

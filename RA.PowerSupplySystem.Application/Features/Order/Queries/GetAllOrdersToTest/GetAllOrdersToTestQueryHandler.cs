using AutoMapper;
using MediatR;
using RA.PowerSupplySystem.Application.Contracts.Persistence;
using RA.PowerSupplySystem.Application.Features.Order.Queries.Shared;

namespace RA.PowerSupplySystem.Application.Features.Order.Queries.GetAllOrdersToTest
{
    public class GetAllOrdersToTestQueryHandler : IRequestHandler<GetAllOrdersToTestQuery, List<OrderListDto>>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public GetAllOrdersToTestQueryHandler(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }
        public async Task<List<OrderListDto>> Handle(GetAllOrdersToTestQuery request, CancellationToken cancellationToken)
        {
            var orders = await _orderRepository.GetAllOrdersWithStatus();
            var ordersToTest = orders.Where(q => q.OrderStatus.Name.Contains("En pruebas"));
            return _mapper.Map<List<OrderListDto>>(ordersToTest);
        }
    }
}

using AutoMapper;
using MediatR;
using RA.PowerSupplySystem.Application.Contracts.Persistence;

namespace RA.PowerSupplySystem.Application.Features.Unit.Queries.GetOrderUnitsToRework
{
    public class GetOrderUnitsToReworkQueryHandler : IRequestHandler<GetOrderUnitsToReworkQuery, List<UnitDto>>
    {
        private readonly IUnitRepository _unitRepository;
        private readonly IMapper _mapper;
        private readonly IOrderDetailRepository _orderDetailRepository;

        public GetOrderUnitsToReworkQueryHandler(IUnitRepository unitRepository, IMapper mapper,
            IOrderDetailRepository orderDetailRepository)
        {
            _unitRepository = unitRepository;
            _mapper = mapper;
            _orderDetailRepository = orderDetailRepository;
        }
        public async Task<List<UnitDto>> Handle(GetOrderUnitsToReworkQuery request, CancellationToken cancellationToken)
        {
            var orderDetails = await _orderDetailRepository.GetOrderDetails(request.OrderId);

            List<Domain.Unit> units = new List<Domain.Unit>();

            foreach (var detail in orderDetails)
            {
                var orderUnits = await _unitRepository.GetAllOrderUnitsByProduct(request.OrderId, detail.ProductId);
                var unitsToRework = orderUnits.Where(q => !q.TestPassed);
                units.AddRange(unitsToRework);
            }

            return _mapper.Map<List<UnitDto>>(units);
        }
    }
}

using AutoMapper;
using MediatR;
using RA.PowerSupplySystem.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.PowerSupplySystem.Application.Features.OrderDetail.Queries.GetOrderDetails
{
    public record GetOrderDetailsQuery(int OrderId) : IRequest<List<OrderDetailDto>>;

    public class GetOrderDetailsQueryHandler : IRequestHandler<GetOrderDetailsQuery, List<OrderDetailDto>>
    {
        private readonly IOrderDetailRepository _orderDetailRepository;
        private readonly IMapper _mapper;

        public GetOrderDetailsQueryHandler(IOrderDetailRepository orderDetailRepository, IMapper mapper)
        {
           _orderDetailRepository = orderDetailRepository;
           _mapper = mapper;
        }
        public async Task<List<OrderDetailDto>> Handle(GetOrderDetailsQuery request, CancellationToken cancellationToken)
        {
            var orderDetails = await _orderDetailRepository.GetOrderDetails(request.OrderId);
            return _mapper.Map<List<OrderDetailDto>>(orderDetails);
        }
    }
}

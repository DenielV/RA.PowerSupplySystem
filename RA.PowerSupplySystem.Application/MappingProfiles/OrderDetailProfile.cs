using AutoMapper;
using RA.PowerSupplySystem.Application.Features.Order.Commands.CreateOrder;
using RA.PowerSupplySystem.Application.Features.OrderDetail.Queries.GetOrderDetails;
using RA.PowerSupplySystem.Domain;

namespace RA.PowerSupplySystem.Application.MappingProfiles
{
    public class OrderDetailProfile : Profile
    {
        public OrderDetailProfile()
        {
            CreateMap<OrderDetail, OrderProductDto>().ReverseMap();
            CreateMap<OrderDetail, OrderDetailDto>().ReverseMap();
        }
    }
}

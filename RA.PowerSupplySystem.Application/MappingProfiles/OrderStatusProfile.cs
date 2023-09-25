using AutoMapper;
using RA.PowerSupplySystem.Application.Features.Order.Queries.GetAllOrders;
using RA.PowerSupplySystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.PowerSupplySystem.Application.MappingProfiles
{
    public class OrderStatusProfile : Profile
    {
        public OrderStatusProfile()
        {
            CreateMap<OrderStatus, OrderStatusDto>().ReverseMap();
        }
    }
}

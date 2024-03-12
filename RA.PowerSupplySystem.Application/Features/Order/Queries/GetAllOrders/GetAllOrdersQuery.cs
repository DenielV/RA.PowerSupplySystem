using MediatR;
using RA.PowerSupplySystem.Application.Features.Order.Queries.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.PowerSupplySystem.Application.Features.Order.Queries.GetAllOrders
{
    public record GetAllOrdersQuery : IRequest<List<OrderListDto>>;
}

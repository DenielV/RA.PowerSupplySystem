using MediatR;
using RA.PowerSupplySystem.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.PowerSupplySystem.Application.Features.Order.Commands.ChangeOrderStatus
{
    public class ChangeOrderStatusCommand : IRequest<BaseCommandResponse>
    {
        public int OrderId { get; set; }
        public int OrderStatusId { get; set; }
    }
}

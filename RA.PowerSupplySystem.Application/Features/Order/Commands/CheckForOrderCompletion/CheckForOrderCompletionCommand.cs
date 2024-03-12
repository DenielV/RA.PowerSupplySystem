using MediatR;
using RA.PowerSupplySystem.Application.Responses.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.PowerSupplySystem.Application.Features.Order.Commands.CheckForOrderCompletion
{
    public class CheckForOrderCompletionCommand : IRequest<CheckForOrderCompletionResponse>
    {
        public int OrderId { get; set; }
    }
}

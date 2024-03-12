using MediatR;
using RA.PowerSupplySystem.Application.Responses;
using RA.PowerSupplySystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.PowerSupplySystem.Application.Features.Unit.Commands.CreateUnit
{
    public class CreateUnitCommand : IRequest<BaseCommandResponse>
    {
        public int ProductId { get; set; }  
        public int OrderId { get; set; }
        public bool TestPassed { get; set; }
    }
}

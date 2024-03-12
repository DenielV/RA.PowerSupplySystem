using MediatR;
using RA.PowerSupplySystem.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.PowerSupplySystem.Application.Features.Unit.Commands.ChangeUnitTestStatus
{
    public class ChangeUnitTestStatusCommand : IRequest<BaseCommandResponse>
    {
        public int UnitId { get; set; }
        public bool TestPassed { get; set; }
    }
}

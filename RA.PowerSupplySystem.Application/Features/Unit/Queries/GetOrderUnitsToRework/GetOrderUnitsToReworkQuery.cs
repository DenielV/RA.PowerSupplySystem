using MediatR;
using RA.PowerSupplySystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.PowerSupplySystem.Application.Features.Unit.Queries.GetOrderUnitsToRework
{
    public class GetOrderUnitsToReworkQuery : IRequest<List<UnitDto>>
    {
        public int OrderId { get; set; }
    }
}

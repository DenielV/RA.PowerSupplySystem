using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.PowerSupplySystem.Application.Features.Material.Queries.GetMaterialsInventory
{
    public record GetMaterialsInventoryQuery : IRequest<List<MaterialInventoryDto>>;
}

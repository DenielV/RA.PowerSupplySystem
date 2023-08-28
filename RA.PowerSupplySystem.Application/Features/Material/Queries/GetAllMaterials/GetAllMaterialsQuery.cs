using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.PowerSupplySystem.Application.Features.Material.Queries.GetAllMaterials
{
    public record GetAllMaterialsQuery : IRequest<List<MaterialListDto>>;
}

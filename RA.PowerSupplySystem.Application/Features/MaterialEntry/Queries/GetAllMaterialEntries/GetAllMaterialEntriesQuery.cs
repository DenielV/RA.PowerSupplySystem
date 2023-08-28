using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.PowerSupplySystem.Application.Features.MaterialEntry.Queries.GetAllMaterialEntries
{
    public record GetAllMaterialEntriesQuery(int materialId) : IRequest<List<MaterialEntryListDto>>;
}

using MediatR;
using Microsoft.AspNetCore.Http;
using RA.PowerSupplySystem.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.PowerSupplySystem.Application.Features.MaterialEntry.Commands.CreateMaterialEntry
{
    public class CreateMaterialEntryCommand : IRequest<BaseCommandResponse>
    {
        public int MaterialId { get; set; }
        public int Quantity { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}

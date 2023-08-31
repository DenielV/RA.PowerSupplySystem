using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RA.PowerSupplySystem.Application.Features.Material.Queries.GetAllMaterials;
using RA.PowerSupplySystem.Application.Features.MaterialEntry.Commands.CreateMaterialEntry;
using RA.PowerSupplySystem.Application.Features.MaterialEntry.Queries.GetAllMaterialEntries;
using RA.PowerSupplySystem.Application.Responses;

namespace RA.PowerSupplySystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialEntriesController : BaseController
    {
        public MaterialEntriesController(IMediator mediator) : base(mediator)
        {
        }

        // GET: api/<MaterialEntriesController>/1
        [HttpGet("{materialId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<MaterialEntryListDto>>> Get(int materialId)
        {
            var materialEntries = await _mediator.Send(new GetAllMaterialEntriesQuery(materialId));
            return Ok(materialEntries);
        }

        // POST: api/<MaterialEntriesController>
        [HttpPost()]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<BaseCommandResponse>> Post([FromBody] CreateMaterialEntryCommand createMaterialEntryCommand)
        {
            var response = await _mediator.Send(createMaterialEntryCommand);
            return Ok(response);
        }
    }
}

using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RA.PowerSupplySystem.Application.Features.Order.Commands.CreateOrder;
using RA.PowerSupplySystem.Application.Features.Unit.Commands.ChangeUnitTestStatus;
using RA.PowerSupplySystem.Application.Features.Unit.Commands.CreateUnit;
using RA.PowerSupplySystem.Application.Features.Unit.Queries.GetOrderUnitsToRework;
using RA.PowerSupplySystem.Application.Responses;

namespace RA.PowerSupplySystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitsController : BaseController
    {
        public UnitsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<BaseCommandResponse>> Post([FromBody] CreateUnitCommand createUnitCommand)
        {
            var response = await _mediator.Send(createUnitCommand);
            return Ok(response);
        }

        [HttpPut("[action]")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<BaseCommandResponse>> ChangeUnitTestStatus([FromBody] ChangeUnitTestStatusCommand changeUnitTestStatusCommand)
        {
            var response = await _mediator.Send(changeUnitTestStatusCommand);
            return Ok(response);
        }

        [HttpGet("[action]/{orderId}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<UnitDto>>> GetOrderUnitsToRework(int orderId)
        {
            var response = await _mediator.Send(new GetOrderUnitsToReworkQuery { OrderId = orderId });
            return Ok(response);
        }
    }
}

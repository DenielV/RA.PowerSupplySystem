using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RA.PowerSupplySystem.Application.Features.MaterialEntry.Commands.CreateMaterialEntry;
using RA.PowerSupplySystem.Application.Features.MaterialEntry.Queries.GetAllMaterialEntries;
using RA.PowerSupplySystem.Application.Features.Order.Commands.CreateOrder;
using RA.PowerSupplySystem.Application.Features.Order.Queries.GetAllOrders;
using RA.PowerSupplySystem.Application.Responses;

namespace RA.PowerSupplySystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : BaseController
    {
        public OrdersController(IMediator mediator) : base(mediator)
        {
        }

        // GET: api/<OrdersController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<OrderListDto>>> Get()
        {
            var orders = await _mediator.Send(new GetAllOrdersQuery());
            return Ok(orders);
        }

        // POST: api/<OrdersController>
        [HttpPost()]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<BaseCommandResponse>> Post([FromBody] CreateOrderCommand createOrderCommand)
        {
            var response = await _mediator.Send(createOrderCommand);
            return Ok(response);
        }
    }
}

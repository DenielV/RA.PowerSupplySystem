using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RA.PowerSupplySystem.Application.Features.MaterialEntry.Commands.CreateMaterialEntry;
using RA.PowerSupplySystem.Application.Features.MaterialEntry.Queries.GetAllMaterialEntries;
using RA.PowerSupplySystem.Application.Features.Order.Commands.ChangeOrderStatus;
using RA.PowerSupplySystem.Application.Features.Order.Commands.CheckForOrderCompletion;
using RA.PowerSupplySystem.Application.Features.Order.Commands.CreateOrder;
using RA.PowerSupplySystem.Application.Features.Order.Queries.GetAllOrders;
using RA.PowerSupplySystem.Application.Features.Order.Queries.GetAllOrdersToTest;
using RA.PowerSupplySystem.Application.Features.Order.Queries.Shared;
using RA.PowerSupplySystem.Application.Responses;
using RA.PowerSupplySystem.Application.Responses.Orders;

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
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<OrderListDto>>> Get()
        {
            var orders = await _mediator.Send(new GetAllOrdersQuery());
            return Ok(orders);
        }

        [HttpGet("GetOrdersToTest")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<OrderListDto>>> GetOrdersToTest()
        {
            var orders = await _mediator.Send(new GetAllOrdersToTestQuery());
            return Ok(orders);
        }

        [HttpGet("CheckForOrderCompletion/{orderId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CheckForOrderCompletionResponse>> CheckForOrderCompletion(int orderId)
        {
            var response = await _mediator.Send(new CheckForOrderCompletionCommand { OrderId = orderId });
            return Ok(response);
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

        [HttpPost("ChangeStatus")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<BaseCommandResponse>> ChangeStatus([FromBody] ChangeOrderStatusCommand changeOrderStatusCommand)
        {
            var response = await _mediator.Send(changeOrderStatusCommand);
            return Ok(response);
        }
    }
}

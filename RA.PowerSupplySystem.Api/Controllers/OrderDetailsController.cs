using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RA.PowerSupplySystem.Application.Features.Order.Commands.CreateOrder;
using RA.PowerSupplySystem.Application.Features.Order.Queries.GetAllOrders;
using RA.PowerSupplySystem.Application.Features.OrderDetail.Queries.GetOrderDetails;
using RA.PowerSupplySystem.Application.Responses;

namespace RA.PowerSupplySystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : BaseController
    {
        public OrderDetailsController(IMediator mediator) : base(mediator)
        {
        }

        // GET: api/<OrderDetailsController>/orderId
        [HttpGet("{orderId}")]
        public async Task<ActionResult<List<OrderDetailDto>>> Get(int orderId)
        {
            var orderDetails = await _mediator.Send(new GetOrderDetailsQuery(orderId));
            return Ok(orderDetails);
        }
    }
}

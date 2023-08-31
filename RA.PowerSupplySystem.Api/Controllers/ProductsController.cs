using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RA.PowerSupplySystem.Application.Features.OrderDetail.Queries.GetOrderDetails;
using RA.PowerSupplySystem.Application.Features.Product.Queries.GetAllProducts;

namespace RA.PowerSupplySystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : BaseController
    {
        public ProductsController(IMediator mediator) : base(mediator)
        {
        }

        // GET: api/<ProductsController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<ProductDto>>> Get()
        {
            var products = await _mediator.Send(new GetAllProductsQuery());
            return Ok(products);
        }
    }
}

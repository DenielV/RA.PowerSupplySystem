using MediatR;
using Microsoft.AspNetCore.Mvc;
using RA.PowerSupplySystem.Application.Features.Material.Queries.GetAllMaterials;
using RA.PowerSupplySystem.Application.Features.Material.Queries.GetMaterialDetails;
using RA.PowerSupplySystem.Application.Features.Material.Queries.GetMaterialsInventory;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RA.PowerSupplySystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialsController : BaseController
    {
        public MaterialsController(IMediator mediator) : base(mediator)
        {
        }

        // GET: api/<MaterialsController>
        [HttpGet]
        public async Task<ActionResult<List<MaterialListDto>>> Get()
        {
            var materials = await _mediator.Send(new GetAllMaterialsQuery());
            return Ok(materials);
        }

        // GET api/<MaterialsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MaterialDetailsDto>> Get(int id)
        {
            var material = await _mediator.Send(new GetMaterialDetailsQuery(id));
            return Ok(material);
        }

        //GET api/<MaterialsController>/GetInventory
        [HttpGet("[action]")]
        public async Task<ActionResult<List<MaterialInventoryDto>>> GetInventory()
        {
            var inventory = await _mediator.Send(new GetMaterialsInventoryQuery());
            return Ok(inventory);
        }

        
    }
}

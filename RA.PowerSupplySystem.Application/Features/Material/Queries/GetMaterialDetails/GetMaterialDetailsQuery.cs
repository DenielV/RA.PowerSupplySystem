using MediatR;

namespace RA.PowerSupplySystem.Application.Features.Material.Queries.GetMaterialDetails
{
    public record GetMaterialDetailsQuery(int Id) : IRequest<MaterialDetailsDto>;
}

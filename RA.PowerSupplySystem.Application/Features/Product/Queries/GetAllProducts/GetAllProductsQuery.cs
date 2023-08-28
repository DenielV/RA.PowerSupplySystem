using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.PowerSupplySystem.Application.Features.Product.Queries.GetAllProducts
{
    public record GetAllProductsQuery : IRequest<List<ProductDto>>;
}

using RA.PowerSupplySystem.Application.Features.Product.Queries.GetAllProducts;
using RA.PowerSupplySystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.PowerSupplySystem.Application.Features.OrderDetail.Queries.GetOrderDetails
{
    public class OrderDetailDto
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public ProductDto Product { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}

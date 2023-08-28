using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.PowerSupplySystem.Application.Features.Order.Commands.CreateOrder
{
    public class OrderProductDto
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}

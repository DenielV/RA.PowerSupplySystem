using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.PowerSupplySystem.Application.Features.Order.Queries.GetAllOrders
{
    public class OrderListDto
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }
        public OrderStatusDto OrderStatus { get; set; }
        public int OrderStatusId { get; set; }
    }
}

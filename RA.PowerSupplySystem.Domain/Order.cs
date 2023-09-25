using RA.PowerSupplySystem.Domain.Common;
using System.Data.SqlTypes;

namespace RA.PowerSupplySystem.Domain
{
    public class Order : BaseEntity
    {
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public int OrderStatusId { get; set; }
    }
}

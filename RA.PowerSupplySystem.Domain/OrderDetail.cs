using RA.PowerSupplySystem.Domain.Common;

namespace RA.PowerSupplySystem.Domain
{
    public class OrderDetail : BaseEntity
    {
        public Order Order { get; set; }
        public int OrderId { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}

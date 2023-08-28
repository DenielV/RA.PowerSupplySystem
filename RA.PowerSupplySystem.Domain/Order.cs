using RA.PowerSupplySystem.Domain.Common;
using System.Data.SqlTypes;

namespace RA.PowerSupplySystem.Domain
{
    public class Order : BaseEntity
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }
    }
}

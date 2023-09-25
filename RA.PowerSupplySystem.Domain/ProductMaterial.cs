using RA.PowerSupplySystem.Domain.Common;

namespace RA.PowerSupplySystem.Domain
{
    public class ProductMaterial : BaseEntity
    {
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public Material Material { get; set; }
        public int MaterialId { get; set; }
        public int Quantity { get; set; }
    }

}

using RA.PowerSupplySystem.Domain.Common;

namespace RA.PowerSupplySystem.Domain
{
    public class MaterialEntry : BaseEntity
    {
        public int Id { get; set; }
        public Material Material { get; set; }
        public int MaterialId { get; set; }
        public DateTime EntryDate { get; set; }
        public string Batch { get; set; }
        public int Quantity { get; set; }
        public byte[]? ImageData { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.PowerSupplySystem.Application.Features.Material.Queries.GetMaterialsInventory
{
    public class MaterialInventoryDto
    {
        public int Id { get; set; }
        public string PartNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public DateTime LastEntryDate { get; set; }
        public string LastBatch { get; set; }
    }
}

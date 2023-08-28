using RA.PowerSupplySystem.Application.Features.Material.Queries.GetMaterialDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.PowerSupplySystem.Application.Features.MaterialEntry.Queries.GetAllMaterialEntries
{
    public class MaterialEntryListDto
    {
        public int Id { get; set; }
        public MaterialDetailsDto Material { get; set; }
        public int MaterialId { get; set; }
        public DateTime EntryDate { get; set; }
        public string Batch { get; set; }
        public int Quantity { get; set; }
    }
}

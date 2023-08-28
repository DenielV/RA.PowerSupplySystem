using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.PowerSupplySystem.Application.Features.Material.Queries.GetAllMaterials
{
    public class MaterialListDto
    {
        public int Id { get; set; }
        public string PartNumber { get; set; }
        public string Name { get; set; }
    }
}

using RA.PowerSupplySystem.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.PowerSupplySystem.Domain
{
    public class Material : BaseEntity
    {
        public int Id { get; set; }
        public string PartNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
    }
}

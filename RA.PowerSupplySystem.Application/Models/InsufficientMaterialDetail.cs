using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.PowerSupplySystem.Application.Models
{
    public class InsufficientMaterialDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RequiredQty { get;set; }
        public int AvailableQty { get; set; }
    }
}

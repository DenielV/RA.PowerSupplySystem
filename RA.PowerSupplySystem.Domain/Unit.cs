using RA.PowerSupplySystem.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.PowerSupplySystem.Domain
{
    public class Unit : BaseEntity
    {
        public string SerialNumber { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public Order Order { get; set; }
        public int OrderId { get; set; }
        public bool TestPassed { get; set; }
    }
}

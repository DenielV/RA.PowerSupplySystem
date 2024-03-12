using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.PowerSupplySystem.Application.Features.Unit.Queries.GetOrderUnitsToRework
{
    public class UnitDto
    {
        public int Id { get; set; }
        public string SerialNumber { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public bool TestPassed { get; set; }
    }
}

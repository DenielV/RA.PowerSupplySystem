using RA.PowerSupplySystem.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.PowerSupplySystem.Domain
{
    public class OrderStatus : BaseEntity
    {
        public string Name { get; set; }
        public OrderStatus PreviousStatus { get; set; } 
        public int? PreviousStatusId { get; set; }
    }
}

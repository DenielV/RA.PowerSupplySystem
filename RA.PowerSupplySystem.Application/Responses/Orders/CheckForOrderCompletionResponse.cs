using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.PowerSupplySystem.Application.Responses.Orders
{
    public class CheckForOrderCompletionResponse
    {
        public int OrderId { get; set; }
        public bool Completed { get; set; }
    }
}

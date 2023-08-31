using RA.PowerSupplySystem.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.PowerSupplySystem.Application.Responses.Orders
{
    public class CreateOrderCommandResponse
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }
        public List<InsufficientMaterialDetail> InsufficientMaterials { get; set; }
    }
}

using RA.PowerSupplySystem.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.PowerSupplySystem.Domain
{
    public class OrderStatus : BaseEntity
    {
        public string Name { get; set; }
        public OrderStatus PreviousStatus { get; set; }
        [ForeignKey(nameof(PreviousStatus))]
        public int? PreviousStatusId { get; set; }
        public OrderStatus NextStatus { get; set; }
        [ForeignKey(nameof(NextStatus))]
        public int? NextStatusId { get; set; }
        public string? Action { get; set; }
        public string? ActionGifLink { get; set; }
    }
}

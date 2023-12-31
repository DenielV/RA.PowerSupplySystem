﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.PowerSupplySystem.Application.Features.Order.Queries.GetAllOrders
{
    public class OrderStatusDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? NextStatusId { get; set; }
        public string? Action { get; set; }
        public string? ActionGifLink { get; set; }
    }
}

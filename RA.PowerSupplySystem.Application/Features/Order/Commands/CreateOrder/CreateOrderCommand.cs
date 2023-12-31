﻿using MediatR;
using RA.PowerSupplySystem.Application.Responses;
using RA.PowerSupplySystem.Application.Responses.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.PowerSupplySystem.Application.Features.Order.Commands.CreateOrder
{
    public class CreateOrderCommand : IRequest<CreateOrderCommandResponse>
    {
        public List<OrderProductDto> Products { get; set; }
    }
}

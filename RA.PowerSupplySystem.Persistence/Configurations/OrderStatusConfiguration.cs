using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using RA.PowerSupplySystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.PowerSupplySystem.Persistence.Configurations
{
    public class OrderStatusConfiguration : IEntityTypeConfiguration<OrderStatus>
    {
        public void Configure(EntityTypeBuilder<OrderStatus> builder)
        {
            builder.HasData(
                new OrderStatus
                {
                    Id = 1,
                    Name = "Pendiente",
                    PreviousStatusId = null
                },
                new OrderStatus
                {
                    Id = 2,
                    Name = "En almacén",
                    PreviousStatusId = 1
                },
                new OrderStatus
                {
                    Id = 3,
                    Name = "Enviado",
                    PreviousStatusId = 2
                },
                new OrderStatus
                {
                    Id = 4,
                    Name = "Entregado",
                    PreviousStatusId = 3
                }
                );
        }
    }
}

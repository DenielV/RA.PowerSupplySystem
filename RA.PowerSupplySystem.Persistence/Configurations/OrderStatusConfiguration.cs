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
                    Name = "En producción",
                    PreviousStatusId = null,
                    NextStatusId = 2,
                    Action = "Producir",
                    ActionGifLink = "https://i.makeagif.com/media/12-04-2020/UrVrI_.gif"
                },
                new OrderStatus
                {
                    Id = 2,
                    Name = "En pruebas",
                    PreviousStatusId = 1,
                    NextStatusId = 3,
                    Action = null,
                    ActionGifLink = null
                },
                new OrderStatus
                {
                    Id = 3,
                    Name = "En almacén",
                    PreviousStatusId = 2,
                    NextStatusId = 4,
                    Action = "Enviar",
                    ActionGifLink = "https://media2.giphy.com/media/TIeTxUeyPeFI771jTF/giphy.gif?cid=ecf05e47nif00spqsshis5n7nfiy6t0cgyjkhn13nvdt2n33&ep=v1_gifs_search&rid=giphy.gif&ct=g"
                },
                new OrderStatus
                {
                    Id = 4,
                    Name = "En camino",
                    PreviousStatusId = 3,
                    NextStatusId = 5,
                    Action = "Entregar",
                    ActionGifLink = "https://cdn.dribbble.com/users/5173832/screenshots/19756669/media/63c78c15a14a043b8a9ff2c8981e4fde.gif"
                },
                new OrderStatus
                {
                    Id = 5,
                    Name = "Entregado",
                    PreviousStatusId = 4,
                    NextStatusId = null,
                    Action = null,
                    ActionGifLink = null
                }
                );
        }
    }
}

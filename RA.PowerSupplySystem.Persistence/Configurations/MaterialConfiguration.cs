using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RA.PowerSupplySystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.PowerSupplySystem.Persistence.Configurations
{
    public class MaterialConfiguration : IEntityTypeConfiguration<Material>
    {
        public void Configure(EntityTypeBuilder<Material> builder)
        {
            builder.HasData(
                new Material
                {
                    Id = 1,
                    Name = "Resistencia",
                    Description ="Resistencia de 10k Ohms",
                    PartNumber = "R10K",
                    Stock = 1000
                },
                new Material
                {
                    Id = 2,
                    Name = "Tablero",
                    Description = "Tablero de circuito impreso",
                    PartNumber = "PCB4",
                    Stock = 100
                },
                new Material
                {
                    Id = 3,
                    Name = "Carcasa",
                    Description = "Carcasa para fuente de poder",
                    PartNumber = "CARK",
                    Stock = 100
                },
                new Material
                {
                    Id = 4,
                    Name = "Capacitor",
                    Description = "Capacitor de 22 uF",
                    PartNumber = "C22U",
                    Stock = 1000
                }
                );
        }
    }
}

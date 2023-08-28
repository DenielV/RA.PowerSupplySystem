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
    public class ProductMaterialConfiguration : IEntityTypeConfiguration<ProductMaterial>
    {
        public void Configure(EntityTypeBuilder<ProductMaterial> builder)
        {
            builder.HasData(
                new ProductMaterial
                {
                    Id = 1,
                    MaterialId = 1,
                    ProductId = 1,
                    Quantity = 10
                },
                new ProductMaterial
                {
                    Id = 2,
                    MaterialId = 2,
                    ProductId = 1,
                    Quantity = 1
                },
                new ProductMaterial
                {
                    Id = 3,
                    MaterialId = 3,
                    ProductId = 1,
                    Quantity = 1
                },
                new ProductMaterial
                {
                    Id = 4,
                    MaterialId = 4,
                    ProductId = 1,
                    Quantity = 10
                }
                );
        }
    }
}

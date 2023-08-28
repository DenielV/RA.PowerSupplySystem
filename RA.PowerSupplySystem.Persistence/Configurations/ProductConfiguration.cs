using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RA.PowerSupplySystem.Domain;

namespace RA.PowerSupplySystem.Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = 1,
                    Name = "Fuente 24V",
                    Description = "Fuente de poder de 24 Volts",
                    Price = 400
                }
                );
            builder.Property(p => p.Price)
                .HasColumnType("money");
        }
    }
}

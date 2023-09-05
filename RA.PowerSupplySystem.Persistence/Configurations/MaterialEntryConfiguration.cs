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
    public class MaterialEntryConfiguration : IEntityTypeConfiguration<MaterialEntry>
    {
        public void Configure(EntityTypeBuilder<MaterialEntry> builder)
        {
            builder.HasData(
                new MaterialEntry
                {
                    Id = 1,
                    EntryDate = DateTime.Now,
                    MaterialId = 1,
                    Quantity = 1000,
                    Batch = "c256530b-adfc-4006-916a-3120933895f1",
                    ImageData = null
                },
                new MaterialEntry
                {
                    Id = 2,
                    EntryDate = DateTime.Now,
                    MaterialId = 2,
                    Quantity = 100,
                    Batch = "410bef14-6e7b-4714-ac3b-32c67de86c38",
                    ImageData = null
                },
                new MaterialEntry
                {
                    Id = 3,
                    EntryDate = DateTime.Now,
                    MaterialId = 3,
                    Quantity = 100,
                    Batch = "8b82b18b-1293-43e7-8e9e-ecbab8336081",
                    ImageData = null
                },
                new MaterialEntry
                {
                    Id = 4,
                    EntryDate = DateTime.Now,
                    MaterialId = 4,
                    Quantity = 1000,
                    Batch = "f50d6f6d-7942-4d2f-b586-22df1889b858",
                    ImageData = null
                }
                );
        }
    }
}

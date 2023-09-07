using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.PowerSupplySystem.Identity.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "dd1ed8d0-3ea0-4a31-ad76-0a06285aaf51",
                    UserId = "70a1964f-9554-4f3d-bed2-07a9d023fe5b"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "dd1ed8d0-3ea0-4a31-ad76-0a06285aaf51",
                    UserId = "593815ef-47f3-46d3-a668-2cc06b6b6628"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "5a2d0f5b-82d9-41b0-b75b-5bc7818973fe",
                    UserId = "8b1bb19e-e114-4037-98a2-124e565fcb37"
                }
            );
        }
    }
}

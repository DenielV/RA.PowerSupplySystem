using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using RA.PowerSupplySystem.Identity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.PowerSupplySystem.Identity.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                new ApplicationUser
                {
                    Id = "70a1964f-9554-4f3d-bed2-07a9d023fe5b",
                    Email = "deniel@powersupply.com",
                    NormalizedEmail = "DENIEL@POWERSUPPLY.COM",
                    FirstName = "DENIEL",
                    LastName = "VILLARREAL",
                    UserName = "deniel@powersupply.com",
                    NormalizedUserName = "DENIEL@POWERSUPPLY.COM",
                    PasswordHash = hasher.HashPassword(null, "Hola1290"),
                    EmailConfirmed = true,
                },
                new ApplicationUser
                {
                    Id = "593815ef-47f3-46d3-a668-2cc06b6b6628",
                    Email = "manuel@powersupply.com",
                    NormalizedEmail = "MANUEL@POWERSUPPLY.COM",
                    FirstName = "JOSE",
                    LastName = "LUGO",
                    UserName = "manuel@powersupply.com",
                    NormalizedUserName = "MANUEL@POWERSUPPLY.COM",
                    PasswordHash = hasher.HashPassword(null, "Hola1290"),
                    EmailConfirmed = true,
                },
                new ApplicationUser
                {
                    Id = "8b1bb19e-e114-4037-98a2-124e565fcb37",
                    Email = "user@powersupply.com",
                    NormalizedEmail = "USER@POWERSUPPLY.COM",
                    FirstName = "System",
                    LastName = "User",
                    UserName = "user@powersupply.com",
                    NormalizedUserName = "USER@POWERSUPPLY.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true,
                }
            );
        }
    }
}

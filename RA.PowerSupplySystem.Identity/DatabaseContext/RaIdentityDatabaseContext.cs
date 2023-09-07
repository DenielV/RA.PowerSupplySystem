using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RA.PowerSupplySystem.Identity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.PowerSupplySystem.Identity.DatabaseContext
{
    public class RaIdentityDatabaseContext : IdentityDbContext<ApplicationUser>
    {
        public RaIdentityDatabaseContext(DbContextOptions<RaIdentityDatabaseContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(RaIdentityDatabaseContext).Assembly);
        }
    }
}

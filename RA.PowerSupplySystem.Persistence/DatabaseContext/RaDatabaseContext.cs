using Microsoft.EntityFrameworkCore;
using RA.PowerSupplySystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.PowerSupplySystem.Persistence.DatabaseContext
{
    public class RaDatabaseContext : DbContext
    {
        public RaDatabaseContext(DbContextOptions<RaDatabaseContext> options) : base(options) { }
        
        public DbSet<Material> Materials { get; set; }
        public DbSet<MaterialEntry> MaterialEntries { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductMaterial> ProductMaterials { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<Unit> Units { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RaDatabaseContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}

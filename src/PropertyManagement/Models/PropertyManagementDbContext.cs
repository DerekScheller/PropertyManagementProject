using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using PropertyManagement.Models;

namespace PropertyManagement.Models
{
    public class PropertyManagementDbContext : IdentityDbContext<ApplicationUser>
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Property> Property { get; set; }
        public DbSet<HouseDocument> HouseDocument { get; set; }
        public DbSet<Tenant> Tenant { get; set; }
    }
}

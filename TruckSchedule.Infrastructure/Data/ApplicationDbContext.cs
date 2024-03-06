using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TruckSchedule.Infrastructure.Data.Models;
using TruckSchedule.Infrastructure.Data.SeedDb;

namespace TrucksSchedule.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Despatcher> Despatchers { get; set; } = null!;
        public DbSet<Client> Clients { get; set; } = null!;
        public DbSet<Truck> Trucks { get; set; } = null!;
        public DbSet<Driver> Drivers { get; set; } = null!;
        public DbSet<Route> Routes { get; set; } = null!;
        public DbSet<DriverTruck> DriversTrucks { get; set; } = null!;

        public DbSet<Category> Categories { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new DespatcherConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new DriverConfiguration());


            builder.Entity<DriverTruck>(e => e.HasKey(dt => new { dt.TruckId, dt.DriverId }));

            builder.Entity<DriverTruck>()
                .HasOne(dt => dt.Driver)
                .WithMany(dt => dt.DriversTrucks)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
        }
    }
}

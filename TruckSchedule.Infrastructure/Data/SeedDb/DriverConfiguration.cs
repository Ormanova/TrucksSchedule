using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TruckSchedule.Infrastructure.Data.Models;

namespace TruckSchedule.Infrastructure.Data.SeedDb
{
    internal class DriverConfiguration : IEntityTypeConfiguration<Driver>
    {
        public void Configure(EntityTypeBuilder<Driver> builder)
        {
            var data = new SeedData();
            builder.HasData(new Driver[] { data.JuniorDriver, data.SeniorDriver, data.ProfesionalDriver });
        }
    }
}

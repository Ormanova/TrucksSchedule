using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TruckSchedule.Infrastructure.Data.Models;

namespace TruckSchedule.Infrastructure.Data.SeedDb
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            var data = new SeedData();

            builder.HasData(new Category[] { data.Jumbo, data.Conestoga, data.Tautliner, data.Tanker, data.SemiTrailer });
        }

    }
}

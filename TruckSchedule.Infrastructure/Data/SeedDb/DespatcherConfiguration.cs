using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckSchedule.Infrastructure.Data.Models;

namespace TruckSchedule.Infrastructure.Data.SeedDb
{
    internal class DespatcherConfiguration : IEntityTypeConfiguration<Despatcher>
    {
        public void Configure(EntityTypeBuilder<Despatcher> builder)
        {
            var data = new SeedData();

            builder.HasData(new Despatcher[] { data.Despatcher });
        }
    }
}

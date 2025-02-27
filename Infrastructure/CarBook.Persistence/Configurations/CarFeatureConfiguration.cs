using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistence.Configurations
{
    public class CarFeatureConfiguration : IEntityTypeConfiguration<CarFeature>
    {
        public void Configure(EntityTypeBuilder<CarFeature> builder)
        {
            builder.HasOne(cf=> cf.Car)
                .WithMany(c=>c.CarFeatures)
                .HasForeignKey(cf=>cf.CarId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(cf => cf.Feature)
                .WithMany(c => c.CarFeatures)
                .HasForeignKey(cf => cf.FeatureId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(cf => new { cf.CarId, cf.FeatureId })
            .IsUnique();
        }
    }
}

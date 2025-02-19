using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistence.Configurations
{
    public class CarPricingConfiguration : IEntityTypeConfiguration<CarPricing>
    {
        public void Configure(EntityTypeBuilder<CarPricing> builder)
        {
            builder.HasOne(cp => cp.Car)
                .WithMany(c => c.CarPricings)
                .HasForeignKey(cp => cp.CarId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(cp => cp.Pricing)
                .WithMany(c => c.CarPricings)
                .HasForeignKey(cp => cp.PricingId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

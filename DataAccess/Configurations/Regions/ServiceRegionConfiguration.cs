using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Models.Regions;
using DataAccess.SeedData.Regions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Regions
{
    internal class ServiceRegionConfiguration : BaseModelConfiguration<ServiceRegion>
    {
        public override void Configure(EntityTypeBuilder<ServiceRegion> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.TouristPopulation).IsRequired(true).HasConversion(x => x ? "Yes" : "No", x => x == "Yes");
            builder.Property(x => x.HasAirport).IsRequired(true).HasConversion(x => x ? "Yes" : "No", x => x == "Yes");
            builder.Property(x => x.HasHotelFacility).IsRequired(true).HasConversion(x => x ? "Yes" : "No", x => x == "Yes");
            builder.HasMany(x => x.Activities).WithOne(x => x.ServiceRegion).HasForeignKey(x => x.RegionId).OnDelete(DeleteBehavior.NoAction);
            builder.HasData(ServiceRegionSeedData.GetServiceRegions(5));
        }
    }
}

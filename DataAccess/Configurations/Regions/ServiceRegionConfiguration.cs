using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Models.Regions;
using DataAccess.SeedData.Regions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Regions
{
    internal class ServiceRegionConfiguration:BaseRegionModelConfiguration<ServiceRegion>
    {
        public override void Configure(EntityTypeBuilder<ServiceRegion> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.TouristPopulation).IsRequired(true);
            builder.Property(x => x.HasAirport).IsRequired(true);
            builder.Property(x => x.HasHotelFacility).IsRequired(true);
            builder.HasMany(x => x.ContractTourGuides_ServiceRegions).WithOne(x => x.ServiceRegion).HasForeignKey(x => x.ServiceRegionId).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.Events).WithOne(x => x.ServiceRegion).HasForeignKey(x => x.RegionId).OnDelete(DeleteBehavior.NoAction);
            builder.HasData(ServiceRegionSeedData.GetServiceRegions(5));
        }
    }
}

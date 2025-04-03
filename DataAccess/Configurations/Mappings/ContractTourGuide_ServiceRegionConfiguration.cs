using DataAccess.Entities.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Mappings
{
    internal class ContractTourGuide_ServiceRegionConfiguration : IEntityTypeConfiguration<ContractTourGuide_ServiceRegion>
    {
        public void Configure(EntityTypeBuilder<ContractTourGuide_ServiceRegion> builder)
        {
            builder.HasKey(x => new { x.ContractTourGuideId, x.ServiceRegionId });
            builder.HasOne(x => x.ContractTourGuide).WithMany(x => x.ContractTourGuides_ServiceRegions).HasForeignKey(x => x.ContractTourGuideId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.ServiceRegion).WithMany(x => x.ContractTourGuides_ServiceRegions).HasForeignKey(x => x.ServiceRegionId).OnDelete(DeleteBehavior.NoAction);
           
        }
    }
}

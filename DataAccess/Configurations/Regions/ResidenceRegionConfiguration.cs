using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Models.Regions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Regions
{
    internal class ResidenceRegionConfiguration:BaseRegionModelConfiguration<ResidenceRegion>
    {
        public override void Configure(EntityTypeBuilder<ResidenceRegion> builder)
        {
            base.Configure(builder);
            //Mapping
            //Employee
            builder.HasMany(x => x.Employees).WithOne(x => x.ResidenceRegion).HasForeignKey(x => x.ResidenceRegionId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}

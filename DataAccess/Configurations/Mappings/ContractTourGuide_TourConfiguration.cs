using DataAccess.Entities.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Mappings
{
    internal class ContractTourGuide_TourConfiguration : IEntityTypeConfiguration<ContractTourGuide_Tour>
    {
        public void Configure(EntityTypeBuilder<ContractTourGuide_Tour> builder)
        {
            builder.HasKey(x => new { x.ContractTourGuideId, x.TourId });
        }
    }
}

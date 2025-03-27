using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Activities;
using DataAccess.SeedData.Activities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Activities
{
    internal class TourConfiguration:BaseActivityModelConfiguration<Tour>
    {
        public override void Configure(EntityTypeBuilder<Tour> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.TourCategory).IsRequired(true).HasConversion(x => x.ToString(), x => (TourCategory)Enum.Parse(typeof(TourCategory), x)).HasMaxLength(50);
            //Mapping
            //TourTicket
            builder.HasOne(x => x.ServiceRegion).WithMany(x => x.Tours).HasForeignKey(x => x.RegionId).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.ContractTourGuides_Tours).WithOne(x => x.Tour).HasForeignKey(x => x.TourId).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.TourTickets).WithOne(x => x.Tour).HasForeignKey(x => x.TourId).OnDelete(DeleteBehavior.NoAction);

            builder.HasData(TourSeedData.GetTours(5));
        }
    }
}

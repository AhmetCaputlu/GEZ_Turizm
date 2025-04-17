using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Activities;
using DataAccess.SeedData.Activities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Activities
{
    internal class ActivityConfiguration:BaseModelConfiguration<Activity>
    {
        public override void Configure(EntityTypeBuilder<Activity> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.ActivityName).HasMaxLength(40).IsRequired(true);
            builder.Property(x => x.StartDate).IsRequired(true);
            builder.Property(x => x.EndDate).IsRequired(true);
            builder.Property(x => x.Description).HasMaxLength(180).IsRequired(false);
            builder.Property(x => x.ActivityCategory).IsRequired(true).HasConversion(x => x.ToString(), x => (ActivityCategory)Enum.Parse(typeof(ActivityCategory), x)).HasMaxLength(50);
            builder.HasMany(x=>x.ActivityTickets).WithOne(x=>x.Activity).HasForeignKey(x=>x.ActivityId);

            builder.HasData(ActivitySeedData.GetActivities(5));
        }
    }
}

using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Activities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Activities
{
    internal class EventConfiguration:BaseActivityModelConfiguration<Event>
    {
        public override void Configure(EntityTypeBuilder<Event> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.EventCategory).IsRequired(true).HasConversion(x => x.ToString(), x => (EventCategory)Enum.Parse(typeof(EventCategory), x)).HasMaxLength(50);
            //builder.Property(x => x.EventCategory)
            builder.HasOne(x => x.ServiceRegion).WithMany(x => x.Events).HasForeignKey(x => x.RegionId).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.EventTickets).WithOne(x => x.Event).HasForeignKey(x => x.EventId).OnDelete(DeleteBehavior.NoAction);

        }
    }
}

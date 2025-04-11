using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Models.Tickets;
using DataAccess.SeedData.Tickets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Tickets
{
    internal class EventTicketConfiguration:BaseTicketModelConfiguration<EventTicket>
    {
        public override void Configure(EntityTypeBuilder<EventTicket> builder)
        {
            base.Configure(builder);
            builder.HasOne(x=>x.Event).WithMany(x=>x.EventTickets).HasForeignKey(x=>x.EventId).OnDelete(DeleteBehavior.NoAction);
            builder.HasData(EventTicketSeedData.GetEventTickets(5));

        }
    }
}

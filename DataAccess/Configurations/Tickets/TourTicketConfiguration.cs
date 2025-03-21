using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Models.Tickets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Tickets
{
    internal class TourTicketConfiguration:BaseTicketModelConfiguration<TourTicket>
    {
        public override void Configure(EntityTypeBuilder<TourTicket> builder)
        {
            base.Configure(builder);
            builder.HasOne(x => x.Tour).WithMany(x => x.TourTickets).HasForeignKey(x => x.TourId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}

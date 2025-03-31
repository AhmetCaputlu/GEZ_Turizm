using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Models.Tickets;
using DataAccess.SeedData.Tickets;
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

            builder.HasData(TourTicketSeedData.GetTourTickets(50));
        }
    }
}

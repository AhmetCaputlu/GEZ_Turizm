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
            //Mapping

            //WebUserAccount
            builder.HasOne(x => x.WebUserAccount).WithMany(x => x.TourTickets).HasForeignKey(x => x.WebUserAccountId).OnDelete(DeleteBehavior.NoAction);
            //Tour
            builder.HasOne(x => x.Tour).WithMany(x => x.TourTickets).HasForeignKey(x => x.TourId).OnDelete(DeleteBehavior.NoAction);
            
        }
    }
}

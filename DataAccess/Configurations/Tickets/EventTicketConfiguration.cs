using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Models.Tickets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Tickets
{
    internal class EventTicketConfiguration:BaseTicketModelConfiguration<EventTicket>
    {
        public override void Configure(EntityTypeBuilder<EventTicket> builder)
        {
            base.Configure(builder);
            //Mapping
            //WebUserAccount
            builder.HasOne(x => x.WebUserAccount).WithMany(x => x.EventTickets).HasForeignKey(x => x.WebUserAccountId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}

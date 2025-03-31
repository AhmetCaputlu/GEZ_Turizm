using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Models.OrderDetails;
using DataAccess.SeedData.OrderDetails;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.OrderDetails
{
    internal class EventTicketOrderDetailConfiguration:BaseOrderDetailModelConfiguration<EventTicketOrderDetail>
    {
        public override void Configure(EntityTypeBuilder<EventTicketOrderDetail> builder)
        {
            base.Configure(builder);
            builder.HasOne(x => x.EventTicket).WithMany(x => x.EventTicketOrderDetails).HasForeignKey(x => x.EventTicketId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.EventTicketOrder).WithMany(x=>x.EventTicketOrderDetails).HasForeignKey(x => x.EventTicketOrderId).OnDelete(DeleteBehavior.NoAction);

            builder.HasData(EventTicketOrderDetailSeedData.GetEventTicketOrderDetails(330));
        }
    }
}

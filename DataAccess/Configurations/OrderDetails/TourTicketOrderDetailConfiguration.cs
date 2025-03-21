using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Models.OrderDetails;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.OrderDetails
{
    internal class TourTicketOrderDetailConfiguration:BaseOrderDetailModelConfiguration<TourTicketOrderDetail>
    {
        public override void Configure(EntityTypeBuilder<TourTicketOrderDetail> builder)
        {
            base.Configure(builder);
            builder.HasOne(x => x.TourTicketOrder).WithMany(x => x.TourTicketOrderDetails).HasForeignKey(x => x.TourTicketOrderId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.TourTicket).WithMany(x => x.TourTicketOrderDetails).HasForeignKey(x => x.TourTicketId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}

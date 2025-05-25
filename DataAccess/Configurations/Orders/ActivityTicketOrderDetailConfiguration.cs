using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Models.Orders;
using DataAccess.SeedData.OrderDetails;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Orders
{
    internal class ActivityTicketOrderDetailConfiguration:BaseModelConfiguration<ActivityTicketOrderDetail>
    {
        public override void Configure(EntityTypeBuilder<ActivityTicketOrderDetail> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.UnitPrice).IsRequired(true).HasColumnType("decimal(8,2)");
            builder.Property(x => x.Quantity).IsRequired(true);
            builder.Property(x => x.Discount).IsRequired(false).HasColumnType("decimal(4,2)");
            builder.Property(x => x.TotalCost).IsRequired(false).HasColumnType("decimal(10,2)");
            builder.HasOne(x => x.ActivityTicket).WithMany(x => x.ActivityTicketOrderDetails).HasForeignKey(x => x.ActivityTicketId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.ActivityTicketOrder).WithMany(x => x.ActivityTicketOrderDetails).HasForeignKey(x => x.ActivityTicketOrderId).OnDelete(DeleteBehavior.NoAction);

            builder.HasData(ActivityTicketOrderDetailSeedData.GetActivityTicketOrderDetails(5));
        }
    }
}

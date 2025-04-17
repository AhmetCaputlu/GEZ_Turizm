using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Models.Orders;
using DataAccess.SeedData.OrderDetails;
using DataAccess.SeedData.Orders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Orders
{
    internal class ActivityTicketOrderConfiguration:BaseModelConfiguration<ActivityTicketOrder>
    {
        public override void Configure(EntityTypeBuilder<ActivityTicketOrder> builder)
        {
            base.Configure(builder);
            base.Configure(builder);
            builder.Property(x => x.Note).IsRequired(false).HasMaxLength(140);
            builder.Property(x => x.WebUserEmail).IsRequired(true).HasMaxLength(120);
            builder.HasOne(x => x.Employee).WithMany(x => x.ActivityTicketOrders).HasForeignKey(x => x.EmployeeId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.WebUserAccount).WithMany(x => x.ActivityTicketOrders).HasForeignKey(x => x.WebUserAccountId).OnDelete(DeleteBehavior.NoAction);

            builder.HasData(ActivityTicketOrderSeedData.GetActivityTicketOrders(5));

        }
    }
}

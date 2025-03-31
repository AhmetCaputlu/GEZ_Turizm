using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Models.Orders;
using DataAccess.SeedData.Orders;
using DataAccess.SeedData.Tickets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Orders
{
    internal class EventTicketOrderConfiguration:BaseOrderModelConfiguration<EventTicketOrder>
    {
        public override void Configure(EntityTypeBuilder<EventTicketOrder> builder)
        {
            base.Configure(builder);
            builder.HasOne(x => x.Employee).WithMany(x => x.EventTicketOrders).HasForeignKey(x => x.EmployeeId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.WebUserAccount).WithMany(x => x.EventTicketOrders).HasForeignKey(x => x.WebUserAccountId).OnDelete(DeleteBehavior.NoAction);

            builder.HasData(EventTicketOrderSeedData.GetEventTicketOrders(130));
        }
    }
}

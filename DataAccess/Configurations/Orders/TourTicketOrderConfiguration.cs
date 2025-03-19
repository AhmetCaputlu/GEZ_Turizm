using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Models.Orders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Orders
{
    internal class TourTicketOrderConfiguration:BaseOrderModelConfiguration<TourTicketOrder>
    {
        public override void Configure(EntityTypeBuilder<TourTicketOrder> builder)
        {
            base.Configure(builder);
            //Mapping

            //WebUserAccount
            builder.HasOne(x => x.WebUserAccount).WithMany(x => x.TourTicketOrders).HasForeignKey(x => x.WebUserAccountId).OnDelete(DeleteBehavior.NoAction);
            //Employee
            builder.HasOne(x => x.Employee).WithMany(x => x.TourTicketOrders).HasForeignKey(x => x.EmployeeId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}

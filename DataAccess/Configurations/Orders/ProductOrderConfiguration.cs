using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Models.Orders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Orders
{
    internal class ProductOrderConfiguration:BaseOrderModelConfiguration<ProductOrder>
    {
        public override void Configure(EntityTypeBuilder<ProductOrder> builder)
        {
            base.Configure(builder);
            //Mapping

            //WebUserAccount
            builder.HasOne(x => x.WebUserAccount).WithMany(x => x.ProductOrders).HasForeignKey(x => x.WebUserAccountId).OnDelete(DeleteBehavior.NoAction);
            //Employee
            builder.HasOne(x => x.Employee).WithMany(x => x.ProductOrders).HasForeignKey(x => x.EmployeeId).OnDelete(DeleteBehavior.NoAction);
            //Product
            builder.HasOne(x => x.Product).WithMany(x => x.ProductOrders).HasForeignKey(x => x.ProductId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}

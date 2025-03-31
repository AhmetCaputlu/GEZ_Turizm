using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Models.Orders;
using DataAccess.SeedData.Orders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Orders
{
    internal class ProductOrderConfiguration:BaseOrderModelConfiguration<ProductOrder>
    {
        public override void Configure(EntityTypeBuilder<ProductOrder> builder)
        {
            base.Configure(builder);
            builder.HasOne(x => x.Employee).WithMany(x => x.ProductOrders).HasForeignKey(x => x.EmployeeId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.WebUserAccount).WithMany(x => x.ProductOrders).HasForeignKey(x => x.WebUserAccountId).OnDelete(DeleteBehavior.NoAction);
            builder.HasData(ProductOrderSeedData.GetProductOrders(80));
        }
    }
}

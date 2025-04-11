using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Models.OrderDetails;
using DataAccess.SeedData.OrderDetails;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.OrderDetails
{
    internal class ProductOrderDetailConfiguration:BaseOrderDetailModelConfiguration<ProductOrderDetail>
    {
        public override void Configure(EntityTypeBuilder<ProductOrderDetail> builder)
        {
            base.Configure(builder);
            builder.HasOne(x => x.Product).WithMany(x => x.ProductOrderDetails).HasForeignKey(x => x.ProductId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.ProductOrder).WithMany(x => x.ProductOrderDetails).HasForeignKey(x => x.ProductOrderId).OnDelete(DeleteBehavior.NoAction);

            builder.HasData(ProductOrderDetailSeedData.GetProductOrderDetails(5));
        }
    }
}

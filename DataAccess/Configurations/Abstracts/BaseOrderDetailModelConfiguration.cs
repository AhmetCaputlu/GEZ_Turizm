using DataAccess.Entities.Abstracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Abstracts
{
    internal class BaseOrderDetailModelConfiguration<T>:BaseModelConfiguration<T> where T : BaseOrderDetailModel
    {
        public override void Configure(EntityTypeBuilder<T> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.UnitPrice).IsRequired(true).HasColumnType("decimal(8,2)");
            builder.Property(x => x.Quantity).IsRequired(true);
            builder.Property(x => x.Discount).IsRequired(false).HasColumnType("decimal(4,2)");
            builder.Property(x => x.TotalCost).IsRequired(false).HasColumnType("decimal(10,2)");
        }
    }
}

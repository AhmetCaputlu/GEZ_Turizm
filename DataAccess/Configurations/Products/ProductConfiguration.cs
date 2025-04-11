using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Models.Products;
using DataAccess.SeedData.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Products
{
    internal class ProductConfiguration:BaseModelConfiguration<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);

            builder.HasOne(x => x.ProductCategory).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.ProductSupplier).WithMany(x => x.Products).HasForeignKey(x => x.ProductSupplierId).OnDelete(DeleteBehavior.NoAction);
            builder.Property(x => x.ProductName).HasMaxLength(75).IsRequired(true);
            builder.Property(x => x.Description).HasMaxLength(220).IsRequired(true);
            builder.Property(x => x.UnitPrice).IsRequired(true);
            builder.Property(x => x.UnitsInStock).IsRequired(true);

            builder.HasData(ProductSeedData.GetProducts(5));
        }
    }
}

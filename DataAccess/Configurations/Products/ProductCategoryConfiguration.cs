using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Products
{
    internal class ProductCategoryConfiguration:BaseModelConfiguration<ProductCategory>
    {
        public override void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            base.Configure(builder);
            builder.HasMany(x => x.Products).WithOne(x => x.ProductCategory).HasForeignKey(x => x.CategoryId).OnDelete(DeleteBehavior.NoAction);
            builder.Property(x => x.CategoryName).HasMaxLength(75).IsRequired(true); 
            builder.Property(x => x.CategoryType).HasDefaultValue(CategoryType.Unknown).HasConversion(x=>x.ToString(),x=>(CategoryType)Enum.Parse(typeof(CategoryType),x)).IsRequired(true).HasMaxLength(75); 
            builder.Property(x => x.Description).HasMaxLength(130).IsRequired(true);
        }
    }
}

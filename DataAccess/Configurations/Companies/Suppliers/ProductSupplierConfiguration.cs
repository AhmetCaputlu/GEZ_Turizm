using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Models.Companies.Suppliers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Companies.Suppliers
{
    internal class ProductSupplierConfiguration:BaseCompanyModelConfiguration<ProductSupplier>
    {
        public override void Configure(EntityTypeBuilder<ProductSupplier> builder)
        {
            base.Configure(builder);
            builder.HasMany(x => x.Products).WithOne(x => x.ProductSupplier).HasForeignKey(x => x.ProductSupplierId).OnDelete(DeleteBehavior.NoAction);


        }
    }
}

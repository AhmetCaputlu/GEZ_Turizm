using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Models.Companies.Suppliers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Companies.Suppliers
{
    internal class SubContractWorkerSupplierConfiguration:BaseCompanyModelConfiguration<SubContractWorkerSupplier>
    {
        public override void Configure(EntityTypeBuilder<SubContractWorkerSupplier> builder)
        {
            base.Configure(builder);
            builder.HasMany(x => x.ContractDrivers).WithOne(x => x.SubContractWorkerSupplier).HasForeignKey(x => x.SubContractWorkerSupplierId).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.ContractTourGuides).WithOne(x => x.SubContractWorkerSupplier).HasForeignKey(x => x.SubContractWorkerSupplierId).OnDelete(DeleteBehavior.NoAction);
        }
       
    }
}

using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Models.Companies.Suppliers;
using DataAccess.SeedData.Companies.Suppliers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Companies.Suppliers
{
    internal class SubContractWorkerSupplierConfiguration:BaseCompanyModelConfiguration<SubContractWorkerSupplier>
    {
        public override void Configure(EntityTypeBuilder<SubContractWorkerSupplier> builder)
        {
            base.Configure(builder);
            builder.HasMany(x => x.ContractEmployees).WithOne(x => x.SubContractWorkerSupplier).HasForeignKey(x => x.SupplierId).OnDelete(DeleteBehavior.NoAction);

            builder.HasData(SubWorkerSupplierSeedData.GetSubContractWorkerSuppliers(5));
        }
       
    }
}

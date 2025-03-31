using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Models.Companies.Suppliers;
using DataAccess.SeedData.Companies.Suppliers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Companies.Suppliers
{
    internal class RentalVehicleSupplierConfiguration:BaseCompanyModelConfiguration<RentalVehicleSupplier>
    {
        public override void Configure(EntityTypeBuilder<RentalVehicleSupplier> builder)
        {
            base.Configure(builder);
            //Mapping
            builder.HasMany(x => x.RentalVehicles).WithOne(x => x.RentalVehicleSupplier).HasForeignKey(x => x.RentalVehicleSupplierId).OnDelete(DeleteBehavior.NoAction);

            builder.HasData(RentalVehicleSupplierSeedData.GetRentalVehicleSuppliers(5));
        }
    }
}

using System.Reflection.Emit;
using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Employees;
using DataAccess.SeedData.Employees;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Employees
{
    internal class ContractDriverConfiguration:BaseEmployeeModelConfiguration<ContractDriver>
    {
        public override void Configure(EntityTypeBuilder<ContractDriver> builder)
        {
            base.Configure(builder);

            builder.HasMany(x => x.ContractDrivers_Vehicles).WithOne(x => x.ContractDriver).HasForeignKey(x => x.ContractDriverId).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.ContractDrivers_RentalVehicles).WithOne(x => x.ContractDriver).HasForeignKey(x => x.ContractDriverId).OnDelete(DeleteBehavior.NoAction);
            builder.Property(x => x.DriverLicense).IsRequired(true).HasDefaultValue(DriverLicense.None).HasConversion(x => x.ToString(), x => (DriverLicense)Enum.Parse(typeof(DriverLicense), x));
            builder.Property(x => x.DriverLicense).HasMaxLength(5);
            builder.HasOne(x => x.SubContractWorkerSupplier).WithMany(x => x.ContractDrivers).HasForeignKey(x => x.SubContractWorkerSupplierId).OnDelete(DeleteBehavior.NoAction);

            builder.HasData(ContractDriverSeedData.GetContractDrivers(5));
        }

    }
}

using DataAccess.Entities.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Mappings
{
    internal class ContractDriver_RentalVehicleConfiguration : IEntityTypeConfiguration<ContractDriver_RentalVehicle>
    {
        public void Configure(EntityTypeBuilder<ContractDriver_RentalVehicle> builder)
        {
            builder.HasKey(x => new { x.ContactDriverId, x.RentalVehicleId });
            builder.HasOne(x => x.ContractDriver).WithMany(x => x.ContractDrivers_RentalVehicles).HasForeignKey(x => x.ContactDriverId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.RentalVehicle).WithMany(x => x.ContractDrivers_RentalVehicles).HasForeignKey(x => x.RentalVehicleId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}

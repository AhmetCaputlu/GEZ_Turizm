using DataAccess.Entities.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Mappings
{
    internal class ContractDriver_VehicleConfiguration : IEntityTypeConfiguration<ContractDriver_Vehicle>
    {
        public void Configure(EntityTypeBuilder<ContractDriver_Vehicle> builder)
        {
            builder.HasKey(x => new { x.ContractDriverId, x.VehicleId });
            builder.HasOne(x => x.ContractDriver).WithMany(x => x.ContractDrivers_Vehicles).HasForeignKey(x => x.ContractDriverId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Vehicle).WithMany(x => x.ContractDrivers_Vehicles).HasForeignKey(x => x.VehicleId).OnDelete(DeleteBehavior.NoAction);
            
        }
    }
}

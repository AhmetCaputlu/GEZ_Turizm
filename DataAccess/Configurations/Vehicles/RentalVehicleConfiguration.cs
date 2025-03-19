using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Models.Vehicles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Vehicles
{
    internal class RentalVehicleConfiguration:BaseVehicleModelConfiguration<RentalVehicle>
    {
        public override void Configure(EntityTypeBuilder<RentalVehicle> builder)
        {
            base.Configure(builder);
            //Mapping
            builder.HasMany(x => x.ContractDrivers_RentalVehicles).WithOne(x => x.RentalVehicle).HasForeignKey(x => x.RentalVehicleId).OnDelete(DeleteBehavior.NoAction);
            builder.Property(x => x.DailyRentalFee).IsRequired(true).HasColumnType("decimal(8,2)");
            builder.Property(x => x.StartDate).IsRequired(true);
            builder.Property(x => x.ExpireDate).IsRequired(true);
            builder.Property(x => x.TotalPrice).IsRequired(true).HasColumnType("decimal(9,2)");
            builder.HasOne(x => x.RentalVehicleSupplier).WithMany(x => x.RentalVehicles).HasForeignKey(x => x.RentalVehicleSupplierId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Event).WithMany(x => x.RentalVehicles).HasForeignKey(x => x.EventId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Tour).WithMany(x => x.RentalVehicles).HasForeignKey(x => x.TourId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}

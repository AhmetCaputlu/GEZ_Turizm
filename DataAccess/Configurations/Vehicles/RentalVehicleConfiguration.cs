using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Models.Vehicles;
using DataAccess.SeedData.Vehicles;
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
            builder.Property(x => x.DailyRentalFee).IsRequired(true).HasColumnType("decimal(8,2)");
            builder.Property(x => x.StartDate).IsRequired(true);
            builder.Property(x => x.ExpireDate).IsRequired(true);
            builder.Property(x => x.TotalPrice).IsRequired(true).HasColumnType("decimal(9,2)");
            builder.HasOne(x => x.RentalVehicleSupplier).WithMany(x => x.RentalVehicles).HasForeignKey(x => x.RentalVehicleSupplierId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Activity).WithMany(x => x.RentalVehicles).HasForeignKey(x => x.ActivityId).OnDelete(DeleteBehavior.NoAction);
            builder.HasData(RentalVehiclesSeedData.GetRentalVehicles(5));
        }
    }
}

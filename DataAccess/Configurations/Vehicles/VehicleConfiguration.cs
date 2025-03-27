using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Models.Vehicles;
using DataAccess.SeedData.Vehicles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Vehicles
{
    internal class VehicleConfiguration:BaseVehicleModelConfiguration<Vehicle>
    {
        public override void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            base.Configure(builder);
            builder.HasMany(x => x.ContractDrivers_Vehicles).WithOne(x => x.Vehicle).HasForeignKey(x => x.VehicleId).OnDelete(DeleteBehavior.NoAction);
            builder.Property(x => x.MarketValue).IsRequired(true).HasColumnType("decimal(10,2)");
            builder.HasOne(x => x.Tour).WithMany(x => x.Vehicles).HasForeignKey(x => x.TourId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Event).WithMany(x => x.Vehicles).HasForeignKey(x => x.EventId).OnDelete(DeleteBehavior.NoAction);

            builder.HasData(VehicleSeedData.GetVehicles(5));
        }
    }
}

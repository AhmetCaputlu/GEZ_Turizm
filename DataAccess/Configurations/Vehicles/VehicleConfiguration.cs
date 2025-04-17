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
            builder.Property(x => x.MarketValue).IsRequired(true).HasColumnType("decimal(10,2)");
            builder.HasOne(x => x.Activity).WithMany(x => x.Vehicles).HasForeignKey(x => x.ActivityId).OnDelete(DeleteBehavior.NoAction);

            builder.HasData(VehicleSeedData.GetVehicles(5));
        }
    }
}

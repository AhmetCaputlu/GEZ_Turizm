using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Abstracts
{
    internal class BaseVehicleModelConfiguration<T>:BaseModelConfiguration<T> where T : BaseVehicleModel
    {
        public override void Configure(EntityTypeBuilder<T> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.VehicleType).IsRequired(true).HasConversion(x => x.ToString(), x => (VehicleType)Enum.Parse(typeof(VehicleType), x));
            builder.Property(x => x.VehicleType).HasMaxLength(30);
            builder.Property(x => x.LicensePlate).HasMaxLength(15).IsRequired(true);
            builder.Property(x => x.Model).HasMaxLength(200).IsRequired(false);
            builder.Property(x => x.Kilometer).HasMaxLength(7).IsRequired(true);
            builder.Property(x => x.Age).HasMaxLength(2).IsRequired(true);
            builder.Property(x => x.Capacity).HasMaxLength(2).IsRequired(true);
            builder.Property(x => x.IsAvailable).IsRequired(true).HasConversion(x => x ? "Available" : "Busy", x => x == "Available");
        }
    }
}

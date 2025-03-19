using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Abstracts
{
    internal class BaseRegionModelConfiguration<T>:BaseModelConfiguration<T> where T : BaseRegionModel
    {
        public override void Configure(EntityTypeBuilder<T> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.DistrictName).HasMaxLength(120).IsRequired(true);
            builder.Property(x => x.ArrivalTime).IsRequired(true).HasColumnType("TIME");
            builder.Property(x => x.TransportVehicle).IsRequired(true).HasConversion(x => x.ToString(),x=> (VehicleType)Enum.Parse(typeof(VehicleType),x));
            builder.Property(x => x.TransportVehicle).HasMaxLength(30);

        }
    }
}

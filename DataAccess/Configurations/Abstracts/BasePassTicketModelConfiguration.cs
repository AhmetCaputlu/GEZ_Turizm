using DataAccess.Entities.Abstracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Abstracts
{
    internal class BasePassTicketModelConfiguration<T>:BaseModelConfiguration<T> where T : BasePassTicketModel
    {
        public override void Configure(EntityTypeBuilder<T> builder)
        {
            base.Configure(builder);
            builder.Ignore(x => x.SeatNumber);
            builder.Property(x => x.CommissionRate).IsRequired(true);
            builder.Property(x => x.Price).IsRequired(true).HasColumnType("decimal(6,2)");
            builder.Property(x => x.TotalCostwithCommission).IsRequired(true).HasColumnType("decimal(8,2)");
            builder.Property(x => x.NetCost).IsRequired(false).HasColumnType("decimal(10,2)");
        }
    }
}

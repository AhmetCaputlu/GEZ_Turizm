using DataAccess.Entities.Abstracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Abstracts
{
    internal class BasePassTicketModelConfiguration<T> : BaseModelConfiguration<T> where T : BasePassTicketModel
    {
        public override void Configure(EntityTypeBuilder<T> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Price).IsRequired(true).HasColumnType("decimal(8,2)");
            builder.Property(x => x.CommissionRate).IsRequired(true);
            builder.Property(x => x.TotalCostwithCommission).IsRequired(false).HasColumnType("decimal(8,2)");
        }
    }
}

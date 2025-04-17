using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Models.PassTickets;
using DataAccess.SeedData.PassTickets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.PassTickets
{
    internal class ActivityPassTicketConfiguration : BaseModelConfiguration<ActivityPassTicket>
    {
        public override void Configure(EntityTypeBuilder<ActivityPassTicket> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Price).IsRequired(true).HasColumnType("decimal(8,2)");
            builder.Property(x => x.CommissionRate).IsRequired(true);
            builder.Property(x => x.TotalCostwithCommission).IsRequired(false).HasColumnType("decimal(8,2)");
            builder.HasOne(x => x.PartnerCompanyTransaction).WithMany(x => x.ActivityPassTickets).HasForeignKey(x => x.PartnerCompanyTransactionId).OnDelete(DeleteBehavior.NoAction);

            builder.HasData(ActivityPassTicketSeedData.GetActivityPassTickets(5));
        }
    }
}

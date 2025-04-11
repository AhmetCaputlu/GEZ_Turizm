using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Models.PassTickets;
using DataAccess.SeedData.PassTickets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.PassTickets
{
    internal class PassEventTicketConfiguration:BasePassTicketModelConfiguration<PassEventTicket>
    {
        public override void Configure(EntityTypeBuilder<PassEventTicket> builder)
        {
            base.Configure(builder);
            builder.HasOne(x => x.PartnerCompanyTransaction).WithMany(x => x.PassEventTickets).HasForeignKey(x => x.PartnerCompanyTransactionId).OnDelete(DeleteBehavior.NoAction);

            builder.HasData(EventPassTicketSeedData.GetPassEventTickets(5));
        }
    }
}

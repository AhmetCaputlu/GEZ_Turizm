using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Models.PassTickets;
using DataAccess.SeedData.PassTickets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.PassTickets
{
    internal class PassTourTicketConfiguration:BasePassTicketModelConfiguration<PassTourTicket>
    {
        public override void Configure(EntityTypeBuilder<PassTourTicket> builder)
        {
            base.Configure(builder);
            builder.HasOne(x => x.PartnerCompanyTransaction).WithMany(x => x.PassTourTickets).HasForeignKey(x => x.PartnerCompanyTransactionId).OnDelete(DeleteBehavior.NoAction);

            builder.HasData(TourPassTicketSeedData.GetPassTourTickets(5));
        }
    }
}

using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Models.Companies.PartnerCompanies;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Companies.PartnerCompanies
{
    internal class PartnerCompanyConfiguration:BaseCompanyModelConfiguration<PartnerCompany>
    {
        public override void Configure(EntityTypeBuilder<PartnerCompany> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.CommissionRate).IsRequired(true).HasColumnType("decimal(7,4)");
            builder.Property(x => x.AcceptTickets).IsRequired(true);
        }
    }
}

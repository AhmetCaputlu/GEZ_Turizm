using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Models.Companies.PartnerCompanies;
using DataAccess.SeedData.Companies.PartnerCompanies;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Companies.PartnerCompanies
{
    internal class PartnerCompanyConfiguration:BaseCompanyModelConfiguration<PartnerCompany>
    {
        public override void Configure(EntityTypeBuilder<PartnerCompany> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.AcceptTickets).IsRequired(true).HasConversion(x=> x ? "Yes":"No",x=> x == "Yes");
            builder.Property(x => x.Debit).IsRequired(true).HasColumnType("decimal(10,4)");
            builder.Property(x => x.Credit).IsRequired(true).HasColumnType("decimal(10,4)");
            builder.Property(x => x.Balance).IsRequired(true).HasColumnType("decimal(10,4)");
            builder.HasMany(x=>x.PartnerCompanyTransactions).WithOne(x=>x.PartnerCompany).HasForeignKey(x=>x.PartnerCompanyId).OnDelete(DeleteBehavior.NoAction);

            builder.HasData(PartnerCompaniesSeedData.GetPartnerCompanies(5));
        }
    }
}

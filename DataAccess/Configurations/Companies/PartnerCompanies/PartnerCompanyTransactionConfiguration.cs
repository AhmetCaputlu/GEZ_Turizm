using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Companies.PartnerCompanies;
using DataAccess.SeedData.Companies.PartnerCompanies;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Companies.PartnerCompanies
{
    internal class PartnerCompanyTransactionConfiguration : BaseModelConfiguration<PartnerCompanyTransaction>
    {
        public override void Configure(EntityTypeBuilder<PartnerCompanyTransaction> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Type).IsRequired(true).HasConversion(x => x.ToString(), x => (TransactionType)Enum.Parse(typeof(TransactionType), x));
            builder.Property(x => x.TotalCost).IsRequired(true).HasColumnType("decimal(10,2)");


            builder.HasData(PartnerCompanyTransactionSeedData.GetPartnerCompanyTransactions(35));
        }
    }
}

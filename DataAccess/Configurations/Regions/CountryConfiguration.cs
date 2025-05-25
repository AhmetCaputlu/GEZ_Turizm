using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Regions;
using DataAccess.SeedData.Countries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Regions
{
    internal class CountryConfiguration:BaseModelConfiguration<Country>
    {
        public override void Configure(EntityTypeBuilder<Country> builder)
        {
            base.Configure(builder);
            builder.Property(x=>x.CountryName).IsRequired(true).HasMaxLength(80);
            builder.Property(x=>x.CountryCode).IsRequired(true).HasMaxLength(8);
            builder.Property(x=>x.CountryDescription).IsRequired(false).HasMaxLength(250);
            builder.Property(x=>x.CountryPhone).IsRequired(true).HasMaxLength(7);
            builder.Property(x=>x.Continent).IsRequired(true).HasConversion(x => x.ToString(), x => (Continent)Enum.Parse(typeof(Continent), x)).HasMaxLength(50);
            //Mapping

            //WebUserAccount
            builder.HasMany(x => x.WebUserAccounts).WithOne(x => x.Country).HasForeignKey(x => x.CountryId).OnDelete(DeleteBehavior.NoAction);

            builder.HasData(CountrySeedData.GetCountries(5));
        }
    }
}

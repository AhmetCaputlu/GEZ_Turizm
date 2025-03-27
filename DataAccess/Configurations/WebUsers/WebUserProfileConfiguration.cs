using System.Reflection.Emit;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.WebUsers;
using DataAccess.SeedData.WebUsers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.WebUsers
{
    internal class WebUserProfileConfiguration : IEntityTypeConfiguration<WebUserProfile>
    {
        public void Configure(EntityTypeBuilder<WebUserProfile> builder)
        {
            builder.HasKey(x => x.WebUserAccountId);
            builder.Property(x => x.FirstName).HasMaxLength(30).IsRequired(true);
            builder.Property(x => x.LastName).HasMaxLength(30).IsRequired(true);
            builder.Property(x => x.Gender).IsRequired(true).HasDefaultValue(Gender.Unknown).HasConversion(x => x.ToString(), x => (Gender)Enum.Parse(typeof(Gender), x));
            builder.Property(x => x.Gender).HasMaxLength(35);
            builder.Property(x => x.BirthDate).IsRequired(true).HasDefaultValue(new DateTime(2000, 01, 01));
            builder.Property(x => x.TCN_Passport).HasMaxLength(15).IsRequired(false);
            builder.Property(x => x.Address).HasMaxLength(180).IsRequired(false);
            builder.Property(x => x.PhotoPath).HasMaxLength(255).IsRequired(false);
            builder.Property(x => x.PhoneNumber).HasMaxLength(18).IsRequired(false);
            builder.Property(x => x.Email).HasMaxLength(120).IsRequired(false);
            builder.Property(x => x.UpdatedDate).IsRequired(false).HasDefaultValue(DateTime.Now);
            //Mapping

            //WebUserAccount
            builder.HasOne(x => x.WebUserAccount).WithOne(x => x.WebUserProfile).HasForeignKey<WebUserProfile>(x => x.WebUserAccountId).OnDelete(DeleteBehavior.NoAction);
            builder.HasData(WebUserProfileSeedData.GetUserProfiles(8));

        }
    }
}

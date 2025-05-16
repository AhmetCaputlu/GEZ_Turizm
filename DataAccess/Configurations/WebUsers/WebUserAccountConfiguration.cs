using System.Reflection.Emit;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.WebUsers;
using DataAccess.SeedData.WebUsers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.WebUsers
{
    internal class WebUserAccountConfiguration : IEntityTypeConfiguration<WebUserAccount>
    {
        public void Configure(EntityTypeBuilder<WebUserAccount> builder)
        {
            //IEntity
            builder.Ignore(x => x.Id);
            builder.Property(x => x.Guid).HasMaxLength(45).IsRequired(true);
            builder.Property(x => x.CreatedDate).IsRequired(true).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedID).IsRequired(true).HasMaxLength(36);
            builder.Property(x => x.CreatedIPAddress).HasMaxLength(30).IsRequired(true).HasDefaultValue("IP verilmedi");
            builder.Property(x => x.UpdatedDate).IsRequired(false);
            builder.Property(x => x.UpdatedID).IsRequired(false).HasMaxLength(36);
            builder.Property(x => x.UpdatedIPAddress).HasMaxLength(30).IsRequired(false);
            builder.Property(x => x.Status).IsRequired(true).HasDefaultValue(DataStatus.Unknown).HasConversion(x => x.ToString(), x => (DataStatus)Enum.Parse(typeof(DataStatus), x)).HasMaxLength(20);
            builder.Property(x => x.IsUpdated).IsRequired(true).HasConversion(x => x ? "Yes" : "No", x => x == "Yes");

            //AspNetUser
            #region Fluent API ile yapılandırma Migration'a yansımıyor.
            //builder.Property(x => x.UserName).HasMaxLength(32).IsRequired(true);
            //builder.Property(x => x.NormalizedUserName).HasMaxLength(32).IsRequired(false);
            //builder.Property(x => x.Email).HasMaxLength(120).IsRequired(true);
            //builder.Property(x => x.NormalizedEmail).HasMaxLength(120).IsRequired(false); 
            #endregion

            builder.Property(x => x.PasswordHash).HasMaxLength(240).IsRequired(true);//BCrypt
            builder.Property(x => x.SecurityStamp).HasMaxLength(45).IsRequired(false);
            builder.Property(x => x.ConcurrencyStamp).HasMaxLength(45).IsRequired(false);
            builder.Property(x => x.PhoneNumber).HasMaxLength(11).IsRequired(true);
            builder.Property(x => x.LockoutEnd).IsRequired(false);

            //Mapping

            //WebUserProfile
            builder.HasOne(x=>x.WebUserProfile).WithOne(x=>x.WebUserAccount).HasForeignKey<WebUserProfile>(x=>x.WebUserAccountId).OnDelete(DeleteBehavior.NoAction);
            //Country
            builder.HasOne(x=>x.Country).WithMany(x=>x.WebUserAccounts).HasForeignKey(x=>x.CountryId).OnDelete(DeleteBehavior.NoAction);

            builder.HasData(WebUserAccountSeedData.GetUserAccounts(5));


        }
    }
}

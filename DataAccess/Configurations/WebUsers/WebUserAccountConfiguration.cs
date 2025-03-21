using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.WebUsers;
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
            builder.Property(x => x.Guid).HasMaxLength(36).IsRequired(true).HasDefaultValue(Guid.NewGuid().ToString());
            builder.Property(x => x.CreatedDate).IsRequired(true).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedID).IsRequired(true).HasMaxLength(36).HasDefaultValue(Guid.NewGuid().ToString());
            //todo:Kayıt oluşturan kullanıcının Guid bilgisi atanacak.
            builder.Property(x => x.CreatedIPAddress).HasMaxLength(20).IsRequired(true).HasDefaultValue("");
            //todo:BLL katmanında kullanıcının IP bilgisi alınacak.(HttpContext)
            builder.Property(x => x.UpdatedDate).IsRequired(false);
            builder.Property(x => x.UpdatedID).IsRequired(false).HasMaxLength(36);
            builder.Property(x => x.UpdatedIPAddress).HasMaxLength(20).IsRequired(false);
            builder.Property(x => x.Status).IsRequired(true).HasDefaultValue(DataStatus.Unknown).HasConversion(x => x.ToString(), x => (DataStatus)Enum.Parse(typeof(DataStatus), x));
            builder.Property(x => x.Status).HasMaxLength(20);

            //AspNetUser
            #region Fluent API ile yapılandırma Migration'a yansımıyor.
            //builder.Property(x => x.UserName).HasMaxLength(32).IsRequired(true);
            //builder.Property(x => x.NormalizedUserName).HasMaxLength(32).IsRequired(false);
            //builder.Property(x => x.Email).HasMaxLength(120).IsRequired(true);
            //builder.Property(x => x.NormalizedEmail).HasMaxLength(120).IsRequired(false); 
            #endregion

            builder.Property(x => x.PasswordHash).HasMaxLength(60).IsRequired(true);//BCrypt
            builder.Property(x => x.SecurityStamp).HasMaxLength(36).IsRequired(false);
            builder.Property(x => x.ConcurrencyStamp).HasMaxLength(36).IsRequired(false);
            builder.Property(x => x.PhoneNumber).HasMaxLength(11).IsRequired(true);
            builder.Property(x => x.LockoutEnd).IsRequired(false);

            //Mapping

            //WebUserProfile
            builder.HasOne(x=>x.WebUserProfile).WithOne(x=>x.WebUserAccount).HasForeignKey<WebUserProfile>(x=>x.WebUserAccountId).OnDelete(DeleteBehavior.NoAction);
            //Country
            builder.HasOne(x=>x.Country).WithMany(x=>x.WebUserAccounts).HasForeignKey(x=>x.CountryId).OnDelete(DeleteBehavior.NoAction);
            
        }
    }
}

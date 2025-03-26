using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Abstracts
{
    internal class BaseEmployeeModelConfiguration<T>:BaseModelConfiguration<T> where T : BaseEmployeeModel
    {
        public override void Configure(EntityTypeBuilder<T> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.FirstName).HasMaxLength(30).IsRequired(true);
            builder.Property(x => x.LastName).HasMaxLength(30).IsRequired(true);
            builder.Property(x => x.Gender).IsRequired(true).HasDefaultValue(Gender.Unknown).HasConversion(x => x.ToString(), x => (Gender)Enum.Parse(typeof(Gender), x));
            builder.Property(x => x.Gender).HasMaxLength(10);
            builder.Property(x => x.BirthDate).IsRequired(true).HasDefaultValue(new DateTime(2000, 01, 01));
            builder.Property(x => x.TCN_Passport).HasMaxLength(11).IsRequired(false);
            builder.Property(x => x.Address).HasMaxLength(180).IsRequired(false);
            builder.Property(x => x.PhotoPath).HasMaxLength(255).IsRequired(false);
            builder.Property(x => x.PhoneNumber).HasMaxLength(11).IsRequired(false);
            builder.Property(x => x.Email).HasMaxLength(120).IsRequired(false);
            builder.Property(x => x.HireDate).IsRequired(true);
            builder.Property(x => x.Experience).IsRequired(true);
            builder.Property(x => x.EndContract).IsRequired(false);
        }
    }
}

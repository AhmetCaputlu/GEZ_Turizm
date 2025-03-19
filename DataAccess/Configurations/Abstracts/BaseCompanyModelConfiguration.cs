using DataAccess.Entities.Abstracts;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Abstracts
{
    internal class BaseCompanyModelConfiguration<T>:BaseModelConfiguration<T> where T : BaseCompanyModel
    {
        public override void Configure(EntityTypeBuilder<T> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.CompanyName).HasMaxLength(90).IsRequired(true);
            builder.Property(x => x.ContactName).HasMaxLength(40).IsRequired(true);
            builder.Property(x => x.ContactTitle).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.Email).HasMaxLength(255).IsRequired(true);
            builder.Property(x => x.PhoneNumber).HasMaxLength(11).IsRequired(true);
            builder.Property(x => x.Address).HasMaxLength(255).IsRequired(true);
        }
    }
}

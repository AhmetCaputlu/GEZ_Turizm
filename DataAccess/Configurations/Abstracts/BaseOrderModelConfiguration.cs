using DataAccess.Entities.Abstracts;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Abstracts
{
    internal class BaseOrderModelConfiguration<T>:BaseModelConfiguration<T> where T : BaseOrderModel
    {
        public override void Configure(EntityTypeBuilder<T> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Note).IsRequired(false).HasMaxLength(40);
            builder.Property(x => x.WebUserEmail).IsRequired(true).HasMaxLength(120);
        }
    }
}

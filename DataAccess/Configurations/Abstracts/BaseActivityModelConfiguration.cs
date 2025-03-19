using DataAccess.Entities.Abstracts;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Abstracts
{
    internal class BaseActivityModelConfiguration<T>:BaseModelConfiguration<T> where T : BaseActivityModel
    {
        public override void Configure(EntityTypeBuilder<T> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.EventName).HasMaxLength(40).IsRequired(true);
            builder.Property(x => x.StartDate).IsRequired(true);
            builder.Property(x => x.EndDate).IsRequired(true);
            builder.Property(x => x.Description).HasMaxLength(180).IsRequired(false);
        }
    }
}

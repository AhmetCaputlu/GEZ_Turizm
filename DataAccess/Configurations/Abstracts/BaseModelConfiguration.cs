using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Abstracts
{
    internal class BaseModelConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseModel
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired(true).UseIdentityColumn(1, 1);
            builder.Property(x => x.Guid).HasMaxLength(36).IsRequired(true).HasDefaultValue(Guid.NewGuid().ToString());
            builder.Property(x => x.CreatedDate).IsRequired(true).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedID).HasMaxLength(36).IsRequired(true).HasDefaultValue(Guid.NewGuid().ToString());
            builder.Property(x => x.CreatedIPAddress).HasMaxLength(20).IsRequired(true).HasDefaultValue("");
            builder.Property(x => x.UpdatedDate).IsRequired(false);
            builder.Property(x => x.UpdatedID).HasMaxLength(36).IsRequired(false);
            builder.Property(x => x.UpdatedIPAddress).HasMaxLength(20).IsRequired(false);
            builder.Property(x => x.Status).IsRequired(true).HasDefaultValue(DataStatus.Unknown)
            .HasConversion(x => x.ToString(), x => (DataStatus)Enum.Parse(typeof(DataStatus), x)).HasMaxLength(20);
            builder.Property(x => x.IsUpdated).IsRequired(true).HasConversion(x => x ? "Yes" : "No", x => x == "Yes");
        }
    }
}

using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Employees;
using DataAccess.SeedData.Employees;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Employees
{
    internal class ContractTourGuideConfiguration :BaseEmployeeModelConfiguration<ContractTourGuide>
    {
        public override void Configure(EntityTypeBuilder<ContractTourGuide> builder)
        {
            base.Configure(builder);
            builder.HasMany(x=>x.ContractTourGuides_ServiceRegions).WithOne(x => x.ContractTourGuide).HasForeignKey(x => x.ContractTourGuideId).OnDelete(DeleteBehavior.NoAction);
            builder.Property(x => x.Language).IsRequired(true).HasDefaultValue(Language.None).HasConversion(x => x.ToString(), x => (Language)Enum.Parse(typeof(Language), x));
            builder.Property(x => x.Language).HasMaxLength(35);
            builder.HasOne(x => x.SubContractWorkerSupplier).WithMany(x => x.ContractTourGuides).HasForeignKey(x => x.SubContractWorkerSupplierId).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.ContractTourGuides_Tours).WithOne(x => x.ContractTourGuide).HasForeignKey(x => x.ContractTourGuideId).OnDelete(DeleteBehavior.NoAction);

            builder.HasData(ContractTourGuideSeedData.GetContractTourGuides(5));


        }
    }
}
